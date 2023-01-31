using Microsoft.EntityFrameworkCore;
using yembis_backend.Entities;
using yembis_backend.Models;

namespace yembis_backend.Helpers
{
    public class RoadwatchContext : DbContext
    {

        private readonly IConfiguration Configuration;

        public RoadwatchContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // in memory database used for simplicity, change to a real db for production applications
            options.UseInMemoryDatabase("yembis_backendContext");
        }



        public DbSet<Location> Locations { get; set; }

        public DbSet<Camera> Cameras { get; set; }
        public DbSet<Meting> Metings { get; set; }
        public DbSet<Categorie> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<SpeedLimit> SpeedLimits { get; set; }

        protected override void ConfigureConventions(ModelConfigurationBuilder builder)
        {

            builder.Properties<DateOnly>()
                .HaveConversion<DateOnlyConverter>()
                .HaveColumnType("date");

            base.ConfigureConventions(builder);

        }

      

    }
}
