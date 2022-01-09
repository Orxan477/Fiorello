using System.ComponentModel.DataAnnotations;

namespace FiorellaAllProcesses.ViewModels.Account
{
    public class ForgotPassword
    {
        public int Id { get; set; }
        [Required, MaxLength(255), DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required, MaxLength(255), DataType(DataType.Password)]
        public string NewPassword { get; set; }
        [DataType(DataType.Password), Compare(nameof(NewPassword))]
        public string ConfirmPassword { get; set; }
    }
}
