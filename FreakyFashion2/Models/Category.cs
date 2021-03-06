﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreakyFashion2.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string  ImgUrl { get; set; }
        public string UrlSlug { get; set; }
        public List<ProductCategory> ProductCategory { get; set; }
    }
}
