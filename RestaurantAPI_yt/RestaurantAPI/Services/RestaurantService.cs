using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using RestaurantAPI.Entities;
using RestaurantAPI.Exceptions;
using RestaurantAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantAPI.Services
{
    public interface IRestaurantService
    {
        RestaurantDto GetByID(int id);
        IEnumerable<RestaurantDto> GetAll();
        int Create(CreateRestaurantDto dto);
        void Delete(int id);
        void Update(int id, UpdateRestaurantDto dto);
    }
    public class RestaurantService : IRestaurantService
    {
        private readonly RestaurantDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly ILogger<IRestaurantService> _logger;

        public RestaurantService(RestaurantDbContext dbContext, IMapper mapper, ILogger<IRestaurantService> logger)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _logger = logger;
        }
        public RestaurantDto GetByID(int id)
        {
            var restaurant = _dbContext
                .Restaurants
                .Include((r) => r.Address)
                .Include((r) => r.Dishes)
                .FirstOrDefault((x) => x.ID == id);

            if (restaurant is null) throw new NotFoundException("Restaurant not found.");

            var result = _mapper.Map<RestaurantDto>(restaurant);
            return result;
        }
        public IEnumerable<RestaurantDto> GetAll()
        {
            var restaurants = _dbContext
                .Restaurants
                .Include((r) => r.Address)
                .Include((r) => r.Dishes)
                .ToList();
            var restaurantsDtos = _mapper.Map<List<RestaurantDto>>(restaurants);
            return restaurantsDtos;
        }
        public int Create(CreateRestaurantDto dto)
        {
            var restaurant = _mapper.Map<Restaurant>(dto);
            _dbContext.Restaurants.Add(restaurant);
            _dbContext.SaveChanges();

            return restaurant.ID;
        }
        public void Delete(int id)
        {
            _logger.LogError($"Restaurant with id : {id} DELETE action invoked");

            var restaurant = _dbContext
                .Restaurants
                .FirstOrDefault((x) => x.ID == id);
            if (restaurant is null) throw new NotFoundException("Restaurant not found.");

            _dbContext.Restaurants.Remove(restaurant);
            _dbContext.SaveChanges();
        }
        public void Update(int id, UpdateRestaurantDto dto)
        {
            var restaurant = _dbContext
                .Restaurants
                .FirstOrDefault((x) => x.ID == id);

            if (restaurant is null) throw new NotFoundException("Restaurant not found.");

            restaurant.Name = dto.Name;
            restaurant.Description = dto.Description;
            restaurant.HasDelivery = dto.HasDelivery;

            _dbContext.SaveChanges();
        }
    }
}
