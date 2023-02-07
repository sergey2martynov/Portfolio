using System.ComponentModel.DataAnnotations;

namespace AndreysPortfolio.Models
{
    public class Request
    {
        [Required(ErrorMessage = "Вам нужно ввести имя")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Вам нужно ввести номер телефона")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Вам нужно ввести сообщение")]
        public string Message { get; set; }
    }
}
