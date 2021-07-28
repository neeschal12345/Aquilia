using System.Collections.Generic;
using System.Linq;
using Aquilia.Data;
using Aquilia.Models;
using Aquilia.ViewModel;
using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Aquilia.Controllers
{

    public class ProductController : Controller
    {

        private ApplicationDbContext Context { get; }
        private readonly ILogger<ProductController> _logger;
        private readonly INotyfService _notyfService;



        public ProductController(INotyfService notyfService, ILogger<ProductController> logger, ApplicationDbContext _context)
        {
            _logger = logger;
            _notyfService = notyfService;
            this.Context = _context;
        }


        [HttpGet]
        public IActionResult DisplayProductPartsReport(int FP_ID)

        {
            List<FinalProduct> listofproducts = new List<FinalProduct>();
            listofproducts = (from finalproducts in Context.FinalProduct select finalproducts).ToList();
            listofproducts.Insert(0, new FinalProduct { FinalProductID = 0, ProductName = "-- Select Product Name --" });
            ViewBag.ListofProducts = listofproducts;
            FinalProduct finalProduct = Context.FinalProduct.Where(x => x.FinalProductID == FP_ID).Include(x => x.ProductParts).FirstOrDefault();
            List<ProductandProductPartsViewModel> p_and_ppviewmodel = finalProduct.ProductParts.Select(x => new ProductandProductPartsViewModel
            {
                
                ProductPartName = x.ProductPartName,
                productPartCode = x.ProductPartNumber,
                ProductCategory = x.ProductPartCategory,
                WaxComposition = x.WaxComposition,

                //TotalPrice = x.TotalAmount
            })
            .ToList();

            finalProduct.ProductandProductPartsViewModel = p_and_ppviewmodel;
            return View("ProductPartsReport", finalProduct);
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


        //public ActionResult AllProductDetails()
        //{

        //    return View ();
        //}

        public ActionResult AddNewProduct()
        {
            
            return View();
        }

        public IActionResult AllProductDetails()
        {

            List<FinalProduct> finalProducts = (from finalproduct in this.Context.FinalProduct.Take(10)
                                                select finalproduct).ToList();
            return View(finalProducts);
        }

        [HttpPost]
        public IActionResult AddNewProduct(FinalProduct finalProduct)

        {
            if (ModelState.IsValid)
            {
                this.Context.FinalProduct.Add(finalProduct);
                this.Context.SaveChanges();
                _notyfService.Custom("New Product added Successfully!", 3, "#38f716", "fa fa-home");
                return Redirect("~/Product/AddNewProduct");
                //Fetch the CustomerId returned via SCOPE IDENTITY.
            }
            return View(finalProduct);
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