using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aquilia.Models
{
    public class Salary
    {
        [Key]
        public int SalaryID { get; set; }
        [Required]
        public string SalaryMonth { get; set; }

        public int AttendanceID { get; set; }
        [ForeignKey("AttendanceID")]
        public Attendance Attendance { get; set; }
    }
}
