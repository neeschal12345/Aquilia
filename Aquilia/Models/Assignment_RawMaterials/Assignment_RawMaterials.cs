using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aquilia.Models
{
    public class Assignment_RawMaterials
    {
        [Key]
        public int AssignmentRawMaterialsID { get; set; }

        public int Quantity { get; set; }

        [Column(Order=1)]
        public int RawMaterialID { get; set; }

        [ForeignKey("RawMaterialID")]
        public RawMaterials RawMaterials { get; set; }
        [Column(Order = 2)]
        public int AssignmentID { get; set; }
        [ForeignKey("AssignmentID")]
        public Assignment Assignment { get; set; }



    }
}