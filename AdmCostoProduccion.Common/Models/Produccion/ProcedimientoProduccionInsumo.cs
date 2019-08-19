using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Models.Inventario;

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdmCostoProduccion.Common.Models.Produccion
{
    public class ProcedimientoProduccionInsumo : EntityBase
    {
        #region Constructor
        public ProcedimientoProduccionInsumo() : base()
        {
        }
        #endregion

        #region Propiedades
        [Key]
        public string ProcedimientoProduccionInsumoId { get; set; }

        public double Cantidad { get; set; }

        #endregion

        #region Foraneas

        public string ProcedimientoProduccionId { get; set; }

        public virtual ProcedimientoProduccion ProcedimientoProduccion { get; set; }

        public string MercaderiaId { get; set; }

        
        public virtual Mercaderia Mercaderia { get; set; }

        public string UnidadMedidaId { get; set; }

        
        public virtual UnidadMedida UnidadMedida { get; set; }

        #endregion

        #region Relacionales
        #endregion
    }
}
