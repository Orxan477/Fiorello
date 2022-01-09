using System.ComponentModel.DataAnnotations;

namespace FiorellaAllProcesses.ViewModels.Account
{
    public class ChangeEmailVM
    {
        public int Id { get; set; }
        [Required, MaxLength(255), DataType(DataType.EmailAddress)]
        public string NewEmail { get; set; }
        [Required, MaxLength(255), DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
