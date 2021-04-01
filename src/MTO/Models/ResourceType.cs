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
        public DbSet<ResourceType> ResourceTypes { get; set; }
    }

    [Table("resourcetype")]
    public class ResourceType
    {
        [Key]
        public int PK_ResourceType { get; set; }
        public string Name { get; set; }
    }
}
