using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FanSite.Models
{
    public class StoriesRepo
    {
        private static List<Stories> stories = new List<Stories>();

        public static List<Stories> Stories { get { return stories; } }
        
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
                Name = "The creation of apple",
                Story = "Apple was created in 1976"
            };
            Stories.Add(story);
        }

    }
}
