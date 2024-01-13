using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MSBATE_2._0._0.Controllers
{
    public class SongController : Controller
    {
        SongManager sm = new SongManager(new EfSongDal());

        // GET: Songs
        public ActionResult ShowSongByAlbum(int id )
        {
            var songs = sm.GetList(id);
            return View(songs);
        }
    }
}