using System.ComponentModel.DataAnnotations;

namespace FiorellaAllProcesses.ViewModels.Account
{
    public class ChangeUsername
    {
        [Required, MaxLength(50)]
        public string NewUsername { get; set; }
        [Required, MaxLength(255), DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
