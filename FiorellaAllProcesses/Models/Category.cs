﻿
using System.ComponentModel.DataAnnotations;

namespace FiorellaAllProcesses.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required][MaxLength(50)]
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
    }
}
