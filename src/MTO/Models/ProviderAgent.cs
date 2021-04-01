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
        public DbSet<ProviderAgent> ProviderAgents { get; set; }
    }

    [Table("provideragent")]
    public class ProviderAgent
    {
        [Key]
        public int PK_ProviderAgent { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }

        public int PK_Provider { get; set; }
        public Provider Provider
        {
            get
            {
                return Program.db.Providers.Find(PK_Provider);
            }
        }
    }
}
