using Lab2.Models;
using Lab2.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lab2.Controllers
{
    public class HomeController : Controller
    {
        SalesManagementDBContext db = new SalesManagementDBContext();

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var productList = db.Products.ToList();

            return View(productList);
        }

        public IActionResult ProductDetail(int id)
        {
            var product = db.Products.FirstOrDefault(p => p.ProductId == id);
            var images = db.ProductImages.Where(img => img.ProductId == id).Select(img => img.ImageUrl).ToList();

            var viewModel = new ProductDetailVM
            {
                Product = product,
                ProductImages = images
            };

            return View(viewModel);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
