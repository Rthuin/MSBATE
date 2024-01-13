using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
	public class Context : DbContext
	{
		public DbSet<Artist> Artists { get; set; }
		public DbSet<Album> Albums { get; set; }	
		public DbSet<Song>	Songs { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<Admin> Admins { get; set; }
		public DbSet<FavoriteSong> Favorites { get; set; }
	}
}
