using System.Collections.Generic;
using Aquilia.Data;
using Aquilia.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Aquilia.ViewModel;

namespace Aquilia.Controllers
{
    public class HomeController : Controller
    {


        private ApplicationDbContext Context { get; }

        public ActionResult Index()
        {
            List<Vendor> listofvendors = new List<Vendor>();
            //Vendor vendor = Context.Vendor.FirstOrDefault();
            //listofvendors = (from vendors in Context.Vendor select vendors).ToList();
            DashboardViewModel db = new DashboardViewModel
            {
                ActiveVendors = listofvendors.Count,
                CompletedAssignments=1,
                ActiveEmployees=1
            };
            return View(db);
            
        }

        public IActionResult Privacy()
        {
            return View();
        }

       
    }
}
