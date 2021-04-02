﻿using Microsoft.EntityFrameworkCore;
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
        public DbSet<Models.ReceiptOrder> ReceiptOrders { get; set; }
    }

    [Table("receiptorder")]
    public class ReceiptOrder
    {
        [Key]
        public int PK_ReceiptOrder { get; set; }
        public string ReceiptOrderNumber { get; set; }

        [Column(TypeName = "Date")]
        public DateTime DeliveryDate { get; set; }

        public int PK_Warehouse { get; set; }
        public Warehouse Warehouse
        {
            get
            {
                return Program.db.Warehouses.Find(PK_Warehouse);
            }
        }

        public int PK_Contract { get; set; }
        public Contract Contract
        {
            get
            {
                return Program.db.Contracts.Find(PK_Contract);
            }
        }

        public int PK_Provider { get; set; }
        public Provider Provider
        {
            get
            {
                return Program.db.Providers.Find(PK_Provider);
            }
        }

        public string Provider_Name
        {
            get
            {
                return Provider.Name;
            }
        }

        public string Warehouse_Cipher
        {
            get
            {
                return Warehouse.Cipher;
            }
        }

        public string Contract_ContractNumber
        {
            get
            {
                return Contract.ContractNumber;
            }
        }
    }
    
}
