using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            optionsBuilder.UseMySql(
                "server=94.251.36.104;user=app;password=qwerty12345;database=mto4;"
            );
        }
    }
}
