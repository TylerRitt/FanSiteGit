using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FanSite.Models;

namespace FanSite.Repository
{
    public interface IStoryRepository
    {
        IQueryable<Stories> Story { get; }

        void AddStory(Stories stories);
        void AddComment(Stories stories, Comment comment);

        Stories GetStoriesByName(string name);




    }
}
