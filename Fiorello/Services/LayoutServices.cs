using Fiorello.DAL;
using Fiorello.Models;
using Fiorello.ViewModels;
using FiorelloBack.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello.Services
{
    public class LayoutServices
    {
        private readonly AppDbContext _context;
        private readonly IHttpContextAccessor _httpContext;
        public LayoutServices(AppDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpContext = httpContextAccessor;
        }
        public BasketVM ShowBasket()
        {
            string basket = _httpContext.HttpContext.Request.Cookies["Basket"];

            //BasketVM basketVM = new BasketVM();
            BasketVM basketData = new BasketVM
            {
                TotalPrice = 0,
                BasketItems = new List<BasketItemVM>(),
                Count = 0
            };
            if (_httpContext.HttpContext.User.Identity.IsAuthenticated)
            {
                List<BasketItem> basketItems = _context.BasketItems.Include(b => b.AppUser).Where(a => a.AppUser.UserName == _httpContext.HttpContext.User.Identity.Name).ToList();
                foreach (BasketItem item in basketItems)
                {
                    Flower flower = _context.Flowers.Include(f => f.Campaigns).FirstOrDefault(f => f.Id == item.FlowerId);
                    if (flower!=null)
                    {
                        BasketItemVM basketItemVM = new BasketItemVM
                        {
                            Flower = flower,
                            Count = item.Count
                        };
                        basketItemVM.Price = flower.CampaignId == null ? flower.Price : flower.Price * (100 - flower.Campaigns.DiscountPercent) / 100;
                        basketData.BasketItems.Add(basketItemVM);
                        basketData.Count++;
                        basketData.TotalPrice += basketItemVM.Price * basketItemVM.Count;
                    }

                }
            }
            else
            {
                if (!string.IsNullOrEmpty(basket))
                {
                    List<BasketCookieItemVM> basketCookieItems = JsonConvert.DeserializeObject<List<BasketCookieItemVM>>(basket);

                    foreach (BasketCookieItemVM item in basketCookieItems)
                    {
                        Flower flower = _context.Flowers.Include(f => f.FlowerImages).FirstOrDefault(f => f.Id == item.Id);
                        if (flower != null)
                        {
                            BasketItemVM basketItem = new BasketItemVM
                            {
                                Flower = _context.Flowers.Include(f => f.Campaigns).Include(f => f.FlowerImages).FirstOrDefault(f => f.Id == item.Id),
                                Count = item.Count

                            };
                            basketItem.Price = basketItem.Flower.CampaignId == null ? basketItem.Flower.Price : basketItem.Flower.Price * (100 - basketItem.Flower.Campaigns.DiscountPercent) / 100;
                            basketData.BasketItems.Add(basketItem);
                            basketData.Count++;
                            basketData.TotalPrice += basketItem.Price * basketItem.Count;
                        }
                    }
                }
            }
            
            return basketData;

        }
    }
}
