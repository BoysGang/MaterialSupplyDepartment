using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MTO.Models
{
    public partial class MTOContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }

    [Table("user")]
    public class User
    {
        public override string ToString()
        {
            return Username;
        }
        [Key]
        public int PK_User { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public int Role { get; set;  }


        public bool isAdmin()
        {
            return Role == (int)UserRoles.ADMIN;
        }

        public bool isContract()
        {
            return Role == (int)UserRoles.CONTRACT_EMPLOYEE;
        }

        public bool isAccounting()
        {
            return Role == (int)UserRoles.ACCOUNTING_EMPLOYEE;
        }
        
    }
}
