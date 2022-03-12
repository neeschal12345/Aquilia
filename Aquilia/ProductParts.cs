using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Aquilia.ViewModel;

namespace Aquilia.Models
{
    public class ProductParts
    {
        [Key]
        public int ProductPartID { get; set; }
        [Required]
        public String ProductPartNumber { get; set; }
        [Required]
        public String ProductPartName { get; set; }
        [Required]
        public string ProductPartCategory { get; set; }

        public String WaxComposition { get; set; }

        public String CopperComposition { get; set; }

        public int FinalProductID { get; set; }

        [ForeignKey("FinalProductID")]

        public FinalProduct FinalProduct { get; set; }

        //public Employee Employee { get; set; }

        
    }
}
