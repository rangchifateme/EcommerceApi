using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceApi.Entities
{
    public class Orders
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        //[ForeignKey("id")]
        public Users? UserId { get; set; }
        [Required]
        [StringLength(200)]
        public string OrderNumber { get; set; }
        [StringLength(200)]
        public string OrderStatus { get; set; }
        [Range(0, 9999999999999999.99)]
        public decimal OrderTotal { get; set; }


    }
}
