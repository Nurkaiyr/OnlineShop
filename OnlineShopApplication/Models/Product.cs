using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShopApplication.Models
{
    public class Product:Entity
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
}