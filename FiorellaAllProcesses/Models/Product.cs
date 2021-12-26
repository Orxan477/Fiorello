using System.Collections.Generic;

namespace FiorellaAllProcesses.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool IsDeleted { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int СurrencyId { get; set; }
        public Сurrency Currency { get; set; }
        public ICollection<ProductImages> ProductImage { get; set; }
    }
}
