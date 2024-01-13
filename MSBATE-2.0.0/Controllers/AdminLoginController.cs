using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MSBATE_2._0._0.Controllers
{
	public class AdminLoginController : Controller
	{
		AdminLoginManager alm = new AdminLoginManager(new EfAdminLoginDal());
		// GET: AdminLogin

		public ActionResult Index()
		{
			string username = HttpContext.User.Identity.Name;
			Admin loggedInAdmin = alm.GetAdmin(username);

			// Pass the admin instance to the view
			return View(loggedInAdmin);
		}

		[HttpGet]
		public ActionResult AdminLogin()
		{
			return View();
		}

		[HttpPost]
		public ActionResult AdminLogin(Admin p)
		{
			AdminValidator adminValidator = new AdminValidator();
			ValidationResult result = adminValidator.Validate(p);
			var adminLoginInfo = alm.GetAdmin(p.AdminUsername, p.AdminPasword);
			if (adminLoginInfo != null)
			{
				FormsAuthentication.SetAuthCookie(adminLoginInfo.AdminUsername, false);
				Session["AdminUsername"] = adminLoginInfo.AdminUsername;
				return RedirectToAction("Index");

			}

			else
			{
				foreach (var item in result.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
				return View();
			}
		}
	}


}



