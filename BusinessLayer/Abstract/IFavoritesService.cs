using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IFavoritesService
	{
		List<FavoriteSong> GetList();
		List<FavoriteSong> GetList(int id);
		void AddToFavorites(FavoriteSong p);
		void FavoriteDelete(FavoriteSong p);
		void FavoriteUpdate(FavoriteSong p);
		FavoriteSong GetById(int id);
	}
}
