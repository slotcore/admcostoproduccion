using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Models.Maestro;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdmCostoProduccion.Common.Models.Almacen
{
    public class OrdenServicio : EntityBase
    {
        #region Constructor
        public OrdenServicio() : base()
        {
        }
        #endregion

        #region Propiedades
        [Key]
        public int OrdenServicioId { get; set; }

        public double CantidadSaldo { get; set; }

        public double CantidadEntrada { get; set; }

        public double CantidadSalida { get; set; }
        #endregion

        #region Foraneas

        public int MercaderiaId { get; set; }

        
        public virtual Mercaderia Mercaderia { get; set; }

        #endregion

        #region Relacionales

        
        public virtual ICollection<Kardex> Kardexs { get; set; }

        #endregion
    }
}
