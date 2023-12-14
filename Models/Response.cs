using EcommerceApi.Entities;

namespace EcommerceApi.Models
{
    public class Response
    {
        public int StatusCode { get; set; }
        public string StatusMessage { get; set; }

        public List<Users> ListUsers { get; set; }
        public Users User { get; set; }

        public List<Products> ListProducts { get; set; }
        public Products Product { get; set; }
        public List<Cart> ListCarts { get; set; }
        public List<Orders> ListOrders { get; set; }
        public Orders Order { get; set; }
        public List<OrderItems> ListOrderItems { get; set; }
        public OrderItems OrderItem { get; set; }
    }
}
