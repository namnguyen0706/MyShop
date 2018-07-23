namespace MyShop.Data.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using MyShop.Model.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MyShop.Data.MyShopDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MyShop.Data.MyShopDbContext context)
        {
            //  This method will be called after migrating to the latest version.
            var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new MyShopDbContext()));

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new MyShopDbContext()));

            var user = new ApplicationUser()
            {
                UserName = "namnguyen",
                Email = "nguyennammegarpri@gmail.com",
                EmailConfirmed = true,
                BirthDay = DateTime.Now,
                FullName = "My Shop Web API"
            };

            manager.Create(user, "123456");

            if (!roleManager.Roles.Any())
            {
                roleManager.Create(new IdentityRole { Name = "Admin" });
                roleManager.Create(new IdentityRole { Name = "User" });
            }

            var admin = manager.FindByEmail("nguyennammegarpri@gmail.com");

            manager.AddToRoles(admin.Id, new string[] { "Admin", "User" });
        }
    }
}
