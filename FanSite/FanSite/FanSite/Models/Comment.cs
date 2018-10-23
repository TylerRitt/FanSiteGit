using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FanSite.Models
{
    public class Comment
    {
        private List<Comment> comment = new List<Comment>();

        public string AStoriesComments { get; set; }

        public List<Comment> Comments { get { return comment; } }



    }
}
