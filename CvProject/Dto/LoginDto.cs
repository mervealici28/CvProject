using System.ComponentModel.DataAnnotations;

namespace CvProject.Dto
{
    public class LoginDto
    {
        [Required(ErrorMessage ="Username boş olamaz")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Şifre boş olamaz")]
        public string Password { get; set; }
    }
}
