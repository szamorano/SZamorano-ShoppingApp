﻿using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SZamoranoShoppingApp.Models
{
    public class Universal : Controller
    {
        public ApplicationDbContext db = new ApplicationDbContext();

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (User.Identity.IsAuthenticated)
            {
                var user = db.Users.Find(User.Identity.GetUserId());
                ViewBag.FirstName = user.FirstName;
                ViewBag.LastName = user.LastName;
                ViewBag.FullName = user.FullName;


                ViewBag.CartItems = user.CartItems.Sum(c => c.Count);

                decimal cartTotal = 0;
                foreach (var cartItem in user.CartItems.ToList())
                {
                    cartTotal += cartItem.UnitTotal;
                }
                ViewBag.CartTotal = cartTotal;

                base.OnActionExecuting(filterContext);
            }
            else
            {

            }
        }
    }
}