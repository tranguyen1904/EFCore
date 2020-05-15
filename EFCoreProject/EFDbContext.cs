using EFCoreProject.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreProject
{
    public class EFDbContext : DbContext
    {
        public EFDbContext(DbContextOptions<EFDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Video> Video { get; set; }
        public virtual DbSet<Comment> Comment { get; set; }
        public virtual DbSet<ActivityStream> ActivityStream { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.Nickname)
                .IsUnique();
                entity.HasIndex(e => e.Mail)
                .IsUnique();
            });

            modelBuilder.Entity<Video>(entity=> 
            {
                entity.Property(e => e.Quality).HasConversion<int>();
                entity.HasOne(e => e.User)
                .WithMany(e => e.Videos)
                .HasForeignKey(e => e.UserId);
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.HasOne(e => e.User)
                .WithMany(e => e.Comments)
                .HasForeignKey(e => e.UserId);

                entity.HasOne(e => e.Video)
                .WithMany(e => e.Comments)
                .HasForeignKey(e => e.VideoId);
            });

            modelBuilder.Entity<ActivityStream>(entity =>
            {
                entity.HasOne(e => e.User)
                .WithOne(e => e.ActivityStream)
                .HasForeignKey<ActivityStream>(e => e.UserId);
            });

            modelBuilder.Entity<ActivityDetail>(entity =>
            {
                entity.HasOne(e => e.ActivityStream)
                .WithMany(e => e.ActivityDetails)
                .HasForeignKey(e => e.ActivityStreamId);

                entity.HasOne(e => e.Video)
                .WithMany(e => e.ActivityDetails)
                .HasForeignKey(e => e.VideoId);
            });
            base.OnModelCreating(modelBuilder);
        }

    }
}
