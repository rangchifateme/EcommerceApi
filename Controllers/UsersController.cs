﻿using EcommerceApi.Models;
using EcommerceApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IUsersService _usersService;
        public UsersController(IConfiguration configuration)
        {
            _configuration = configuration;            
        }

        [HttpGet]
        [Route("register")]
        public Response registerUser(UsersModel user) { 
            var responseMessage = _usersService.registerUser(user);
            int statusCode = responseMessage == "" ? 200 : 400;
            Response res = new Response
            {
                StatusCode = statusCode,
                StatusMessage = responseMessage
            };
            return res;
        }
    }
}
