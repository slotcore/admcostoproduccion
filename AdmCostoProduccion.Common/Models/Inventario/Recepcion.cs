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
        public string RecepcionId { get; set; }

        public string Codigo { get; set; }

        public DateTime Fecha { get; set; }

        public string Observacion { get; set; }
        #endregion

        #region Foraneas

        public string TipoRecepcionId { get; set; }
                
        public virtual TipoRecepcion TipoRecepcion { get; set; }

        public string AlmacenId { get; set; }
                
        public virtual Maestro.Almacen Almacen { get; set; }

        public string InventarioInicialId { get; set; }

        public virtual InventarioInicial InventarioInicial { get; set; }

        public string AjusteInventarioId { get; set; }

        public virtual AjusteInventario AjusteInventario { get; set; }

        public string OrdenProduccionId { get; set; }
                
        public virtual OrdenProduccion OrdenProduccion { get; set; }

        public string CompraId { get; set; }

        public virtual Compra Compra { get; set; }

        #endregion

        #region Relacionales


        
        public virtual ICollection<RecepcionDetalle> RecepcionDetalles { get; set; }
        #endregion
    }
}
