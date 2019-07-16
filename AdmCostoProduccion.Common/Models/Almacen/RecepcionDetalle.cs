using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Models.Maestro;
using AdmCostoProduccion.Common.Models.Produccion;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdmCostoProduccion.Common.Models.Almacen
{
    public class RecepcionDetalle : EntityBase
    {
        #region Constructor
        public RecepcionDetalle() : base()
        {
        }
        #endregion

        #region Propiedades
        [Key]
        public int RecepcionDetalleId { get; set; }

        public double Cantidad { get; set; }
        #endregion

        #region Foraneas

        public int RecepcionId { get; set; }

        
        public virtual Recepcion Recepcion { get; set; }

        public int OrdenProduccionInsumoId { get; set; }

        
        public virtual OrdenProduccionInsumo OrdenProduccionInsumo { get; set; }

        public int MercaderiaId { get; set; }

        
        public virtual Mercaderia Mercaderia { get; set; }

        public int UnidadMedidaId { get; set; }

        
        public virtual UnidadMedida UnidadMedida { get; set; }

        #endregion

        #region Relacionales

        
        public virtual ICollection<KardexMovimiento> KardexMovimientos { get; set; }

        #endregion
    }
}
