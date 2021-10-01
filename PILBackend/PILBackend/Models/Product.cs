using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PILBackend.Models
{
    public class Product
    {
        public int id { get; set; }
        public string product_name { get; set; }
        public int stock { get; set; }
        public string product_image { get; set; }
    }
}
