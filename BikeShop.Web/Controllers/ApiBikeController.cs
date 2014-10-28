using BikeShop.Data;
using BikeShop.Data.Models;
using BikeShop.Web.Adapters;
using BikeShop.Web.Adapters.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

//Note: This controller is only intended to be used with calls that involve bikes. There should be a 'ApiPictureController' and an 'ApiCommentController' as well.

namespace BikeShop.Web.Controllers
{
    public class ApiBikeController : ApiController
    {
        private IBike _adapter;
        public ApiBikeController()
        {
            _adapter = new BikeAdapter();
        }
        public IHttpActionResult GET(int id = -1)
        {
            if (id == -1)
            {
                return Ok(_adapter.GetAllBikes());
            }
            else
            {
                return Ok(_adapter.GetBike(id));
            }
        }
        [HttpPost]
        public IHttpActionResult POST(BikeVM bike)
        {
            _adapter.CreateBike(bike);
            return Ok();
        }
        [HttpDelete]
        public IHttpActionResult DELETE(int id)
        {
            _adapter.DeleteAllPictures(id);
            _adapter.DeleteAllComments(id);
            _adapter.DeleteBike(id);
            return Ok();
        }
        [HttpPut]
        public IHttpActionResult PUT(Bike bike)
        {
            _adapter.UpdateBike(bike.Id, bike);
            return Ok();
        }
    }
}
