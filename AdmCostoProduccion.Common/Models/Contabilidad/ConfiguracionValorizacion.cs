using AdmCostoProduccion.Common.Classes;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdmCostoProduccion.Common.Models.Contabilidad
{
    public class ConfiguracionValorizacion : EntityBase
    {
        #region Constructor
        public ConfiguracionValorizacion() : base()
        {
        }
        #endregion

        #region Propiedades
        [Key]
        public int ConfiguracionValorizacionId { get; set; }

        public string Codigo { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }
        #endregion

        #region Foraneas

        public int MetodoValorizacionId { get; set; }

        
        public virtual MetodoValorizacion MetodoValorizacion { get; set; }

        public int DistribucionValorizacionId { get; set; }

        
        public virtual DistribucionValorizacion DistribucionValorizacion { get; set; }

        #endregion

        #region Relacionales

        
        public virtual ICollection<CostoProduccion> CostoProduccions { get; set; }

        #endregion
    }
}
