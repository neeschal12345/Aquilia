using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aquilia.Models
{
    public class RawMaterials
    {
        [Key]
        public int RawMaterialID { get; set; } //For both

        public string Date { get; set; }
        //[Required]
        public int BillNo { get; set; } //To buy raw material
        [Required]
        public String Description { get; set; }

        public short Quantity { get; set; }//To buy raw material
        //[Required]
        public int Rate { get; set; } //To buy raw material

        public int VoucherNo { get; set; } 

        public long ChequeNumber { get; set; }

        public int CreditAmount { get; set; } //To buy raw material

        public int DebitAmount { get; set; }
        [Required]
        public int CurrentBalance { get; set; } 

        public int VendorID { get; set; }

        [ForeignKey("VendorID")]

        public Vendor Vendor { get; set; }

        public ICollection<Assignment_RawMaterials> assignment_RawMaterials { get; set; }


    }
}
