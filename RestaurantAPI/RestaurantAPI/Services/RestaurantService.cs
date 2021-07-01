using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RestaurantAPI.Models;
using RestaurantAPI.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAPI.Services
{
    public interface IRestaurantService
    {
        RestaurantDto GetSingle(int id);
        IEnumerable<RestaurantDto> GetAll();
        int Create(CreateRestaurantDto crd);
        bool Delete(int id);
        bool Update(int id, UpdateRestaurantDto urd);
    }
    public class RestaurantService : IRestaurantService
    {
        private readonly RestaurantDbContext _dbContext;
        private readonly IMapper _mapper;

        public RestaurantService(RestaurantDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public RestaurantDto GetSingle(int id)
        {
            var restaurant = _dbContext
                .Restaurants
                .Include((a) => a.address)
                .Include((d) => d.dishes)
                .FirstOrDefault((r) => r.ID == id);

            if (restaurant is null) return null;

            var result = _mapper.Map<RestaurantDto>(restaurant);

            return result;
        }
        public IEnumerable<RestaurantDto> GetAll()
        {
            var restaurants = _dbContext
                .Restaurants
                .Include((a) => a.address)
                .Include((d) => d.dishes)
                .ToList();

            var result = _mapper.Map<List<RestaurantDto>>(restaurants);

            return result;
        }
        public int Create(CreateRestaurantDto crd)
        {
            var restaurant = _mapper.Map<Restaurant>(crd);
            _dbContext.Restaurants.AddRange(restaurant);
            _dbContext.SaveChanges();

            return restaurant.ID;
        }
        public bool Delete(int id)
        {
            var restaurant = _dbContext
                .Restaurants
                .FirstOrDefault((r) => r.ID == id);

            if (restaurant is null) return false;

            _dbContext.Restaurants.Remove(restaurant);
            _dbContext.SaveChanges();
            return true;
        }
        public bool Update(int id, UpdateRestaurantDto urd)
        {
            var restaurant = _dbContext.Restaurants.FirstOrDefault((r) => r.ID == id);

            if (restaurant is null) return false;

            restaurant.Name = urd.Name;
            restaurant.Description = urd.Description;
            restaurant.HasDelivery = urd.HasDelivery;

            _dbContext.SaveChanges();

            return true;
        }
    }
}
