using System;
using System.ComponentModel.DataAnnotations;

namespace Aquilia.ViewModel
{
    public class DashboardViewModel
    {
        [Key]
        public int ActiveVendors { get; set; }
        public int ActiveEmployees { get; set; }
        public int CompletedAssignments { get; set; }
        public int PendingAssignments { get; set; }
        public decimal LedgerStatus { get; set; }
        public int AvailableStock { get; set; }
        //public string ProductName { get; set; }
     


    }
}
