using Aquilia.Models;
using Microsoft.EntityFrameworkCore;

namespace Aquilia.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Vendor> Vendor { get; set; }
        public DbSet<FinalProduct> FinalProduct { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<RawMaterials> RawMaterials { get; set; }
        public DbSet<Assignment> Assignment { get; set; }
        public DbSet<AssignmentLog> AssignmentLog { get; set; }
        public DbSet<Salary> Salary { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<DebitCredit> DebitCredits { get; set; }
        //public DbSet<VendorLedger> VendorLedger { get; set; }
        public DbSet<CustomerLedger> CustomerLedger { get; set; }
        public DbSet<Sales> Sales { get; set; }
        public DbSet<ProductParts> ProductParts { get; set; }
        public DbSet<Assignment_RawMaterials> Assignment_RawMaterials { get; set; }
       
      


    }
}

    //public DbSet<BudgetManagementSystem.Models.Budget.Class> Class { get; set; }




