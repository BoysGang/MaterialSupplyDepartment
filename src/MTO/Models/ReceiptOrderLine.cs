using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTO.Models
{
    public partial class MTOContext : DbContext
    {
        public DbSet<ReceiptOrderLine> ReceiptOrderLines { get; set; }
    }

    [Table("receiptorderline")]
    public class ReceiptOrderLine
    {
        [Key]
        public int PK_ReceiptOrderLine { get; set; }
        public float AcceptedAmount { get; set; }
        public float DocumentAmount { get; set; }

        public int PK_ReceiptOrder { get; set; }
        public ReceiptOrder ReceiptOrder
        {
            get
            {
                return Program.db.ReceiptOrders.Find(PK_ReceiptOrder);
            }
        }

        public int PK_Resource { get; set; }
        public Resource Resource
        {
            get
            {
                return Program.db.Resources.Find(PK_Resource);
            }
        }
    }
}
