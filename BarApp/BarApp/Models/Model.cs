using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BarApp.Models
{
    public class DrinkContext : DbContext
    {
        public DrinkContext(DbContextOptions<DrinkContext> options)
            : base(options)
        { }

        public DbSet<Drink> Drinks { get; set; }
        public DbSet<Post> Posts { get; set; }
    }

    public class Drink
    {
        public int DrinkId { get; set; }
        public string Drinks { get; set; }

        public List<Post> Posts { get; set; }
    }

    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int DrinkId { get; set; }
        public Drink Drink { get; set; }
    }
}
