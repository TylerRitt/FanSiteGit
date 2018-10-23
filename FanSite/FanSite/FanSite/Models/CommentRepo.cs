using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FanSite.Models
{
    public class CommentRepo
    {
       private static List<Comment> comments = new List<Comment>();

       public static List<Comment> Comments { get { return comments; }}

        static CommentRepo()
        {
            AddData();
        }

        public static void AddComment(Comment comment)
        {
            comments.Add(comment);
        }

        static void AddData()
        {
            Comment comment;

            comment = new Comment()
            {
                AStoriesComments = "Some comments and stuff"
            };

            comment.Comments.Add(comment);       
        }
    }
}
