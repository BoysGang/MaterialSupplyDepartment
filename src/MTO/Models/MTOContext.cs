using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetEnv;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MTO.Models
{
    public partial class MTOContext : DbContext
    {
        public MTOContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            Env.Load("../../.env");

            string host = Env.GetString("DB_HOST");
            string database = Env.GetString("DB_DATABASE");
            string username = Env.GetString("DB_USERNAME");
            string password = Env.GetString("DB_PASSWORD");

            optionsBuilder.UseMySql(
                $"server={host};user={username};password={password};database={database};"
            );
        }
    }
}
