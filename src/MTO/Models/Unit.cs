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
        public DbSet<Unit> Units { get; set; }
    }

    [Table("unit")]
    public class Unit
    {
        [Key]
        public int PK_Unit { get; set; }

        public string Name { get; set; }

        public string Cipher { get; set; }
    }
}
