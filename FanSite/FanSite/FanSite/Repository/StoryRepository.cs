using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FanSite.Models;
using Microsoft.EntityFrameworkCore;


namespace FanSite.Repository
{
    public class StoryRepository : IStoryRepository
    {
        private AppDbContext context;

        public IQueryable<Stories> Story
        {
            get
            {
                return context.Story.Include("Stories").Include("Comment");
            }
        }

        public StoryRepository(AppDbContext appDbContext)
        {
            context = appDbContext;
        }

        public void AddStory(Stories stories)
        {
            context.Story.Add(stories);
            context.SaveChanges();
        }

        public void AddComment(Stories stories, Comment comment)
        {
            stories.Comments.Add(comment);
            context.Story.Update(stories);
            context.SaveChanges();
        }

        public Stories GetStoriesByName(string name)
        {
            Stories stories;
            stories = context.Story.First(s => s.Name == name);
            return stories;

        }
    }
}
