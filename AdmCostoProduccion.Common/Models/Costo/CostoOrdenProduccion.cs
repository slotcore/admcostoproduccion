using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Models.Almacen;
using AdmCostoProduccion.Common.Models.Produccion;

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdmCostoProduccion.Common.Models.Costo
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
        public int CostoOrdenProduccionId { get; set; }

        public double FactorDistribucion { get; set; }

        public double CostoMp { get; set; }

        public double CostoMod { get; set; }

        public double CostoCif { get; set; }

        #endregion

        #region Foraneas

        public int CostoProduccionId { get; set; }

        
        public virtual CostoProduccion CostoProduccion { get; set; }

        public int OrdenProduccionId { get; set; }

        
        public virtual OrdenProduccion OrdenProduccion { get; set; }

        public int KardexMovimientoId { get; set; }

        
        public virtual KardexMovimiento KardexMovimiento { get; set; }

        #endregion

        #region Relacionales
        #endregion
    }
}
