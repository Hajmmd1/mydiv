using System.ComponentModel.DataAnnotations;

namespace mydiv.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "این فیلد اجباری")]
        [MinLength(3, ErrorMessage = "این فیلد اجباری 3 تا است")]
        [MaxLength(100, ErrorMessage = "این فیلد اجباری100 تا است")]
        public string Name { get; set; }
        [EmailAddress(ErrorMessage = "مقدرا وارد شده صحیح نیست")]
        public string Email { get; set; }
        public string Message { get; set; }
        public string Service { get; set; }
    }
}
