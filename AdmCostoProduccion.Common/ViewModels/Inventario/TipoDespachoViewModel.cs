using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Models.Almacen;
using AdmCostoProduccion.Common.Models.Inventario;
using System;
using System.Linq;
using System.Text;

namespace AdmCostoProduccion.Common.ViewModels.Inventario
{
    public class TipoDespachoViewModel : ObjectBase
    {
        #region Constructor

        public TipoDespachoViewModel()
        {
        }

        public TipoDespachoViewModel(TipoDespacho model)
        {
            TipoDespachoId = model.TipoDespachoId;
            Codigo = model.Codigo;
            Nombre = model.Nombre;
            Descripcion = model.Descripcion;
            Proceso = model.Proceso;
        }

        #endregion

        #region Propiedades privadas

        private int _TipoDespachoId;

        private string _Codigo;

        private string _Nombre;

        private string _Descripcion;

        private string _Proceso;

        #endregion

        #region Propiedades publicas

        public int TipoDespachoId
        {
            get
            {
                return _TipoDespachoId;
            }

            set
            {
                if (value != _TipoDespachoId)
                {
                    _TipoDespachoId = value;
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

        public void CopyTo(ref TipoDespachoViewModel viewModel)
        {
            viewModel.TipoDespachoId = _TipoDespachoId;
            viewModel.Codigo = _Codigo;
            viewModel.Nombre = _Nombre;
            viewModel.Descripcion = _Descripcion;
            viewModel.Proceso = _Proceso;
        }

        public TipoDespacho ToModel()
        {
            TipoDespacho model = new TipoDespacho
            {
                TipoDespachoId = _TipoDespachoId,
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
