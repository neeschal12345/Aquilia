using System;
using System.ComponentModel.DataAnnotations;

namespace Aquilia.ViewModel
{
    public class ProductandProductPartsViewModel
    {
        [Key]
        public int ProductandProductPartsID { get; set; }
        public string FinalProductName { get; set; }
        public string ProductPartName { get; set; }
        public string ProductCategory { get; set; }
        public string productPartCode { get; set; }
        //public string RawMaterialCompositionName { get; set; }
        public string WaxComposition { get; set; }

    }
}
