using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceApi.Entities
{
    public class Products
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(200)]
        public string ProductName { get; set; }
        public string Description { get; set; }
        [Required]
        [Range(0, 9999999999999999.99)]
        public decimal UnitPrice { get; set; }
        [Range(0, 9999999999999999.99)]
        public decimal Discount { get; set; }
        public int Quantity { get; set; }
        [StringLength(10000)]
        public string ImageURL { get; set; }
        public int Status { get; set; }

    }
}
