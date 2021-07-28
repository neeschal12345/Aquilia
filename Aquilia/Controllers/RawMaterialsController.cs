using System.Collections.Generic;
using System.Linq;
using Aquilia.Data;
using Aquilia.Models;
using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Aquilia.Controllers
{
    public class RawMaterialsController : Controller
    {
        private ApplicationDbContext Context { get; }
        private readonly ILogger<RawMaterialsController> _logger;
        private readonly INotyfService _notyfService;



        public RawMaterialsController(INotyfService notyfService, ILogger<RawMaterialsController> logger, ApplicationDbContext _context)
        {
            _logger = logger;
            _notyfService = notyfService;
            this.Context = _context;
        }
        // GET: /RawMaterials/

        public IActionResult AddNewRawMaterials()
        {
            List<Vendor> listofvendors = new List<Vendor>();
            listofvendors = (from vendor in Context.Vendor select vendor).ToList();
            listofvendors.Insert(0, new Vendor { VendorID=0,VendorName="-- Select Vendor Name --"});
            ViewBag.ListofVendors = listofvendors;
            return View();
        }

        public IActionResult AvailableRawMaterials()
        {

            List<RawMaterials> rawMaterials = (from rawmaterials in this.Context.RawMaterials.Take(10)
                                    select rawmaterials).ToList();
            return View(rawMaterials);
        }

        [HttpPost]
        public IActionResult AddNewRawMaterials(RawMaterials rawmaterials)
            
        {
            if (ModelState.IsValid)
            {
                this.Context.RawMaterials.Add(rawmaterials);
                this.Context.SaveChanges();
                _notyfService.Custom("New Vendor added Successfully!", 3, "#38f716", "fa fa-home");
                return Redirect("~/RawMaterials/AddNewRawMaterials");
            }
            return View(rawmaterials);

        }
    }
}
