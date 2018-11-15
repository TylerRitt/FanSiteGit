using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FanSite.Models;

namespace FanSiteTests
{
    public class CommentTests
    {
       [Fact]
       public void TestAStoriesCommentsGetSet()
       {
            Comment comment = new Comment();

            comment.AStoriesComments = "This was a great story to read!";

            Assert.Equal("This was a great story to read!", comment.AStoriesComments);

       }




    }
}
