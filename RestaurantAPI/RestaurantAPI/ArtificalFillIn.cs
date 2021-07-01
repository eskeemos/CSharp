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
                Name = "templete",
                Category = "templete",
                Description = "templete",
                HasDelivery = false,
                ContactEmail = "templete",
                ContactNumber = "templete",
                address = new Address()
                    {
                        City = "templete",
                        Street = "templete",
                        PostalCode = "templete",
                    },
                dishes = new List<Dish>()
                    {
                        new Dish()
                        {
                            Name = "templete",
                            Description = "templete",
                            Price = 99.99M
                        },
                    }
                }
            };
            return restaurants;
        }
    }
}
