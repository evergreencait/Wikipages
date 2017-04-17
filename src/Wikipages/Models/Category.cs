﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wikipages.Models
{
    [Table("Categories")]
    public class Category
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
    }
}
