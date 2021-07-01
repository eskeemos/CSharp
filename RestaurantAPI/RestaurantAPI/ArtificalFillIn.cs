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
                Name = "tst_name",
                Category = "tst_category",
                Description = "tst_description",
                HasDelivery = true,
                ContactEmail = "tst_contactEmail",
                ContactNumber = "tst_contactNumber",
                address = new Address()
                    {
                        City = "tst_city",
                        Street = "tst_street",
                        PostalCode = "tst_postalCode",
                    },
                dishes = new List<Dish>()
                    {
                        new Dish()
                        {
                            Name = "tst_dishName",
                            Description = "tst_dishDescription",
                            Price = 99.99M
                        },
                    }
                }
            };
            return restaurants;
        }
    }
}
