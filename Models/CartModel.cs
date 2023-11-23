namespace EcommerceApi.Models
{
    public class CartModel
    {
        public int Id { get; set; }
        public UsersModel? UserId { get; set; }
        public ProductsModel? ProductId { get; set; }

    }
}
