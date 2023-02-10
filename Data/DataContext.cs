using Feedback_Service.Models;
using Microsoft.EntityFrameworkCore;

namespace Feedback_Service.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Rating Property Configuration
            modelBuilder.Entity<Rating>()
            .HasKey(e => e.Id);

            modelBuilder.Entity<Rating>()
                .Property(e => e.TitleId)
                .IsRequired();

            //Enum RatingEnum Configuration
            modelBuilder
           .Entity<Rating>()
           .Property(s => s.RatingValue)
           .HasConversion(
               v => v.ToString(),
               v => (RatingEnum)Enum.Parse(typeof(RatingEnum), v));
            modelBuilder.Entity<Rating>().ToTable("ratings");
        }
        public DbSet<Rating> Ratings { get; set; } = default!;
    }
}