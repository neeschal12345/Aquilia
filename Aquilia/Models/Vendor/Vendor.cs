using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Aquilia.ViewModel;

namespace Aquilia.Models
{
    public class Vendor
    {
        [Key]
        public int VendorID { get; set; }
        [Required]
        public String VendorName { get; set; }
        [Required]
        public String VendorLocation { get; set; }
        [Required]
        public String VendorContact { get; set; }
        [Required]
        public String PANNo { get; set; }
        
        public ICollection<RawMaterials> RawMaterials { get; set; }

        public virtual ICollection<VendorPurchasesViewModel> VendorPurchasesViewModel { get; set; }

        //public ICollection<VendorLedger> VendorLedger { get; set; }
        public virtual ICollection <VendorLedgerViewModel> VendorLedgerViewModel { get; set; }
    }
    

}
