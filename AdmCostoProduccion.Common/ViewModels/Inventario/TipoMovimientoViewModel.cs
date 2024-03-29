﻿using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Models.Inventario;
using System;
using System.Linq;
using System.Text;

namespace AdmCostoProduccion.Common.ViewModels.Inventario
{
    public class TipoMovimientoViewModel : ObjectBase
    {
        #region Constructor

        public TipoMovimientoViewModel()
        {
            _TipoMovimientoId = Guid.NewGuid().ToString();
        }

        public TipoMovimientoViewModel(TipoMovimiento model)
        {
            _TipoMovimientoId = model.TipoMovimientoId;
            _Codigo = model.Codigo;
            _Nombre = model.Nombre;
            _Descripcion = model.Descripcion;
        }

        #endregion

        #region Propiedades privadas

        private string _TipoMovimientoId;

        private string _Codigo;

        private string _Nombre;

        private string _Descripcion;

        #endregion

        #region Propiedades publicas

        public string TipoMovimientoId
        {
            get
            {
                return _TipoMovimientoId;
            }

            set
            {
                if (value != _TipoMovimientoId)
                {
                    _TipoMovimientoId = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Codigo
        {
            get
            {
                return _Codigo;
            }

            set
            {
                if (value != _Codigo)
                {
                    _Codigo = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Nombre
        {
            get
            {
                return _Nombre;
            }

            set
            {
                if (value != _Nombre)
                {
                    _Nombre = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Descripcion
        {
            get
            {
                return _Descripcion;
            }

            set
            {
                if (value != _Descripcion)
                {
                    _Descripcion = value;
                    NotifyPropertyChanged();
                }
            }
        }

        #endregion

        #region Metodos Publicos

        public void CopyTo(ref TipoMovimientoViewModel viewModel)
        {
            viewModel.TipoMovimientoId = _TipoMovimientoId;
            viewModel.Codigo = _Codigo;
            viewModel.Nombre = _Nombre;
            viewModel.Descripcion = _Descripcion;
        }

        public TipoMovimiento ToModel()
        {
            TipoMovimiento model = new TipoMovimiento
            {
                TipoMovimientoId = _TipoMovimientoId,
                Codigo = _Codigo,
                Nombre = _Nombre,
                Descripcion = _Descripcion
            };

            return model;
        }

        #endregion
    }
}
