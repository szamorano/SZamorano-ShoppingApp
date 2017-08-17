using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SZamoranoShoppingApp.Models.CodeFirst
{
    public class CartItem
    {
        public int Id { get; set; }
        public string ItemId { get; set; }
        public int Count { get; set; }
        public DateTime CreationDate { get; set; }
        public string CustomerId { get; set; }

        public virtual Item Item { get; set; }                  // COMMENT OUT THESE VIRTUAL PROPERTIES OUT WHEN ADDING CONTROLLERS; DEPENDENCY ISSUES; REMEMBER TO "UPDATE DATABASE" AFTERWARDS
        public virtual ApplicationUser Customer { get; set; }   // COMMENT OUT THESE VIRTUAL PROPERTIES OUT WHEN ADDING CONTROLLERS; DEPENDENCY ISSUES; REMEMBER TO "UPDATE DATABASE" AFTERWARDS

        public decimal unitTotal
        {
            get
            {
                return Count * Item.Price;
            }
        }
    }
}