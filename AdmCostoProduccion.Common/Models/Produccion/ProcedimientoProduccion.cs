using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Models.Inventario;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdmCostoProduccion.Common.Models.Produccion
{
    public class ProcedimientoProduccion : EntityBase
    {
        #region Constructor
        public ProcedimientoProduccion() : base()
        {
        }
        #endregion

        #region Propiedades

        [Key]
        public string ProcedimientoProduccionId { get; set; }

        public string Codigo { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public double Cantidad { get; set; }

        #endregion

        #region Foraneas

        public string MercaderiaId { get; set; }

        
        public virtual Mercaderia Mercaderia { get; set; }

        public string UnidadMedidaId { get; set; }

        
        public virtual UnidadMedida UnidadMedida { get; set; }

        #endregion

        #region Relacionales

        public virtual ICollection<ProcedimientoProduccionInsumo> ProcedimientoProduccionInsumos { get; set; }
        
        public virtual ICollection<OrdenProduccion> OrdenProduccions { get; set; }

        #endregion
    }
}
