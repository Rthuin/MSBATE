using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MSBATE_2._0._0.Controllers
{
	public class ArtistController : Controller
	{
		// GET: Artist
		//AlbumManager am = new AlbumManager();
		public ActionResult Index()
		{
			return View();
		}
		public ActionResult GetAlbum(Album p)
		{
			//var userValues = am.GetBl();
			return View();
		}

	}
}