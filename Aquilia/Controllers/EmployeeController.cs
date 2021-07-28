using System.Collections.Generic;
using Aquilia.Data;
using Aquilia.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.Extensions.Logging;
using AspNetCoreHero.ToastNotification.Abstractions;
using Aquilia.ViewModel;


namespace Aquilia.Controllers
{
    public class EmployeeController : Controller
    {
        private ApplicationDbContext Context { get; }
        private readonly ILogger<EmployeeController> _logger;
        private readonly INotyfService _notyfService;



        public EmployeeController(INotyfService notyfService, ILogger<EmployeeController> logger, ApplicationDbContext _context)
        {
            _logger = logger;
            _notyfService = notyfService;
            this.Context = _context;
        }


     
        public ActionResult VendorPurchasesReport()
        {
            List<Vendor> listofvendors = new List<Vendor>();
            listofvendors = (from vendor in Context.Vendor select vendor).ToList();
            listofvendors.Insert(0, new Vendor { VendorID = 0, VendorName = "-- Select Vendor Name --" });
            ViewBag.ListofVendors = listofvendors;
            return View();
            //List<Vendor> vendors = (from vendor in this.Context.Vendor
            //                        select vendor).ToList();
            //return View(vendors);
        }


        public ActionResult AddNewEmployee()
        {
            return View();
        }



        [HttpPost]
        public IActionResult AddNewEmployee(Employee employee)
        {

            if (ModelState.IsValid)
            {
                this.Context.Employee.Add(employee);
                this.Context.SaveChanges();

                //Fetch the CustomerId returned via SCOPE IDENTITY.
                int id = employee.EmployeeID;
                string vendorName = employee.EmployeeName;
                string vendorAddress = employee.EmployeeAddress;
                string vendorContact = employee.EmployeeContactNo;
                _notyfService.Custom("New Employee added Successfully!", 3, "#38f716", "fa fa-home");
                return Redirect("/Employee/AllActiveEmployees");

            }

            return View(employee);
        }

        public IActionResult AllActiveEmployees()
        {
            List<Employee> employeelist = (from employees in this.Context.Employee
                                    select employees).ToList();
            return View(employeelist);
            
        }

        public ActionResult Create()
        {
            return View ();
        } 

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try {
                return RedirectToAction ("Index");
            } catch {
                return View ();
            }
        }
        
        public ActionResult Edit(int id)
        {
            return View ();
        }

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try {
                return RedirectToAction ("Index");
            } catch {
                return View ();
            }
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