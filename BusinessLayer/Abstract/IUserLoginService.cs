using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IUserLoginService
	{
		User GetUser(string email, string password);
		User GetUserByEmail(string email);	
		List<User> GetList();
		//void AddAdmin(Admin p);
		//void AdminDelete(Admin p);
		//void AdminUpdate(Admin p);
		//Admin GetById(int id);

	}
}
