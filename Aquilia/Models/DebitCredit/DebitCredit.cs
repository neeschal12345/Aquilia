using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aquilia.Models
{
    public class DebitCredit
    {
        [Key]
        public int TransactionID { get; set; }
        [Required]
        public string Date { get; set; }

        public String Description { get; set; }
        [Required]
        public int VoucherNo { get; set; }
        [Required]
        public string TransactionType { get; set; }
        [Required]
        public int Amount { get; set; }
        [Required]
        public int CurrentBalance { get; set; }

        public int EmployeeID { get; set; }

        [ForeignKey("EmployeeID")]

        public Employee Employee { get; set; }

        
    }
    

}
