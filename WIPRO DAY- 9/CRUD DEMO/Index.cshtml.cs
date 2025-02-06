using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CRUDRazorDemousingFF.Models;

namespace CRUDRazorDemousingFF.Pages
{
    public class IndexModel : PageModel
    {
        private readonly CRUDRazorDemousingFF.Models.ProductDbContext _context;

        public IndexModel(CRUDRazorDemousingFF.Models.ProductDbContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Product = await _context.Products.ToListAsync();
        }
    }
}
