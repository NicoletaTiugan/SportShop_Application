using System.ComponentModel.DataAnnotations;
namespace Sport_Shop.Models
{
    public class Order
    {
        [Key]
        public int No_Order { get; set; }
        public bool Confirm_Order { get; set; } = true;
        public string Cancel_Order { get; set; }
        public int Id_User { get; set; }
    

            
    }
}
