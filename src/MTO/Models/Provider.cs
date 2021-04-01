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
        public DbSet<Provider> Providers { get; set; }
    }

    [Table("provider")]
    public class Provider
    {
        [Key]
        public int PK_Provider { get; set; }
        public string Name { get; set; }
        public string INN { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string CheckingAccount { get; set; }
        public string CorrespondentAccount { get; set; }
        public string BIK { get; set; }
    }
}
