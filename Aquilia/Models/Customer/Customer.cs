using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Aquilia.ViewModel;

namespace Aquilia.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        [Required]
        public string CustomerName { get; set; }
        [Required]
        public string CustomerAddress { get; set; }
        [Required]
        public long ContactNo { get; set; }

        //public int SalesID { get; set; }

        //[ForeignKey("SalesID")]

        //public Sales Sales { get; set; }
        public ICollection<Sales> Sales { get; set; }
        public ICollection<FinalProduct> FinalProducts { get; set; }
        public virtual ICollection<CustomerSalesViewModel> CustomerSalesViewModel { get; set; }
        public ICollection<CustomerLedger> CustomerLedger { get; set; }
        public virtual ICollection<CustomerLedgerViewModel> CustomerLedgerViewModel { get; set; }
    }
    
    
}
