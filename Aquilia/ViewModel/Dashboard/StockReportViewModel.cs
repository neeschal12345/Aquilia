using System;
using System.ComponentModel.DataAnnotations;

namespace Aquilia.ViewModel.Dashboard
{
    public class ResourceStockViewModel
    {
        [Key]
        public int ID { get; set; }
        public string RawMaterialName { get; set; }
        public decimal RawmaterialQuantity { get; set; }
        public string VendorName { get; set; }
        public string Remarks { get; set; }
    }
}
