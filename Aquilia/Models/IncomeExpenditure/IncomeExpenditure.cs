using System;
namespace Aquilia.Models.IncomeExpenditure
{
    public class IncomeExpenditure
    {
        public RawMaterials RawMaterials { get; set; }
        public FinalProduct FinalProduct { get; set; }
        public Salary Salary { get; set; }
        public Sales Sales { get; set; }
    }
}
