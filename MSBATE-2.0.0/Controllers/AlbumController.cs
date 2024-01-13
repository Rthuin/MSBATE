using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using DataAccessLayer.EntityFramework;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MSBATE_2._0._0.Controllers
{
    public class AlbumController : Controller
    {
        AlbumManager am = new AlbumManager(new EfAlbumDal());
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetAlbum()
        {
            var albumValues = am.GetList();
            return View(albumValues);
        }
    }
}