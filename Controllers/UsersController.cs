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
    }
}
