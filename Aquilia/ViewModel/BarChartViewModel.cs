using System;
using System.ComponentModel.DataAnnotations;

namespace Aquilia.ViewModel
{
    public class BankBalanceViewModel


    {
        [Key]
        public int BB_ID { get; set; }
        //public string BankName { get; set; }
         public string AvailableBalance { get; set; }

        public string OD_Balance { get; set; }



    }
}
