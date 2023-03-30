using System.ComponentModel.DataAnnotations;
namespace Sport_Shop.Models
{
    public class Size
    {
        [Key]
        public int Id_Size { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }
        public int Id_User { get; set; }

    }
}
