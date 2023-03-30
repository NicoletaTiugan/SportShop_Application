using System.ComponentModel.DataAnnotations;
namespace Sport_Shop.Models
{
    public class Discount
    {
        [Key]
        public int Id_Discount { get; set; }
        public string Type { get; set; }
        public int Code { get; set; }

    }
}
