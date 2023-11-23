using System.ComponentModel.DataAnnotations;

namespace EcommerceApi.Models
{
    public class ProductsModel
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        public int Quantity { get; set; }
        public string ImageURL { get; set; }
        public int Status { get; set; }
    }
}
