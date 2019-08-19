using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Data;
using AdmCostoProduccion.Common.Models.Inventario;
using System;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace AdmCostoProduccion.Common.ViewModels.Inventario
{
    public class OrdenServicioViewModel : ObjectBase
    {
        #region Constructor

        public OrdenServicioViewModel()
        {
            _IsNew = true;
            _OrdenServicioId = Guid.NewGuid().ToString();
        }

        public OrdenServicioViewModel(OrdenServicio model)
        {
            _OrdenServicioId = model.OrdenServicioId;
            _MercaderiaId = model.MercaderiaId;
            _CantidadSaldo = model.CantidadSaldo;
            _CantidadEntrada = model.CantidadEntrada;
            _CantidadSalida = model.CantidadSalida;

            foreach (var child in model.Kardexs)
            {
                KardexViewModels.Add(new KardexViewModel(child));
            }
        }

        #endregion

        #region Propiedades privadas

        private string _OrdenServicioId;

        private string _MercaderiaId;

        private double _CantidadSaldo;

        private double _CantidadEntrada;

        private double _CantidadSalida;

        private ObservableListSource<KardexViewModel> _KardexViewModels
            = new ObservableListSource<KardexViewModel>();

        #endregion

        #region Propiedades publicas

        public string OrdenServicioId
        {
            get
            {
                return _OrdenServicioId;
            }

            set
            {
                if (value != _OrdenServicioId)
                {
                    _OrdenServicioId = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string MercaderiaId
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

        public double CantidadSaldo
        {
            get
            {
                return _CantidadSaldo;
            }

            set
            {
                if (value != _CantidadSaldo)
                {
                    _CantidadSaldo = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public double CantidadEntrada
        {
            get
            {
                return _CantidadEntrada;
            }

            set
            {
                if (value != _CantidadEntrada)
                {
                    _CantidadEntrada = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public double CantidadSalida
        {
            get
            {
                return _CantidadSalida;
            }

            set
            {
                if (value != _CantidadSalida)
                {
                    _CantidadSalida = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public ObservableListSource<KardexViewModel> KardexViewModels
        {
            get
            {
                return _KardexViewModels;
            }
            set
            {
                if (value != _KardexViewModels)
                {
                    _KardexViewModels = value;
                    NotifyPropertyChanged();
                }
            }
        }

        #endregion

        #region Metodos Publicos

        public void CopyOf(OrdenServicioViewModel viewModel)
        {
            _IsNew = viewModel.IsNew;
            _IsOld = viewModel.IsOld;
            _OrdenServicioId = viewModel.OrdenServicioId;
            _MercaderiaId = viewModel.MercaderiaId;
            _CantidadSaldo = viewModel.CantidadSaldo;
            _CantidadEntrada = viewModel.CantidadEntrada;
            _CantidadSalida = viewModel.CantidadSalida;
            _KardexViewModels = viewModel.KardexViewModels;
        }

        public OrdenServicio ToModel()
        {
            OrdenServicio model = new OrdenServicio
            {
                OrdenServicioId = _OrdenServicioId,
                MercaderiaId = _MercaderiaId,
                CantidadSaldo = _CantidadSaldo,
                CantidadEntrada = _CantidadEntrada,
                CantidadSalida = _CantidadSalida
            };

            return model;
        }

        public void Grabar(ApplicationDbContext Context)
        {
            OrdenServicio model = this.ToModel();

            if (IsNew)
            {
                Context.OrdenServicios.Add(model);
            }
            else
            {
                if (IsOld)
                {
                    Context.OrdenServicios.Attach(model);
                    Context.Entry(model).State = EntityState.Modified;
                }
            }
            //Childs
            foreach (KardexViewModel viewModel in KardexViewModels)
            {
                viewModel.Grabar(Context);
            }
            //Childs deletes
            foreach (var viewModel in KardexViewModels.GetRemoveItems())
            {
                viewModel.Eliminar(Context);
            }
            //Context.SaveChanges();
            //_IsNew = false;
            //_IsOld = false;
            //_OrdenServicioId = model.OrdenServicioId;
        }

        public void Eliminar()
        {
            ApplicationDbContext Context = new ApplicationDbContext();

            OrdenServicio model = this.ToModel();
            foreach (var viewModelChild in KardexViewModels)
            {
                viewModelChild.Eliminar(Context);
            }
            Context.Entry(model).State = EntityState.Deleted;
            Context.SaveChanges();
        }

        #endregion
    }
}
