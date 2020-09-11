using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web; 

namespace ShipMedicineFast.Models
{
    public class DbContextMedicine:DbContext
    {
        public DbContextMedicine() : base("DbMedicine")
        {

        }

        public DbSet<ConfigSite> ConfigSites { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<FeedBack> FeedBacks { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<PostCategory> PostCategories { get; set; }
        public DbSet<Post> Posts { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}