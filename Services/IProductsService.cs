using EcommerceApi.Entities;

namespace EcommerceApi.Services
{
    public interface IProductsService
    {
        public List<Products> getAllProducts();
        public string deleteProductWithId(int id);
    }
}
