using System;
using System.ComponentModel.DataAnnotations;

namespace Aquilia.ViewModel.Dashboard
{
    public class AssignmentViewModel


    {
        [Key]
        public int ID { get; set; }
        public string EmployeeName { get; set; }
         public string FinalProductName { get; set; }
        public int PendingQty { get; set; }
      
       
    }
}
