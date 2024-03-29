﻿using AdmCostoProduccion.Common.Classes;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdmCostoProduccion.Common.Models.Inventario
{
    public class Kardex : EntityBase
    {
        #region Constructor
        public Kardex() : base()
        {
        }
        #endregion

        #region Propiedades
        [Key]
        public string KardexId { get; set; }

        public double CantidadSaldo { get; set; }

        public double CantidadEntrada { get; set; }

        public double CantidadSalida { get; set; }
        #endregion

        #region Foraneas

        public string OrdenServicioId { get; set; }

        
        public virtual OrdenServicio OrdenServicio { get; set; }

        public string AlmacenId { get; set; }

        
        public virtual Models.Maestro.Almacen Almacen { get; set; }

        #endregion

        #region Relacionales

        
        public virtual ICollection<KardexMovimiento> KardexMovimientos { get; set; }

        #endregion
    }
}
