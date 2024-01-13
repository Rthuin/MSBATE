using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class SongManager : ISongService
	{
		ISongDal _songDal;

		public SongManager(ISongDal songDal)
		{
			_songDal = songDal;
		}

		public Song GetById(int id)
		{
			return _songDal.Get(x => x.AlbumId == id);
		}

		public List<Song> GetList()
		{
			return _songDal.List();
		}
		public List<Song> GetList(int id)
		{
			return _songDal.List(x=>x.AlbumId == id);
		}
	}
}
