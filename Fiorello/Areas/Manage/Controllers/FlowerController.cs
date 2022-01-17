using Fiorello.DAL;
using Fiorello.Models;
using FiorelloBack.Extensions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class FlowerController : Controller
    {
        private readonly AppDbContext _context;
        private IWebHostEnvironment _env;
        public FlowerController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;

        }
        public IActionResult Index()
        {
            List<Flower> flowers = _context.Flowers.Include(f=>f.FlowerImages).ToList();
            return View(flowers);
        }
        public  IActionResult Create()
        {
            ViewBag.Campaigns = _context.Campaigns.ToList();
            ViewBag.Categories = _context.Categories.ToList();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Create(Flower flower)
        {
            ViewBag.Campaigns = _context.Campaigns.ToList();
            ViewBag.Categories = _context.Categories.ToList();
            if (!ModelState.IsValid) return View();
            flower.FlowerCategories = new List<FlowerCategory>();
            foreach (int id in flower.CategoryIds)
            {
                FlowerCategory flowerCategory = new FlowerCategory()
                {
                    Flower = flower,
                    CategoryId = id
                };
                flower.FlowerCategories.Add(flowerCategory);
            }
            if (flower.ImageFiles.Count > 5)
            {
                ModelState.AddModelError("ImageFiles", "You can choose only 5 images");
                return View();
            }
            foreach (var image in flower.ImageFiles)
            {
                if (!image.IsImage())
                {
                    ModelState.AddModelError("ImageFiles", "Please choose image file");
                    return View();
                }
                if (!image.IsSizeOkay(2))
                {
                    ModelState.AddModelError("ImageFiles", "Image size must be max 2MB");
                    return View();
                }

            }
            if (flower.CampaignId==0)
            {
                flower.CampaignId = 0;
            }
            var MainImg = flower.MainImageFile;
            FlowerImage fimage = new FlowerImage
            {
                Image = MainImg.SaveImage(_env.WebRootPath, "assets/images"),
                IsMain = true,
                Flower = flower
            };
            flower.FlowerImages.Add(fimage);
            foreach (var image in flower.ImageFiles)
            {
                FlowerImage flowerImage = new FlowerImage
                {
                    Image = image.SaveImage(_env.WebRootPath, "assets/images"),
                    IsMain = flower.FlowerImages.Count < 1 ? true : false,
                    Flower = flower
                };
                flower.FlowerImages.Add(flowerImage);
            }
            _context.Flowers.Add(flower);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }
    }
}

