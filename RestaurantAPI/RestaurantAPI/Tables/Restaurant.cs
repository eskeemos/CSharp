using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAPI.Tables
{
    public class Restaurant
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string category { get; set; }
        public string description { get; set; }
        public bool hasDelivery { get; set; }
        public string contactEmail { get; set; }
        public string contactNumber { get; set; }
        public string addressID { get; set; }
        public virtual Address address { get; set; }
        public virtual List<Dish> dishes { get; set; }
    }
}
