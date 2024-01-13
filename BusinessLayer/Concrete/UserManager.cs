using BusinessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BusinessLayer.Concrete
{
	public class UserManager : IUserService
	{
		private IUserDal _userDal;

		public UserManager(IUserDal userDal)
		{
			_userDal = userDal;
		}

		public List<User> GetUsers()
		{
			return _userDal.List();
		}

		public void InsertBl(User p)
		{
			try
			{
				_userDal.Insert(p);
				
			}
			catch (SqlException ex)
			{
				
				throw;
			}
		}
		public int GetUserIdByUserName(string userName)
		{
			// Veritabanından kullanıcı adı ile eşleşen bir kayıt bul
			var user = _userDal.Get(x => x.UserName == userName);
			// Kayıt varsa, user id döndür
			if (user != null)
			{
				return user.UserId;
			}
			// Kayıt yoksa, -1 döndür
			else
			{
				return -1;
			}
		}
		public void DeleteBl(User p)
		{
			_userDal.Delete(p);
		}
		public User GetBl(int id)
		{
			return _userDal.Get(x => x.UserId==id);
		}

		public void UserDeleteBl(User p)
		{
			_userDal.Delete(p);
		}
	}
}
