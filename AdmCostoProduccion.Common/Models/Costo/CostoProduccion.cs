using AdmCostoProduccion.Common.Classes;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdmCostoProduccion.Common.Models.Costo
{
    public class CostoProduccion : EntityBase
    {
        #region Constructor
        public CostoProduccion() : base()
        {
        }
        #endregion

        #region Propiedades
        [Key]
        public int CostoProduccionId { get; set; }

        public string Codigo { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get; set; }

        public double CostoMod { get; set; }

        public double CostoCif { get; set; }

        #endregion

        #region Foraneas

        public int AlmacenId { get; set; }

        
        public virtual Models.Maestro.Almacen Almacen { get; set; }

        public int ConfiguracionValorizacionId { get; set; }

        
        public virtual ConfiguracionValorizacion ConfiguracionValorizacion { get; set; }

        #endregion

        #region Relacionales

        
        public virtual ICollection<CostoOrdenProduccion> CostoOrdenProduccions { get; set; }

        #endregion
    }
}
