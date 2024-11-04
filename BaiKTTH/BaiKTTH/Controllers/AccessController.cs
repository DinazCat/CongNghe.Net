using BaiKTTH.Models;
using Microsoft.AspNetCore.Mvc;

namespace BaiKTTH.Controllers
{
	public class AccessController : Controller
	{
		SalesManagementDBContext db = new SalesManagementDBContext();
		[HttpGet]
		public IActionResult Login()
		{
			if (HttpContext.Session.GetString("Email") == null)
				return View();
			else return RedirectToAction("Index", "Home");
		}

		[HttpPost]
		public IActionResult Login(User user)
		{
			if (HttpContext.Session.GetString("Email") == null)
			{
				var u = db.Users.Where(x=>x.Email.Equals(user.Email) && x.FullName.Equals(user.Password)).FirstOrDefault();
				if (u!= null)
				{
					HttpContext.Session.SetString("Email", u.Email.ToString());
					return RedirectToAction("Index", "Home");
				}
			}			
			return View();
		}

        [HttpGet]
        public IActionResult SignUp()
        {
            if (HttpContext.Session.GetString("Email") != null)
                return RedirectToAction("Index", "Home");

            return View();
        }

        [HttpPost]
        public IActionResult SignUp(User user)
        {
            if (HttpContext.Session.GetString("Email") != null)
                return RedirectToAction("Index", "Home");

            var existingUser = db.Users.Where(x => x.Email.Equals(user.Email)).FirstOrDefault();
            if (existingUser != null)
            {
                ModelState.AddModelError("Email", "Email này đã được sử dụng.");
                return View(user);
            }

            db.Users.Add(user);
            db.SaveChanges();

            HttpContext.Session.SetString("Email", user.Email.ToString());

            return RedirectToAction("Index", "Home");
        }

    }
}
