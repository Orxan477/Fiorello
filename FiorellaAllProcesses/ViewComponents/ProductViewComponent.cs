using FiorellaAllProcesses.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace FiorellaAllProcesses.ViewComponents
{
    public class ProductViewComponent:ViewComponent
    {
        private AppDbContext _context;

        public ProductViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync(int take, int skip = 0)
        {
            var model = await _context.Products
                                         .Where(p => p.IsDeleted == false)
                                         .Include(p => p.ProductImage)
                                         .Include(p => p.Category)
                                         .Include(p => p.Currency)
                                         .OrderByDescending(p => p.Id)
                                         .Skip(skip)
                                         .Take(take)
                                         .ToListAsync();
            return View(await Task.FromResult(model));
        }
    }
}
