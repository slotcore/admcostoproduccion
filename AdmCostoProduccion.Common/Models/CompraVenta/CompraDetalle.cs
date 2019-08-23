using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Models.Inventario;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdmCostoProduccion.Common.Models.CompraVenta
{
    public class CompraDetalle : EntityBase
    {
        #region Constructor
        public CompraDetalle() : base()
        {
        }
        #endregion

        #region Propiedades
        [Key]
        public string CompraDetalleId { get; set; }

        public double Cantidad { get; set; }

        public double PrecioUnitario { get; set; }

        public double PrecioTotal { get; set; }
        #endregion

        #region Foraneas

        public string CompraId { get; set; }

        public virtual Compra Compra { get; set; }

        public string MercaderiaId { get; set; }

        public virtual Mercaderia Mercaderia { get; set; }

        public string UnidadMedidaId { get; set; }

        public virtual UnidadMedida UnidadMedida { get; set; }
        #endregion

        #region Relacionales

        public virtual ICollection<RecepcionDetalle> RecepcionDetalles { get; set; }

        #endregion
    }
}
