using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FanSite.Models;
using Microsoft.EntityFrameworkCore;

namespace FanSite.Repository
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Stories> Story { get; set; }
        public DbSet<Comment> Comments { get; set; }


    }
}
