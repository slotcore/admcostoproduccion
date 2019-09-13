using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Models.Inventario;
using AdmCostoProduccion.Common.Models.Produccion;

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdmCostoProduccion.Common.Models.Contabilidad
{
    public class CostoOrdenProduccion : EntityBase
    {
        #region Constructor
        public CostoOrdenProduccion() : base()
        {
        }
        #endregion

        #region Propiedades
        [Key]
        public string CostoOrdenProduccionId { get; set; }

        public double FactorDistribucion { get; set; }

        public double CostoMp { get; set; }

        public double CostoMod { get; set; }

        public double CostoIf { get; set; }

        #endregion

        #region Foraneas

        public string CostoProduccionId { get; set; }

        
        public virtual CostoProduccion CostoProduccion { get; set; }

        public string OrdenProduccionId { get; set; }

        
        public virtual OrdenProduccion OrdenProduccion { get; set; }

        public string KardexMovimientoId { get; set; }

        
        public virtual KardexMovimiento KardexMovimiento { get; set; }

        #endregion

        #region Relacionales
        #endregion
    }
}
