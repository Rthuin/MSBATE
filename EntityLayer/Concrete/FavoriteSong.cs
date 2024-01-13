using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class FavoriteSong
	{
		[Key]
		public int FavoriteSongId { get; set; }

		public int UserId { get; set; }
		public virtual User User { get; set; }

		public int SongId { get; set; }
		public virtual Song Song { get; set; }
	}
}
