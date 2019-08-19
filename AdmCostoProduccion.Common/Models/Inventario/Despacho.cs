using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Models.CompraVenta;
using AdmCostoProduccion.Common.Models.Produccion;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdmCostoProduccion.Common.Models.Inventario
{
    public class Despacho : EntityBase
    {
        #region Constructor
        public Despacho() : base()
        {
        }
        #endregion

        #region Propiedades

        [Key]
        public string DespachoId { get; set; }

        public string Codigo { get; set; }

        public string Observacion { get; set; }

        #endregion

        #region Foraneas

        public string TipoDespachoId { get; set; }

        public virtual TipoDespacho TipoDespacho { get; set; }

        public string AlmacenId { get; set; }

        public virtual Maestro.Almacen Almacen { get; set; }

        public string OrdenProduccionId { get; set; }

        public virtual OrdenProduccion OrdenProduccion { get; set; }

        public string VentaId { get; set; }

        public virtual Venta Venta { get; set; }

        #endregion

        #region Relacionales

        public virtual ICollection<DespachoDetalle> DespachoDetalles { get; set; }

        #endregion
    }
}
