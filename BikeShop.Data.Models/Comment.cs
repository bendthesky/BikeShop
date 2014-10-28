using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeShop.Data.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int BikeId { get; set; }
        public string User { get; set; }
        public string Body { get; set; }
        public int Review { get; set; }
    }
}
