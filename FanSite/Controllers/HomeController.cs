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
            ViewData["Message"] = "This is your home";
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
        
    }
}
