using BikeShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeShop.Web.Adapters.Interfaces
{
    interface IBike
    {
        BikeVM GetBike(int id);
        List<BikeVM> GetAllBikes();
        int CreateBike(BikeVM bike);
        int AddPicture(int id, Picture picture);
        int AddComment(int id, Comment comment);
        void DeleteBike(int id);
        void DeletePicture(int id);
        void DeleteAllPictures(int id);
        void DeleteComment(int id);
        void DeleteAllComments(int id);
        void UpdateBike(int id, Bike bike);
    }
}
