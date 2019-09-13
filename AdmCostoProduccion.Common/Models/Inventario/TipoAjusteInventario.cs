using AdmCostoProduccion.Common.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdmCostoProduccion.Common.Models.Inventario
{
    public class TipoAjusteInventario : EntityBase
    {
        #region Constructor
        public TipoAjusteInventario() : base()
        {
        }
        #endregion

        #region Propiedades
        [Key]
        public string TipoAjusteInventarioId { get; set; }

        public string Codigo { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }
        #endregion

        #region Foraneas
        #endregion

        #region Relacionales

        public virtual ICollection<AjusteInventario> AjusteInventarios { get; set; }

        #endregion
    }
}
