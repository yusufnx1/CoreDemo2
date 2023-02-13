using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace CoreDemo2.Models
{
    public class AddProfieImage
    {
        [Key]
        public int WriterId { get; set; }
        public string WriterName { get; set; }
        public string WriterAbout { get; set; }
        public IFormFile WriterImage { get; set; }
        public string WriterMail { get; set; }
        public string WriterPassword { get; set; }
        //[Compare("WriterPassword", ErrorMessage = "Şifreler eşleşmiyor. Lütfen tekrar deneyin!")]
        //public string ConfirmPassword { get; set; }
        public bool WriterStatus { get; set; }
    }
}
