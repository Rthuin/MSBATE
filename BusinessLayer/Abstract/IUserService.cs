using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IUserService
	{
		List<User> GetUsers();
		void InsertBl(User p );
		void DeleteBl(User p);
		void UserDeleteBl(User p );
	}
}
