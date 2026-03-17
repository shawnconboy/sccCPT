using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Packt.Shared;

namespace Northwind.Web.Pages
{
    public class IndexModel : PageModel
    {
        public string CurrentTime { get; set; } = string.Empty;

        private readonly NorthwindContext _context;

        public int ProductCount { get; set; }

        public IndexModel(NorthwindContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            ProductCount = _context.Products.Count();
            CurrentTime = DateTime.Now.ToString("hh:mm:ss tt");
        }
    }
}
