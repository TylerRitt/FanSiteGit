using System;
using Xunit;
using FanSite.Models;
namespace Tests
{
    public class StoriesTests
    {
        [Fact]
        public void TestStoryNameGetterSetter()
        {
            Stories stories = new Stories();
            stories.Name = "The Life of Steve Jobs";

            Assert.Equal("The Life of Steve Jobs" , stories.Name);
        }

        [Fact]
        public void TestStoryStoryGetterSetter()
        {
            Stories stories = new Stories();
            stories.Story = "A story about Steve Jobs";

            Assert.Equal("A story about Steve Jobs", stories.Story);
        }

        [Fact]
        public void TestOverridingName()
        {
            Stories stories = new Stories();
            stories.Name = "The Life of Steve Jobs";

            Assert.Equal("The Life of Steve Jobs", stories.Name);

            stories.Name = "This is a different story title";

            Assert.Equal("This is a different story title", stories.Name);

        }
        [Fact]
        public void TestOverridingStory()
        {
            Stories stories = new Stories();
            stories.Story = "A story about Steve Jobs";

            Assert.Equal("A story about Steve Jobs", stories.Story);

            stories.Story = "A different story about Steve Jobs";

            Assert.Equal("A different story about Steve Jobs", stories.Story);
        }
      
    }
}
