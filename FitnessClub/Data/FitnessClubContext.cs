using FitnessClub.Models;
using Microsoft.EntityFrameworkCore;

namespace FitnessClub.Data
{
    public class FitnessClubContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<MembershipPlan> MembershipPlans { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost;Database=Wombat;Username=dummy;Password=dumbby");
    }
}