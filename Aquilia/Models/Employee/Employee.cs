using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Aquilia.ViewModel;

namespace Aquilia.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        [Required]
        public String EmployeeName { get; set; }
        [Required]
        public String EmployeeAddress { get; set; }
        [Required]
        public String EmployeeContactNo { get; set; }

        public Attendance Attendance { get; set; }

        public ICollection<Assignment> Assignments { get; set; }

        public ProductParts ProductParts { get; set; }

        public ICollection<DebitCredit> DebitCredit { get; set; }

        public ICollection<AssignmentLog> AssignmentLog { get; set; }

        public virtual ICollection<DebitAndCreditReportViewModel> DebitAndCreditReportViewModel { get; set; }

    }
}
