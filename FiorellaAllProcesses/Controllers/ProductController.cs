using FiorellaAllProcesses.DAL;
using FiorellaAllProcesses.Models;
using FiorellaAllProcesses.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiorellaAllProcesses.Controllers
{
    public class ProductController : Controller
    {
        private AppDbContext _context { get; }
        private int _proCount;
        private object _take;

        public ProductController(AppDbContext context)
        {
            _context = context;
            _proCount = _context.Products
                               .Where(p => p.IsDeleted == false)
                               .Count();
        }
        public IActionResult Index()
        {
            ViewBag.proCount = _proCount;
            return View();
        }
        public IActionResult LoadProduct(int skip)
        {
            _take = _context.Settings
                           .Where(s => s.Key == "Take")
                           .Select(s => s.Value)
                           .FirstOrDefault();

            if (_proCount == skip)
            {

                return Json(new
                {
                    alert = "error"
                });
            }

            return ViewComponent("Product", new { take = _take, skip = skip });
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Basket(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Product dbProduct = await _context.Products.FindAsync(id);
            if (dbProduct == null)
            {
                return BadRequest();
            }
            List<BasketVM> basket = GetBasket();
            UpdateBasket((int)id, basket);

            return RedirectToAction("Index", "Home");
        }
        private void UpdateBasket(int id, List<BasketVM> basket)
        {
            BasketVM basketProduct = basket.Find(p => p.Id == id);
            if (basketProduct == null)
            {
                basket.Add(new BasketVM
                {
                    Id = id,
                    Count = 1,
                });
            }
            else
            {
                basketProduct.Count += 1;
            }

            Response.Cookies.Append("basket", JsonConvert.SerializeObject(basket));
        }
        private List<BasketVM> GetBasket()
        {
            List<BasketVM> basket;
            if (Request.Cookies["basket"] != null)
            {
                basket = JsonConvert.DeserializeObject<List<BasketVM>>(Request.Cookies["basket"]);
            }
            else
            {
                basket = new List<BasketVM>();
            }
            return basket;
        }
        public async Task<IActionResult> BasketShop()
        {
            List<BasketVM> basket = GetBasket();
            List<BasketItemVM> model = await GetBasketList(basket);
            return View(model);
        }
        private async Task<List<BasketItemVM>> GetBasketList(List<BasketVM> basket)
        {
            List<BasketItemVM> model = new List<BasketItemVM>();
            foreach (BasketVM item in basket)
            {
                Product dbProduct = await _context.Products
                                                 .Include(p => p.ProductImage)
                                                 .FirstOrDefaultAsync(p => p.Id == item.Id);
                BasketItemVM itemVM = GetBasketItem(item, dbProduct);
                model.Add(itemVM);
            }
            return model;
        }
        private BasketItemVM GetBasketItem(BasketVM item, Product dbProduct)
        {
            return new BasketItemVM
            {
                Id = item.Id,
                Name = dbProduct.Name,
                Count = item.Count,
                Image = dbProduct.ProductImage.FirstOrDefault().Image,
                Price = dbProduct.Price,
                IsActive = dbProduct.IsDeleted
            };
        }
    }
}
