using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceApi.Entities
{
    public class OrderItems
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        //[ForeignKey("Id")]
        public Orders? OrdertId { get; set; }
        //[ForeignKey("Id")]
        public Products? ProductId { get; set; }
        //[ForeignKey("Id")]
        public Users? UsertId { get; set; }
        [Range(0, 9999999999999999.99)]
        public decimal UnitPrice { get; set; }
        [Range(0, 9999999999999999.99)]
        public decimal TotalPrice { get; set; }
        [Range(0, 9999999999999999.99)]
        public decimal Discount { get; set; }
        public int Quantity { get; set; }

    }
}
