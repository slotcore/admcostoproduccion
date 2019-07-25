﻿using AdmCostoProduccion.Common.Classes;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdmCostoProduccion.Common.Models.Inventario
{
    public class TipoRecepcion : EntityBase
    {
        #region Constructor
        public TipoRecepcion() : base()
        {
        }
        #endregion

        #region Propiedades
        [Key]
        public int TipoRecepcionId { get; set; }

        public string Codigo { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public string Proceso { get; set; }

        #endregion

        #region Foraneas
        #endregion

        #region Relacionales


        public virtual ICollection<TipoRecepcion> TipoRecepcions { get; set; }

        #endregion
    }
}
