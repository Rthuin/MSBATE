﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Admin
	{
        [Key]
        public int AdminId { get; set; }
        [StringLength(50)]
        public string AdminUsername { get; set; }
        [StringLength(50)]
        public string AdminPasword { get; set; }
        [StringLength(1)]
        public string AdminRole { get; set; }
    }
}
