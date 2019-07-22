using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Models.Maestro;
using System;
using System.Linq;
using System.Text;

namespace AdmCostoProduccion.Common.ViewModels.Maestro
{
    public class AlmacenViewModel : ObjectBase
    {
        #region Constructor

        public AlmacenViewModel()
        {
        }

        public AlmacenViewModel(Almacen model)
        {
            AlmacenId = model.AlmacenId;
            CentroLogisticoId = model.CentroLogisticoId;
            Codigo = model.Codigo;
            Nombre = model.Nombre;
            Descripcion = model.Descripcion;
            CentroLogistico = model.CentroLogistico.Nombre;
        }

        #endregion

        #region Propiedades privadas

        private int _AlmacenId;

        private int _CentroLogisticoId;

        private string _Codigo;

        private string _Nombre;

        private string _Descripcion;

        private string _CentroLogistico;

        #endregion

        #region Propiedades publicas

        public int AlmacenId
        {
            get
            {
                return _AlmacenId;
            }

            set
            {
                if (value != _AlmacenId)
                {
                    _AlmacenId = value;
                    NotifyPropertyChanged();
                }
            }
        }

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

        public string CentroLogistico
        {
            get
            {
                return _CentroLogistico;
            }

            set
            {
                if (value != _CentroLogistico)
                {
                    _CentroLogistico = value;
                    NotifyPropertyChanged();
                }
            }
        }

        #endregion

        #region Metodos Publicos

        public void CopyTo(ref AlmacenViewModel viewModel)
        {
            viewModel.AlmacenId = _AlmacenId;
            viewModel.CentroLogisticoId = _CentroLogisticoId;
            viewModel.Codigo = _Codigo;
            viewModel.Nombre = _Nombre;
            viewModel.Descripcion = _Descripcion;
        }

        public Almacen ToModel()
        {
            Almacen model = new Almacen
            {
                AlmacenId = _AlmacenId,
                CentroLogisticoId = _CentroLogisticoId,
                Codigo = _Codigo,
                Nombre = _Nombre,
                Descripcion = _Descripcion
            };

            return model;
        }

        #endregion
    }
}
