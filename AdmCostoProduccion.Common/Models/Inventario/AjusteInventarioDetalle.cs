using AdmCostoProduccion.Common.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdmCostoProduccion.Common.Models.Inventario
{
    public class AjusteInventarioDetalle : EntityBase
    {
        #region Constructor
        public AjusteInventarioDetalle() : base()
        {
        }
        #endregion

        #region Propiedades

        [Key]
        public string AjusteInventarioDetalleId { get; set; }

        public double Cantidad { get; set; }

        public double Costo { get; set; }

        #endregion

        #region Foraneas

        public string AjusteInventarioId { get; set; }

        public virtual AjusteInventario AjusteInventario { get; set; }

        public string MercaderiaId { get; set; }

        public virtual Mercaderia Mercaderia { get; set; }

        public string UnidadMedidaId { get; set; }

        public virtual UnidadMedida UnidadMedida { get; set; }

        #endregion

        #region Relacionales

        public virtual ICollection<DespachoDetalle> DespachoDetalles { get; set; }

        public virtual ICollection<RecepcionDetalle> RecepcionDetalles { get; set; }

        #endregion
    }
}
