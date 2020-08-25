using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Models
{
    public class MailDelivery
    {
        [Required(ErrorMessage = "Пожалуйста введите имя")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Пожалуйста введите индекс")]
        public int ZIP { get; set; }
        [Required(ErrorMessage = "Пожалуйста введите адрес")]
        public string Address { get; set; }

    }
}
