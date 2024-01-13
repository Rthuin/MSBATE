using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.ApplicationServices;

namespace EntityLayer.Concrete
{
	public class User
	{
		[Key]
		public int UserId { get; set; }
		[StringLength(25)]
		[Index(IsUnique = true)]
		public String UserName { get; set; }
	
		[StringLength(25)]
		public String Password { get; set; }

		[StringLength(50)]
		[Index(IsUnique = true)]
		public String Email { get; set; }
		
		public virtual ICollection<FavoriteSong> FavoriteSongs { get; set; }

		

	}
}
