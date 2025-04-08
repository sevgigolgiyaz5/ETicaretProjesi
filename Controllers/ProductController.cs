using Microsoft.AspNetCore.Mvc;
using ETicaretProjesi.Models;

namespace ETicaretProjesi.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Laptop", Price = 15000, Description = "Oyun bilgisayarı", ImageUrl = "/images/laptop.jpg" },
                new Product { Id = 2, Name = "Telefon", Price = 8000, Description = "Akıllı telefon", ImageUrl = "/images/telefon.jpg" }
            };

            return View(products);
        }
    }
}
