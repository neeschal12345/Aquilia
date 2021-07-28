using System;
using System.ComponentModel.DataAnnotations;

namespace Aquilia.ViewModel
{
    public class CustomerSalesViewModel
    {
        [Key]
        public int CustomerSalesID { get; set; }
        public string TransactionDate { get; set; }
        public int BillNo { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public int CustomerContact { get; set; }
        public string ProductName { get; set; }
        public decimal ProductRate { get; set; }
        public string ProductQuantity { get; set; }
        public decimal TotalPrice { get; set; }


    }
}
