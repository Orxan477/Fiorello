using System.ComponentModel.DataAnnotations;

namespace FiorellaAllProcesses.ViewModels.Account
{
    public class ChangePasswordVM
    {
        public int Id { get; set; }
        [Required, MaxLength(255), DataType(DataType.Password)]
        public string CurrentPassword { get; set; }
        [Required, MaxLength(255), DataType(DataType.Password)]
        public string NewPassword { get; set; }
        [DataType(DataType.Password), Compare(nameof(NewPassword))]
        public string ConfirmPassword { get; set; }
    }
}
