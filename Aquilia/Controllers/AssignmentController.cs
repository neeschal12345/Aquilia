using System.Collections.Generic;
using Aquilia.Data;
using Aquilia.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.Extensions.Logging;
using Aquilia.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace Aquilia.Controllers

{
    public class AssignmentController : Controller
    {
        private ApplicationDbContext Context { get; }
        private readonly ILogger<AssignmentController> _logger;
        private readonly INotyfService _notyfService;





        public ActionResult EmployeeAssignmentReport()
        {
            List<Assignment> listofactiveassignments = new List<Assignment>();
            listofactiveassignments = (from assignments in Context.Assignment select assignments).ToList();
            listofactiveassignments.Insert(0, new Assignment { AssignmentID = 0,AssignmentName="-- Select an Assignment --"});
            ViewBag.ListofActiveAssignments = listofactiveassignments;

            return View();
        }

        [HttpGet]
        public IActionResult DisplayAssignmentForEmployeeReport(int As_ID)

        {
            List<Assignment> listofactiveassignments = new List<Assignment>();
            listofactiveassignments = (from assignments in Context.Assignment select assignments).ToList();
            listofactiveassignments.Insert(0, new Assignment { AssignmentID = 0,AssignmentName = "--- Select an Assignment ---" });
            ViewBag.ListofActiveAssignments = listofactiveassignments;
            //Employee employee
            Assignment assignment = Context.Assignment.Where(x => x.AssignmentID == As_ID).Include(x => x.AssignmentLogs).Include(x=>x.ProductParts).FirstOrDefault();
            List<EmployeeAssignmentsViewModel> v_p_viewmodel = assignment.AssignmentLogs.Select(x => new EmployeeAssignmentsViewModel
            {
                //EmployeeName = x,
                AssignedDate = x.AssignedDate,
                FinalProductName = assignment.ProductParts.ProductPartName,
                //EmployeeName=assignment.E,
                //ProductPartCode = x.Assignment.ProductParts,
                //AssignedProductPart = assignment.ProductParts.ProductPartName,
                //AssignmentState = assignment.ProductPartID

            })
            .ToList();
            assignment.EmployeeAssignmentsViewModel = v_p_viewmodel;
            return View("EmployeeAssignmentReport",assignment);
        }

        public AssignmentController(INotyfService notyfService, ILogger<AssignmentController> logger, ApplicationDbContext _context)
        {
            _logger = logger;
            _notyfService = notyfService;
            this.Context = _context;
        }

        public IActionResult AddNewAssignmentLog()
        {
            List<Assignment> listofassignments = new List<Assignment>();
            listofassignments = (from assignment in Context.Assignment select assignment).ToList();
            listofassignments.Insert(0, new Assignment { AssignmentID = 0, AssignmentName = "-- Select Assignment Name --" });
            ViewBag.ListofAssignments = listofassignments;
            //List<ProductParts> listofproductparts = new List<ProductParts>();
            //listofproductparts = (from productParts in Context.ProductParts select productParts).ToList();
            //listofproductparts.Insert(0, new ProductParts { ProductPartID = 0, ProductPartName = "-- Select Product Parts Name --" });
            //ViewBag.ListofProductParts = listofproductparts;

            List<Employee> listofactiveemployees = new List<Employee>();
            listofactiveemployees = (from currentemployee in Context.Employee select currentemployee).ToList();
            listofactiveemployees.Insert(0, new Employee { EmployeeID = 0, EmployeeName = "-- Select Product Name --" });
            ViewBag.listofactiveemployees = listofactiveemployees;
            return View();
        }

        public IActionResult AddNewAssignment()
        {
            List<FinalProduct> listoffinalproduct = new List<FinalProduct>();
            listoffinalproduct = (from finalproducts in Context.FinalProduct select finalproducts).ToList();
            listoffinalproduct.Insert(0, new FinalProduct { FinalProductID = 0, ProductName = "-- Select Product Name --" });
            ViewBag.ListofProducts = listoffinalproduct;
            List<ProductParts> listofproductparts = new List<ProductParts>();
            listofproductparts = (from productParts in Context.ProductParts select productParts).ToList();
            listofproductparts.Insert(0, new ProductParts { ProductPartID = 0, ProductPartName = "-- Select Product Parts Name --" });
            ViewBag.ListofProductParts = listofproductparts;

            List<Employee> listofactiveemployees = new List<Employee>();
            listofactiveemployees = (from currentemployee in Context.Employee select currentemployee).ToList();
            listofactiveemployees.Insert(0, new Employee { EmployeeID = 0, EmployeeName = "-- Select Product Name --" });
            ViewBag.listofactiveemployees = listofactiveemployees;
            return View();
        }
        [HttpPost]
        public IActionResult AddNewAssignmentLog(AssignmentLog assignmentlog)
        {
            if (ModelState.IsValid)
            {
                AssignmentLog ass = new AssignmentLog();
                this.Context.AssignmentLog.Add(assignmentlog);
                //int assignedstate = 1;
                //ass.AssignedState = assignedstate;
                //this.Context..DateEmployee.Add(employee);
                this.Context.SaveChanges();

                _notyfService.Custom("New Assignment Log added Successfully!", 3, "#38f716", "fa fa-home");
                return Redirect("~/Assignment/AddNewAssignmentLog");
            }
            return View();
        }

        [HttpPost]
        public IActionResult AddNewAssignment(Assignment assignment)
        {
            if (ModelState.IsValid)
            {
                this.Context.Assignment.Add(assignment);
                //this.Context..DateEmployee.Add(employee);
                this.Context.SaveChanges();
                
                _notyfService.Custom("New Assignment added Successfully!", 3, "#38f716", "fa fa-home");
                return Redirect("~/Assignment/AddNewAssignment");
            }
            return View();
        }

        public ActionResult AllActiveAssignments()
        {
            List<Assignment> assignmentlist = (from assignment in this.Context.Assignment
                                           select assignment).ToList();
            return View(assignmentlist);

            
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