using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Models.Costo;
using System;

namespace AdmCostoProduccion.Common.ViewModels.Costo
{
    public class CostoProduccionViewModel : ObjectBase
    {

        #region Constructor

        public CostoProduccionViewModel()
        {
        }

        public CostoProduccionViewModel(Models.Costo.CostoProduccion model)
        {
            _AlmacenId = model.AlmacenId;
            _ConfiguracionValorizacionId = model.ConfiguracionValorizacionId;
            _Codigo = model.Codigo;
            _Nombre = model.Nombre;
            _Descripcion = model.Descripcion;
            _FechaInicio = model.FechaInicio;
            _FechaFin = model.FechaFin;
            _CostoMod = model.CostoMod;
            _CostoCif = model.CostoCif;

            foreach (CostoOrdenProduccion costoOrdenProduccion in model.CostoOrdenProduccions)
            {
                _CostoOrdenProduccionViewModels.Add(new CostoOrdenProduccionViewModel(costoOrdenProduccion));
            }
        }

        #endregion

        #region Propiedades privadas

        private int _AlmacenId;

        private int _ConfiguracionValorizacionId;

        private string _Codigo;

        private string _Nombre;

        private string _Descripcion;

        private DateTime _FechaInicio;

        private DateTime _FechaFin;

        private double _CostoMod;

        private double _CostoCif;

        private ObservableListSource<CostoOrdenProduccionViewModel> _CostoOrdenProduccionViewModels = new ObservableListSource<CostoOrdenProduccionViewModel>();

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

        public int ConfiguracionValorizacionId
        {
            get
            {
                return _ConfiguracionValorizacionId;
            }

            set
            {
                if (value != _ConfiguracionValorizacionId)
                {
                    _ConfiguracionValorizacionId = value;
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

        public DateTime FechaInicio
        {
            get
            {
                return _FechaInicio;
            }

            set
            {
                if (value != _FechaInicio)
                {
                    _FechaInicio = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public DateTime FechaFin
        {
            get
            {
                return _FechaFin;
            }

            set
            {
                if (value != _FechaFin)
                {
                    _FechaFin = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public double CostoMod
        {
            get
            {
                return _CostoMod;
            }

            set
            {
                if (value != _CostoMod)
                {
                    _CostoMod = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public double CostoCif
        {
            get
            {
                return _CostoCif;
            }

            set
            {
                if (value != _CostoCif)
                {
                    _CostoCif = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public virtual ObservableListSource<CostoOrdenProduccionViewModel> CostoOrdenProduccionViewModels
        {
            get
            {
                return _CostoOrdenProduccionViewModels;
            }
        }

        #endregion
    }
}
