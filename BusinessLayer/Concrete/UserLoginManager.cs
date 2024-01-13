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
	public class UserLoginManager : IUserLoginService
	{
		IUserLoginDal _userLoginDal;

		public UserLoginManager(IUserLoginDal userLoginDal)
		{
			_userLoginDal = userLoginDal;
		}

		public List<User> GetList()
		{
			return _userLoginDal.List();
		}

		public User GetUser(string email, string password)
		{
			return _userLoginDal.Get(x=> x.Email ==  email && x.Password == password);	
		}


		public User GetUserByEmail(string email)
		{
			return _userLoginDal.Get(x => x.Email == email );
		}
	}
}
