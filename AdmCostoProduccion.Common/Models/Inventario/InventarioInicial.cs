using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Models.Maestro;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdmCostoProduccion.Common.Models.Inventario
{
    public class InventarioInicial : EntityBase
    {
        #region Constructor
        public InventarioInicial() : base()
        {
        }
        #endregion

        #region Propiedades
        [Key]
        public string InventarioInicialId { get; set; }

        public string Codigo { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public DateTime Fecha { get; set; }

        public string Observacion { get; set; }
        #endregion

        #region Foraneas

        public string AlmacenId { get; set; }

        public virtual Almacen Almacen { get; set; }

        #endregion

        #region Relacionales

        public virtual ICollection<InventarioInicialDetalle> InventarioInicialDetalles { get; set; }

        public virtual ICollection<Recepcion> Recepcions { get; set; }

        #endregion
    }
}
