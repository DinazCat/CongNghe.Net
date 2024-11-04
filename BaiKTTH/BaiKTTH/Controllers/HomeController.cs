using BaiKTTH.Models;
using BaiKTTH.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BaiKTTH.Controllers
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
			/*          int pageSize = 8;
						int pageNumber = page == null || page < 0 ? 1 : page.Value;
						var lstsanpham = db.TDanhMucSps.AsNoTracking().OrderBy(x => x.TenSp);
						PagedList<TDanhMucSp> lst = new PagedList<TDanhMucSp>(lstsanpham, pageNumber, pageSize);
						return View(1st);
						using X.PagedList*/
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