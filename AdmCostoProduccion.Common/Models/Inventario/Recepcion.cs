using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Models.CompraVenta;
using AdmCostoProduccion.Common.Models.Produccion;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdmCostoProduccion.Common.Models.Inventario
{
    public class Recepcion : EntityBase
    {
        #region Constructor
        public Recepcion() : base()
        {
        }
        #endregion

        #region Propiedades
        [Key]
        public int RecepcionId { get; set; }

        public string Codigo { get; set; }

        public string Observacion { get; set; }
        #endregion

        #region Foraneas

        public int TipoRecepcionId { get; set; }

        
        public virtual TipoRecepcion TipoRecepcion { get; set; }

        public int AlmacenId { get; set; }

        
        public virtual Maestro.Almacen Almacen { get; set; }

        public int OrdenProduccionId { get; set; }

        
        public virtual OrdenProduccion OrdenProduccion { get; set; }

        public int CompraId { get; set; }

        public virtual Compra Compra { get; set; }

        #endregion

        #region Relacionales


        
        public virtual ICollection<RecepcionDetalle> RecepcionDetalles { get; set; }
        #endregion
    }
}
