using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Aquilia.ViewModel;

namespace Aquilia.Models
{
    public class Assignment
    {
        [Key]
        public int AssignmentID { get; set; }

        public string AssignmentName { get; set; }


        public int ProductPartID { get; set; }
        [ForeignKey("ProductPartID")]
        public ProductParts ProductParts { get; set; }

        public ICollection<Employee> Employees { get; set; }

        public ICollection<Assignment_RawMaterials> assignment_RawMaterials { get; set; }

        public ICollection<AssignmentLog> AssignmentLogs { get; set; }

        public virtual ICollection<EmployeeAssignmentsViewModel> EmployeeAssignmentsViewModel { get; set; }

    }
}
