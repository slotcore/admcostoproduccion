using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Models.CompraVenta;
using AdmCostoProduccion.Common.Models.Produccion;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdmCostoProduccion.Common.Models.Inventario
{
    public class DespachoDetalle : EntityBase
    {
        #region Constructor
        public DespachoDetalle() : base()
        {
        }
        #endregion

        #region Propiedades

        [Key]
        public string DespachoDetalleId { get; set; }

        public double Cantidad { get; set; }

        #endregion

        #region Foraneas

        public string DespachoId { get; set; }

        
        public virtual Despacho Despacho { get; set; }

        public string MercaderiaId { get; set; }

        
        public virtual Mercaderia Mercaderia { get; set; }

        public string UnidadMedidaId { get; set; }

        
        public virtual UnidadMedida UnidadMedida { get; set; }

        public string AjusteInventarioDetalleId { get; set; }

        public virtual AjusteInventarioDetalle AjusteInventarioDetalle { get; set; }

        public string OrdenProduccionInsumoId { get; set; }

        public virtual OrdenProduccionInsumo OrdenProduccionInsumo { get; set; }

        public string VentaDetalleId { get; set; }

        public virtual VentaDetalle VentaDetalle { get; set; }

        #endregion

        #region Relacionales

        public virtual ICollection<KardexMovimiento> KardexMovimientos { get; set; }

        #endregion
    }
}
