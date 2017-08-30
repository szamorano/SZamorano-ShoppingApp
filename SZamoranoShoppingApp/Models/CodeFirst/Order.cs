using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SZamoranoShoppingApp.Models.CodeFirst
{
    public class Order
    {

        public int Id { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public decimal Total { get; set; }
        public DateTime OrderDate { get; set; }
        public string CustomerId { get; set; }
        public string OrderDetails { get; set; }

        public virtual ApplicationUser Customer { get; set; }              // COMMENT OUT THESE VIRTUAL PROPERTIES OUT WHEN ADDING CONTROLLERS; DEPENDENCY ISSUES; REMEMBER TO "UPDATE DATABASE" AFTERWARDS
        public virtual ICollection<OrderItem> OrderItems { get; set; }     // COMMENT OUT THESE VIRTUAL PROPERTIES OUT WHEN ADDING CONTROLLERS; DEPENDENCY ISSUES; REMEMBER TO "UPDATE DATABASE" AFTERWARDS

    }
}