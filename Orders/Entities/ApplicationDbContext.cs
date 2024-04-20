using Microsoft.EntityFrameworkCore;

namespace Orders.Entities
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Register all tables to use in orders app 
        public DbSet<OrderEntity> Orders { get; set; }
        public DbSet<ShoppingEntity> Shopping_car {  get; set; }
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<PaymentsEntity> Payments { get; set; }
        public DbSet<LocationEntity> Locations { get; set; }
        public DbSet<TrackingEntity> Trackings { get; set; }

        // It is necesarry if you has compost keys
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LocationEntity>()
                .HasKey(l => new { l.CountryCode, l.DepartmentCode, l.CityCode });
        }
    }
}
