using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Aquilia.ViewModel;

namespace Aquilia.Models
{
    public class Sales
    {
        [Key]
        public int SalesID { get; set; }

        public string TransactionDate { get; set; }

        public int BillNo { get; set; }

        public decimal TotalPrice { get; set; }

        public int CustomerID { get; set; }

        [ForeignKey("CustomerID")]

        public Customer Customer { get; set; }

        public int FinalProductID { get; set; }

        [ForeignKey("FinalProductID")]

        public FinalProduct FinalProduct { get; set; }

    

    }
}
