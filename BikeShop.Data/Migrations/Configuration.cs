namespace BikeShop.Data.Migrations
{
    using BikeShop.Data.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BikeShop.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(BikeShop.Data.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Bikes.AddOrUpdate(
                b => b.Model,
                new Bike("Trek", "Elite XC", "Mountain", 5559.99m, "The ultimate 29er full suspension race bike. You get speed, speed, and more speed, plus incredible handling and control. This bike leaves nothing on the table."),
                new Bike("Haro", "ZX20", "BMX", 249.99m, "This BMX bike is perfect for kids or if you need something compact to jump those ramps. Great for streets or in bowls."),
                new Bike("GMC", "Denali 700", "Street", 699.99m ,"This is a great bicycle for traveling across the city. It's lightweight and has plenty of gear functionality to travel long distance or uphill."),
                new Bike("Jamis", "Commuter 2", "Street", 559.99m, "People are discovering that commuting by bike is not only healthy, efficient and green, but on the right bike is also easy and fun. Our Commuters are designed to minimize maintenance, while maximizing comfort and efficiency. The lightweight aluminum frames, fenders, rear carriers, and single-chainring drivetrains are ready for the inner city shuffle with our saddles and grips designed to offer comfortable contact points so you arrive refreshed and recharged."),
                new Bike("Jamis", "Dakar XCT 650", "Mountain", 5999.99m, "This is the bike that teed it up and kicked it off way back in 2009. After all the nay-saying and 'it’s not really exactly between 26 and 29', the world is now clearly ready (finally) to fully embrace 650B. And there’s no better place to start the group hug than on the rig that believed from the beginning and now has over 5 years of PD and real-world riding and refinement to ensure it IS Best in Class. Expanded in 2014 to include four versions: 2 carbon fiber and 2 aluminum. What are you waiting for? See you at the races."),
                new Bike("Daimondback", "Insight 1", "Street", 499.99m, "The Insight 1 provides incredible performance and quality. Its aluminum frame and integrated aluminum aero straight blade fork give this bike a platform that rides as fast as it looks. Shimano shifters and derailleurs allow you to snap through the gears leaving you to focus on the task at hand. Combine those features with Diamondback patented components and a set of double wall rims and what you get is the bike of choice for anyone looking for a great-performing fitness bike.")
                
                );
            context.Pictures.AddOrUpdate(
                p => p.Url,
                new Picture { Url = "http://s7d4.scene7.com/is/image/TrekBicycleProducts/Asset_169545?wid=1490&hei=1080&fit=fit,1&fmt=png-alpha&qlt=80,1&op_usm=0,0,0,0&iccEmbed=0", BikeId = 1 },
                new Picture { Url = "http://s7d4.scene7.com/is/image/TrekBicycleProducts/Asset_146847?wid=1490&hei=1080&fit=fit,1&fmt=png-alpha&qlt=80,1&op_usm=0,0,0,0&iccEmbed=0", BikeId = 1 },
                new Picture { Url = "http://s7d4.scene7.com/is/image/TrekBicycleProducts/Asset_168048?wid=1490&hei=1080&fit=fit,1&fmt=png-alpha&qlt=80,1&op_usm=0,0,0,0&iccEmbed=0", BikeId = 1 },
                new Picture { Url = "http://www.bigimagerack.com/cfs/img/2012/a81e19bb/webmed.jpg", BikeId = 2 },
                new Picture { Url = "http://e957abd285182b87bec9-0f59de06f4abeba093949d3ada5a5db9.r33.cf1.rackcdn.com/2014-Haro-ZX20-Black.jpg", BikeId = 2 },
                new Picture { Url = "http://i.walmartimages.com/i/p/00/01/67/51/32/0001675132714_300X300.jpg", BikeId = 3 },
                new Picture { Url = "http://img.auctiva.com/imgdata/1/0/0/3/6/4/4/webimg/494607791_tp.jpg", BikeId = 3 },
                new Picture { Url = "http://www.myjamis.com/SSP%20Applications/JamisBikes/MyJamis/consumer/images/fancy/14_commuter2_te.jpg", BikeId = 4 },
                new Picture { Url = "http://www.jamisbikes.com/usa/images/14_commuter1step-over_wh.jpg", BikeId = 4 },
                new Picture { Url = "http://www.myjamis.com/SSP%20Applications/JamisBikes/MyJamis/consumer/images/fancy/14_dakarxct650team_cb.jpg", BikeId = 5 },
                new Picture { Url = "http://www.myjamis.com/SSP%20Applications/JamisBikes/MyJamis/consumer/images/fancy/14_dakarxct650comp_pd.jpg", BikeId = 5 },
                new Picture { Url = "http://media.performancebike.com/images/performance/products/415/31-1585-RED-ANGLE.jpg", BikeId = 6 },
                new Picture { Url = "http://media.performancebike.com/images/performance/products/415/31-1585-RED-SIDE.JPG", BikeId = 6 }
                );
            context.Comments.AddOrUpdate(
                c => c.Body,
                new Comment { User = "User1", Body = "This bike is great!", BikeId = 1},
                new Comment { User = "User2", Body = "This bike is awesome!", BikeId = 1},
                new Comment { User = "User3", Body = "Hello!", BikeId = 1},
                new Comment { User = "User4", Body = "This bike is too small for adults", BikeId = 1},
                new Comment { User = "User5", Body = "This bike is bad!", BikeId = 2},
                new Comment { User = "User6", Body = "This bike is rabbish!", BikeId = 2},
                new Comment { User = "User7", Body = "This bike is okay!", BikeId = 2},
                new Comment { User = "User8", Body = "This bike is cute!", BikeId = 3},
                new Comment { User = "User9", Body = "This bike is cool!", BikeId = 3},
                new Comment { User = "User10", Body = "This bike looks great!", BikeId = 3}
                );
                

            var UserStore = new UserStore<ApplicationUser>(context);
            var UserManager = new UserManager<ApplicationUser>(UserStore);
            var RoleStore = new RoleStore<IdentityRole>(context);
            var RoleManager = new RoleManager<IdentityRole>(RoleStore);
            if (!RoleManager.RoleExists("Admin"))
            {
                IdentityRole Role = new IdentityRole("Admin");
                RoleManager.Create(Role);
            }
            if (!RoleManager.RoleExists("User"))
            {
                IdentityRole Role = new IdentityRole("User");
                RoleManager.Create(Role);
            }
            if (!context.Users.Any(u => u.UserName == "Admin@me.com"))
            {
                ApplicationUser User = new ApplicationUser();
                User.UserName = "Admin@me.com";
                UserManager.Create(User, "123456");
                UserManager.AddToRole(User.Id, "Admin");
            }
            if (!context.Users.Any(u => u.UserName == "User@me.com"))
            {
                ApplicationUser User = new ApplicationUser();
                User.UserName = "User@me.com";
                UserManager.Create(User, "123456");
                UserManager.AddToRole(User.Id, "User");
            }
        }
    }
}
