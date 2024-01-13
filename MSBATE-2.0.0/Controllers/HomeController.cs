using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MSBATE_2._0._0.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public ActionResult AddUserFromHome(User user)
		{
			// Burada kullanıcı eklemek için gerekli işlemleri gerçekleştirin
			// Örneğin, UserController'daki AddUser metodu gibi bir şey yapabilirsiniz.

			// Örnek olarak, UserManager sınıfının bir örneğini alıp InsertBl metoduyla kullanıcıyı ekleyelim
			UserManager userManager = new UserManager(new EfUserDal());

			// Burada gerekli validasyonları yapabilirsiniz.

			try
			{
				userManager.InsertBl(user);
				ViewBag.Message = "Kayıt başarılı! MSBATE'e hoş geldiniz!";

				return RedirectToAction("GetUser", "User"); // Kullanıcı ekledikten sonra GetUser sayfasına yönlendir
			}
			catch (Exception ex)
			{
				ViewBag.ErrorMessage = "Kullanıcı eklenirken bir hata oluştu: " + ex.Message;
				return View("Index");
			}
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}