using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FanSite.Models;

namespace FanSite.Repository
{
    public class FakeStoryRepo
    {
        private static List<Stories> stories = new List<Stories>();

        public static List<Stories> Stories { get { return stories; } }

        static FakeStoryRepo()
        {
            AddData();
        }


        public static void AddStory(Stories story)
        {
            stories.Add(story);
        }

        public static Stories GetStoryByName(string name)
        {
            Stories story = stories.Find(s => s.Name == name);
            return story;
        }

        static void AddData()
        {
            Stories story = new Stories()
            {
                Name = "Life of Steve Jobs",
                Story = "Steve jobs was a frutitarian"
            };
            Stories.Add(story);

            story = new Stories()
            {
                Name = "The Creation of Apple",
                Story = "Apple was created in 1976"
            };
            Stories.Add(story);

            story = new Stories()
            {
                Name = "The Legend of Steve Jobs",
                Story = "Steve Jobs Was CEO of Apple"
            };

            Stories.Add(story);

            Comment comment = new Comment()
            {
                AStoriesComments = "Super generic comment"
            };

            story.Comments.Add(comment);

            Comment newComment = new Comment()
            {
                AStoriesComments = "A Random Comment"
            };

            story.Comments.Add(newComment);


        }

 
    }
}
