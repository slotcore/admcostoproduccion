using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Models.Contabilidad;
using AdmCostoProduccion.Common.Models.Inventario;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdmCostoProduccion.Common.Models.Almacen
{
    public class KardexMovimiento : EntityBase
    {
        #region Constructor
        public KardexMovimiento() : base()
        {
        }
        #endregion

        #region Propiedades
        [Key]
        public int KardexMovimientoId { get; set; }

        public double Cantidad { get; set; }
        #endregion

        #region Foraneas

        public int KardexId { get; set; }

        
        public virtual Kardex Kardex { get; set; }

        public int TipoMovimientoId { get; set; }

        
        public virtual TipoMovimiento TipoMovimiento { get; set; }

        public int RecepcionDetalleId { get; set; }

        
        public virtual RecepcionDetalle RecepcionDetalle { get; set; }

        public int DespachoDetalleId { get; set; }

        
        public virtual DespachoDetalle DespachoDetalle { get; set; }

        public int MercaderiaId { get; set; }

        
        public virtual Mercaderia Mercaderia { get; set; }

        public int UnidadMedidaId { get; set; }

        
        public virtual UnidadMedida UnidadMedida { get; set; }

        #endregion

        #region Relacionales

        
        public virtual ICollection<CostoOrdenProduccion> CostoOrdenProduccions { get; set; }

        #endregion
    }
}
