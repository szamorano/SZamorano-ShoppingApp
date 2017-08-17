using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using SZamoranoShoppingApp.Models;

namespace SZamoranoShoppingApp.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            var roleManager = new RoleManager<IdentityRole>(
                new RoleStore<IdentityRole>(context));
            if (!context.Roles.Any(r => r.Name == "Admin"))
            {
                roleManager.Create(new IdentityRole { Name = "Admin" });
            }
            var userManager = new UserManager<ApplicationUser>(
                new UserStore<ApplicationUser>(context));
            if (!context.Users.Any(u => u.Email == "steven.zamorano@gmail.com"))
            {
                userManager.Create(new ApplicationUser
                {
                    UserName = "steven.zamorano@gmail.com",
                    Email = "steven.zamorano@gmail.com",
                    FirstName = "Steven",
                    LastName = "Zamorano",
                }, "Password1!");
            }
            var userId = userManager.FindByEmail("steven.zamorano@gmail.com").Id;
            userManager.AddToRole(userId, "Admin");
        }
    }
}