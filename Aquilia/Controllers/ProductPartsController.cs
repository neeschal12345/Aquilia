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
    public class ProductPartsController : Controller
    {
        private ApplicationDbContext Context { get; }
        private readonly ILogger<ProductPartsController> _logger;
        private readonly INotyfService _notyfService;



        public ProductPartsController(INotyfService notyfService, ILogger<ProductPartsController> logger, ApplicationDbContext _context)
        {
            _logger = logger;
            _notyfService = notyfService;
            this.Context = _context;
        }

        public IActionResult AddNewProductParts()
        {
            List<FinalProduct> listoffinishedproducts = new List<FinalProduct>();
            listoffinishedproducts = (from finalproducts in Context.FinalProduct select finalproducts).ToList();
            listoffinishedproducts.Insert(0, new FinalProduct { FinalProductID = 0, ProductName = "-- Select Product Name --" });
            ViewBag.ListofFinalProducts = listoffinishedproducts;
            return View();



        }

        public ActionResult ProductPartsReport()
        {
            List<FinalProduct> listofproducts = new List<FinalProduct>();
            listofproducts = (from finalproducts in Context.FinalProduct select finalproducts).ToList();
            listofproducts.Insert(0, new FinalProduct { FinalProductID = 0, ProductName = "-- Select Product Name --" });
            ViewBag.ListofProducts = listofproducts;
            return View();
            //List<Vendor> vendors = (from vendor in this.Context.Vendor
            //                        select vendor).ToList();
            //return View(vendors);
        }


        [HttpPost]
        public IActionResult AddNewProductParts(ProductParts productparts)
        {
            if (ModelState.IsValid)
            {
                this.Context.ProductParts.Add(productparts);
                this.Context.SaveChanges();
                _notyfService.Custom("New Product Part added Successfully!", 3, "#38f716", "fa fa-home");
                return Redirect("~/ProductParts/AddNewProductParts");
            }
            return View();
        }
            public ActionResult AllProductPartDetails()
        {
            List<ProductParts> productParts = (from productparts in this.Context.ProductParts.Take(10)
                                               select productparts).ToList();
            return View(productParts);

          
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