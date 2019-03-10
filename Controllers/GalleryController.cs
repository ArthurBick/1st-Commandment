using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _1stCommandment.Models;
using ImageGallery.Data.Models;
using ImageGallery.Data;

namespace _1stCommandment.Controllers
{
    public class GalleryController : Controller
    {
        private readonly IImage _imageService;

        public GalleryController(IImage imageService)
        {
            _imageService = imageService;
        }

        public IActionResult Index()
        {
            var imageList = _imageService.GetAll();

            var model = new GalleryIndexModel()
            {
                Images = imageList,
                SearchQuery = ""
            };

            return View(model);
        }

        public IActionResult Detail(int id)
        {
            var image = _imageService.GetById(id);

            var model = new GalleryDetailModel()
            {
                Id = image.Id,
                Title = image.Title,
                Created = image.Created,
                Url = image.Url,
                //Tags = (image.Tags == null) ? new List<string>() : image.Tags.Select(t => t.Description).ToList()
                Tags = image.Tags.Select(t => t.Description).ToList()
            };
            return View(model);
        }
    }
}