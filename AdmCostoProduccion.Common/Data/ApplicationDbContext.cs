using AdmCostoProduccion.Common.Models.Almacen;
using AdmCostoProduccion.Common.Models.Maestro;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmCostoProduccion.Common.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); // This needs to go before the other rules!

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Entity<DespachoDetalle>()
                .HasRequired(f => f.Mercaderia)
                .WithRequiredDependent()
                .WillCascadeOnDelete(false);
        }

        public DbSet<CentroLogistico> CentroLogisticos { get; set; }
        public DbSet<Almacen> Almacens { get; set; }
        public DbSet<PlantaFabricacion> PlantaFabricacions { get; set; }
    }
}
