using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class AlbumManager : IAlbumService
	{
		IAlbumDal _albumDal;

		public AlbumManager(IAlbumDal albumDal)
		{
			_albumDal = albumDal;
		}

		public void AlbumAdd(Album p)
		{
			_albumDal.Insert(p);
		}

		public void AlbumDelete(Album p)
		{
			_albumDal.Delete(p);
		}

		public void AlbumUpdate(Album p)
		{
			_albumDal.Update(p);
		}

		public Album GetById(int id)
		{
			return _albumDal.Get(x => x.AlbumId == id);
		}

		public List<Album> GetList()
		{
			return _albumDal.List();
		}
	}
}
