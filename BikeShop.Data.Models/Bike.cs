using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeShop.Data.Models
{
    public class Bike
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        

          public Bike() { }

          public Bike(string brand, string model, string type, decimal price, string description)
          {
              Brand = brand;
              Model = model;
              Type = type;
              Price = price;
              Description = description;
          }
      

    }
}
