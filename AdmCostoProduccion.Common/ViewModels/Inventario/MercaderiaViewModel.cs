using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Models.Inventario;
using System;
using System.Linq;
using System.Text;

namespace AdmCostoProduccion.Common.ViewModels.Inventario
{
    public class MercaderiaViewModel : ObjectBase
    {
        #region Constructor

        public MercaderiaViewModel()
        {
        }

        public MercaderiaViewModel(Mercaderia model)
        {
            MercaderiaId = model.MercaderiaId;
            TipoMercaderiaId = model.TipoMercaderiaId;
            Codigo = model.Codigo;
            Nombre = model.Nombre;
            Descripcion = model.Descripcion;
            TipoMercaderia = model.TipoMercaderia.Nombre;
        }

        #endregion

        #region Propiedades privadas

        private int _MercaderiaId;

        private int _TipoMercaderiaId;

        private string _Codigo;

        private string _Nombre;

        private string _Descripcion;

        private string _TipoMercaderia;

        #endregion

        #region Propiedades publicas

        public int MercaderiaId
        {
            get
            {
                return _MercaderiaId;
            }

            set
            {
                if (value != _MercaderiaId)
                {
                    _MercaderiaId = value;
                    NotifyPropertyChanged();
                }
            }
        }

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

        public string TipoMercaderia
        {
            get
            {
                return _TipoMercaderia;
            }

            set
            {
                if (value != _TipoMercaderia)
                {
                    _TipoMercaderia = value;
                    NotifyPropertyChanged();
                }
            }
        }

        #endregion

        #region Metodos Publicos

        public void CopyTo(ref MercaderiaViewModel viewModel)
        {
            viewModel.MercaderiaId = _MercaderiaId;
            viewModel.Codigo = _Codigo;
            viewModel.Nombre = _Nombre;
            viewModel.Descripcion = _Descripcion;
            viewModel.TipoMercaderiaId = _TipoMercaderiaId;
            viewModel.TipoMercaderia = _TipoMercaderia;
        }

        public Mercaderia ToModel()
        {
            Mercaderia model = new Mercaderia
            {
                MercaderiaId = _MercaderiaId,
                Codigo = _Codigo,
                Nombre = _Nombre,
                Descripcion = _Descripcion,
                TipoMercaderiaId = TipoMercaderiaId
            };

            return model;
        }

        #endregion
    }
}
