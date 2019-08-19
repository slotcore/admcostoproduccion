using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Data;
using AdmCostoProduccion.Common.Models.Inventario;
using System;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace AdmCostoProduccion.Common.ViewModels.Inventario
{
    public class KardexViewModel : ObjectBase
    {
        #region Constructor

        public KardexViewModel(string parentId)
        {
            _IsNew = true;
            _OrdenServicioId = parentId;
            _KardexId = Guid.NewGuid().ToString();
        }

        public KardexViewModel(Kardex model)
        {
            _KardexId = model.KardexId;
            _OrdenServicioId = model.OrdenServicioId;
            _AlmacenId = model.AlmacenId;
            _CantidadSaldo = model.CantidadSaldo;
            _CantidadEntrada = model.CantidadEntrada;
            _CantidadSalida = model.CantidadSalida;

            foreach (var child in model.KardexMovimientos)
            {
                KardexMovimientoViewModels.Add(new KardexMovimientoViewModel(child));
            }
        }

        #endregion

        #region Propiedades privadas

        private string _KardexId;

        private string _OrdenServicioId;

        private string _AlmacenId;

        private double _CantidadSaldo;

        private double _CantidadEntrada;

        private double _CantidadSalida;

        private ObservableListSource<KardexMovimientoViewModel> _KardexMovimientoViewModels
            = new ObservableListSource<KardexMovimientoViewModel>();

        #endregion

        #region Propiedades publicas

        public string KardexId
        {
            get
            {
                return _KardexId;
            }

            set
            {
                if (value != _KardexId)
                {
                    _KardexId = value;
                    NotifyPropertyChanged();
                }
            }
        }

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

        public string AlmacenId
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

        public ObservableListSource<KardexMovimientoViewModel> KardexMovimientoViewModels
        {
            get
            {
                return _KardexMovimientoViewModels;
            }
            set
            {
                if (value != _KardexMovimientoViewModels)
                {
                    _KardexMovimientoViewModels = value;
                    NotifyPropertyChanged();
                }
            }
        }

        #endregion

        #region Metodos Publicos

        public void CopyOf(KardexViewModel viewModel)
        {
            _IsNew = viewModel.IsNew;
            _IsOld = viewModel.IsOld;
            _KardexId = viewModel.KardexId;
            _OrdenServicioId = viewModel.OrdenServicioId;
            _AlmacenId = viewModel.AlmacenId;
            _CantidadSaldo = viewModel.CantidadSaldo;
            _CantidadEntrada = viewModel.CantidadEntrada;
            _CantidadSalida = viewModel.CantidadSalida;
            _KardexMovimientoViewModels = viewModel.KardexMovimientoViewModels;
        }

        public Kardex ToModel()
        {
            Kardex model = new Kardex
            {
                KardexId = _KardexId,
                OrdenServicioId = _OrdenServicioId,
                AlmacenId = _AlmacenId,
                CantidadSaldo = _CantidadSaldo,
                CantidadEntrada = _CantidadEntrada,
                CantidadSalida = _CantidadSalida
            };

            return model;
        }

        public void Grabar(ApplicationDbContext Context)
        {
            Kardex model = this.ToModel();

            if (IsNew) Context.Kardexs.Add(model);
            else
            {
                if (IsOld) Context.Entry(model).State = EntityState.Modified;
            }
            //Childs
            foreach (KardexMovimientoViewModel viewModel in KardexMovimientoViewModels)
            {
                viewModel.Grabar(Context);
            }
            //Childs deletes
            foreach (var viewModel in KardexMovimientoViewModels.GetRemoveItems())
            {
                viewModel.Eliminar(Context);
            }
        }

        public void Eliminar(ApplicationDbContext Context)
        {
            if (!IsNew)
            {
                Kardex model = this.ToModel();
                foreach (var viewModelChild in KardexMovimientoViewModels)
                {
                    viewModelChild.Eliminar(Context);
                }
                Context.Entry(model).State = EntityState.Deleted;
            }
        }

        #endregion
    }
}
