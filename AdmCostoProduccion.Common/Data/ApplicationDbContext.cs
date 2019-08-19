using AdmCostoProduccion.Common.Models.Aplicacion;
using AdmCostoProduccion.Common.Models.CompraVenta;
using AdmCostoProduccion.Common.Models.Contabilidad;
using AdmCostoProduccion.Common.Models.Inventario;
using AdmCostoProduccion.Common.Models.Maestro;
using AdmCostoProduccion.Common.Models.Produccion;
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
                .HasRequired(d => d.Mercaderia)
                .WithMany(m => m.DespachoDetalles)
                .HasForeignKey(d => d.MercaderiaId)
                .WillCascadeOnDelete(false);

        }

        public DbSet<AplicacionConfiguracion> AplicacionConfiguracions { get; set; }
        public DbSet<AplicacionCorrelativo> AplicacionCorrelativos { get; set; }
        public DbSet<CentroLogistico> CentroLogisticos { get; set; }
        public DbSet<Almacen> Almacens { get; set; }
        public DbSet<PlantaFabricacion> PlantaFabricacions { get; set; }
        public DbSet<UnidadMedida> UnidadMedidas { get; set; }
        public DbSet<TipoMercaderia> TipoMercaderias { get; set; }
        public DbSet<Mercaderia> Mercaderias { get; set; }
        public DbSet<TipoDespacho> TipoDespachos { get; set; }
        public DbSet<TipoMovimiento> TipoMovimientos { get; set; }
        public DbSet<TipoRecepcion> TipoRecepcions { get; set; }
        public DbSet<ProcedimientoProduccion> ProcedimientoProduccions { get; set; }
        public DbSet<ProcedimientoProduccionInsumo> ProcedimientoProduccionInsumos { get; set; }
        public DbSet<Despacho> Despachos { get; set; }
        public DbSet<DespachoDetalle> DespachoDetalles { get; set; }
        public DbSet<Recepcion> Recepcions { get; set; }
        public DbSet<RecepcionDetalle> RecepcionDetalles { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<VentaDetalle> VentaDetalles { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<CompraDetalle> CompraDetalles { get; set; }
        public DbSet<OrdenProduccion> OrdenProduccions { get; set; }
        public DbSet<OrdenProduccionInsumo> OrdenProduccionInsumos { get; set; }
        public DbSet<CostoProduccion> CostoProduccions { get; set; }
        public DbSet<CostoOrdenProduccion> CostoOrdenProduccions { get; set; }
        public DbSet<ConfiguracionValorizacion> ConfiguracionValorizacions { get; set; }
        public DbSet<OrdenServicio> OrdenServicios { get; set; }
        public DbSet<Kardex> Kardexs { get; set; }
        public DbSet<KardexMovimiento> KardexMovimientos { get; set; }
    }
}
