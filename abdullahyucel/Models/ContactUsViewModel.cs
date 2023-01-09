using Microsoft.AspNetCore.Cors;
using System.ComponentModel.DataAnnotations;

namespace abdullahyucel.Models
{
    public class ContactUsViewModel
    {
        
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }

    }
}
