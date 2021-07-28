using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Aquilia.Models;

namespace Aquilia.ViewModel
{
    public class CustomerLedgerViewModel
    {
        [Key]
        public int TransactionID { get; set; }
        [Required]
        public string Date { get; set; }

        public String Descriptions { get; set; }
        [Required]
        public int VoucherNo { get; set; }

        public long ChequeNumber { get; set; }
        [Required]
        public string TransactionTypes { get; set; }
        [Required]
        public int Amount { get; set; }
        [Required]
        public int CurrentBalance { get; set; }

        public int CustomerID { get; set; }

        [ForeignKey("CustomerID")]

        public Customer Customer { get; set; }

    }
}
