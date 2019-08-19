using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Data;
using AdmCostoProduccion.Common.Models.CompraVenta;
using System;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace AdmCostoProduccion.Common.ViewModels.CompraVenta
{
    public class CompraDetalleViewModel : ObjectBase
    {
        #region Constructor

        public CompraDetalleViewModel(string parentId)
        {
            _IsNew = true;
            _CompraId = parentId;
            _CompraDetalleId = Guid.NewGuid().ToString();
        }

        public CompraDetalleViewModel(CompraDetalle model)
        {
            _CompraDetalleId = model.CompraDetalleId;
            _CompraId = model.CompraId;
            _MercaderiaId = model.MercaderiaId;
            _Cantidad = model.Cantidad;
            _PrecioUnitario = model.PrecioUnitario;
            _CodigoMercaderia = model.Mercaderia.Codigo;
            _NombreMercaderia = model.Mercaderia.Nombre;
        }

        #endregion

        #region Propiedades privadas

        private string _CompraDetalleId;

        private string _CompraId;

        private string _MercaderiaId;

        private double _Cantidad;

        private double _PrecioUnitario;

        private double _PrecioTotal;

        private string _CodigoMercaderia;

        private string _NombreMercaderia;

        #endregion

        #region Propiedades publicas

        public string CompraDetalleId
        {
            get
            {
                return _CompraDetalleId;
            }

            set
            {
                if (value != _CompraDetalleId)
                {
                    _CompraDetalleId = value;
                    NotifyPropertyChanged();
                }
            }
        }

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

        public void CopyOf(CompraDetalleViewModel viewModel)
        {
            _IsNew = viewModel.IsNew;
            _IsOld = viewModel.IsOld;
            _CompraDetalleId = viewModel.CompraDetalleId;
            _CompraId = viewModel.CompraId;
            _MercaderiaId = viewModel.MercaderiaId;
            _Cantidad = viewModel.Cantidad;
            _PrecioUnitario = viewModel.PrecioUnitario;
            _CodigoMercaderia = viewModel.CodigoMercaderia;
            _NombreMercaderia = viewModel.NombreMercaderia;
        }

        public CompraDetalle ToModel()
        {
            CompraDetalle model = new CompraDetalle
            {
                CompraDetalleId = _CompraDetalleId,
                CompraId = _CompraId,
                MercaderiaId = _MercaderiaId,
                Cantidad = _Cantidad,
                PrecioUnitario = _PrecioUnitario
            };

            return model;
        }

        public void Grabar(ApplicationDbContext Context)
        {
            CompraDetalle model = this.ToModel();

            if (IsNew) Context.CompraDetalles.Add(model);
            else
            {
                if (IsOld) Context.Entry(model).State = EntityState.Modified;
            }
        }

        public void Eliminar(ApplicationDbContext Context)
        {
            if (!IsNew)
            {
                CompraDetalle model = this.ToModel();
                Context.Entry(model).State = EntityState.Deleted;
            }
        }

        #endregion
    }
}
