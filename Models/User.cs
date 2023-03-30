using System.ComponentModel.DataAnnotations;
namespace Sport_Shop.Models
{
    public class User
    {
        [Key]
        public int Id_User { get; set; }
        public string Email { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }

    }
}
