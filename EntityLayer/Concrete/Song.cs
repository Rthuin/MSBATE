using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Song
	{
		[Key]
		public int SongId { get; set; }

		[StringLength(50)]
		public string SongName { get; set; }

		public float Duration { get; set; }

		[StringLength(100)]
		public string SongUrl { get; set; }

		public virtual ICollection<FavoriteSong> FavoriteSongs { get; set; }


		public int AlbumId { get; set; }
		public virtual ICollection<Album> Albums{ get; set; }
    }
}
