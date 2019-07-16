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

        }
        public CentroLogisticoViewModel(CentroLogistico model)
        {
            CentroLogisticoId = model.CentroLogisticoId;
            Codigo = model.Codigo;
            Nombre = model.Nombre;
            Descripcion = model.Descripcion;
            foreach (var almacen in model.Almacens)
            {
                Almacens.Add(new AlmacenViewModel(almacen));
            }
        }

        #endregion

        #region Propiedades privadas

        private int _CentroLogisticoId;

        private string _Codigo;

        private string _Nombre;

        private string _Descripcion;

        private ObservableListSource<AlmacenViewModel> _Almacens = new ObservableListSource<AlmacenViewModel>();

        #endregion

        #region Propiedades publicas

        public int CentroLogisticoId
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
        }

        #endregion
    }
}
