using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Models
{
    public class HomeDelivery
    {
        [Required(ErrorMessage = "Пожалуйста введите имя")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Пожалуйста введите адрес")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Пожалуйста введите адрес")]
        public string Phone { get; set; }
    }
}
