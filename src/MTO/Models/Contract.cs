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
        public DbSet<Contract> Contracts { get; set; }
    }

    [Table("contract")]
    public class Contract
    {
        [Key]
        public int PK_Contract { get; set; }

        public string ContractNumber { get; set; }

        [Column(TypeName = "Date")]
        public DateTime ConclusionDate { get; set; }

        [Column(TypeName = "Date")]
        public DateTime ExpiredDate { get; set; }

        public string ConclusionCity { get; set; }

        public Decimal SupplierPenalty { get; set; }

        public Decimal CustomerPenalty { get; set; }

        public int PK_ProviderAgent { get; set; }
        public ProviderAgent ProviderAgent
        {
            get 
            {
                return Program.db.ProviderAgents.Find(PK_ProviderAgent);  
            }
        }

        public int PK_OrganizationDescription { get; set; }
        public OrganizationDescription OrganizationDescription
        {
            get 
            {
                return Program.db.OrganizationDescriptions.Find(PK_OrganizationDescription); 
            }
        }
    }
}
