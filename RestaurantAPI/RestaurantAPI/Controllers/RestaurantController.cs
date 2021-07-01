﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestaurantAPI.Models;
using RestaurantAPI.Services;
using RestaurantAPI.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAPI.Controllers
{
    [Route("api/restaurant")]
    public class RestaurantController : ControllerBase
    {
        private readonly IRestaurantService _restaurantService;

        public RestaurantController(IRestaurantService restaurantService)
        {
            _restaurantService = restaurantService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<RestaurantDto>> GetAll()
        {
            var restaurantsDtos = _restaurantService.GetAll();
            return Ok(restaurantsDtos);
        }

        [HttpGet("{id}")]
        public ActionResult<RestaurantDto> GetSingle([FromRoute] int id)
        {
            var restaurant = _restaurantService.GetSingle(id);
            return restaurant;
        }

        [HttpPost]
        public ActionResult CreateRestaurant([FromBody] CreateRestaurantDto crd)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var id = _restaurantService.Create(crd);
            return Created($"api/restaurant/{id}", null);
        }
    }
}
