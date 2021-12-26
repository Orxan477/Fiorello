using System.ComponentModel.DataAnnotations;

namespace FiorellaAllProcesses.Models
{
    public class Expert
    {
        public int Id { get; set; }
        public string Image { get; set; }
        [Required][MaxLength(50)]
        public string NameSurname { get; set; }
        [Required][MaxLength(50)]
        public string Position { get; set; }
        public bool IsDeleted { get; set; }
    }
}
