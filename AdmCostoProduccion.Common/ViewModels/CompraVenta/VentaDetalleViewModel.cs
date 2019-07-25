using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Models.CompraVenta;
using System;
using System.Linq;
using System.Text;

namespace AdmCostoProduccion.Common.ViewModels.CompraVenta
{
    public class VentaDetalleViewModel : ObjectBase
    {
        #region Constructor

        public VentaDetalleViewModel()
        {
        }

        public VentaDetalleViewModel(VentaDetalle model)
        {
            VentaDetalleId = model.VentaDetalleId;
            MercaderiaId = model.MercaderiaId;
            Cantidad = model.Cantidad;
            PrecioUnitario = model.PrecioUnitario;
            CodigoMercaderia = model.Mercaderia.Codigo;
            NombreMercaderia = model.Mercaderia.Nombre;
        }

        #endregion

        #region Propiedades privadas

        private int _VentaDetalleId;

        private int _MercaderiaId;

        private double _Cantidad;

        private double _PrecioUnitario;

        private double _PrecioTotal;

        private string _CodigoMercaderia;

        private string _NombreMercaderia;

        #endregion

        #region Propiedades publicas

        public int VentaDetalleId
        {
            get
            {
                return _VentaDetalleId;
            }

            set
            {
                if (value != _VentaDetalleId)
                {
                    _VentaDetalleId = value;
                    NotifyPropertyChanged();
                }
            }
        }

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

        public double Cantidad
        {
            get
            {
                return _Cantidad;
            }

            set
            {
                if (value != _Cantidad)
                {
                    _Cantidad = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public double PrecioUnitario
        {
            get
            {
                return _PrecioUnitario;
            }

            set
            {
                if (value != _PrecioUnitario)
                {
                    _PrecioUnitario = value;
                    NotifyPropertyChanged();
                    //
                    PrecioTotal = _PrecioUnitario * _Cantidad;
                }
            }
        }

        public double PrecioTotal
        {
            get
            {
                return _PrecioTotal;
            }

            set
            {
                if (value != _PrecioTotal)
                {
                    _PrecioTotal = value;
                    NotifyPropertyChanged();
                    //
                    if (_Cantidad > 0) PrecioUnitario = _PrecioTotal / _Cantidad;
                }
            }
        }

        public string CodigoMercaderia
        {
            get
            {
                return _CodigoMercaderia;
            }

            set
            {
                if (value != _CodigoMercaderia)
                {
                    _CodigoMercaderia = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string NombreMercaderia
        {
            get
            {
                return _NombreMercaderia;
            }

            set
            {
                if (value != _NombreMercaderia)
                {
                    _NombreMercaderia = value;
                    NotifyPropertyChanged();
                }
            }
        }

        #endregion

        #region Metodos Publicos

        public void CopyTo(ref VentaDetalleViewModel viewModel)
        {
            viewModel.VentaDetalleId = _VentaDetalleId;
            viewModel.MercaderiaId = _MercaderiaId;
            viewModel.Cantidad = _Cantidad;
            viewModel.PrecioUnitario = _PrecioUnitario;
            viewModel.CodigoMercaderia = _CodigoMercaderia;
            viewModel.NombreMercaderia = _NombreMercaderia;
        }

        public VentaDetalle ToModel()
        {
            VentaDetalle model = new VentaDetalle
            {
                VentaDetalleId = _VentaDetalleId,
                MercaderiaId = _MercaderiaId,
                Cantidad = _Cantidad,
                PrecioUnitario = _PrecioUnitario
            };

            return model;
        }

        #endregion
    }
}
