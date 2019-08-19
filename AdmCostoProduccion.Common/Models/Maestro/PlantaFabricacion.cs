using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Models.Contabilidad;
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
        public string PlantaFabricacionId { get; set; }

        public string Codigo { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }
        #endregion

        #region Foraneas

        public string CentroLogisticoId { get; set; }

        
        public virtual CentroLogistico CentroLogistico { get; set; }

        #endregion

        #region Relacionales
                
        public virtual ICollection<OrdenProduccion> OrdenProduccions { get; set; }

        public virtual ICollection<CostoProduccion> CostoProduccions { get; set; }

        #endregion
    }
}
