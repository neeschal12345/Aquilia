using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aquilia.Models
{
    public class Attendance
    {
        public int AttendanceID { get; set; }
        public String AtttendantEmployee { get; set; }
        public String AttendentDays { get; set; }
        public int EmployeeID { get; set; }
        [ForeignKey("EmployeeID")]
        public Employee Employee { get; set; }
        

    }
}
