using FiorellaAllProcesses.DAL;
using FiorellaAllProcesses.Models;
using FiorellaAllProcesses.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace FiorellaAllProcesses.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FlowerController : Controller
    {
            private AppDbContext _context;

            public FlowerController(AppDbContext context)
            {
                _context = context;
            }

        public async Task<IActionResult> Index()
            {
                HomeVM homeVM = new HomeVM
                {
                    Products = await _context.Products
                                           .Where(p => p.IsDeleted == false)
                                           .Include(p => p.Category)
                                           .Include(p => p.Currency)
                                           .Include(p => p.ProductImage)
                                           .ToListAsync(),
                };
                return View(homeVM);
            }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Product product)
        {
            if (!ModelState.IsValid) return View();
            bool isExist = _context.Products.Any(p => p.Name.Trim()
                                                          .ToLower() == product.Name.Trim().ToLower());
            if (isExist)
            {
                ModelState.AddModelError("Name", "Bu Kateqoriya artiq var");
                return View();
            }
            await _context.AddAsync(product);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Flower");
        }
        public IActionResult Update(int id)
        {
            Product Product = _context.Products.Find(id);
            if (Product == null) return NotFound();

            return View(Product);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, Product Product)
        {
            //if (ModelState.IsValid) return View();
            if (id != Product.Id) return BadRequest();

            Product dbProduct = await _context.Products.FindAsync(id);
            if (dbProduct == null) return NotFound();
            if (dbProduct.Name.Trim().ToLower() == Product.Name.Trim().ToLower())
            {
                return RedirectToAction("Index", "Product");
            }

            bool isExist = _context.Products
                                         .Any(c => c.Name.ToLower().Trim() == Product.Name.ToLower().Trim());
            if (isExist)
            {
                ModelState.AddModelError("Name", "Bu Kateqoriya artiq var");
                return View();
            }
            dbProduct.Name = Product.Name;
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Product");
        }
        //public IActionResult Delete()
        //{
        //    return View();
        //}

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            Product dbproduct = await _context.Products
                                              .Where(p => p.IsDeleted == false && p.Id == id)
                                              .FirstOrDefaultAsync();
            if (dbproduct == null) return NotFound();
            dbproduct.IsDeleted = true;
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Product");
        }
    }
}
