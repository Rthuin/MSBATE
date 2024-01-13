using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Artist
	{
		[Key]
		public int ArtistId { get; set; }
		[StringLength(25)]
		public String Name { get; set; }

        public ICollection<Album> Albums { get; set; }
    }
}
