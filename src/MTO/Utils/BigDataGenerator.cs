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


        private Dictionary<int, string> cities = new Dictionary<int, string>
            {
                {0,  "Максим"},
                {1,  "Барнаул"},
                {2,  "Артем"},
                {3,  "Бийск"},
                {4,  "Москва"},
                {5,  "Грозный"},
                {6,  "Киров"},
                {7,  "Новочеркасск"},
                {8,  "Новосибирск"},
                {9,  "Новороссийск"},
                {10,  "Новокузнецк"},
            };

        public bool generateDictionaries()
        {
            try
            {
                Random rand = new Random();


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
