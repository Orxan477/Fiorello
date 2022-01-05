using FiorellaAllProcesses.DAL;
using FiorellaAllProcesses.Models;
using FiorellaAllProcesses.ViewModels;
using FiorellaAllProcesses.ViewModels.Product;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiorellaAllProcesses.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FlowerController : Controller
    {
        private AppDbContext _context;
        private int _takeProductCount;

        public FlowerController(AppDbContext context)
            {
             _context = context;
            _takeProductCount = Setting("Take Product Count");
            }
        public int Setting(string key)
        {
            string dbSetting = _context.Settings
                             .Where(s => s.Key == key)
                             .Select(s => s.Value)
                             .FirstOrDefault();
            int option = int.Parse(dbSetting);
            return (option);
        }
        public async Task<IActionResult> Index(int page=1)
        {
            ViewBag.takeProductCount = _takeProductCount;
            var products = await _context.Products
                                          .Where(p => !p.IsDeleted)
                                          .OrderByDescending(p=>p.Id)
                                          .Skip((page-1)* _takeProductCount)
                                          .Take(_takeProductCount)
                                          .Include(p => p.Category)
                                          .Include(p => p.Currency)
                                          .Include(p => p.ProductImage)
                                          .ToListAsync();
            var productsVM = GetProductList(products);
            int pageCount = GetPageCount(_takeProductCount);
            Paginate<ProductListVM> model = new Paginate<ProductListVM>(productsVM,page, pageCount);
            return View(model);
        }
        private int GetPageCount(int take)
        {
            var prodCount = _context.Products.Where(p => !p.IsDeleted).Count();
            return (int)Math.Ceiling((decimal)prodCount / take);
        }
        private List<ProductListVM> GetProductList(List<Product> products)
        {
            List<ProductListVM> model = new List<ProductListVM>();
            foreach (var item in products)
            {
                var product = new ProductListVM
                {
                    Id = item.Id,
                    Name=item.Name,
                    Price=item.Price,
                    Currency=item.Currency.Character,
                    CategoryName=item.Category.Name,
                    Image= item.ProductImage.FirstOrDefault().Image,
                };
                model.Add(product);
            }
            return model;
        }
        public async Task<IActionResult> Create()
        {
            await GetSelectedItemAsync();
            return View();
        }

        
        #region  Create- Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Product product)
        {
            if (!ModelState.IsValid) return View();
            bool isExist = _context.Products.Any(p => p.Name.Trim()
                                                            .ToLower() == product.Name.Trim().ToLower());
            if (isExist)
            {
                ModelState.AddModelError("Name", "Bu Product artiq var");
                return View();
            }
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Flower");
        }
        #endregion

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        #region PostVM

        //public async Task<IActionResult> Create(CreateProductVM product)
        //{
        //    await GetSelectedItemAsync();
        //    if (!ModelState.IsValid) return View();
        //    bool isExist = _context.Products.Any(p => p.Name.Trim()
        //                                                    .ToLower() == product.Name.Trim().ToLower());
        //    if (isExist)
        //    {
        //        ModelState.AddModelError("Name", "Bu Product artiq var");
        //        return View();
        //    }
        //    //await _context.Products.AddAsync(product);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction("Index", "Flower");
        //}
        #endregion
        private async Task GetSelectedItemAsync()
        {
            ViewBag.category = new SelectList(await _context.Categories
                                                             .Where(c => c.IsDeleted == false)
                                                             .ToListAsync(), "Id", "Name");
            ViewBag.currency = new SelectList(await _context.Сurrencies.ToListAsync(), "Id", "Character");
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
