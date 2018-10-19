using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FanSite.Models
{
    public class Stories
    {
        private List<Stories> story = new List<Stories>();

        public string Name { get; set; }
        public string Story { get; set; }

        public List<Stories> SavedStories { get { return story; } }


    }
}
