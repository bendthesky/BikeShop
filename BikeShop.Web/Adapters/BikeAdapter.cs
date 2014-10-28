using BikeShop.Data;
using BikeShop.Data.Models;
using BikeShop.Web.Adapters.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BikeShop.Web.Adapters
{
    public class BikeAdapter : IBike
    {

        public BikeVM GetBike(int id)                                          
        {                                                                       
            ApplicationDbContext Db = new ApplicationDbContext();               
            BikeVM Bike = Db.Bikes.Where(b => b.Id == id).Select(               
                b => new BikeVM
                {
                    Id = id,
                    Brand = b.Brand,
                    Model = b.Model,
                    Type = b.Type,
                    Price = b.Price,
                    Description = b.Description,
                    Pictures = Db.Pictures.Where(p => p.BikeId == id).ToList(),
                    Comments = Db.Comments.Where(c => c.BikeId == id).ToList()
                }).FirstOrDefault();
            return Bike;
        }

        public List<BikeVM> GetAllBikes()
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            List<BikeVM> Bikes = Db.Bikes.Select(
                    b => new BikeVM {
                        Id = b.Id,
                        Brand = b.Brand,
                        Model = b.Model,
                        Type = b.Type,
                        Price = b.Price,
                        Description = b.Description,
                        Pictures = Db.Pictures.Where(p => p.BikeId == b.Id).ToList()
                    }).ToList();
            return Bikes;
        }

        public int CreateBike(BikeVM bike)
        {
            ApplicationDbContext Db = new ApplicationDbContext();  // interpretor 
            Bike Bike = new Bike(bike.Brand, bike.Model, bike.Type, bike.Price, bike.Description);
            Db.Bikes.Add(Bike);
            Db.SaveChanges();
            return AddPicture(Bike.Id, bike.Picture);
        }

        public int AddPicture(int id, Picture picture)
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            picture.BikeId = id;
            Db.Pictures.Add(picture);
            Db.SaveChanges();
            return picture.Id;
        }

        public int AddComment(int id, Comment comment)
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            comment.BikeId = id;
            Db.Comments.Add(comment);
            Db.SaveChanges();
            return comment.Id;
        }

        public void DeleteBike(int id)
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            Bike Bike = Db.Bikes.Where(b => b.Id == id).FirstOrDefault();
            Db.Bikes.Remove(Bike);
            Db.SaveChanges();
        }

        public void DeletePicture(int id)
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            Picture Picture = Db.Pictures.Where(p => p.Id == id).FirstOrDefault();
            Db.Pictures.Remove(Picture);
            Db.SaveChanges();
        }
        public void DeleteAllPictures(int id)
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            foreach (var Pic in Db.Pictures.Where(p => p.BikeId == id))
            {
                Db.Pictures.Remove(Pic);
            }
            Db.SaveChanges();
        }

        public void DeleteComment(int id)
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            Comment Comment = Db.Comments.Where(c => c.BikeId == id).FirstOrDefault();
            Db.Comments.Remove(Comment);
            Db.SaveChanges();
        }

        public void DeleteAllComments(int id)
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            foreach (var Comm in Db.Comments.Where(c => c.BikeId == id))
            {               
                Db.Comments.Remove(Comm);
            }
            Db.SaveChanges();
        }

        public void UpdateBike(int id, Bike bike)
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            Bike Bike = Db.Bikes.Where(b => b.Id == id).FirstOrDefault();
            Bike.Brand = bike.Brand;
            Bike.Model = bike.Model;
            Bike.Type = bike.Type;
            Bike.Price = bike.Price;
            Bike.Description = bike.Description;
            Db.SaveChanges();
        }
    }
}