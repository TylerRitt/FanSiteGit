using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FanSite.Models;

namespace FanSite.Controllers
{
    public class CommentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddComment()
        {
            return View();
        }

        /*[HttpPost]
        public RedirectToActionResult AddComment(string commentText)
        {
            Comment stories = new Comment { AStoriesComments = commentText };
            CommentRepo.AddComment(stories);    

            return RedirectToAction("Index");
        }*/
    }
}