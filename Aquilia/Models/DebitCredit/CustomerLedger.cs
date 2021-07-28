using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aquilia.Models
{
    public class CustomerLedger
    {
        [Key]
        public int TransactionID { get; set; }
        [Required]
        public string Date { get; set; }

        public String Description { get; set; }
        [Required]
        public int VoucherNo { get; set; }
        [Required]
        public int ChequeNumber { get; set; }
        [Required]
        public string TransactionInfo { get; set; }
        [Required]
        public int Amount { get; set; }
        [Required]
        public int CurrentBalance { get; set; }

        public int CustomerID { get; set; }

        [ForeignKey("CustomerID")]

        public Customer Customer { get; set; }




    }


}
