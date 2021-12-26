﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiorellaAllProcesses.ViewModels
{
    public class BasketItemVM
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int Count { get; set; }
        public int StockCount { get; set; }
        public bool IsActive { get; set; }
    }
}
