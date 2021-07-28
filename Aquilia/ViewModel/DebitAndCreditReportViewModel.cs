﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Aquilia.ViewModel
{
    public class DebitAndCreditReportViewModel
    {
        [Key]
        public int DebitCreditID { get; set; }
        public int EmployeeName { get; set; }
        public string TransactionDate { get; set; }
        public string Description { get; set; }
        public string TransactionType { get; set; }
        public int Quantity { get; set; }
        public string BankName { get; set; }
        public int ChequeNo { get; set; }
        public int VoucherID { get; set; }
        public int Amount { get; set; } //If it's 1, not complete, 2 means completed

    }
}
