using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Models.Maestro;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdmCostoProduccion.Common.Models.Inventario
{
    public class AjusteInventario : EntityBase
    {
        #region Constructor
        public AjusteInventario() : base()
        {
        }
        #endregion

        #region Propiedades
        [Key]
        public string AjusteInventarioId { get; set; }

        public string Codigo { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public DateTime Fecha { get; set; }

        public string Observacion { get; set; }

        #endregion

        #region Foraneas

        public string TipoAjusteInventarioId { get; set; }

        public virtual TipoAjusteInventario TipoAjusteInventario { get; set; }

        public string AlmacenId { get; set; }

        public virtual Almacen Almacen { get; set; }

        #endregion

        #region Relacionales

        public virtual ICollection<AjusteInventarioDetalle> AjusteInventarioDetalles { get; set; }

        public virtual ICollection<Despacho> Despachos { get; set; }

        public virtual ICollection<Recepcion> Recepcions { get; set; }

        #endregion
    }
}
