using System.Collections.Generic;
using Aquilia.Data;
using Aquilia.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.Extensions.Logging;
using AspNetCoreHero.ToastNotification.Abstractions;

namespace Aquilia.Controllers

{
    public class AssignmentProductPartsController : Controller
    {
        private ApplicationDbContext Context { get; }
        private readonly ILogger<AssignmentProductPartsController> _logger;
        private readonly INotyfService _notyfService;



        public AssignmentProductPartsController(INotyfService notyfService, ILogger<AssignmentProductPartsController> logger, ApplicationDbContext _context)
        {
            _logger = logger;
            _notyfService = notyfService;
            this.Context = _context;
        }

        public IActionResult AddNewProductPartsComposition()
        {
            List<Assignment> listofassignments = new List<Assignment>();
            listofassignments = (from assignments in Context.Assignment select assignments).ToList();
            listofassignments.Insert(0, new Assignment { AssignmentID = 0,AssignmentName="-- Select an Assignment Name --"});
            ViewBag.ListofAssignments = listofassignments;

            List<RawMaterials> listofrawmaterials = new List<RawMaterials>();
            listofrawmaterials = (from rawmaterials in Context.RawMaterials select rawmaterials).ToList();
            listofrawmaterials.Insert(0, new RawMaterials { RawMaterialID = 0, Description = "-- Select Raw Material Name --" });
            ViewBag.ListofRawMaterials = listofrawmaterials;
            return View();


        }

        [HttpPost]
        public IActionResult AddNewProductPartsComposition(Assignment_RawMaterials productpartscomposition)
        {
            if (ModelState.IsValid)
            {
                this.Context.Assignment_RawMaterials.Add(productpartscomposition);
                this.Context.SaveChanges();
                
                _notyfService.Custom("New Composition added Successfully!", 3, "#38f716", "fa fa-home");
                return Redirect("~/AssignmentProductParts/AddNewProductPartsComposition");
            }
            return View();
        }


        public ActionResult AllProductPartsComposition()
        {
            List<Assignment_RawMaterials> productPartsComposition = (from productpartscomposition in this.Context.Assignment_RawMaterials
                                                                     select productpartscomposition).ToList();
            return View(productPartsComposition);


        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}