using System;
using System.ComponentModel.DataAnnotations;

namespace AdmCostoProduccion.Common.Classes
{
    public class EntityBase
    {
        #region Constructor
        public EntityBase()
        {
            FechaCreacion = DateTime.Now;
            FechaUltimaActualizacion = DateTime.Now;
        }
        #endregion

        #region Propiedades Trazabilidad
        [ScaffoldColumn(false)]
        public string UsuarioCreacion { get; set; }

        [ScaffoldColumn(false)]
        public DateTime FechaCreacion { get; set; }

        [ScaffoldColumn(false)]
        public string UsuarioUltimaActualizacion { get; set; }

        [ScaffoldColumn(false)]
        public DateTime? FechaUltimaActualizacion { get; set; }

        [ScaffoldColumn(false)]
        public bool Eliminado { get; set; }
        #endregion

    }
}
