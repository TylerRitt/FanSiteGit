using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FanSite.Models;
using FanSite.Repository;


namespace FanSite.Controllers
{
    public class StoriesController : Controller
    {
        IStoryRepository repo;
        public StoriesController(IStoryRepository r)
        {
            repo = r; 
        }

        public IActionResult Index()
        {
            List<Stories> story = StoriesRepo.Stories;
            // Lambda sort
            story.Sort((s1, s2) => string.Compare(s1.Name, s2.Name, StringComparison.Ordinal));
            // view bag one
            ViewBag.newestStory = story[story.Count - 1].Name;
            // another viewdata
            ViewData["StoriesCount"] = story.Count;

            return View(story);
           
        }
        // returns add story view
        public IActionResult AddStory()
        {
            return View();
        }
        // returns add comment view
        public IActionResult AddComment()
        {
            return View();
        }
        // post request for adding a story 
        [HttpPost]
        public RedirectToActionResult AddStory(string name, string story)
        {
            Stories stories = new Stories { Name = name, Story = story };
            StoriesRepo.AddStory(stories);

            return RedirectToAction("Index");
        }
        // post request for adding a comment
        [HttpPost]
        public RedirectToActionResult AddComment(string commentText)
        {
            Comment stories = new Comment { AStoriesComments = commentText };
            CommentRepo.AddComment(stories);

            return RedirectToAction("Index");
        }

    }
}