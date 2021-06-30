using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAPI.Tables
{
    public class Address
    {
        public int ID { get; set; }
        public string city { get; set; }
        public string street { get; set; }
        public string postalCode { get; set; }
        public int restaurantID { get; set; }
        public virtual Restaurant restaurant { get; set; }
    }
}
