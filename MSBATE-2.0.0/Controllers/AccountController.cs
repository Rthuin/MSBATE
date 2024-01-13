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
using System.Web.Security;

namespace MSBATE_2._0._0.Controllers
{
	public class AccountController : Controller
	{
		UserManager um = new UserManager(new EfUserDal());
		UserLoginManager ulm = new UserLoginManager(new EfUserLoginDal());
	

		[HttpGet]
		public ActionResult Login()
		{
			string email = HttpContext.User.Identity.Name;
			User loggedInUser = ulm.GetUserByEmail(email);
			//if (HttpContext.User.Identity.IsAuthenticated)
			//{
			//	return RedirectToAction("Index", "Home");
			//}	

			// Pass the admin instance to the view
			return View(loggedInUser);
		}

		[HttpPost]
		public ActionResult Login(User p)
		{
			if (ModelState.IsValid)
			{
				//var user = um.GetUsers().FirstOrDefault(u => u.UserName == p.UserName && u.Password == p.Password);
				var user = ulm.GetUser(p.Email, p.Password);

				if (user != null)
				{
					FormsAuthentication.SetAuthCookie(user.Email, false);
					Session["Email"] = user.Email;

					return RedirectToAction("Login");
				}
				else
				{
					ViewBag.ErrorMessage = "Invalid username or password";
					return RedirectToAction("Index", "Home");
				}
			}

			return View(p);
		}
		[HttpGet]
		public ActionResult AddUser()
		{
			return View();
		}
		[HttpPost]
		public ActionResult AddUser(User p)
		{
			UserValidator userValidator = new UserValidator();
			ValidationResult result = userValidator.Validate(p);

			if (result.IsValid)
			{
				try
				{
					um.InsertBl(p);
					ViewBag.Message = "Kayıt başarılı! MSBATE'e hoş geldiniz!";

					return RedirectToAction("Index", "Home");
				}
				catch
				{
;
					return View("Index");
				}
			}
			else
			{
				foreach (var item in result.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
				return View("Index", "User");
			}


		}
	}
}