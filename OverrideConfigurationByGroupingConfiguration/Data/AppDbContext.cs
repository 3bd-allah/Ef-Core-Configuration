﻿using ConfigurationByConvention.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using OverrideConfigurationByGroupingConfiguration.Data.Config;


namespace ConfigurationByConvention.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { set; get; } = null!;     
        public DbSet<Tweet> Tweets { set; get; } = null!;
        public DbSet<Comment> Comments{ set; get; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // individual call 
            new UserConfiguration().Configure(modelBuilder.Entity<User>());
            new TweetConfiguration().Configure(modelBuilder.Entity<Tweet>());
            new CommentConfiguration().Configure(modelBuilder.Entity<Comment>());

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            var connectionString = config.GetSection("constr").Value;
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
