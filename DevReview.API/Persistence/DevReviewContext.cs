using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevReview.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace DevReview.API.Persistence
{
    public class DevReviewContext : DbContext
    {
        public DevReviewContext(DbContextOptions<DevReviewContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; private set; }
        public DbSet<Review> Reviews { get; private set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<Product>()
                .HasMany(p => p.Reviews)
                .WithOne()
                .HasForeignKey(r => r.ProductId);

            modelBuilder.Entity<Review>()
                .HasKey(r => r.Id);
        }
    }
}
