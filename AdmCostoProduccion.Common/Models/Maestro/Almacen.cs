using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Models.Inventario;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdmCostoProduccion.Common.Models.Maestro
{
    public class Almacen : EntityBase
    {
        #region Constructor
        public Almacen() : base()
        {
        }
        #endregion

        #region Propiedades
        [Key]
        public string AlmacenId { get; set; }

        public string Codigo { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }
        #endregion

        #region Foraneas

        public string CentroLogisticoId { get; set; }

        
        public virtual CentroLogistico CentroLogistico { get; set; }
        #endregion

        #region Relacionales
                       
        public virtual ICollection<Kardex> Kardexs { get; set; }

        
        public virtual ICollection<Recepcion> Recepcions { get; set; }

        
        public virtual ICollection<Despacho> Despachos { get; set; }

        #endregion
    }
}
