using Microsoft.AspNetCore.Cors;
using System.ComponentModel.DataAnnotations;

namespace abdullahyucel.Models
{
    public class ContactUsViewModel
    {
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "{0} alanı boş bırakılamaz!")]
        public string Name { get; set; }


        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "{0} alanı boş bırakılamaz!")]
        public string Email { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "{0} alanı boş bırakılamaz!")]
        public string Subject { get; set; }


        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "{0} alanı boş bırakılamaz!")]
        public string Message { get; set; }

    }
}
