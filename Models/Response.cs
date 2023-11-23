namespace EcommerceApi.Models
{
    public class Response
    {
        public int StatusCode { get; set; }
        public string StatusMessage { get; set; }

        public List<UsersModel> ListUsers { get; set; }
        public UsersModel User { get; set; }

        public List<ProductsModel> ListProducrs { get; set; }
        public ProductsModel Product { get; set; }
        public List<CartModel> ListCarts { get; set; }
        public List<OrdersModel> ListOrders { get; set; }
        public OrdersModel Order { get; set; }
        public List<OrderItemsModel> ListOrderItems { get; set; }
        public OrderItemsModel OrderItem { get; set; }
    }
}
