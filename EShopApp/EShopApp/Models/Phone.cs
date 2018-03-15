using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EShopApp.Models
{
    public class Phone
    {
        public int ID { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public string ImageFile { get; set; }
        public int Amount { get; set; }
    }
}