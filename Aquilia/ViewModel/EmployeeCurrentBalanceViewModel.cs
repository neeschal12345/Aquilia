using System;
using System.ComponentModel.DataAnnotations;

namespace Aquilia.ViewModel
{
    public class StockOutViewModel

    {
        [Key]
        public int StockOutID { get; set; }
        public string EmployeeName { get; set; }
        public int Quantity { get; set; }
        public int OutQuantity { get; set; }
        public string TransactionType { get; set; }

    }
}
