﻿using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace FiorellaAllProcesses.ViewModels.Product
{
    public class CreateProductVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public int СurrencyId { get; set; }
        public List<IFormFile> Photos { get; set; }
    }
}
