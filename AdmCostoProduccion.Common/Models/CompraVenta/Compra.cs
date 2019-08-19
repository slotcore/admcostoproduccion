using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Models.Inventario;
using AdmCostoProduccion.Common.Models.Maestro;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdmCostoProduccion.Common.Models.CompraVenta
{
    public class Compra : EntityBase
    {
        #region Constructor
        public Compra() : base()
        {
        }
        #endregion

        #region Propiedades
        [Key]
        public string CompraId { get; set; }

        public string NumeroDocumento { get; set; }

        public DateTime Fecha { get; set; }

        public string Descripcion { get; set; }
        #endregion

        #region Foraneas

        public string CentroLogisticoId { get; set; }

        public virtual CentroLogistico CentroLogistico { get; set; }

        #endregion

        #region Relacionales

        public virtual ICollection<CompraDetalle> CompraDetalles { get; set; }

        public virtual ICollection<Recepcion> Recepcions { get; set; }

        #endregion
    }
}
