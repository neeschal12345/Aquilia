using System;
using System.ComponentModel.DataAnnotations;

namespace Aquilia.ViewModel
{
    public class VendorLedgerViewModel
    {
        [Key]
        public int VendorLedgerID { get; set; }
        [Required]
        public string Date { get; set; }

        public String Description { get; set; }

        public short Quantity { get; set; }//To buy raw material
        //[Required]
        public int Rate { get; set; } //To buy raw material

        public int VoucherNo { get; set; }

        public long ChequeNumber { get; set; }
        [Required]
        public int CreditAmount { get; set; }
        [Required]
        public int DebitAmount { get; set; }
        [Required]
        public int Amount { get; set; }
        [Required]
        public int CurrentBalance { get; set; }


        //public decimal Balance { get; set; }
        //If it's 1, not complete, 2 means completed

    }
}
