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
	public class FavoriteController : Controller
	{
		FavoriteManager fm = new FavoriteManager(new EfFavoriteSongDal());

		public ActionResult ShowSongByUserId(int id)
		{
			var favValues = fm.GetList(id);
			return View(favValues);
		}
	}
}
