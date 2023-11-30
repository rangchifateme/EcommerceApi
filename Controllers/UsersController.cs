using EcommerceApi.Entities;
using EcommerceApi.Models;
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
        private readonly ApplicationDbContext _context;
        private readonly IUsersService _usersService;
        public UsersController(IConfiguration configuration, ApplicationDbContext context)
        {
            _configuration = configuration;
            _context = context;
            _usersService = new UsersService(context);
        }

        [HttpPost]
        [Route("register")]
        public Response registerUser(Users user) { 
            var responseMessage = _usersService.registerUser(user);
            int statusCode = responseMessage == "" ? 200 : 400;
            Response res = new Response
            {
                StatusCode = statusCode,
                StatusMessage = responseMessage
            };
            return res;
        }
        [HttpDelete]
        [Route("deleteUserWithEmail")]
        public Response deleteUserWithEmail(string emailAddress) {
            return new Response {
                StatusCode = 200,
                StatusMessage = _usersService.deleteUserWithEmail(emailAddress)
            };
        }

        [HttpGet]
        [Route("getAll")]
        public Response getAllUsers()
        {
            try {
                var users = _usersService.getAllUsers();
                return new Response {
                    ListUsers = users,
                    StatusCode = 200
                };
            }
            catch(Exception ex) {
                return new Response
                {
                    StatusCode = 400,
                    StatusMessage = ex.Message
                };
            }
            
            
        }

        [HttpPost]
        [Route("updateUserWithId")]
        public Response UpdateUserWithId(Users user)
        {
            var result = _usersService.updateUserWithUserId(user);
            var final = new Response();
            final.StatusMessage = result;
            if (result == "successful")
            {
                final.StatusCode = 200;
            }
            else {
                final.StatusCode = 400;
            }
            return final;
        }

        [HttpGet]
        [Route("getUserInfoByFirstname")]
        public Response getUserInfoByFirstname(string firstName) {
            var users = _usersService.getUserInfoByFirstname(firstName);
            return new Response { ListUsers = users };
        }
    }
}
