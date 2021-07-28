using System;
using System.ComponentModel.DataAnnotations;

namespace Aquilia.ViewModel
{
    public class VendorPurchasesViewModel 
    {
        [Key]
        public int VendorPurchaseID { get; set; }
        public string VendorName { get; set; }
        public string TransactionDate { get; set; }
        public int BillNo { get; set; }
        //public object MyProperty { get; set; }
        public string particularName { get; set; }
        public decimal Rate { get; set; }
        public decimal Quantity { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
