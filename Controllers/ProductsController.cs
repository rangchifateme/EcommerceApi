using EcommerceApi.Models;
using EcommerceApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly ApplicationDbContext _context;
        private readonly IProductsService _productsService;
        public ProductsController(IConfiguration configuration, ApplicationDbContext context)
        {
            _configuration = configuration;
            _context = context;
            _productsService = new ProductsService(_context);
        }
        [HttpGet]
        [Route("getAll")]
        public Response getAllUsers()
        {
            try
            {
                var products = _productsService.getAllProducts();
                return new Response
                {
                    ListProducrs = products,
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                return new Response
                {
                    StatusCode = 400,
                    StatusMessage = ex.Message
                };
            }

        }
    }
