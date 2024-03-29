﻿using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Models.Inventario;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdmCostoProduccion.Common.Models.Produccion
{
    public class OrdenProduccionInsumo : EntityBase
    {
        #region Constructor
        public OrdenProduccionInsumo() : base()
        {
        }
        #endregion

        #region Propiedades
        [Key]
        public string OrdenProduccionInsumoId { get; set; }

        public double Cantidad { get; set; }
        #endregion

        #region Foraneas

        public string OrdenProduccionId { get; set; }

        
        public virtual OrdenProduccion OrdenProduccion { get; set; }

        public string MercaderiaId { get; set; }

        
        public virtual Mercaderia Mercaderia { get; set; }

        public string UnidadMedidaId { get; set; }

        
        public virtual UnidadMedida UnidadMedida { get; set; }

        #endregion

        #region Relacionales

        
        public virtual ICollection<RecepcionDetalle> RecepcionDetalles { get; set; }

        
        public virtual ICollection<DespachoDetalle> DespachoDetalles { get; set; }

        #endregion
    }
}
