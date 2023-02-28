using Microsoft.EntityFrameworkCore;
using TeamLeadHelp.Models;

namespace TeamLeadHelp.Data
{
    public class DevTaskContext : DbContext
    {
        public DevTaskContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<DevTask> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DevTask>()
                .Property(d => d.Title)
                .IsRequired()
                .HasMaxLength(25);

            modelBuilder.Entity<DevTask>()
                .Property(d => d.Description)
                .IsRequired()
                .HasDefaultValue("Description To be added at a later time")
                .HasMaxLength(1000)
                .IsUnicode(true)
                .IsFixedLength(false);

            modelBuilder.Entity<DevTask>()
                .Property(d => d.HoursEstimated)
                .IsRequired();

            modelBuilder.Entity<DevTask>()
                .Property(d => d.WorkedHours)
                .HasDefaultValue(null);

            modelBuilder.Entity<DevTask>()
                .Property(d => d.IsFinished)
                .HasDefaultValue(false);

            modelBuilder.Entity<DevTask>()
                .Property(d => d.OnHold)
                .HasDefaultValue(false);

            
        }
    }
}
