using System.ComponentModel.DataAnnotations;

namespace FiorellaAllProcesses.ViewModels.Auth
{
    public class RegisterVM
    {
        [Required,MaxLength(50)]
        public string Fullname { get; set; }
        [Required, MaxLength(50)]
        public string Username { get; set; }
        [Required, MaxLength(255),DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required, MaxLength(255), DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password),Compare(nameof (Password))]
        public string ConfirmPassword { get; set; }
    }
}
