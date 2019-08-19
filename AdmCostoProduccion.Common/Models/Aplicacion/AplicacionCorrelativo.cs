using AdmCostoProduccion.Common.Classes;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdmCostoProduccion.Common.Models.Aplicacion
{
    public class AplicacionCorrelativo : EntityBase
    {
        #region Constructor
        public AplicacionCorrelativo() : base()
        {
        }
        #endregion

        #region Propiedades
        [Key]
        public string AplicacionCorrelativoId { get; set; }

        public string Codigo { get; set; }

        public string Nombre { get; set; }

        public string Prefijo { get; set; }

        public int NumeroDigitos { get; set; }

        public int Correlativo { get; set; }
        #endregion

        #region Foraneas
        #endregion

        #region Relacionales
        #endregion
    }
}
