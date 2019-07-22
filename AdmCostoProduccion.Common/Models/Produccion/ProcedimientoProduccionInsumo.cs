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
        public int ProcedimientoProduccionInsumoId { get; set; }

        public double Cantidad { get; set; }

        #endregion

        #region Foraneas

        public int MercaderiaId { get; set; }

        
        public virtual Mercaderia Mercaderia { get; set; }

        public int UnidadMedidaId { get; set; }

        
        public virtual UnidadMedida UnidadMedida { get; set; }

        #endregion

        #region Relacionales
        #endregion
    }
}
