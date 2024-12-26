using BloggingMVC.Data;
using BloggingMVC.Models.Domain;
using BloggingMVC.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BloggingMVC.Controllers
{
    
    public class AdminTagController : Controller
    {
        // private variable declared to assigned  constructor value
        private readonly BloggieDbContext bloggieDbContext;

        // constructor created for DB
        public AdminTagController(BloggieDbContext bloggieDbContext)
        {
            this.bloggieDbContext = bloggieDbContext;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(AddTagRequest addTagRequest)
        {
            
           // Mapping AddTagRequest to Tag domain Model
            var tag = new Tag
            {
                Name = addTagRequest.name,
                DisplayName=addTagRequest.displayName
            };

            bloggieDbContext.Tags.Add(tag);
            bloggieDbContext.SaveChanges();

            return View("Add");
        }
    }
}
