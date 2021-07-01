using AutoMapper;
using RestaurantAPI.Models;
using RestaurantAPI.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAPI
{
    public class RestaurantObjectMapper : Profile
    {
        public RestaurantObjectMapper()
        {
            CreateMap<Restaurant, RestaurantDto>()
                .ForMember((m) => m.City, (a) => a.MapFrom((x) => x.address.City))
                .ForMember((m) => m.Street, (a) => a.MapFrom((x) => x.address.Street))
                .ForMember((m) => m.PostalCode, (a) => a.MapFrom((x) => x.address.PostalCode));
            CreateMap<Dish, DishDto>();
            CreateMap<CreateRestaurantDto, Restaurant>()
                .ForMember((m) => m.address, (a) => a.MapFrom((x) => new Address()
                {
                    City = x.City, Street = x.Street, PostalCode = x.PostalCode
                }));
        }
    }
}
