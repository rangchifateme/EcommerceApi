using EcommerceApi.Entities;
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
        [HttpPost]
        [Route("addNewProduct")]
        public Response addNewProduct(Products product) {
            var responseMessage = _productsService.addNewProduct(product);
            int statusCode = responseMessage == "" ? 200 : 400;
            Response res = new Response
            {
                StatusCode = statusCode,
                StatusMessage = responseMessage
            };
            return res;
        }

        [HttpPost]
        [Route("UpdateProductWithId")]
        public Response updateProductWithId(Products product)
        {
            var result = _productsService.updateProductWithProductId(product);
            var final = new Response();
            final.StatusMessage = result;
            if (result == "successful")
            {
                final.StatusCode = 200;
            }
            else
            {
                final.StatusCode = 400;
            }
            return final;
        }
        [HttpPost]
        [Route("UpdateProductWithName")]
        public Response updateProductWithName(Products product)
        {
            var result = _productsService.updateProductWithProductName(product);
            var final = new Response();
            final.StatusMessage = result;
            if (result == "successful")
            {
                final.StatusCode = 200;
            }
            else
            {
                final.StatusCode = 400;
            }
            return final;
        }
        [HttpDelete]
        [Route("deleteProductWithId")]
        public Response deleteProductWithId(int id)
        {
            return new Response
            {
                StatusCode = 200,
                StatusMessage = _productsService.deleteProductWithId(id)
            };
        }
    }
}
