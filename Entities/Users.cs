using EcommerceApi.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Permissions;

namespace EcommerceApi.Entities
{
    public class Users
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        [MaxLength(100)]
        public string LasttName { get; set; } = string.Empty;
        [Required]
        [MaxLength(100)]
        public string PhoneNumber { get; set; } = string.Empty;
        [DataType(DataType.Password)]
        [Required]
        [MaxLength(255)]
        public string Password { get; set; } = string.Empty;
        [DataType(DataType.EmailAddress)]
        [MaxLength(255)]
        public string EmailAddress { get; set; } = string.Empty;
        [Required]
        [MaxLength(100)]
        string UserType { get; set; } = string.Empty;

    }
}
