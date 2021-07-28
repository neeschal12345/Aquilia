using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aquilia.Models
{
    public class VendorLedger
    {
        [Key]
        public int TransactionID { get; set; }
        [Required]
        public string Date { get; set; }

        public String Description { get; set; }
        [Required]
        public int VoucherNo { get; set; }

        public long ChequeNumber { get; set; }
        [Required]
        public string TransactionType { get; set; }
        [Required]
        public int Amount { get; set; }
        [Required]
        public int CurrentBalance { get; set; }

        public int VendorID { get; set; }

        [ForeignKey("VendorID")]

        public Vendor Vendor { get; set; }

        
    }
    

}
