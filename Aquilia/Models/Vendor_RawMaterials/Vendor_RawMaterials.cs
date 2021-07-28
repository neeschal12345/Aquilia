using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aquilia.Models
{
    public class Vendor_RawMaterials
    {
        [Key]
        [Column(Order=1)]
        public int VendorID { get; set; }

        public Vendor Vendor { get; set; }
        [Key]
        [Column(Order = 2)]
        public int RawMaterialID { get; set; }

        public RawMaterials RawMaterials { get; set; }
    }
}