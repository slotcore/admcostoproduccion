using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Data;
using AdmCostoProduccion.Common.Models.Contabilidad;
using System;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace AdmCostoProduccion.Common.ViewModels.Contabilidad
{
    public class CostoProduccionViewModel : ObjectBase
    {
        #region Constructor

        public CostoProduccionViewModel()
        {
            _IsNew = true;
            _CostoProduccionId = Guid.NewGuid().ToString();
        }

        public CostoProduccionViewModel(CostoProduccion model)
        {
            _CostoProduccionId = model.CostoProduccionId;
            _PlantaFabricacionId = model.PlantaFabricacionId;
            _ConfiguracionValorizacionId = model.ConfiguracionValorizacionId;
            _Codigo = model.Codigo;
            _Nombre = model.Nombre;
            _Descripcion = model.Descripcion;
            _FechaInicio = model.FechaInicio;
            _FechaFin = model.FechaFin;
            _CostoMod = model.CostoMod;
            _CostoCif = model.CostoCif;
            _PlantaFabricacion = model.PlantaFabricacion.Nombre;
            _ConfiguracionValorizacion = model.ConfiguracionValorizacion.Nombre;

            foreach (var child in model.CostoOrdenProduccions)
            {
                CostoOrdenProduccionViewModels.Add(new CostoOrdenProduccionViewModel(child));
            }
        }

        #endregion

        #region Propiedades privadas

        private string _CostoProduccionId;

        private string _PlantaFabricacionId;

        private string _ConfiguracionValorizacionId;

        private string _Codigo;

        private string _Nombre;

        private string _Descripcion;

        private DateTime _FechaInicio;

        private DateTime _FechaFin;

        private double _CostoMod;

        private double _CostoCif;

        private string _PlantaFabricacion;

        private string _ConfiguracionValorizacion;

        private ObservableListSource<CostoOrdenProduccionViewModel> _CostoOrdenProduccionViewModels
            = new ObservableListSource<CostoOrdenProduccionViewModel>();

        #endregion

        #region Propiedades publicas

        public string CostoProduccionId
        {
            get
            {
                return _CostoProduccionId;
            }

            set
            {
                if (value != _CostoProduccionId)
                {
                    _CostoProduccionId = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string PlantaFabricacionId
        {
            get
            {
                return _PlantaFabricacionId;
            }

            set
            {
                if (value != _PlantaFabricacionId)
                {
                    _PlantaFabricacionId = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string ConfiguracionValorizacionId
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

        public string PlantaFabricacion
        {
            get
            {
                return _PlantaFabricacion;
            }

            set
            {
                if (value != _PlantaFabricacion)
                {
                    _PlantaFabricacion = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string ConfiguracionValorizacion
        {
            get
            {
                return _ConfiguracionValorizacion;
            }

            set
            {
                if (value != _ConfiguracionValorizacion)
                {
                    _ConfiguracionValorizacion = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public ObservableListSource<CostoOrdenProduccionViewModel> CostoOrdenProduccionViewModels
        {
            get
            {
                return _CostoOrdenProduccionViewModels;
            }
            set
            {
                if (value != _CostoOrdenProduccionViewModels)
                {
                    _CostoOrdenProduccionViewModels = value;
                    NotifyPropertyChanged();
                }
            }
        }

        #endregion

        #region Metodos Publicos

        public void CopyOf(CostoProduccionViewModel viewModel)
        {
            _IsNew = viewModel.IsNew;
            _IsOld = viewModel.IsOld;
            _CostoProduccionId = viewModel.CostoProduccionId;
            _PlantaFabricacionId = viewModel.PlantaFabricacionId;
            _ConfiguracionValorizacionId = viewModel.ConfiguracionValorizacionId;
            _Codigo = viewModel.Codigo;
            _Nombre = viewModel.Nombre;
            _Descripcion = viewModel.Descripcion;
            _FechaInicio = viewModel.FechaInicio;
            _FechaFin = viewModel.FechaFin;
            _CostoMod = viewModel.CostoMod;
            _CostoCif = viewModel.CostoCif;
            _PlantaFabricacion = viewModel.PlantaFabricacion;
            _ConfiguracionValorizacion = viewModel.ConfiguracionValorizacion;
            _CostoOrdenProduccionViewModels = viewModel.CostoOrdenProduccionViewModels;
        }

        public CostoProduccion ToModel()
        {
            CostoProduccion model = new CostoProduccion
            {
                CostoProduccionId = _CostoProduccionId,
                PlantaFabricacionId = _PlantaFabricacionId,
                ConfiguracionValorizacionId = _ConfiguracionValorizacionId,
                Codigo = _Codigo,
                Nombre = _Nombre,
                Descripcion = _Descripcion,
                FechaInicio = _FechaInicio,
                FechaFin = _FechaFin,
                CostoMod = _CostoMod,
                CostoCif = _CostoCif
            };

            return model;
        }

        public void Grabar()
        {
            ApplicationDbContext Context = new ApplicationDbContext();
            CostoProduccion model = this.ToModel();

            if (IsNew)
            {
                Context.CostoProduccions.Add(model);
            }
            else
            {
                if (IsOld)
                {
                    Context.Entry(model).State = EntityState.Modified;
                }
            }
            //Childs
            foreach (CostoOrdenProduccionViewModel viewModel in CostoOrdenProduccionViewModels)
            {
                viewModel.Grabar(Context);
            }
            //Childs deletes
            foreach (var viewModel in CostoOrdenProduccionViewModels.GetRemoveItems())
            {
                viewModel.Eliminar(Context);
            }
            Context.SaveChanges();
            _IsNew = false;
            _IsOld = false;
            _CostoProduccionId = model.CostoProduccionId;
        }

        public void Eliminar()
        {
            ApplicationDbContext Context = new ApplicationDbContext();

            CostoProduccion model = this.ToModel();
            foreach (var viewModelChild in CostoOrdenProduccionViewModels)
            {
                viewModelChild.Eliminar(Context);
            }
            Context.Entry(model).State = EntityState.Deleted;
            Context.SaveChanges();
        }

        #endregion
    }
}
