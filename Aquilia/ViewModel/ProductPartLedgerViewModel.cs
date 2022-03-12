using System;
using System.ComponentModel.DataAnnotations;

namespace Aquilia.ViewModel
{
    public class BankLedgerViewModel
    {
        [Key]
        public int BankLedgerID { get; set; }
        [Required]
        public string Date { get; set; }

        public string TransactionType { get; set; }

        public string TransactionBy { get; set; }//To buy raw material

        public int ChqNo { get; set; }

        public decimal DebitAmount { get; set; }

        public decimal CreditAmount { get; set; }
        [Required]
        public decimal CurrentBalance { get; set; }

        public string Remarks { get; set; }


    }
}
