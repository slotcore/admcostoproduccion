using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Models.Maestro;
using AdmCostoProduccion.Common.Models.Produccion;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdmCostoProduccion.Common.Models.Almacen
{
    public class DespachoDetalle : EntityBase
    {
        #region Constructor
        public DespachoDetalle() : base()
        {
        }
        #endregion

        #region Propiedades

        [Key]
        public int DespachoDetalleId { get; set; }

        public double Cantidad { get; set; }

        #endregion

        #region Foraneas

        public int DespachoId { get; set; }

        
        public virtual Despacho Despacho { get; set; }

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
