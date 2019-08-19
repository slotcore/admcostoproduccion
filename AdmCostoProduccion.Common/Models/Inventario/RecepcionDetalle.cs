using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Models.CompraVenta;
using AdmCostoProduccion.Common.Models.Produccion;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdmCostoProduccion.Common.Models.Inventario
{
    public class RecepcionDetalle : EntityBase
    {
        #region Constructor
        public RecepcionDetalle() : base()
        {
        }
        #endregion

        #region Propiedades
        [Key]
        public string RecepcionDetalleId { get; set; }

        public double Cantidad { get; set; }
        #endregion

        #region Foraneas

        public string RecepcionId { get; set; }

        
        public virtual Recepcion Recepcion { get; set; }

        public string MercaderiaId { get; set; }

        
        public virtual Mercaderia Mercaderia { get; set; }

        public string UnidadMedidaId { get; set; }

        
        public virtual UnidadMedida UnidadMedida { get; set; }

        public string OrdenProduccionInsumoId { get; set; }
        
        public virtual OrdenProduccionInsumo OrdenProduccionInsumo { get; set; }

        public string CompraDetalleId { get; set; }

        public virtual CompraDetalle CompraDetalle { get; set; }

        #endregion

        #region Relacionales


        public virtual ICollection<KardexMovimiento> KardexMovimientos { get; set; }

        #endregion
    }
}
