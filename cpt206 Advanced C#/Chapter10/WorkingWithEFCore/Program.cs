using Microsoft.EntityFrameworkCore;
using WorkingWithEFCore.Data;
using WorkingWithEFCore.Models;

namespace WorkingWithEFCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using NorthwindContext db = new();

            // 1. Read all categories
            var categories = db.Categories.ToList();

            Console.WriteLine("All Categories:\n");

            foreach (var category in categories)
            {
                Console.WriteLine($"{category.CategoryId} : {category.CategoryName}");
            }

            // 2. Filter categories
            var seafood = db.Categories
                .Where(c => c.CategoryName.Contains("Sea"))
                .ToList();

            Console.WriteLine("\nFiltered Results:\n");

            foreach (var category in seafood)
            {
                Console.WriteLine($"{category.CategoryId} : {category.CategoryName}");
            }

            // 3. Order categories alphabetically
            var ordered = db.Categories
                .OrderBy(c => c.CategoryName)
                .ToList();

            Console.WriteLine("\nAlphabetical Order:\n");

            foreach (var category in ordered)
            {
                Console.WriteLine($"{category.CategoryId} : {category.CategoryName}");
            }

            // 4. Query related data with Include
            var products = db.Products
                .Include(p => p.Category)
                .Take(10)
                .ToList();

            Console.WriteLine("\nProducts with Categories:\n");

            foreach (var product in products)
            {
                Console.WriteLine($"{product.ProductName} - {product.Category?.CategoryName}");
            }

            // 5. Projection with Select
            var productList = db.Products
                .Select(p => new
                {
                    p.ProductName,
                    Category = p.Category!.CategoryName,
                    p.UnitPrice
                })
                .Take(10)
                .ToList();

            Console.WriteLine("\nProjected Results:\n");

            foreach (var item in productList)
            {
                Console.WriteLine($"{item.ProductName} - {item.Category} - {item.UnitPrice:C}");
            }

            // 6. Insert only if Sports Gear does not already exist
            var existingCategory = db.Categories
                .FirstOrDefault(c => c.CategoryName == "Sports Gear");

            if (existingCategory is null)
            {
                var newCategory = new Category
                {
                    CategoryName = "Sports Gear",
                    Description = "Equipment and sporting goods"
                };

                db.Categories.Add(newCategory);
                db.SaveChanges();

                Console.WriteLine("\nNew category inserted!");
            }
            else
            {
                Console.WriteLine("\nSports Gear already exists.");
            }

            // 7. Update Sports Gear if it exists
            var categoryToUpdate = db.Categories
                .FirstOrDefault(c => c.CategoryName == "Sports Gear");

            if (categoryToUpdate is not null)
            {
                categoryToUpdate.Description = "Updated sporting equipment category";
                db.SaveChanges();

                Console.WriteLine("\nCategory updated!");
            }
            else
            {
                Console.WriteLine("\nSports Gear category not found.");
            }

            // deletions
            var categoryToDelete = db.Categories
                .FirstOrDefault(c => c.CategoryName == "Sports Gear");

            if (categoryToDelete is not null)
            {
                db.Categories.Remove(categoryToDelete);
                db.SaveChanges();

                Console.WriteLine("\nCategory deleted!");
            }
        }
    }
}