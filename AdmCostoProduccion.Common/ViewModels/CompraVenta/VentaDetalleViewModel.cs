using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Data;
using AdmCostoProduccion.Common.Models.CompraVenta;
using System;
using System.Data.Entity;
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

        public VentaDetalleViewModel(string parentId)
        {
            _IsNew = true;
            _VentaId = parentId;
            _VentaDetalleId = Guid.NewGuid().ToString();
        }

        public VentaDetalleViewModel(VentaDetalle model)
        {
            _VentaDetalleId = model.VentaDetalleId;
            _VentaId = model.VentaId;
            _MercaderiaId = model.MercaderiaId;
            _UnidadMedidaId = model.UnidadMedidaId;
            _Cantidad = model.Cantidad;
            _PrecioUnitario = model.PrecioUnitario;
            _PrecioTotal = model.PrecioUnitario * model.Cantidad;
            _CodigoMercaderia = model.Mercaderia.Codigo;
            _NombreMercaderia = model.Mercaderia.Nombre;
            _UnidadMedida = model.UnidadMedida?.Nombre;
        }

        #endregion

        #region Propiedades privadas

        private string _VentaDetalleId;

        private string _VentaId;

        private string _MercaderiaId;

        private string _UnidadMedidaId;

        private double _Cantidad;

        private double _PrecioUnitario;

        private double _PrecioTotal;

        private string _CodigoMercaderia;

        private string _NombreMercaderia;

        private string _UnidadMedida;

        #endregion

        #region Propiedades publicas

        public string VentaDetalleId
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

        public string UnidadMedidaId
        {
            get
            {
                return _UnidadMedidaId;
            }

            set
            {
                if (value != _UnidadMedidaId)
                {
                    _UnidadMedidaId = value;
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

        public string UnidadMedida
        {
            get
            {
                return _UnidadMedida;
            }

            set
            {
                if (value != _UnidadMedida)
                {
                    _UnidadMedida = value;
                    NotifyPropertyChanged();
                }
            }
        }

        #endregion

        #region Metodos Publicos

        public void CopyOf(VentaDetalleViewModel viewModel)
        {
            _IsNew = viewModel.IsNew;
            _IsOld = viewModel.IsOld;
            _VentaDetalleId = viewModel.VentaDetalleId;
            _VentaId = viewModel.VentaId;
            _MercaderiaId = viewModel.MercaderiaId;
            _UnidadMedidaId = viewModel.UnidadMedidaId;
            _Cantidad = viewModel.Cantidad;
            _PrecioUnitario = viewModel.PrecioUnitario;
            _CodigoMercaderia = viewModel.CodigoMercaderia;
            _NombreMercaderia = viewModel.NombreMercaderia;
            _UnidadMedida = viewModel.UnidadMedida;
        }

        public VentaDetalle ToModel()
        {
            VentaDetalle model = new VentaDetalle
            {
                VentaDetalleId = _VentaDetalleId,
                VentaId = _VentaId,
                MercaderiaId = _MercaderiaId,
                UnidadMedidaId = _UnidadMedidaId,
                Cantidad = _Cantidad,
                PrecioUnitario = _PrecioUnitario
            };

            return model;
        }

        public void Grabar(ApplicationDbContext Context)
        {
            VentaDetalle model = this.ToModel();

            if (IsNew) Context.VentaDetalles.Add(model);
            else
            {
                if (IsOld) Context.Entry(model).State = EntityState.Modified;
            }
        }

        public void Eliminar(ApplicationDbContext Context)
        {
            if (!IsNew)
            {
                VentaDetalle model = this.ToModel();
                Context.Entry(model).State = EntityState.Deleted;
            }
        }

        #endregion
    }
}
