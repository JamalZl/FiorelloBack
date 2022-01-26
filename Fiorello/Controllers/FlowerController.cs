using Fiorello.DAL;
using Fiorello.Models;
using Fiorello.ViewModels;
using FiorelloBack.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello.Controllers
{
    public class FlowerController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        public FlowerController(AppDbContext context,UserManager<AppUser> userManager)
        {
            _context = context;
        }
        public IActionResult Details(int id,int categoryId)
        {
            Flower flower = _context.Flowers.Include(f=>f.Campaigns).Include(f=>f.FlowerCategories).ThenInclude(fc=>fc.Category).Include(f=>f.FlowerTags).ThenInclude(ft=>ft.Tag).Include(f=>f.FlowerImages).FirstOrDefault(f => f.Id == id);
            if (flower == null) return NotFound();
            ViewBag.RelatedFlowers = _context.Flowers.Include(f => f.FlowerCategories).ThenInclude(f=>f.Category).Include(f=>f.Campaigns).Include(f=>f.FlowerImages).Where(f=>f.FlowerCategories.FirstOrDefault().CategoryId==categoryId).Take(4).ToList();
            //List<Flower> flowers = _context.Flowers.Include(f => f.FlowerCategories).ThenInclude(f => f.Category).Include(f => f.Campaigns).Include(f => f.FlowerImages).Where(f => f.FlowerCategories.FirstOrDefault().CategoryId == categoryId).Take(4).ToList();
            //return Json(flowers);
            return View(flower);
        }
        public async Task<IActionResult> AddBasket(int id)
        {
            Flower flower = _context.Flowers.Include(f => f.Campaigns).FirstOrDefault(f => f.Id == id);

            if (User.Identity.IsAuthenticated)
            {
                AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

                BasketItem basketItem = _context.BasketItems.FirstOrDefault(b => b.FlowerId == flower.Id && b.AppUserId==user.Id);
                if (basketItem==null)
                {
                    basketItem = new BasketItem
                    {
                        AppUserId = user.Id,
                        FlowerId = flower.Id,
                        Count = 1
                    };
                    _context.BasketItems.Add(basketItem);
                }
                else
                {
                    basketItem.Count++;
                }
            }
            else
            {
                string basket = HttpContext.Request.Cookies["Basket"];

                if (basket == null)
                {
                    List<BasketCookieItemVM> basketCookieItems = new List<BasketCookieItemVM>();

                    basketCookieItems.Add(new BasketCookieItemVM
                    {
                        Id = flower.Id,
                        Count = 1
                    });



                    string basketStr = JsonConvert.SerializeObject(basketCookieItems);


                    HttpContext.Response.Cookies.Append("Basket", basketStr);
                }
                else
                {
                    List<BasketCookieItemVM> basketCookieItems = JsonConvert.DeserializeObject<List<BasketCookieItemVM>>(basket);

                    BasketCookieItemVM cookieItem = basketCookieItems.FirstOrDefault(c => c.Id == flower.Id);

                    if (cookieItem == null)
                    {
                        cookieItem = new BasketCookieItemVM
                        {
                            Id = flower.Id,
                            Count = 1
                        };
                        basketCookieItems.Add(cookieItem);
                    }
                    else
                    {
                        cookieItem.Count++;
                    }

                    string basketStr = JsonConvert.SerializeObject(basketCookieItems);

                    HttpContext.Response.Cookies.Append("Basket", basketStr);

                }
            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult ShowBasket()
        {
            string basketStr = HttpContext.Request.Cookies["Basket"];
            if (!string.IsNullOrEmpty(basketStr))
            {
                List<BasketCookieItemVM> basket = JsonConvert.DeserializeObject<List<BasketCookieItemVM>>(basketStr);
                return Json(basket);
            }
            return Content("Basket is empty");
        }
        public IActionResult Search(string keyword)
        {
            List<Flower> flowers = _context.Flowers.Include(f=>f.FlowerImages).Include(f=>f.FlowerCategories).ThenInclude(fc=>fc.Category).Where(f=>f.Name.Contains(keyword)).ToList();
            if (!flowers.Any(f => f.Name.Contains(keyword)))
            {
                ModelState.AddModelError("", "No result");
                
            }
            return View(flowers);
        }
        //public IActionResult SetCookie(int id)
        //{
        //    Flower flower = _context.Flowers.FirstOrDefault(f => f.Id == id);
        //    HttpContext.Response.Cookies.Append("Cookie", flower.Name);
        //    return RedirectToAction("Index", "Home");
        //}
        //public IActionResult ShowCookie()
        //{
        //    return Content(HttpContext.Request.Cookies["Cookie"]);
        //}
        //public IActionResult DeleteCookie(string key)
        //{
        //    HttpContext.Response.Cookies.Delete(key);
        //    return RedirectToAction("Index", "Home");
        //}

    }
}
