using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Models.Almacen;
using AdmCostoProduccion.Common.Models.Inventario;
using System;
using System.Linq;
using System.Text;

namespace AdmCostoProduccion.Common.ViewModels.Inventario
{
    public class TipoRecepcionViewModel : ObjectBase
    {
        #region Constructor

        public TipoRecepcionViewModel()
        {
        }

        public TipoRecepcionViewModel(TipoRecepcion model)
        {
            TipoRecepcionId = model.TipoRecepcionId;
            Codigo = model.Codigo;
            Nombre = model.Nombre;
            Descripcion = model.Descripcion;
            Proceso = model.Proceso;
        }

        #endregion

        #region Propiedades privadas

        private int _TipoRecepcionId;

        private string _Codigo;

        private string _Nombre;

        private string _Descripcion;

        private string _Proceso;

        #endregion

        #region Propiedades publicas

        public int TipoRecepcionId
        {
            get
            {
                return _TipoRecepcionId;
            }

            set
            {
                if (value != _TipoRecepcionId)
                {
                    _TipoRecepcionId = value;
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

        public string Proceso
        {
            get
            {
                return _Proceso;
            }

            set
            {
                if (value != _Proceso)
                {
                    _Proceso = value;
                    NotifyPropertyChanged();
                }
            }
        }

        #endregion

        #region Metodos Publicos

        public void CopyTo(ref TipoRecepcionViewModel viewModel)
        {
            viewModel.TipoRecepcionId = _TipoRecepcionId;
            viewModel.Codigo = _Codigo;
            viewModel.Nombre = _Nombre;
            viewModel.Descripcion = _Descripcion;
            viewModel.Proceso = _Proceso;
        }

        public TipoRecepcion ToModel()
        {
            TipoRecepcion model = new TipoRecepcion
            {
                TipoRecepcionId = _TipoRecepcionId,
                Codigo = _Codigo,
                Nombre = _Nombre,
                Descripcion = _Descripcion,
                Proceso = _Proceso
            };

            return model;
        }

        #endregion
    }
}
