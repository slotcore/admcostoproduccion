using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Models.CompraVenta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdmCostoProduccion.Common.ViewModels.CompraVenta
{
    public class VentaViewModel : ObjectBase
    {
        #region Constructor

        public VentaViewModel()
        {
            _VentaId = Guid.NewGuid().ToString();
            Fecha = DateTime.Now;
        }

        public VentaViewModel(Venta model)
        {
            VentaId = model.VentaId;
            CentroLogisticoId = model.CentroLogisticoId;
            NumeroDocumento = model.NumeroDocumento;
            Fecha = model.Fecha;
            Descripcion = model.Descripcion;
            CentroLogistico = model.CentroLogistico.Nombre;

            foreach (var ventaDetalle in model.VentaDetalles)
            {
                VentaDetalleViewModels.Add(new VentaDetalleViewModel(ventaDetalle));
            }
        }

        #endregion

        #region Propiedades privadas

        private string _VentaId;

        private string _CentroLogisticoId;

        private string _NumeroDocumento;

        private DateTime _Fecha;

        private string _Descripcion;

        private string _CentroLogistico;

        private ObservableListSource<VentaDetalleViewModel> _VentaDetalleViewModels 
            = new ObservableListSource<VentaDetalleViewModel>();

        #endregion

        #region Propiedades publicas

        public string VentaId
        {
            get
            {
                return _VentaId;
            }

            set
            {
                if (value != _VentaId)
                {
                    _VentaId = value;
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

        public virtual ObservableListSource<VentaDetalleViewModel> VentaDetalleViewModels
        {
            get
            {
                return _VentaDetalleViewModels;
            }
            set
            {
                if (value != _VentaDetalleViewModels)
                {
                    _VentaDetalleViewModels = value;
                    NotifyPropertyChanged();
                }
            }
        }

        #endregion

        #region Metodos Publicos

        public void CopyTo(ref VentaViewModel viewModel)
        {
            viewModel.VentaId = _VentaId;
            viewModel.CentroLogisticoId = _CentroLogisticoId;
            viewModel.NumeroDocumento = _NumeroDocumento;
            viewModel.Fecha = _Fecha;
            viewModel.Descripcion = _Descripcion;
            viewModel.CentroLogistico = _CentroLogistico;
            viewModel.VentaDetalleViewModels = _VentaDetalleViewModels;
        }

        public Venta ToModel()
        {
            Venta model = new Venta
            {
                VentaId = _VentaId,
                CentroLogisticoId = _CentroLogisticoId,
                NumeroDocumento = _NumeroDocumento,
                Fecha = _Fecha,
                Descripcion = _Descripcion
            };

            model.VentaDetalles = new List<VentaDetalle>();
            foreach (var ventaDetalleViewModel in VentaDetalleViewModels)
            {
                model.VentaDetalles.Add(ventaDetalleViewModel.ToModel());
            }

            return model;
        }

        #endregion
    }
}
