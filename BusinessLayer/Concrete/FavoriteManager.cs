using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class FavoriteManager : IFavoritesService
	{
		IFavoriteSongDal _favoriteDal;

		public FavoriteManager(IFavoriteSongDal favoriteDal)
		{
			_favoriteDal = favoriteDal;
		}

		public void AddToFavorites(FavoriteSong p)
		{
			_favoriteDal.Insert(p);
		}

		public void FavoriteDelete(FavoriteSong p)
		{
			_favoriteDal.Delete(p);
		}

		public void FavoriteUpdate(FavoriteSong p)
		{
			_favoriteDal.Update(p);
		}

		public FavoriteSong GetById(int id)
		{
			return _favoriteDal.Get(x => x.UserId == id);
		}

		public List<FavoriteSong> GetList()
		{
			return _favoriteDal.List();
		}
		public List<FavoriteSong> GetList(int id)
		{
			return _favoriteDal.List(x => x.UserId == id);
		}

	}
}

