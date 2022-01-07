using FiorellaAllProcesses.Utilities;
using System.Collections.Generic;

namespace FiorellaAllProcesses.ViewModels
{
    public class RoleVM
    {
        public string Id { get; set; }
        public string RoleName { get; set; }
        public string Description { get; set; }
        public int NumberOfUsers { get; set; }
    }
}
