using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAPI.Entities
{
    public class RestaurantSeeder
    {
        private readonly RestaurantDbContext _dbContext;
        public RestaurantSeeder(RestaurantDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Seed()
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
                    Name = "KFC",
                    Description = "KFC (abbr. for Kentucky Fried Chicken) is an American fast food restaurant chain headquartered in Louisville, Kentucky that specializes in fried chicken.",
                    Category = "Fast Food",
                    ContactEmail = "contact@kfc.com",
                    HasDelivery = true,
                    Dishes = new List<Dish>()
                    {
                        new Dish()
                        {
                            Name = "Fillet Tower Burger Meal",
                            Price = 5.59M,
                        },
                        new Dish()
                        {
                            Name = "Trilogy Box Meal",
                            Price = 6.99M,
                        }
                    },
                    Address = new Address()
                    {
                        City = "Kraków",
                        Street = "Zygmuntowska 17",
                        PostalCode = "30-301"
                    }
                },
                new Restaurant()
                {
                    Name = "Burger King",
                    Description = "Burger King Corporation, restaurant company specializing in flame-broiled fast-food hamburgers.",
                    Category = "Fast Food",
                    ContactEmail = "contact@bgKing.com",
                    HasDelivery = true,
                    Dishes = new List<Dish>()
                    {
                        new Dish()
                        {
                            Name = "Double Whopper",
                            Price = 4.79M,
                        },
                        new Dish()
                        {
                            Name = "Plant Based Whopper",
                            Price = 5.79M,
                        }
                    },
                    Address = new Address()
                    {
                        City = "Wrocław",
                        Street = "Krótka 21",
                        PostalCode = "35-509"
                    }
                }
            };
            return restaurants;
        }
    }
}
