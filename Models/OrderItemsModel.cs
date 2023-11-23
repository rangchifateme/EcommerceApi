
namespace EcommerceApi.Models
{
    public class OrderItemsModel
    {
        public int Id { get; set; }
        public OrdersModel? OrdertId { get; set; }
        public ProductsModel? ProductId { get; set; }
        public UsersModel? UsertId { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal Discount { get; set; }
        public int Quantity { get; set; }
    }
}
