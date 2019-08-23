using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Models.Maestro;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdmCostoProduccion.Common.Models.Inventario
{
    public class ReglaAlmacenaje : EntityBase
    {
        #region Constructor
        public ReglaAlmacenaje() : base()
        {
        }
        #endregion

        #region Propiedades
        [Key]
        public string ReglaAlmacenajeId { get; set; }

        public string Codigo { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }
        #endregion

        #region Foraneas

        public string AlmacenId { get; set; }

        public virtual Almacen Almacen { get; set; }

        public string FamiliaMercaderiaId { get; set; }

        public virtual FamiliaMercaderia FamiliaMercaderia { get; set; }

        #endregion

        #region Relacionales
        #endregion
    }
}
