using System.ComponentModel.DataAnnotations;
namespace Sport_Shop.Models
{
    public class Payment
    {
        [Key]
        public int No_Payment { get; set; }
        public string Method { get; set; }
        public string Name_on_card { get; set; }
        public int Postal_cod { get; set; }
        public int Id_User { get; set; }
    }
}
