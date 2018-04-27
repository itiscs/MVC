using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApiApp.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }

    public class ProductsDB:DbContext
    {
        public DbSet<Product> Products { get; set; }
    }


}