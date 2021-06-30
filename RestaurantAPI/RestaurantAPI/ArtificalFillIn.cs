using RestaurantAPI.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAPI
{
    public class ArtificalFillIn
    {
        private readonly RestaurantDbContext _dbContext;
        
        public ArtificalFillIn(RestaurantDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void FillInWithArtificalData()
        {
            if (_dbContext.Database.CanConnect())
            {
                if (!_dbContext.Restaurants.Any())
                {
                    var restaurants = GetRestaurants();
                    _dbContext.Restaurants.AddRange(restaurants);
                    _dbContext.SaveChanges();
                }
            }
        }

        private IEnumerable<Restaurant> GetRestaurants()
        {
            var restaurants = new List<Restaurant>()
            {
                new Restaurant()
                {
                name = "tst_name",
                category = "tst_category",
                description = "tst_description",
                hasDelivery = true,
                contactEmail = "tst_contactEmail",
                contactNumber = "tst_contactNumber",
                
                address = new Address()
                    {
                        city = "tst_city",
                        street = "tst_street",
                        postalCode = "tst_postalCode",
                    },
                dishes = new List<Dish>()
                    {
                        new Dish()
                        {
                            name = "tst_dishName",
                            description = "tst_dishDescription",
                            price = 99.99M
                        },
                    }
                }
            };
            return restaurants;
        }
    }
}
