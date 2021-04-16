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
        public override string ToString()
        {
            return ContractNumber;
        }
        [Key]
        public int PK_Contract { get; set; }

        public string ContractNumber { get; set; }

        [Column(TypeName = "Date")]
        public DateTime StartDate { get; set; }

        public string StartDateWithoutTime
        {
            get
            {
                return StartDate.ToString("dd-MM-yyyy");
            }
        }

        [Column(TypeName = "Date")]
        public DateTime ConclusionDate { get; set; }

        public string ConclusionDateWithoutTime
        {
            get
            {
                return ConclusionDate.ToString("dd-MM-yyyy");
            }
        }

        [Column(TypeName = "Date")]
        public DateTime ExpiredDate { get; set; }
        public string ExpiredDateWithoutTime
        {
            get
            {
                return ExpiredDate.ToString("dd-MM-yyyy");
            }
        }

        public string ConclusionCity { get; set; }

        public Decimal SupplierPenalty { get; set; }

        public Decimal CustomerPenalty { get; set; }

        public string ProviderAgentName { get; set; }
        
        public string ProviderAgentRole { get; set; }
        
        public string CustomerAgentName { get; set; }
        
        public string CustomerAgentRole { get; set; }

        public int PK_Provider { get; set; }
        public Provider Provider
        {
            get
            {
                return Program.db.Providers.Find(PK_Provider);
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

        public List<ContractLine> getContractLines()
        {
            return Program.db.ContractLines
                    .Where(b => b.PK_Contract == PK_Contract)
                    .ToList();
        }

    }
}
