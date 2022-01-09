using System.ComponentModel.DataAnnotations;

namespace FiorellaAllProcesses.ViewModels.Account
{
    public class PasswordMailVM
    {
        public int Id { get; set; }
        [Required,MaxLength(255), DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
