using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAPI.Tables
{
    public class Dish
    {
        public int ID { get; set; }
        public int name { get; set; }
        public int description { get; set; }
        public decimal price { get; set; }
        public int restaurantID { get; set; }
        public virtual Restaurant restaurant { get; set; }
    }
}
