using Microsoft.AspNetCore.Identity;

namespace FiorellaAllProcesses.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string Fullname { get; set; }
        public bool IsActived { get; set; }
        public bool Status { get; set; }
    }
}
