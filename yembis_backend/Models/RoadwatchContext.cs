using Microsoft.EntityFrameworkCore;

namespace yembis_backend.Models
{
    public class RoadwatchContext:DbContext
    {

        public RoadwatchContext(DbContextOptions option) : base(option) 
        { 
                
        } 

        public DbSet<Location> Locations { get; set; }

        public DbSet<Camera> Cameras { get; set; }
        public DbSet<Meting> Metings { get; set; }
        public DbSet<Type> Types { get; set; }

        protected override void ConfigureConventions(ModelConfigurationBuilder builder)
        {

            builder.Properties<DateOnly>()
                .HaveConversion<DateOnlyConverter>()
                .HaveColumnType("date");

            base.ConfigureConventions(builder);

        }

    }
}
