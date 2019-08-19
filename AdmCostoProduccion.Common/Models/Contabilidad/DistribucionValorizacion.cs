using AdmCostoProduccion.Common.Classes;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdmCostoProduccion.Common.Models.Contabilidad
{
    public class DistribucionValorizacion : EntityBase
    {
        #region Constructor
        public DistribucionValorizacion() : base()
        {
        }
        #endregion

        #region Propiedades
        [Key]
        public string DistribucionValorizacionId { get; set; }

        public string Codigo { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }
        #endregion

        #region Foraneas
        #endregion

        #region Relacionales

        
        public virtual ICollection<ConfiguracionValorizacion> ConfiguracionValorizacions { get; set; }

        #endregion
    }
}
