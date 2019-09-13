using AdmCostoProduccion.Common.Classes;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdmCostoProduccion.Common.Models.Aplicacion
{
    public class AplicacionConfiguracion : EntityBase
    {
        #region Constructor
        public AplicacionConfiguracion() : base()
        {
        }
        #endregion

        #region Propiedades
        [Key]
        public string AplicacionConfiguracionId { get; set; }

        public bool CompraGeneraRecepcion { get; set; }

        public bool VentaGeneraDespacho { get; set; }

        public bool OrdenProduccionGeneraMovimiento { get; set; }

        public bool OrdenProduccionGeneraMovimientoInsumos { get; set; }
        #endregion

        #region Foraneas
        #endregion

        #region Relacionales
        #endregion
    }
}
