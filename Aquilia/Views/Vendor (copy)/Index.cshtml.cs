using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Aquilia.Data;
using Aquilia.Models;

namespace Aquilia.Views.Vendor
{
    public class IndexModel : PageModel
    {
        private readonly Aquilia.Data.ApplicationDbContext _context;

        public IndexModel(Aquilia.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Employee> Employee { get;set; }

        public async Task OnGetAsync()
        {
            Employee = await _context.Employee.ToListAsync();
        }
    }
}
