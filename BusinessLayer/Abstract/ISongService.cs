using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface ISongService
	{
		Song GetById(int id);
		List<Song> GetList(int id);
		List<Song> GetList();
	}
}
