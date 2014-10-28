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
    public class ApiCommentController : ApiController
    {
        private IBike _adapter;
        public ApiCommentController()
        {
            _adapter = new BikeAdapter();
        }

        //Comments are "got" when the bike is.

        [HttpPost]
        public IHttpActionResult POST(int id, Comment comment)
        {
            return Ok(_adapter.AddComment(id, comment));
        }
        [HttpDelete]
        public IHttpActionResult DELETE(int id)
        {
            _adapter.DeleteComment(id);
            return Ok();
        }
    }
}
