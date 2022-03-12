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

        public decimal Quantity { get; set; }//To buy raw material
        //[Required]
        public decimal Rate { get; set; } //To buy raw material

        public int VoucherNo { get; set; }

        public long ChequeNumber { get; set; }
        [Required]
        public decimal CreditAmount { get; set; }
        [Required]
        public decimal DebitAmount { get; set; }
        [Required]
        public decimal Amount { get; set; }
        [Required]
        public decimal CurrentBalance { get; set; }

        //[Required]
        //public string Remarks { get; set; }
        //public decimal Balance { get; set; }
        //If it's 1, not complete, 2 means completed

    }
}
