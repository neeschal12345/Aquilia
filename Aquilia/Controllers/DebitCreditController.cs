using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aquilia.Data;
using Aquilia.Models;
using Aquilia.ViewModel;
using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Aquilia.Controllers
{
    
    public class DebitCreditController : Controller
    {
        private ApplicationDbContext Context { get; }
        private readonly ILogger<DebitCreditController> _logger;
        private readonly INotyfService _notyfService;

      

        public DebitCreditController(INotyfService notyfService, ILogger<DebitCreditController> logger,ApplicationDbContext _context)
        {
            _logger = logger;
            _notyfService = notyfService;
            this.Context = _context;
        }

       
        public ActionResult AddNewCustomerTransaction()
        {
            List<Customer> listofcustomers = new List<Customer>();
            listofcustomers = (from customers in Context.Customer select customers).ToList();
            listofcustomers.Insert(0, new Customer { CustomerID = 0, CustomerName = "-- Select Employee Name --" });
            ViewBag.ListofCustomers = listofcustomers;
            return View("~/Customer/AddNewCustomerTransaction");
        }

        public ActionResult AddNewTransaction() //Employee Transaction
        {
            List<Employee> listofemployee = new List<Employee>();
            listofemployee = (from employees in Context.Employee select employees).ToList();
            listofemployee.Insert(0, new Employee { EmployeeID = 0, EmployeeName = "-- Select Employee Name --" });


            ViewBag.ListofEmployee = listofemployee;
            return View();
        }
        [HttpGet]
        public IActionResult DisplayCustomerLedger(int EMP_ID)

        {
            List<Customer> listofcustomers = new List<Customer>();
            listofcustomers = (from customers in Context.Customer select customers).ToList();
            listofcustomers.Insert(0, new Customer { CustomerID = 0, CustomerName = "-- Select Employee Name --" });
            ViewBag.ListofCustomers = listofcustomers;
            Customer customer = Context.Customer.Where(x => x.CustomerID == EMP_ID).Include(x => x.CustomerLedger).FirstOrDefault();
            List<CustomerLedgerViewModel> d_c_viewmodel = customer.CustomerLedger.Select(x => new CustomerLedgerViewModel
            {
                Date=x.Date,
                Descriptions=x.Description,
                VoucherNo=x.VoucherNo,
                ChequeNumber=x.ChequeNumber,
                TransactionTypes=x.TransactionInfo,
                Amount=x.Amount,
                CurrentBalance=x.CurrentBalance
                

                //TransactionDate = x.Date,



            })
            .ToList();

            customer.CustomerLedgerViewModel = d_c_viewmodel;
            return View("DebitAndCredit", customer);
        }

        
        [HttpGet]
        public IActionResult DisplayEmployeeLedger(int EMP_ID)

        {
            List<Employee> listofemployee = new List<Employee>();
            listofemployee = (from employees in Context.Employee select employees).ToList();
            listofemployee.Insert(0, new Employee { EmployeeID = 0, EmployeeName = "-- Select Employee Name --" });
            ViewBag.ListofEmployee = listofemployee;
            Employee employee = Context.Employee.Where(x => x.EmployeeID == EMP_ID).Include(x => x.DebitCredit).FirstOrDefault();
            List<DebitAndCreditReportViewModel> d_c_viewmodel = employee.DebitCredit.Select(x => new DebitAndCreditReportViewModel
            {
                DebitCreditID=x.TransactionID,
                TransactionDate = x.Date,
                Description = x.Description,
                VoucherID = x.VoucherNo,
                TransactionType=x.TransactionType,
                Amount = x.Amount
                
            })
            .ToList();

            employee.DebitAndCreditReportViewModel = d_c_viewmodel;
            return View("DebitAndCredit", employee);
        }

        public ActionResult DebitAndCredit()
        {
            List<Employee> listofemployee = new List<Employee>();
            listofemployee = (from employees in Context.Employee select employees).ToList();
            listofemployee.Insert(0, new Employee { EmployeeID = 0, EmployeeName = "-- Select Employee Name --" });

            
            ViewBag.ListofEmployee = listofemployee;
           
            return View();
            
        }

        //[HttpGet]
        //public IActionResult VendorPurchasesReport(int id)
        //{

        //    return View();
        //}


        public IActionResult DebitCreditReports()
        {

            List<Employee> listofemployee = new List<Employee>();
            listofemployee = (from employees in Context.Employee select employees).ToList();
            listofemployee.Insert(0, new Employee { EmployeeID = 0, EmployeeName = "-- Select Employee Name --" });
            ViewBag.ListofEmployee = listofemployee;
            return View();
        }

        //public ActionResult AddNewTransaction()
        //{

        //    return View ();
        //}

        [HttpPost]
        public IActionResult AddNewCustomerTransaction(CustomerLedger customerLedger)


        {

            if (ModelState.IsValid)
            {
                this.Context.CustomerLedger.Add(customerLedger);
                this.Context.SaveChanges();
                _notyfService.Custom("New Customer Transaction added Successfully!", 3, "#00ad1a", "fa fa-home");
                //_notyfService.Success("New Vendor added Successfully!");
                return Redirect("~/DebitCredit/AddNewCustomerTransaction");

            }

            return View();
        }
        [HttpPost]
        public IActionResult AddNewVendorTransaction(RawMaterials rawMaterials)


        {

            if (ModelState.IsValid)
            {
                this.Context.RawMaterials.Add(rawMaterials);
                this.Context.SaveChanges();
                _notyfService.Custom("New Vendor Transaction added Successfully!", 3, "#00ad1a", "fa fa-home");
                //_notyfService.Success("New Vendor added Successfully!");
                return Redirect("~/RawMaterials/AddNewRawMaterials");

            }

            return View();
        }
        [HttpPost]
        public IActionResult AddNewTransaction(DebitCredit debitCredit)
            

        {
            
            if (ModelState.IsValid)
            {
                this.Context.DebitCredits.Add(debitCredit);
                this.Context.SaveChanges();

                //Fetch the CustomerId returned via SCOPE IDENTITY.
                int id = debitCredit.TransactionID;
                string description = debitCredit.Description;
                int voucherNo = debitCredit.VoucherNo;
                string transType = debitCredit.TransactionType;
                int amount = debitCredit.Amount;
                _notyfService.Custom("New Transaction added Successfully!", 3, "#38f716", "fa fa-home");
                //_notyfService.Success("New Vendor added Successfully!");
                return Redirect("~/DebitCredit/AddNewTransaction");
                
            }

            return View(); 
        }
        [HttpGet]
            public ActionResult EditTransaction(int id)
        {
            List<DebitCredit> debitCredits = (from debitcredits in this.Context.DebitCredits
                                    select debitcredits).ToList();
            var ven = debitCredits.Where(s => s.TransactionID == id).FirstOrDefault();
    
            return View(ven);
        }

        [HttpPost]
        public IActionResult EditVendor(Vendor model)
        {
        
                List<Vendor> vendors = (from vendor in this.Context.Vendor
                                        select vendor).ToList();
               
                Vendor vend = vendors.Where(s => s.VendorID == model.VendorID).FirstOrDefault(); ;
                
                vend.VendorName = model.VendorName;
                vend.VendorContact = model.VendorContact;
                vend.VendorLocation = model.VendorLocation;
                vend.PANNo = model.PANNo;
            this.Context.Vendor.Update(vend);
            this.Context.SaveChanges();
            

            return Redirect("~/Vendor/AllActiveVendors");
        }

        public ActionResult Delete(int id)
        {
            return View ();
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try {
                return RedirectToAction ("Index");
            } catch {
                return View ();
            }
        }
       
        
    }
}