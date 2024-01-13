using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IAdminLoginService
	{
		Admin GetAdmin(string username, string password);
		Admin GetAdmin(string username);
		List<Admin> GetList();
		//void AddAdmin(Admin p);
		//void AdminDelete(Admin p);
		//void AdminUpdate(Admin p);
		//Admin GetById(int id);
	}
}
