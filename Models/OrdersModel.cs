
namespace EcommerceApi.Models
{
    public class OrdersModel
    {
        public int Id { get; set; }
        public UsersModel? UserId { get; set; }
        public string OrderNumber { get; set; }
        public string OrderStatus { get; set; }
        public decimal OrderTotal { get; set; }

    }
}
