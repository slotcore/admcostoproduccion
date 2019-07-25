using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Models.Almacen;
using AdmCostoProduccion.Common.Models.CompraVenta;
using AdmCostoProduccion.Common.Models.Inventario;
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
        public int DespachoDetalleId { get; set; }

        public double Cantidad { get; set; }

        #endregion

        #region Foraneas

        public int DespachoId { get; set; }

        
        public virtual Despacho Despacho { get; set; }

        public int MercaderiaId { get; set; }

        
        public virtual Mercaderia Mercaderia { get; set; }

        public int UnidadMedidaId { get; set; }

        
        public virtual UnidadMedida UnidadMedida { get; set; }

        public int? OrdenProduccionInsumoId { get; set; }

        public virtual OrdenProduccionInsumo OrdenProduccionInsumo { get; set; }

        public int? VentaDetalleId { get; set; }

        public virtual VentaDetalle VentaDetalle { get; set; }

        #endregion

        #region Relacionales

        public virtual ICollection<KardexMovimiento> KardexMovimientos { get; set; }

        #endregion
    }
}
