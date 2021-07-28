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
            List<Vendor> listofvendors = new List<Vendor>();
            listofvendors = (from vendors in Context.Vendor select vendors).ToList();
            listofvendors.Insert(0, new Vendor { VendorID = 0, VendorName = "-- Select Employee Name --" });


            ViewBag.ListofVendors = listofvendors;

            return View();

        }
        [HttpPost]
        public IActionResult AddNewVendorTransaction(RawMaterials rawMaterials)


        {

            if (ModelState.IsValid)
            {
                this.Context.RawMaterials.Add(rawMaterials);
                this.Context.SaveChanges();

                //Fetch the CustomerId returned via SCOPE IDENTITY.
                //int id = debitCredit.TransactionID;
                //string description = debitCredit.Description;
                //int voucherNo = debitCredit.VoucherNo;
                //string transType = debitCredit.TransactionType;
                //int amount = debitCredit.Amount;
                _notyfService.Custom("New Vendor Transaction added Successfully!", 3, "#38f716", "fa fa-home");
                //_notyfService.Success("New Vendor added Successfully!");
                return Redirect("~/RawMaterials/AddNewRawMaterials");

            }

            return View();
        }
            [HttpGet]
        public IActionResult DisplayVendorLedger(int EMP_ID)

        {
            List<Vendor> listofvendors = new List<Vendor>();
            listofvendors = (from vendors in Context.Vendor select vendors).ToList();
            listofvendors.Insert(0, new Vendor { VendorID = 0, VendorName = "-- Select Employee Name --" });
            ViewBag.ListofVendors = listofvendors;
            Vendor vendor = Context.Vendor.Where(x => x.VendorID == EMP_ID).Include(x => x.RawMaterials).FirstOrDefault();
            List<VendorLedgerViewModel> v_l_viewmodel = vendor.RawMaterials.Select(x => new VendorLedgerViewModel
            {

                VendorLedgerID = x.RawMaterialID,
                Date = x.Date,
                Description = x.Description,
                VoucherNo = x.VoucherNo,
                ChequeNumber=x.ChequeNumber,
                CreditAmount = x.CreditAmount,
                DebitAmount = x.DebitAmount,
                Rate=x.Rate,
                CurrentBalance = x.CurrentBalance


            })
            .ToList();

            vendor.VendorLedgerViewModel = v_l_viewmodel;
            return View("VendorLedger", vendor);
        }

        public ActionResult AddNewVendorTransaction()
        {
            List<Vendor> listofvendors = new List<Vendor>();
            listofvendors = (from vendors in Context.Vendor select vendors).ToList();
            listofvendors.Insert(0, new Vendor { VendorID = 0, VendorName = "-- Select Vendor Name --" });
            ViewBag.ListofVendors = listofvendors;
            return View();
        }
        [HttpGet]
        public IActionResult DisplayVendorPurchaseReport(int V_ID)

        {
            List<Vendor> listofvendors = new List<Vendor>();
            listofvendors = (from vendors in Context.Vendor select vendors).ToList();
            listofvendors.Insert(0, new Vendor { VendorID = 0, VendorName = "-- Select Vendor Name --" });
            ViewBag.ListofVendors = listofvendors;
            Vendor vendor = Context.Vendor.Where(x => x.VendorID == V_ID).Include(x=>x.RawMaterials).FirstOrDefault();
            List<VendorPurchasesViewModel> v_p_viewmodel = vendor.RawMaterials.Select(x => new VendorPurchasesViewModel
            {
                BillNo = x.BillNo,
                particularName = x.Description,
                Rate=x.Rate,
                Quantity=x.Quantity,
                TotalPrice=x.CreditAmount
            })
            .ToList();
            vendor.VendorPurchasesViewModel = v_p_viewmodel;
            return View("VendorPurchasesReport", vendor);
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

        public ActionResult Create()
        {

            return View ();
        }


        [HttpPost]
        public IActionResult AddNewVendor(Vendor vendor)
            

        {
            
            if (ModelState.IsValid)
            {
                this.Context.Vendor.Add(vendor);
                this.Context.SaveChanges();

                //Fetch the CustomerId returned via SCOPE IDENTITY.
                int id = vendor.VendorID;
                string vendorName = vendor.VendorName;
                string vendorAddress = vendor.VendorLocation;
                string vendorContact = vendor.VendorContact;
                string PAN = vendor.PANNo;
                _notyfService.Custom("New Vendor added Successfully!", 3, "#38f716", "fa fa-home");
                //_notyfService.Success("New Vendor added Successfully!");
                return Redirect("~/Vendor/AddNewVendor");
                
            }

            return View(); 
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
            // Check if the provided data is valid, if not rerender the edit view
            // so the user can correct and resubmit the edit form
            //if (ModelState.IsValid)
            //{
                List<Vendor> vendors = (from vendor in this.Context.Vendor
                                        select vendor).ToList();
                //var ven = vendors.Where(s => s.VendorID == model.VendorID).FirstOrDefault();

                // Retrieve the employee being edited from the database
                Vendor vend = vendors.Where(s => s.VendorID == model.VendorID).FirstOrDefault(); ;
                // Update the employee object with the data in the model object
                vend.VendorName = model.VendorName;
                vend.VendorContact = model.VendorContact;
                vend.VendorLocation = model.VendorLocation;
                vend.PANNo = model.PANNo;
            this.Context.Vendor.Update(vend);
            this.Context.SaveChanges();
            // If the user wants to change the photo, a new photo will be
            // uploaded and the Photo property on the model object receives
            // the uploaded photo. If the Photo property is null, user did
            // not upload a new photo and keeps his existing photo

            //return RedirectToAction("AllActiveVendors");
            //}

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