using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Aquilia.ViewModel;

namespace Aquilia.Models
{
    public class FinalProduct
    {
        [Key]
        public int FinalProductID { get; set; }
        [Required]
        public String ProductName { get; set; }
        [Required]
        public String Category { get; set; } //Denotes the category that the product falls in; like Peace, Angry
        [Required]
        public String ProductSize { get; set; }

        public decimal ProductPrice { get; set; }

        public ICollection<ProductParts> ProductParts{ get; set; }

        public virtual ICollection<ProductandProductPartsViewModel> ProductandProductPartsViewModel { get; set; }


        //public ICollection<FinalProduct_Sales> finalProduct_Sales { get; set; }

    }
}
