using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Models.Inventario;
using System;
using System.Linq;
using System.Text;

namespace AdmCostoProduccion.Common.ViewModels.Inventario
{
    public class UnidadMedidaViewModel : ObjectBase
    {
        #region Constructor

        public UnidadMedidaViewModel()
        {
        }

        public UnidadMedidaViewModel(UnidadMedida model)
        {
            UnidadMedidaId = model.UnidadMedidaId;
            _Codigo = model.Codigo;
            _Nombre = model.Nombre;
            _Descripcion = model.Descripcion;
            _Simbolo = model.Simbolo;
        }

        #endregion

        #region Propiedades privadas

        private int _UnidadMedidaId;

        private string _Codigo;

        private string _Nombre;

        private string _Descripcion;

        private string _Simbolo;

        #endregion

        #region Propiedades publicas

        public int UnidadMedidaId
        {
            get
            {
                return _UnidadMedidaId;
            }

            set
            {
                if (value != _UnidadMedidaId)
                {
                    _UnidadMedidaId = value;
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

        public string Simbolo
        {
            get
            {
                return _Simbolo;
            }

            set
            {
                if (value != _Simbolo)
                {
                    _Simbolo = value;
                    NotifyPropertyChanged();
                }
            }
        }

        #endregion

        #region Metodos Publicos

        public void CopyTo(ref UnidadMedidaViewModel viewModel)
        {
            viewModel.UnidadMedidaId = _UnidadMedidaId;
            viewModel.Codigo = _Codigo;
            viewModel.Nombre = _Nombre;
            viewModel.Descripcion = _Descripcion;
            viewModel.Simbolo = _Simbolo;
        }

        public UnidadMedida ToModel()
        {
            UnidadMedida model = new UnidadMedida
            {
                UnidadMedidaId = _UnidadMedidaId,
                Codigo = _Codigo,
                Nombre = _Nombre,
                Descripcion = _Descripcion,
                Simbolo = _Simbolo
            };

            return model;
        }

        #endregion
    }
}
