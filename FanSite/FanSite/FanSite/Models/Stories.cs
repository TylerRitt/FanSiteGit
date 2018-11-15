using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FanSite.Models
{
    public class Stories
    {
        private List<Stories> story = new List<Stories>();
        private List<Comment> comments = new List<Comment>();

        public string Name { get; set; }

        public string Story { get; set; }

        //public string AStoriesComments { get; set; }

        public ICollection<Stories> SavedStories { get { return story; } }
        public ICollection<Comment> Comments { get { return comments; } }

    }
}
