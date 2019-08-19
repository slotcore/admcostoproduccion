using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Models.Maestro;
using System;
using System.Linq;
using System.Text;

namespace AdmCostoProduccion.Common.ViewModels.Maestro
{
    public class CentroLogisticoViewModel : ObjectBase
    {
        #region Constructor

        public CentroLogisticoViewModel()
        {
            _CentroLogisticoId = Guid.NewGuid().ToString();
        }
        public CentroLogisticoViewModel(CentroLogistico model)
        {
            _CentroLogisticoId = model.CentroLogisticoId;
            _Codigo = model.Codigo;
            _Nombre = model.Nombre;
            _Descripcion = model.Descripcion;
            foreach (var almacen in model.Almacens)
            {
                Almacens.Add(new AlmacenViewModel(almacen));
            }
        }

        #endregion

        #region Propiedades privadas

        private string _CentroLogisticoId;

        private string _Codigo;

        private string _Nombre;

        private string _Descripcion;

        private ObservableListSource<AlmacenViewModel> _Almacens = new ObservableListSource<AlmacenViewModel>();

        #endregion

        #region Propiedades publicas

        public string CentroLogisticoId
        {
            get
            {
                return _CentroLogisticoId;
            }

            set
            {
                if (value != _CentroLogisticoId)
                {
                    _CentroLogisticoId = value;
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

        public virtual ObservableListSource<AlmacenViewModel> Almacens {
            get
            {
                return _Almacens;
            }

            set
            {
                if (value != _Almacens)
                {
                    _Almacens = value;
                    NotifyPropertyChanged();
                }
            }
        }

        #endregion

        #region Metodos

        public CentroLogisticoViewModel GetCopy()
        {
            CentroLogisticoViewModel viewModel = new CentroLogisticoViewModel
            {
                CentroLogisticoId = _CentroLogisticoId,
                Codigo = _Codigo,
                Nombre = _Nombre,
                Descripcion = _Descripcion,
                Almacens = _Almacens
            };

            return viewModel;
        }

        public CentroLogistico ToModel()
        {
            CentroLogistico centroLogistico = new CentroLogistico
            {
                CentroLogisticoId = _CentroLogisticoId,
                Codigo = _Codigo,
                Nombre = _Nombre,
                Descripcion = _Descripcion
            };

            return centroLogistico;
        }

        #endregion
    }
}
