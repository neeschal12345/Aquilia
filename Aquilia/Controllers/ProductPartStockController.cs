using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aquilia.Data;
using Aquilia.Models;
using Aquilia.ViewModel;
using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Aquilia.Controllers
{
    
    public class VendorController : Controller
    {
        private ApplicationDbContext Context { get; }
        private readonly ILogger<VendorController> _logger;
        private readonly INotyfService _notyfService;

        public VendorController(INotyfService notyfService, ILogger<VendorController> logger,ApplicationDbContext _context)
        {
            _logger = logger;
            _notyfService = notyfService;
            this.Context = _context;
        }
        [HttpGet]
        public ActionResult AddNewVendor()
        {

            return View();
        }
        public ActionResult VendorLedger()
           
        {
            try
            {
                List<Vendor> listofvendors = new List<Vendor>();
                listofvendors = (from vendors in Context.Vendor.Where(x => x.Active != false) select vendors).ToList();
                listofvendors.Insert(0, new Vendor { VendorID = 0, VendorName = "-- Select Vendor Name --" });


                ViewBag.ListofVendors = listofvendors;

                return View();
            }
            catch (Exception ex)

            {
                if(ex is SqlException)
                {

                    _notyfService.Error("Database is not Active!!!",3);
                    
                }
                return RedirectToAction("Index", "Home");
            }

        }
        [HttpPost]
        public IActionResult AddNewVendorTransaction(RawMaterials rawMaterials)


        {
            
            if (ModelState.IsValid)
            {

                this.Context.RawMaterials.Add(rawMaterials);
                this.Context.SaveChanges();
                _notyfService.Success("New Payment added Successfully!", 3);
                return Redirect("~/RawMaterials/AddNewRawMaterials");

            }

            return View();
        }

            [HttpGet]
        public IActionResult DisplayVendorLedger(int EMP_ID)

        {
            if (EMP_ID > 0)
            {
                List<Vendor> listofvendors = new List<Vendor>();
                listofvendors = (from vendors in Context.Vendor.Where(x=>x.Active!=false) select vendors).ToList();
                listofvendors.Insert(0, new Vendor { VendorID = 0, VendorName = "-- Select Vendor Name --" });
                ViewBag.ListofVendors = listofvendors;
                Vendor vendor = Context.Vendor.Where(x => x.VendorID == EMP_ID).Include(x => x.RawMaterials).FirstOrDefault();
                List<VendorLedgerViewModel> v_l_viewmodel = vendor.RawMaterials.Select(x => new VendorLedgerViewModel
                {
                    VendorLedgerID = x.RawMaterialID,
                    Date = x.Date,
                    Quantity = x.Quantity,
                    Description = x.Description,
                    VoucherNo = x.VoucherNo,
                    ChequeNumber = x.ChequeNumber,
                    CreditAmount = x.CreditAmount,
                    DebitAmount = x.DebitAmount,
                    Rate = x.Rate,
                    CurrentBalance = x.CurrentBalance,
                   



                })
                .ToList();

                vendor.VendorLedgerViewModel = v_l_viewmodel;
                return View("VendorLedger", vendor);
            }
            else
            {
                _notyfService.Custom("Vendor Not Found!", 3, "#ff4f4f", "fa fa-home");
                return RedirectToAction("VendorLedger", "Vendor");
            }
        }

        [HttpGet]
        public ActionResult AddVendorOldBalance(int Ven_ID)
        {
            int listofvendor = Context.Vendor.Where(x => x.Active == true).Where(x => x.VendorID == Ven_ID).Select(x => x.VendorID).FirstOrDefault();
            string listofvendorname = Context.Vendor.Where(x => x.Active == true).Where(x => x.VendorID == Ven_ID).Select(x => x.VendorName).FirstOrDefault();
            ViewBag.ListofVendor = listofvendor;
            ViewBag.ListofVendorName = listofvendorname;
            return View();
        }

        [HttpPost]
        public IActionResult AddVendorOldBalance(RawMaterials rawMaterials, string returnUrl)


        {

            if (ModelState.IsValid)
            {

                this.Context.RawMaterials.Add(rawMaterials);
                this.Context.SaveChanges();
                _notyfService.Success("Old Balance added!", 3);
                return Redirect(returnUrl);

            }

            return View();
        }

        [HttpGet]
        public ActionResult AddNewVendorTransaction(int Ven_ID)
        {
            int listofvendor = Context.Vendor.Where(x => x.Active == true).Where(x => x.VendorID == Ven_ID).Select(x => x.VendorID).FirstOrDefault();
            string listofvendorname = Context.Vendor.Where(x => x.Active == true).Where(x => x.VendorID == Ven_ID).Select(x => x.VendorName).FirstOrDefault();
            ViewBag.ListofVendor = listofvendor;
            ViewBag.ListofVendorName = listofvendorname;
            return View();
        }
        [HttpGet]
        public IActionResult DisplayVendorPurchaseReport(int V_ID)

        {
            if (V_ID > 0)
            {
                List<Vendor> listofvendors = new List<Vendor>();
                listofvendors = (from vendors in Context.Vendor select vendors).ToList();
                listofvendors.Insert(0, new Vendor { VendorID = 0, VendorName = "-- Select Vendor Name --" });
                ViewBag.ListofVendors = listofvendors;
                Vendor vendor = Context.Vendor.Where(x => x.VendorID == V_ID).Include(x => x.RawMaterials).FirstOrDefault();
                List<VendorPurchasesViewModel> v_p_viewmodel = vendor.RawMaterials.Select(x => new VendorPurchasesViewModel
                {
                    BillNo = x.BillNo,
                    particularName = x.Description,
                    Rate = x.Rate,
                    Quantity = x.Quantity,
                    TotalPrice = x.CreditAmount
                })
                .ToList();
                vendor.VendorPurchasesViewModel = v_p_viewmodel;
                return View("VendorPurchasesReport", vendor);
            }
            else
            {
                _notyfService.Error("Vendor Not Found!", 3);
                return RedirectToAction("VendorPurchasesReport", "Vendor");
            }
        }

        public ActionResult VendorPurchasesReport()
        {
            List<Vendor> listofvendors = new List<Vendor>();
            listofvendors = (from vendor in Context.Vendor select vendor).ToList();
            listofvendors.Insert(0, new Vendor { VendorID = 0, VendorName = "-- Select Vendor Name --" });

            List<RawMaterials> listofbills = new List<RawMaterials>();
            listofbills = (from rawmaterials in Context.RawMaterials select rawmaterials).ToList();
            listofbills.Insert(0, new RawMaterials { RawMaterialID = 0, BillNo = 0 });
            ViewBag.ListofVendors = listofvendors;
            ViewBag.ListofAvailableBills = listofbills;
            return View();
        }

        public IActionResult AllActiveVendors()
        {

            List<Vendor> vendors = (from vendor in this.Context.Vendor select vendor).ToList();
            return View(vendors);
        }

        [HttpPost]
        public IActionResult AddNewVendor(Vendor vendor)
            

        {
            string name = vendor.ToString();
            List<Vendor> vendors = (from vendo in this.Context.Vendor
                                    select vendor).ToList();
            var ven = vendors.Where(s => s.VendorName == name).FirstOrDefault();

            if (ven == null)
            {

                if (ModelState.IsValid)
                {
                    this.Context.Vendor.Add(vendor);
                    this.Context.SaveChanges();

                    int id = vendor.VendorID;
                    string vendorName = vendor.VendorName;
                    string vendorAddress = vendor.VendorLocation;
                    string vendorContact = vendor.VendorContact;
                    string PAN = vendor.PANNo;
                    _notyfService.Success("New Vendor added Successfully!", 3);
                    int xx = vendor.VendorID;
                    
                    int listofvendor = Context.Vendor.Where(x => x.Active == true).Where(x => x.VendorID == xx).Select(x => x.VendorID).FirstOrDefault();
                    string listofvendorname = Context.Vendor.Where(x => x.Active == true).Where(x => x.VendorID == xx).Select(x => x.VendorName).FirstOrDefault();
                    ViewBag.ListofVendor = listofvendor;
                    ViewBag.ListofVendorName = listofvendorname;
                    return RedirectToAction("AddNewVendor", "Vendor");

                }
                return View();
            }
            else
            {
                _notyfService.Error("Vendor exists already!", 3);
                return RedirectToAction("AddNewVendor", "Vendor");
            }
        }
        [HttpGet]
            public ActionResult EditVendor(int id)
        {
            List<Vendor> vendors = (from vendor in this.Context.Vendor
                                    select vendor).ToList();
            var ven = vendors.Where(s => s.VendorID == id).FirstOrDefault();
    
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
            vend.Active = model.Active;
            this.Context.Vendor.Update(vend);
            this.Context.SaveChanges();
            _notyfService.Warning("Record Updated!",2);
            return Redirect("~/Vendor/AllActiveVendors");
        }

        public ActionResult Delete(int id)
        {
            ViewBag.returnUrl = Request.Headers["Referer"].ToString();
            return View ();
        }

        [HttpPost]
        public ActionResult Delete(int id, string returnUrl,IFormCollection collection)
        {
            
            var term = Context.RawMaterials.Where(x => x.RawMaterialID == id).First();
            Context.RawMaterials.Remove(term);
            Context.SaveChanges();
            _notyfService.Warning("Record Deleted!", 2);
            return Redirect(returnUrl);
        }

        [HttpGet]
        public ActionResult EditVendorLedger(int id)
        {
            ViewBag.returnUrl = Request.Headers["Referer"].ToString();
            List<RawMaterials> rawMaterials = (from RawMaterials in this.Context.RawMaterials
                                               select RawMaterials).ToList();
            var ven = rawMaterials.Where(s => s.RawMaterialID == id).FirstOrDefault();

            return View(ven);
        }

        [HttpPost]
        public IActionResult EditVendorLedger(RawMaterials rawmaterials, string returnUrl)
        {
            List<RawMaterials> rawMaterials = (from RawMaterials in this.Context.RawMaterials
                                               select RawMaterials).ToList();

            RawMaterials raw = rawMaterials.Where(s => s.RawMaterialID == rawmaterials.RawMaterialID).FirstOrDefault(); ;
            raw.Date = rawmaterials.Date;
            raw.Description = rawmaterials.Description;
            raw.Quantity = rawmaterials.Quantity;
            raw.Rate = rawmaterials.Rate;
            raw.VoucherNo = rawmaterials.VoucherNo;
            raw.DebitAmount = rawmaterials.DebitAmount;
            raw.CreditAmount = rawmaterials.CreditAmount;
            this.Context.RawMaterials.Update(raw);
            this.Context.SaveChanges();
            _notyfService.Warning("Record Updated!", 2);
            return Redirect(returnUrl);
        }
    }
}