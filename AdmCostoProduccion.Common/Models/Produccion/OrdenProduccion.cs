using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Models.Contabilidad;
using AdmCostoProduccion.Common.Models.Inventario;
using AdmCostoProduccion.Common.Models.Maestro;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdmCostoProduccion.Common.Models.Produccion
{
    public class OrdenProduccion : EntityBase
    {
        #region Constructor
        public OrdenProduccion() : base()
        {
        }
        #endregion

        #region Propiedades
        [Key]
        public string OrdenProduccionId { get; set; }

        public string Codigo { get; set; }

        public string Descripcion { get; set; }

        public DateTime Fecha { get; set; }

        public double Cantidad { get; set; }

        public string Lote { get; set; }

        #endregion

        #region Foraneas

        public string PlantaFabricacionId { get; set; }

        
        public virtual PlantaFabricacion PlantaFabricacion { get; set; }

        public string MercaderiaId { get; set; }

        
        public virtual Mercaderia Mercaderia { get; set; }

        public string ProcedimientoProduccionId { get; set; }

        
        public virtual ProcedimientoProduccion ProcedimientoProduccion { get; set; }

        public string UnidadMedidaId { get; set; }

        
        public virtual UnidadMedida UnidadMedida { get; set; }

        #endregion

        #region Relacionales

        
        public virtual ICollection<OrdenProduccionInsumo> OrdenProduccionInsumos { get; set; }

        
        public virtual ICollection<CostoOrdenProduccion> CostoOrdenProduccions { get; set; }

        
        public virtual ICollection<Recepcion> Recepcions { get; set; }

        
        public virtual ICollection<Despacho> Despachos { get; set; }

        #endregion
    }
}
