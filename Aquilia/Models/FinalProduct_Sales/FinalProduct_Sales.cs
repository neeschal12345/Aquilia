using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aquilia.Models
{
    public class FinalProduct_Sales
    {
        [Key]
        public int FinalProduct_SalesID { get; set; }
        [Column(Order = 1)]
        
        public int FinalProductID { get; set; }

        [ForeignKey("FinalProductID")]
        public FinalProduct FinalProduct { get; set; }

        [Column(Order = 2)]
        public int SalesID { get; set; }
        [ForeignKey("SalesID")]
        public Sales Sales { get; set; }



    }
}