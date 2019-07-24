using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Models.Almacen;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdmCostoProduccion.Common.Models.Inventario
{
    public class TipoMovimiento : EntityBase
    {
        #region Constructor
        public TipoMovimiento() : base()
        {
        }
        #endregion

        #region Propiedades
        [Key]
        public int TipoMovimientoId { get; set; }

        public string Codigo { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }
        #endregion

        #region Foraneas
        #endregion

        #region Relacionales

        
        public virtual ICollection<KardexMovimiento> KardexMovimientos { get; set; }

        #endregion
    }
}
