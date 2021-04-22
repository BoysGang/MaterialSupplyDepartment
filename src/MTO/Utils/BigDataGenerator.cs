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

        private Random rand = new Random();

        private string[] cities = new string[]
        {
            "Новоалтайск",
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

        private string[] streets = new string[]
        {
            "ул. Ленина",
            "пр. Карла Маркса",
            "пр. Строителей",
        };

        public BigDataGenerator(MTOContext db)
        {
            this.db = db;
        }

        public bool generateContracts()
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }

            return true;
        }


        public bool generateDictionaries()
        {
            try
            {
                OrganizationDescription description = new OrganizationDescription()
                {
                    PK_OrganizationDescription = 1,
                    Name = "ООО 'Тестировщики'",
                    DirectorName = "Тестировщик А.А.",
                    INN = getINN(),
                    PhoneNumber = getPhoneNumber(),
                    CheckingAccount = getCheckingAccount(),
                    CorrespondentAccount = getCorrespondentAccount(),
                    Address = getAddress(),
                    BIK = getBIK(),

                };
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
                            INN = getINN(),
                            PhoneNumber = getPhoneNumber(),
                            CheckingAccount = getCheckingAccount(),
                            CorrespondentAccount = getCorrespondentAccount(),
                            Address = getAddress(),
                            BIK = getBIK(),
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
                            Cipher = getResourcesCipher(),
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
                            Cipher = getResourcesCipher(),
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

        public bool generateUsers()
        {
            try
            {
                User admin = new User()
                {
                    Username = "admin",
                    Password = "$2y$12$T1q0TXfrFI6PE4mjzlGCc.UyOMovIqGkpX8xk9DYvxh/hMqNmZjzm",
                    Role = 0,
                };

                User accounting = new User()
                {
                    Username = "accounting",
                    Password = "$2y$12$t5na4Nbj7t8AwYHdYgRPWeEkDeNIGjKcRp590ayS4hgOlYO4epXz2",
                    Role = 2,
                };

                User contract = new User()
                {
                    Username = "contract",
                    Password = "$2y$12$Omm/lPfHpYuJRRbbVNufp.xUkTffKdh8hOLnMdp6RImm9lB5DhgC.",
                    Role = 1,
                };

                db.AddRange(admin, accounting, contract);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }

            return true;
        }

        private string getINN()
        {
            return rand.Next(100000, 999999).ToString() + rand.Next(100000, 999999).ToString();
        }

        private string getPhoneNumber()
        {
            return "+7 (" + rand.Next(100, 999).ToString() + ") " + rand.Next(100, 999).ToString() +
                                             "-" + rand.Next(10, 99).ToString() + "-" + rand.Next(10, 99).ToString();
        }

        private string getCheckingAccount()
        {
            return rand.Next(10000, 99999).ToString() + rand.Next(10000, 99999).ToString() +
                                              rand.Next(10000, 99999).ToString() + rand.Next(10000, 99999).ToString();
        }

        private string getCorrespondentAccount()
        {
            return rand.Next(10000, 99999).ToString() + rand.Next(10000, 99999).ToString() +
                                              rand.Next(10000, 99999).ToString() + rand.Next(10000, 99999).ToString();
        }

        private string getAddress()
        {
            return "г. " + cities[rand.Next(cities.Length)] + ", " + streets[rand.Next(streets.Length)] +
                    ", д. " + rand.Next(1, 1000).ToString();
        }

        private string getBIK()
        {
            return rand.Next(10000, 99999).ToString() + rand.Next(1000, 9999).ToString();
        }

        private string getResourcesCipher()
        {
            return rand.Next(10, 99) + "." + rand.Next(10, 99) + "." +
                                     rand.Next(10, 99) + "." + rand.Next(100, 999);
        }
    }
}
