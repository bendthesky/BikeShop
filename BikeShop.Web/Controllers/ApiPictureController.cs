using BikeShop.Data.Models;
using BikeShop.Web.Adapters;
using BikeShop.Web.Adapters.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BikeShop.Web.Controllers
{
    public class ApiPictureController : ApiController
    {
        private IBike _adapter;
        public ApiPictureController()
        {
            _adapter = new BikeAdapter();
        }

        //No "GET" needed, pictures are 'got' when the bike is
        [HttpPost]
        public IHttpActionResult POST(int id, Picture picture)
        {
            return Ok(_adapter.AddPicture(id, picture));
        }

        [HttpDelete]
        public IHttpActionResult DELETE(int id)
        {
            _adapter.DeletePicture(id);
            return Ok();
        }
    }
}
