using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace MSBATE_2._0._0.Controllers
{
	public class UserController : Controller
	{
		UserManager um = new UserManager(new EfUserDal());


		public ActionResult Index()
		{
			return View();
		}
		

		public ActionResult GetUser(User p)
		{
			var userValues = um.GetUsers();
			return View(userValues);
		}

		public ActionResult DeleteUser(string userName)
		{
			var userId = um.GetUserIdByUserName(userName);
			if (userId != -1)
			{
				var userValue = um.GetBl(userId);
				um.DeleteBl(userValue);
				// Silme işlemi başarılı olduğunda, kullanıcıyı GetUser sayfasına yönlendir
				return RedirectToAction("GetUser");
			}
			else
			{
				ViewBag.ErrorMessage = "Kullanıcı adı bulunamadı.";
				// Silme işlemi başarısız olduğunda, silme sayfasında kal
				return View();
			}
		}
	}
}