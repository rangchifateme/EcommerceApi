using EcommerceApi.Entities;

namespace EcommerceApi.Services
{
    public class ProductsService : IProductsService
    {
        private readonly ApplicationDbContext _context;

        public ProductsService(ApplicationDbContext context) {
            _context = context;
        }
        public List<Products> getAllProducts()
        {
            return _context.Products.ToList();
        }
        public string addNewProduct(Products product) {
            try
            {
                _context.Products.Add(product);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return "";
        }
        public string deleteProductWithId(int id)
        {
            try
            {
                _context.Remove(_context.Products.Single(p => p.Id == id));
                _context.SaveChanges();
                return "successful";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
