using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Models.Produccion;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdmCostoProduccion.Common.Models.Maestro
{
    public class PlantaFabricacion : EntityBase
    {
        #region Constructor
        public PlantaFabricacion() : base()
        {
        }
        #endregion

        #region Propiedades
        [Key]
        public int PlantaFabricacionId { get; set; }

        public string Codigo { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }
        #endregion

        #region Foraneas

        public int CentroLogisticoId { get; set; }

        
        public virtual CentroLogistico CentroLogistico { get; set; }

        #endregion

        #region Relacionales

        
        public virtual ICollection<OrdenProduccion> OrdenProduccions { get; set; }

        #endregion
    }
}
