using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiorellaAllProcesses.Models
{
    public class BlogFlower
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Date { get; set; }
        public string Position { get; set; }
        public string Content { get; set; }
        public bool IsDelete { get; set; }
    }
}
