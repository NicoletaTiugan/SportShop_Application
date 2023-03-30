using System.ComponentModel.DataAnnotations;
namespace Sport_Shop.Models
{
    public class Products
    {
        [Key]
        public int No_Product { get; set; }
        public string Gender { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public string Category_type { get; set; }
            public int Id_Discount { get; set; }

    }
}
