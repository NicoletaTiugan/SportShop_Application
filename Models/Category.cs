using System.ComponentModel.DataAnnotations;
namespace Sport_Shop.Models
{
    public class Category
    {
        [Key]
        public int Category_type { get; set; }

        public   string  Clothing { get; set; }
        public string Shoes { get; set; }
        public List <Products> Sport_Equipment { get; set; }
    }
}
