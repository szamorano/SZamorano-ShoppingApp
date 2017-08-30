﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SZamoranoShoppingApp.Models.CodeFirst
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ItemId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        public virtual Item Item { get; set; }          // COMMENT OUT THESE VIRTUAL PROPERTIES OUT WHEN ADDING CONTROLLERS; DEPENDENCY ISSUES; REMEMBER TO "UPDATE DATABASE" AFTERWARDS
        public virtual Order Order { get; set; }        // COMMENT OUT THESE VIRTUAL PROPERTIES OUT WHEN ADDING CONTROLLERS; DEPENDENCY ISSUES; REMEMBER TO "UPDATE DATABASE" AFTERWARDS

    }
}