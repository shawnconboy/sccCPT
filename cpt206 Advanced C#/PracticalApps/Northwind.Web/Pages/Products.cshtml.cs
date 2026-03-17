using Microsoft.AspNetCore.Mvc.RazorPages;
using Packt.Shared;

namespace Northwind.Web.Pages;

public class ProductsModel : PageModel
{
    private readonly NorthwindContext _context;

    public IEnumerable<Product> Products { get; set; } = Enumerable.Empty<Product>();

    public string? SearchText { get; set; }
    public decimal? MaxPrice { get; set; }

    public ProductsModel(NorthwindContext context)
    {
        _context = context;
    }

    public void OnGet(string? searchText, decimal? maxPrice)
    {
        SearchText = searchText;
        MaxPrice = maxPrice;

        IQueryable<Product> query = _context.Products;

        if (!string.IsNullOrWhiteSpace(searchText))
        {
            string term = searchText.Trim();

            query = query.Where(p =>
                p.ProductName != null &&
                p.ProductName.Contains(term));
        }

        if (maxPrice.HasValue)
        {
            query = query.Where(p =>
                p.UnitPrice.HasValue &&
                p.UnitPrice.Value <= maxPrice.Value);
        }

        Products = query
            .OrderBy(p => p.ProductId)
            .ToList();
    }
}