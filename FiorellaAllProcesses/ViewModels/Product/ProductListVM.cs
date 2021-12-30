using FiorellaAllProcesses.Models;

namespace FiorellaAllProcesses.ViewModels.Product
{
    public class ProductListVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string CategoryName { get; set; }
        public string Currency { get; set; }
        public string Image { get; set; }
    }
}
