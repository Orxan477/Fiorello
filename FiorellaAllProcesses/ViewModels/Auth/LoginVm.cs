using System.ComponentModel.DataAnnotations;

namespace FiorellaAllProcesses.ViewModels.Auth
{
    public class LoginVm
    {
        public int Id { get; set; }
        [Required, MaxLength(255), DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required, MaxLength(255), DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RemembeMe {get; set; }
    }
}
