using CovidHelp.Data.Entities;
using CovidHelp.Data.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CovidHelp.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser, IdentityRole<long>, long>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<City> Cities { get; set; }

        public DbSet<Province> Provinces { get; set; }

        public DbSet<HelpRequest> HelpRequests { get; set; }

        public DbSet<Tag> Tags { get; set; }

        public override int SaveChanges()
        {
            AddTimestamps();
            return base.SaveChanges();
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            AddTimestamps();
            return await base.SaveChangesAsync();
        }

        protected void AddTimestamps()
        {
            var entries = ChangeTracker
               .Entries()
               .Where(e => e.Entity is EntityBase && (
                       e.State == EntityState.Added
                       || e.State == EntityState.Modified));

            foreach (var entityEntry in entries)
            {
                ((EntityBase)entityEntry.Entity).UpdatedDate = DateTimeOffset.UtcNow;

                if (entityEntry.State == EntityState.Added)
                {
                    ((EntityBase)entityEntry.Entity).CreatedDate = DateTimeOffset.UtcNow;
                }
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<HelpRequestTag>()
                .HasKey(x => new { x.HelpRequestId, x.TagId });
            modelBuilder.Entity<HelpRequestTag>()
                .HasOne(x => x.HelpRequest)
                .WithMany(x => x.Tags)
                .HasForeignKey(x => x.HelpRequestId);
            modelBuilder.Entity<HelpRequestTag>()
                .HasOne(x => x.Tag)
                .WithMany(x => x.HelpRequests)
                .HasForeignKey(x => x.TagId);

            modelBuilder.Entity<HelpRequestItemAppUser>()
                .HasKey(x => new { x.AppUserId, x.HelpRequestItemId });
            modelBuilder.Entity<HelpRequestItemAppUser>()
                .HasOne(x => x.AppUser)
                .WithMany(x => x.HelpedRequests)
                .HasForeignKey(x => x.AppUserId);
            modelBuilder.Entity<HelpRequestItemAppUser>()
                .HasOne(x => x.HelpRequestItem)
                .WithMany(x => x.HelpedBy)
                .HasForeignKey(x => x.HelpRequestItemId);

            modelBuilder.SeedCities();
        }
    }
}
