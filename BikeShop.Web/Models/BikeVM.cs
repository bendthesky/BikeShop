using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeShop.Data.Models
{
    public class BikeVM
    {
        public Bike Bike { get; set; }
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public Picture Picture { get; set; }
        public List<Picture> Pictures { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
