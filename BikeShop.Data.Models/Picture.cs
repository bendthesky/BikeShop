using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeShop.Data.Models
{
    public class Picture
    {
        public int Id { get; set; }
        public int BikeId { get; set; }
        public string Url { get; set; }
    }
}
