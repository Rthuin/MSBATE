using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IAlbumService
	{
		List<Album> GetList();
		void AlbumAdd(Album p);
		void AlbumDelete(Album p);
		void AlbumUpdate(Album p);
		Album GetById(int id);
	}
}
