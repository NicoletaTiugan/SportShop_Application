using System.ComponentModel.DataAnnotations;
namespace Sport_Shop.Models
{
    public class Admin
    {
        [Key]
        public int Id_Admin { get; set; }
        public string Name { get; set; }
        [Required]
        public string Password { get; set; }
        public string Email { get; set; }
        [Required]
        public int Id_Discount { get; set; }

        
    }
}
