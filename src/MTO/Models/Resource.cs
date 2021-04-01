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
        public DbSet<Resource> Resources { get; set; }
    }

    [Table("resource")]
    public class Resource
    {
        [Key]
        public int PK_Resource { get; set; }

        public string Name { get; set; }

        public string Cipher { get; set; }

        public int PK_Unit { get; set; }
        public Unit Unit 
        { 
            get 
            { 
                return Program.db.Units.Find(PK_Unit); 
            }
        }

        public int PK_ResourceType { get; set; }
        public ResourceType ResourceType
        {
            get
            {
                return Program.db.ResourceTypes.Find(PK_ResourceType);
            }
        }
    }
}
