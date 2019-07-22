using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Models.Inventario;
using System;
using System.Linq;
using System.Text;

namespace AdmCostoProduccion.Common.ViewModels.Inventario
{
    public class TipoMercaderiaViewModel : ObjectBase
    {
        #region Constructor

        public TipoMercaderiaViewModel()
        {
        }

        public TipoMercaderiaViewModel(TipoMercaderia model)
        {
            TipoMercaderiaId = model.TipoMercaderiaId;
            _Codigo = model.Codigo;
            _Nombre = model.Nombre;
            _Descripcion = model.Descripcion;
        }

        #endregion

        #region Propiedades privadas

        private int _TipoMercaderiaId;

        private string _Codigo;

        private string _Nombre;

        private string _Descripcion;

        #endregion

        #region Propiedades publicas

        public int TipoMercaderiaId
        {
            get
            {
                return _TipoMercaderiaId;
            }

            set
            {
                if (value != _TipoMercaderiaId)
                {
                    _TipoMercaderiaId = value;
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

        public void CopyTo(ref TipoMercaderiaViewModel viewModel)
        {
            viewModel.TipoMercaderiaId = _TipoMercaderiaId;
            viewModel.Codigo = _Codigo;
            viewModel.Nombre = _Nombre;
            viewModel.Descripcion = _Descripcion;
        }

        public TipoMercaderia ToModel()
        {
            TipoMercaderia model = new TipoMercaderia
            {
                TipoMercaderiaId = _TipoMercaderiaId,
                Codigo = _Codigo,
                Nombre = _Nombre,
                Descripcion = _Descripcion
            };

            return model;
        }

        #endregion
    }
}
