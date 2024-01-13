using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EntityLayer.Concrete
{
	public class Album
	{
		[Key]
		public int AlbumId { get; set; }
		[StringLength(50)]
		public String Title { get; set; }

		public DateTime Date { get; set; }

		[StringLength(50)]
		public string Label { get; set; }

		[StringLength(100)]
		public string AlbumCover { get; set; }

		[StringLength(10)]
		public string Genre { get; set; }

        public int ArtistId { get; set; }
        public virtual Artist Artist { get; set; }

		public ICollection<Song> Songs { get; set; }

		

	}
}
