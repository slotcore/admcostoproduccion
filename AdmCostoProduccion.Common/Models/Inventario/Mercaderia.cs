using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Models.CompraVenta;
using AdmCostoProduccion.Common.Models.Produccion;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdmCostoProduccion.Common.Models.Inventario
{
    public class Mercaderia : EntityBase
    {
        #region Constructor
        public Mercaderia() : base()
        {
        }
        #endregion

        #region Propiedades
        [Key]
        public string MercaderiaId { get; set; }

        public string Codigo { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }
        #endregion

        #region Foraneas

        public string TipoMercaderiaId { get; set; }

        
        public virtual TipoMercaderia TipoMercaderia { get; set; }

        #endregion

        #region Relacionales

        
        public virtual ICollection<ProcedimientoProduccion> ProcedimientoProduccions { get; set; }

        
        public virtual ICollection<ProcedimientoProduccionInsumo> ProcedimientoProduccionInsumos { get; set; }

        
        public virtual ICollection<OrdenProduccion> OrdenProduccions { get; set; }

        
        public virtual ICollection<OrdenProduccionInsumo> OrdenProduccionInsumos { get; set; }

        
        public virtual ICollection<OrdenServicio> OrdenServicios { get; set; }

        
        public virtual ICollection<RecepcionDetalle> RecepcionDetalles { get; set; }

        
        public virtual ICollection<DespachoDetalle> DespachoDetalles { get; set; }

        
        public virtual ICollection<KardexMovimiento> KardexMovimientos { get; set; }

        public virtual ICollection<CompraDetalle> CompraDetalles { get; set; }  

        public virtual ICollection<VentaDetalle> VentaDetalles { get; set; }

        #endregion
    }
}
