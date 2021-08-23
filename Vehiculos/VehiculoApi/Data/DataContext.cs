using Microsoft.EntityFrameworkCore;
using VehiculoApi.Data.Entities;

namespace VehiculoApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<VehicleType> vehicleTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) //aca creamos una exprecion unica que no se repitan la descripciones 
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<VehicleType>().HasIndex(x => x.Description).IsUnique();//exprecioon lamda se indica indice unico
        }

    }
}
