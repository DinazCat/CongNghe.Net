using BaiKTTH.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace BaiKTTH.Areas.Admin.Controllers
{
	[Area("admin")]
	[Route("admin")]
	[Route("admin/homeadmin")]
	public class HomeAdminController : Controller
	{
		SalesManagementDBContext db = new SalesManagementDBContext();
		[Route("")]
		[Route("index")]
		public IActionResult Index()
		{
            var productList = db.Products.Include(p => p.Category).ToList();

            return View(productList);
        }

        [Route("AddProduct")]
        [HttpGet]
        public IActionResult AddProduct()
        {
            ViewBag.CategoryId = new SelectList(db.Categories.ToList(), "CategoryId", "Name");
            return View();
        }

        [Route("AddProduct")]
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            if(ModelState.IsValid)
            {
                db.Products.Add(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        [Route("UpdateProduct")]
        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            ViewBag.CategoryId = new SelectList(db.Categories.ToList(), "CategoryId", "Name");

            var product = db.Products.Find(id);

            return View(product);
        }

        [Route("UpdateProduct")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                db.Entry(product).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index", "HomeAdmin");
            }
            return View();
        }

        [Route("DeleteProduct")]
        [HttpGet]
        public IActionResult DeleteProduct(int id)
        {
            TempData["Message"] = "";
            var productVariants = db.ProductVariants.Where(item => item.ProductId == id).ToList();
            if(productVariants.Count() > 0)
            {
                TempData["Message"] = "Cannot delete this product.";
                return RedirectToAction("Index", "HomeAdmin");
            }

            var productImgs = db.ProductImages.Where(item => item.ProductId == id);
            if(productImgs.Any()) { db.RemoveRange(productImgs); }

            db.Remove(db.Products.Find(id));
            db.SaveChanges();
            TempData["Message"] = "Product has been deleted.";

            return RedirectToAction("Index", "HomeAdmin");
        }
    }
}
