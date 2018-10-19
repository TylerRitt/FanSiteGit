using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FanSite.Models;

namespace FanSite.Controllers
{
    public class HomeController : Controller
    {
       public IActionResult Index()
        {
            List<Stories> story = StoriesRepo.Stories;
            story.Sort((s1, s2) => string.Compare(s1.Name, s2.Name, StringComparison.Ordinal));
            /*ViewBag.newestStory = story[story.Count - 1].Name;
            ViewData["StoriesCount"] = story.Count;*/
           
            return View(story);
        }

        public IActionResult AddStory()
        {
            return View();
        }

        public IActionResult History()
        {
            ViewData["Message"] = "Facts about person";

            return View();
        }

        public IActionResult Stories()
        {
            ViewData["Message"] = "Stories about person/ form";

            return View();
        }

        Stories story;

        public void StoriesController()
        {
            if (StoriesRepo.Stories.Count == 0)
            {
                story = new Stories()
                {
                    Name = "The legend of Steve Jobs",
                    Story = "Steve Jobs Was CEO of Apple"
                };

                StoriesRepo.AddStory(story);
            }
        }


        [HttpPost]
        public RedirectToActionResult AddStory(string name, string story)
        {
            Stories stories = new Stories { Name = name, Story = story };
            StoriesRepo.AddStory(stories);

            return RedirectToAction("Index");
        }  
        
    }
}
