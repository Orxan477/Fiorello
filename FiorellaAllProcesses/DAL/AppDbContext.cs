using FiorellaAllProcesses.Models;
using Microsoft.EntityFrameworkCore;

namespace FiorellaAllProcesses.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {
        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<HomeIntro> HomeIntros { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImages> ProductImages { get; set; }
        public DbSet<Сurrency> Сurrencies { get; set; }
        public DbSet<Valentine> Valentines { get; set; }
        public DbSet<ValentineOption> ValentineOptions { get; set; }
        public DbSet<FlowerExpert> FlowerExperts { get; set; }
        public DbSet<Expert> Experts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogFlower> BlogFlowers { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Instagram> Instagrams { get; set; }
        public DbSet<Setting> Settings { get; set; }

    }
}
