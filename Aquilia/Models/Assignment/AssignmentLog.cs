using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aquilia.Models
{
    public class AssignmentLog
    {
        [Key]   
        public int LogId { get; set; }
        public DateTime AssignedDate { get; set; }

        public AssignmentState AssignedState { get; set; }

        public int EmployeeID { get; set; }

        public int AssignmentId { get; set; }

        [ForeignKey("EmployeeID")]

        public Employee Employee { get; set; }


        [ForeignKey("AssignmentId")]

        public Assignment Assignment { get; set; }
    }
    
}
