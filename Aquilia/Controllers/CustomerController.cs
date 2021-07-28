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
    
    public class CustomerController : Controller
    {
        private ApplicationDbContext Context { get; }
        private readonly ILogger<CustomerController> _logger;
        private readonly INotyfService _notyfService;

      

        public CustomerController(INotyfService notyfService, ILogger<CustomerController> logger,ApplicationDbContext _context)
        {
            _logger = logger;
            _notyfService = notyfService;
            this.Context = _context;
        }
        public ActionResult AddNewCustomer()
        {
          
            return View();
        }

        [HttpGet]
        public IActionResult DisplayCustomerPurchaseReport(int C_ID)

        {
            List<Customer> listofcustomers = new List<Customer>();
            listofcustomers = (from customers in Context.Customer select customers).ToList();
            listofcustomers.Insert(0, new Customer { CustomerID = 0, CustomerName = "-- Select Customer Name --" });
            ViewBag.ListofCustomer = listofcustomers;
            Customer customer = Context.Customer.Where(x => x.CustomerID == C_ID).Include(x=>x.Sales).FirstOrDefault();
            List<CustomerSalesViewModel> c_s_viewmodel = customer.Sales.Select(x => new CustomerSalesViewModel
            {
                BillNo=x.BillNo,
                TotalPrice=x.TotalPrice,
                CustomerName=customer.CustomerName,
                ProductName=x.FinalProduct.ProductName,
                ProductRate=x.FinalProduct.ProductPrice
            })
            .ToList();

            customer.CustomerSalesViewModel = c_s_viewmodel;
            return View("CustomerPurchasesReport",customer);
        }


        public ActionResult CustomerPurchasesReport()
        {
            List<Customer> listofcustomers = new List<Customer>();
            listofcustomers = (from customer in Context.Customer select customer).ToList();
            listofcustomers.Insert(0, new Customer { CustomerID = 0, CustomerName = "-- Select Customer Name --" });
            ViewBag.ListofCustomer = listofcustomers;
            return View();
        }

        


        public IActionResult AllActiveCustomer()
        {

            List<Customer> customer = (from customers in this.Context.Customer
                                        select customers).ToList();
            return View(customer);
        }

        public ActionResult Create()
        {

            //ViewBag.Text("Hello");
            return View ();
        }


        //public void ClearData()
        //{
        //    Customer v = new Customer();
        //    v.CustomerName = "";
        //    v.CustomerContact = "";
        //    v.CustomerLocation = "";
        //    v.PANNo = "";

        //}
        [HttpPost]
        public IActionResult AddNewCustomer(Customer customer)
            

        {
            
            if (ModelState.IsValid)
            {
                this.Context.Customer.Add(customer);
                this.Context.SaveChanges();

                //Fetch the CustomerId returned via SCOPE IDENTITY.
                int id = customer.CustomerID;
                string CustomerName = customer.CustomerName;
                string CustomerAddress = customer.CustomerAddress;
                long CustomerContact = customer.ContactNo;
                
                _notyfService.Custom("New Customer added Successfully!", 3, "#38f716", "fa fa-home");
                //_notyfService.Success("New Customer added Successfully!");
                return Redirect("~/Customer/AddNewCustomer");
                
            }

            return View(); 
        }
        [HttpGet]
            public ActionResult EditCustomer(int id)
        {
            List<Customer> customer = (from customers in this.Context.Customer
                                    select customers).ToList();
            var ven = customer.Where(s => s.CustomerID == id).FirstOrDefault();
    
            return View(ven);
        }

        [HttpPost]
        public IActionResult EditCustomer(Customer model)
        {
            // Check if the provided data is valid, if not rerender the edit view
            // so the user can correct and resubmit the edit form
            //if (ModelState.IsValid)
            //{
                List<Customer> customer = (from customers in this.Context.Customer
                                        select customers).ToList();
                //var ven = Customer.Where(s => s.CustomerID == model.CustomerID).FirstOrDefault();

                // Retrieve the employee being edited from the database
                Customer vend = customer.Where(s => s.CustomerID == model.CustomerID).FirstOrDefault(); ;
                // Update the employee object with the data in the model object
                vend.CustomerName = model.CustomerName;
                vend.CustomerAddress = model.CustomerAddress;
                vend.ContactNo = model.ContactNo;
                
            this.Context.Customer.Update(vend);
            this.Context.SaveChanges();
            // If the user wants to change the photo, a new photo will be
            // uploaded and the Photo property on the model object receives
            // the uploaded photo. If the Photo property is null, user did
            // not upload a new photo and keeps his existing photo

            //return RedirectToAction("AllActiveCustomer");
            //}

            return Redirect("~/Customer/AllActiveCustomer");
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