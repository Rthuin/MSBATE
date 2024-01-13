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
	public class AdminLoginManager : IAdminLoginService
	{
		IAdminLoginDal _adminLoginDal;

		public AdminLoginManager(IAdminLoginDal adminLoginDal)
		{
			_adminLoginDal = adminLoginDal;
		}

		public List<Admin> GetList()
		{
			return _adminLoginDal.List();
		}

		public Admin GetAdmin(string username, string password)
		{
			return _adminLoginDal.Get(x => x.AdminUsername == username && x.AdminPasword == password);
		}
		public Admin GetAdmin(string username)
		{
			return _adminLoginDal.Get(x => x.AdminUsername == username);
		}
	}
}
