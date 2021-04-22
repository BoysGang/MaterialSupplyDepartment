using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MTO;
using MTO.Models;

namespace MTO.Utils
{
    class BigDataGenerator
    {
        private MTOContext db;

        public BigDataGenerator(MTOContext db)
        {
            this.db = db;

            startDateDefault = new DateTime(DateTime.Now.Year - 3, 1, 1);
            finalDateDefault = new DateTime(DateTime.Now.Year + 1, 1, 1);
            daysRange = (finalDateDefault - startDateDefault).Days;
        }

        private Random rand = new Random();

        private DateTime startDateDefault;
        private DateTime finalDateDefault;
        private int daysRange;


        private DateTime randomDay()
        {
            return startDateDefault.AddDays(rand.Next(daysRange) + 1);
        }

        private DateTime randomDay(DateTime dateFrom)
        {
            return dateFrom.AddDays(rand.Next((finalDateDefault - dateFrom).Days + 1));
        }

        private DateTime randomDay(DateTime dateFrom, DateTime dateTo)
        {
            return dateFrom.AddDays(rand.Next((dateTo - dateFrom).Days + 1));
        }


        public bool generateContracts()
        {
            try
            {
                int amountCities = cities.Length;
                int amountRoles = roles.Length;

                OrganizationDescription description = db.OrganizationDescriptions.FirstOrDefault();
                if (description == null)
                    return false;

                List<int> PK_Providers = new List<int>();
                int amountProviders = PK_Providers.Count;

                List<int> PK_Resources = new List<int>();
                int amountResources = PK_Resources.Count;

                foreach (var provider in db.Providers)
                {
                    PK_Providers.Add(provider.PK_Provider);
                }

                foreach (var resource in db.Resources)
                {
                    PK_Resources.Add(resource.PK_Resource);
                }


                List<ContractLine> generatedContractLines = new List<ContractLine>();
                DateTime conclusionDate, startDate, expiredDate;

                //генерация контрактов и ордеров
                for (int i = 0; i < 500; i++)
                {

                    conclusionDate = randomDay();
                    startDate = conclusionDate.AddDays(1);
                    expiredDate = randomDay(startDate);

                    //генерация контракта
                    Contract generatedContract = new Contract()
                    {
                        ContractNumber = "0000" + (i + 1).ToString(),

                        ConclusionDate = conclusionDate,
                        StartDate = startDate,
                        ExpiredDate = expiredDate,

                        ConclusionCity = cities[rand.Next(amountCities)],
                        ProviderAgentName = "Оформитель_" + (i + 1).ToString(),
                        ProviderAgentRole = roles[rand.Next(amountRoles)],
                        CustomerAgentName = "Оформитель_" + (i + 1).ToString(),
                        CustomerAgentRole = roles[rand.Next(amountRoles)],

                        SupplierPenalty = Decimal.Parse(rand.Next(10) + rand.NextDouble().ToString()),
                        CustomerPenalty = Decimal.Parse(rand.Next(10) + rand.NextDouble().ToString()),
                        IsOpened = expiredDate <= DateTime.Now,
                        PK_Provider = PK_Providers[rand.Next(amountProviders)],
                        PK_OrganizationDescription = description.PK_OrganizationDescription,
                    };
                    db.Contracts.Add(generatedContract);
                    db.SaveChanges();

                    //генерация строк контракта
                    generatedContractLines.Clear();
                    int pk_contract = generatedContract.PK_Contract;
                    int amountContractLines = rand.Next(10);
                    for(int j = 0; j < amountContractLines; j++)
                    {
                        ContractLine line = new ContractLine()
                        {
                            PK_Contract = pk_contract,
                            PK_Resource = PK_Resources[rand.Next(amountResources)],
                            Amount = rand.Next(1, 100),
                            UnitPrice = Decimal.Parse(rand.Next(1, 10000).ToString()),
                            DeliveryDate = randomDay(startDate, expiredDate),
                        };
                        db.ContractLines.Add(line);
                        generatedContractLines.Add(line);
                    }
                    db.SaveChanges();

                    //генерация приходных ордеров

                    //генерация строк приходных ордеров


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }

            return true;
        }

        private string[] cities = new string[]
        {
            "Токио",
            "Барнаул",
            "Артем",
            "Бийск",
            "Москва",
            "Грозный",
            "Киров",
            "Новочеркасск",
            "Новосибирск",
            "Новороссийск",
        };

        private string[] roles = new string[]
        {
            "директор",
            "исп. директор",
            "фин. директор",
            "бухгалтер",
            "провизор"
        };

        public bool generateDictionaries()
        {
            try
            {
                OrganizationDescription description = new OrganizationDescription()
                {
                    PK_OrganizationDescription = 1,
                    Name = "ООО 'Тестировщики'",
                    DirectorName = "Тестировщик А.А.",
                    INN = rand.Next(100000, 999999).ToString() + rand.Next(100000, 999999).ToString(),
                    PhoneNumber = "+7 (" + rand.Next(100, 999).ToString() + ") " + rand.Next(100, 999).ToString() +
                                             "-" + rand.Next(10, 99).ToString() + "-" + rand.Next(10, 99).ToString(),
                    CheckingAccount = rand.Next(10000, 99999).ToString() + rand.Next(10000, 99999).ToString() +
                                              rand.Next(10000, 99999).ToString() + rand.Next(10000, 99999).ToString(),
                    CorrespondentAccount = rand.Next(10000, 99999).ToString() + rand.Next(10000, 99999).ToString() +
                                              rand.Next(10000, 99999).ToString() + rand.Next(10000, 99999).ToString(),
                    Address = "г. " + cities[rand.Next(10)] + ", д. " + rand.Next(1, 1000).ToString(),
                    BIK = rand.Next(10000, 99999).ToString() + rand.Next(1000, 9999).ToString(),

                };
                db.OrganizationDescriptions.Add(description);
                db.SaveChanges();

                //создание типа ресурса
                ResourceType typeMaterial = new ResourceType()
                {
                    Name = "Материал",
                };

                ResourceType typeTool = new ResourceType()
                {
                    Name = "Оборудование",
                };

                db.AddRange(typeMaterial, typeTool);
                db.SaveChanges();

                //создание складов
                for(int i = 0; i < 50; i++)
                {
                    db.Warehouses.Add(
                        new Warehouse()
                        {
                            Name = "СКЛАД_" + (i+1).ToString(),
                            Cipher = "0000" + (i+1).ToString(),
                        }
                    );
                }
                db.SaveChanges();

                //создание ед. измерения
                Unit testUnit = new Unit()
                {
                    Name = "Шт.",
                    Cipher = "796"
                };

                Program.db.Units.Add(testUnit);
                db.SaveChanges();


                //создание поставщиков
                for(int i = 0; i < 100; i++)
                {
                    db.Providers.Add(
                        new Provider()
                        {
                            Name = "Поставщик_" + (i+1).ToString(),
                            INN = rand.Next(100000, 999999).ToString() + rand.Next(100000, 999999).ToString(),
                            PhoneNumber = "+7 (" + rand.Next(100, 999).ToString() + ") " + rand.Next(100, 999).ToString() +
                                             "-" + rand.Next(10, 99).ToString() + "-" + rand.Next(10, 99).ToString(),
                            CheckingAccount = rand.Next(10000, 99999).ToString() + rand.Next(10000, 99999).ToString() +
                                              rand.Next(10000, 99999).ToString() + rand.Next(10000, 99999).ToString(),
                            CorrespondentAccount = rand.Next(10000, 99999).ToString() + rand.Next(10000, 99999).ToString() +
                                              rand.Next(10000, 99999).ToString() + rand.Next(10000, 99999).ToString(),
                            Address = "г. " + cities[rand.Next(10)] + ", д. " + rand.Next(1, 1000).ToString(),
                            BIK = rand.Next(10000, 99999).ToString() + rand.Next(1000, 9999).ToString(),
                        }
                    );
                }
                db.SaveChanges();

                //создание ресурсов
                for(int i = 0; i < 500; i++)
                {
                    //материалы
                    db.Resources.Add(
                        new Resource()
                        {
                            Name = "Материал_" + (i+1).ToString(),
                            Cipher = rand.Next(10, 99) + "." + rand.Next(10, 99) + "." +
                                     rand.Next(10, 99) + "." + rand.Next(100, 999),
                            PK_ResourceType = typeMaterial.PK_ResourceType,
                            PK_Unit = testUnit.PK_Unit,
                        }
                    );
                }
                db.SaveChanges();

                for(int i = 0; i < 500; i++)
                {
                    //оборудование
                    db.Resources.Add(
                        new Resource()
                        {
                            Name = "Оборудование_" + (i + 1).ToString(),
                            Cipher = rand.Next(10, 99) + "." + rand.Next(10, 99) + "." +
                                     rand.Next(10, 99) + "." + rand.Next(100, 999),

                            PK_ResourceType = typeTool.PK_ResourceType,
                            PK_Unit = testUnit.PK_Unit,
                        }
                    );
                }
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }

            return true;
        }

        public bool generate()
        {
            return  generateDictionaries() && generateContracts();
        }
    }
}
