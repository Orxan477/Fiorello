using FiorellaAllProcesses.Models;
using System.Collections.Generic;

namespace FiorellaAllProcesses.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public HomeIntro HomeIntro{ get; set; }
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
        public Сurrency Сurrencies { get; set; }
        public Valentine Valentines { get; set; }
        public List<ValentineOption> ValentineOption { get; set; }
        public FlowerExpert FlowerExpert { get; set; }
        public List<Expert> Experts { get; set; }
        public Blog Blogs { get; set; }
        public List<BlogFlower> BlogFlowers { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Instagram> Instagrams { get; set; }
        public List<Setting> Settings { get; set; }

    }
}
