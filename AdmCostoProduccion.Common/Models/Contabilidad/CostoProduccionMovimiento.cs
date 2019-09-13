using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Models.Inventario;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdmCostoProduccion.Common.Models.Contabilidad
{
    public class CostoProduccionMovimiento : EntityBase
    {
        #region Constructor
        public CostoProduccionMovimiento() : base()
        {
        }
        #endregion

        #region Propiedades
        [Key]
        public string CostoProduccionMovimientoId { get; set; }

        public double CostoMp { get; set; }

        public double CostoMod { get; set; }

        public double CostoIf { get; set; }

        public double CostoUnitario { get; set; }

        public double CostoUnitarioPromedio { get; set; }
        #endregion

        #region Foraneas

        public string CostoProduccionId { get; set; }

        public virtual CostoProduccion CostoProduccion { get; set; }

        public string KardexMovimientoId { get; set; }

        public virtual KardexMovimiento KardexMovimiento { get; set; }

        #endregion

        #region Relacionales
        #endregion

        #region No Mapeadas

        [NotMapped]
        public double Costo
        {
            get
            {
                return CostoMp + CostoMod + CostoIf;
            }
        }

        #endregion
    }
}
