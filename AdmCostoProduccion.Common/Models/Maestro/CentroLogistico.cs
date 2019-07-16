using AdmCostoProduccion.Common.Classes;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdmCostoProduccion.Common.Models.Maestro
{
    public class CentroLogistico : EntityBase
    {
        #region Constructor
        public CentroLogistico() : base()
        {
        }
        #endregion

        #region Propiedades
        [Key]
        public int CentroLogisticoId { get; set; }

        public string Codigo { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }
        #endregion

        #region Foraneas
        #endregion

        #region Relacionales

        
        public virtual ICollection<Almacen> Almacens { get; set; }

        
        public virtual ICollection<PlantaFabricacion> PlantaFabricacions { get; set; }

        #endregion
    }
}
