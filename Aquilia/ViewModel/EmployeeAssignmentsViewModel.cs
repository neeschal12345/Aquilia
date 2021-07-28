using System;
using System.ComponentModel.DataAnnotations;

namespace Aquilia.ViewModel
{
    public class EmployeeAssignmentsViewModel
    {
        [Key]
        public int EmployeeAssignmentID { get; set; }
        public string EmployeeName { get; set; }
        public DateTime AssignedDate { get; set; }
        public string ProductPartCode { get; set; }
        public string AssignedProductPart { get; set; }
        public int AssignedQuantity { get; set; }
        public int AssignmentState { get; set; } //If it's 1, not complete, 2 means completed
        public string FinalProductName { get; set; }
    }
}
