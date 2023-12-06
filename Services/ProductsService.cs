using EcommerceApi.Entities;

namespace EcommerceApi.Services
{
    public class ProductsService:IProductsService
    {
        private readonly ApplicationDbContext _context;

        public ProductsService(ApplicationDbContext context) { 
            _context = context;
        }
        public List<Products> getAllProducts()
        {
            return _context.Products.ToList();
        }
    }
}
