using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using MTO.Models;
using MTO.Utils;

namespace MTO
{
    enum UserRoles {
        ADMIN = 0,
        CONTRACT_EMPLOYEE = 1,
        ACCOUNTING_EMPLOYEE = 2,
    };
    static class Program
    {
        public static MTOContext db;

        public static User user;

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            db = new MTOContext();

            if (args.Length >= 1)
            {
                switch (args[0])
                {
                    case "--generateData":
                        BigDataGenerator generator = new BigDataGenerator(db);
                        generator.generate();
                        break;
                }

                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
        }
    }
}
