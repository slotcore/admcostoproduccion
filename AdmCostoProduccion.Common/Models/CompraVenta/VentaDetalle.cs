using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Models.Inventario;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdmCostoProduccion.Common.Models.CompraVenta
{
    public class VentaDetalle : EntityBase
    {
        #region Constructor
        public VentaDetalle() : base()
        {
        }
        #endregion

        #region Propiedades
        [Key]
        public string VentaDetalleId { get; set; }

        public double Cantidad { get; set; }

        public double PrecioUnitario { get; set; }
        #endregion

        #region Foraneas

        public string VentaId { get; set; }

        public virtual Venta Venta { get; set; }

        public string MercaderiaId { get; set; }

        public virtual Mercaderia Mercaderia { get; set; }

        #endregion

        #region Relacionales

        public virtual ICollection<DespachoDetalle> DespachoDetalles { get; set; }

        #endregion
    }
}
