using ImdbFilmArsiv.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ImdbFilmArsiv.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<MovieViewModel> Movies { get; set; }

        private readonly IConfiguration _configuration;

        // Constructor ile IConfiguration alınır
        public AppDbContext(DbContextOptions<AppDbContext> options, IConfiguration configuration)
            : base(options)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // ConnectionString'i appsettings.json'dan al
                var connectionString = _configuration.GetConnectionString("DefaultConnection");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
    }
}
