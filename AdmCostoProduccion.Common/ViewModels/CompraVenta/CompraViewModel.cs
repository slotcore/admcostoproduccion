using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Data;
using AdmCostoProduccion.Common.Models.CompraVenta;
using System;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace AdmCostoProduccion.Common.ViewModels.CompraVenta
{
    public class CompraViewModel : ObjectBase
    {
        #region Constructor

        public CompraViewModel()
        {
            _IsNew = true;
            _CompraId = Guid.NewGuid().ToString();
            _Fecha = DateTime.Now;
        }

        public CompraViewModel(Compra model)
        {
            _CompraId = model.CompraId;
            _CentroLogisticoId = model.CentroLogisticoId;
            _NumeroDocumento = model.NumeroDocumento;
            _Fecha = model.Fecha;
            _Descripcion = model.Descripcion;
            _CentroLogistico = model.CentroLogistico.Nombre;

            foreach (var child in model.CompraDetalles)
            {
                CompraDetalleViewModels.Add(new CompraDetalleViewModel(child));
            }
        }

        #endregion

        #region Propiedades privadas

        private string _CompraId;

        private string _CentroLogisticoId;

        private string _NumeroDocumento;

        private DateTime _Fecha;

        private string _Descripcion;

        private string _CentroLogistico;

        private ObservableListSource<CompraDetalleViewModel> _CompraDetalleViewModels
            = new ObservableListSource<CompraDetalleViewModel>();

        #endregion

        #region Propiedades publicas

        public string CompraId
        {
            get
            {
                return _CompraId;
            }

            set
            {
                if (value != _CompraId)
                {
                    _CompraId = value;
                    NotifyPropertyChanged();
                }
            }
        }

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

        public string NumeroDocumento
        {
            get
            {
                return _NumeroDocumento;
            }

            set
            {
                if (value != _NumeroDocumento)
                {
                    _NumeroDocumento = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public DateTime Fecha
        {
            get
            {
                return _Fecha;
            }

            set
            {
                if (value != _Fecha)
                {
                    _Fecha = value;
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

        public ObservableListSource<CompraDetalleViewModel> CompraDetalleViewModels
        {
            get
            {
                return _CompraDetalleViewModels;
            }
            set
            {
                if (value != _CompraDetalleViewModels)
                {
                    _CompraDetalleViewModels = value;
                    NotifyPropertyChanged();
                }
            }
        }

        #endregion

        #region Metodos Publicos

        public void CopyOf(CompraViewModel viewModel)
        {
            _IsNew = viewModel.IsNew;
            _IsOld = viewModel.IsOld;
            _CompraId = viewModel.CompraId;
            _CentroLogisticoId = viewModel.CentroLogisticoId;
            _NumeroDocumento = viewModel.NumeroDocumento;
            _Fecha = viewModel.Fecha;
            _Descripcion = viewModel.Descripcion;
            _CentroLogistico = viewModel.CentroLogistico;
            _CompraDetalleViewModels = viewModel.CompraDetalleViewModels;
        }

        public Compra ToModel()
        {
            Compra model = new Compra
            {
                CompraId = _CompraId,
                CentroLogisticoId = _CentroLogisticoId,
                NumeroDocumento = _NumeroDocumento,
                Fecha = _Fecha,
                Descripcion = _Descripcion
            };

            return model;
        }

        public void Grabar()
        {
            ApplicationDbContext Context = new ApplicationDbContext();
            Compra model = this.ToModel();

            if (IsNew)
            {
                Context.Compras.Add(model);
            }
            else
            {
                if (IsOld)
                {
                    Context.Entry(model).State = EntityState.Modified;
                }
            }
            foreach (CompraDetalleViewModel viewModel in CompraDetalleViewModels)
            {
                viewModel.Grabar(Context);
            }
            foreach (var viewModel in CompraDetalleViewModels.GetRemoveItems())
            {
                viewModel.Eliminar(Context);
            }
            Context.SaveChanges();
            _IsNew = false;
            _IsOld = false;
            _CompraId = model.CompraId;
        }

        public void Eliminar()
        {
            ApplicationDbContext Context = new ApplicationDbContext();

            Compra model = this.ToModel();
            foreach (var viewModelChild in CompraDetalleViewModels)
            {
                viewModelChild.Eliminar(Context);
            }
            Context.Entry(model).State = EntityState.Deleted;
            Context.SaveChanges();
        }

        #endregion
    }
}
