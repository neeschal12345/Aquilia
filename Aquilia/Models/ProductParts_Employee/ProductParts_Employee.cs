using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aquilia.Models
{
    public class ProductParts_Employee
    {
        [Key]
        [Column(Order = 1)]
        public int ProductPartID { get; set; }

        public ProductParts ProductParts { get; set; }
        [Key]
        [Column(Order = 2)]
        public int EmployeeID { get; set; }

        public Employee Employee { get; set; }
    }
}