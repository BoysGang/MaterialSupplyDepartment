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
        public DbSet<Warehouse> Warehouses { get; set; }
    }

    [Table("warehouse")]
    public class Warehouse
    {
        [Key]
        public int PK_Warehouse { get; set; }
        public string Name { get; set; }
        public string Cipher { get; set; }
    }
}
