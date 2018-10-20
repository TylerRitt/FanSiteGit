using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FanSite.Controllers
{
    public class StoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddStory()
        {
            return View();
        }
    }
}