using Microsoft.EntityFrameworkCore;
using GTM.Core.Entities;  // User, Course, LessonPlan sınıfları

namespace GTM.Core.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        // Entity'ler için DbSet tanımları
        public DbSet<User> Users { get; set; }
        public DbSet<AboutUs> AboutUs { get; set; }
        public DbSet<Account> Accounts { get; set; }

        // Model oluşturma yapılandırması (opsiyonel)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Gerekirse burada daha fazla model yapılandırması ekleyebilirsin
        }
    }
}
