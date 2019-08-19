using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Data;
using AdmCostoProduccion.Common.Models.Inventario;
using System;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace AdmCostoProduccion.Common.ViewModels.Inventario
{
    public class DespachoDetalleViewModel : ObjectBase
    {
        #region Constructor

        public DespachoDetalleViewModel(string despachoId)
        {
            _IsNew = true;
            _DespachoId = despachoId;
            _DespachoDetalleId = Guid.NewGuid().ToString();
        }

        public DespachoDetalleViewModel(DespachoDetalle model)
        {
            _DespachoDetalleId = model.DespachoDetalleId;
            _DespachoId = model.DespachoId;
            _OrdenProduccionInsumoId = model.OrdenProduccionInsumoId;
            _VentaDetalleId = model.VentaDetalleId;
            _MercaderiaId = model.MercaderiaId;
            _UnidadMedidaId = model.UnidadMedidaId;
            _Cantidad = model.Cantidad;
            _CodigoMercaderia = model.Mercaderia.Codigo;
            _NombreMercaderia = model.Mercaderia.Nombre;
            _UnidadMedida = model.UnidadMedida.Nombre;
        }

        #endregion

        #region Propiedades privadas

        private string _DespachoDetalleId;

        private string _DespachoId;

        private string _OrdenProduccionInsumoId;

        private string _VentaDetalleId;

        private string _MercaderiaId;

        private string _UnidadMedidaId;

        private double _Cantidad;

        private string _CodigoMercaderia;

        private string _NombreMercaderia;

        private string _UnidadMedida;

        #endregion

        #region Propiedades publicas

        public string DespachoDetalleId
        {
            get
            {
                return _DespachoDetalleId;
            }

            set
            {
                if (value != _DespachoDetalleId)
                {
                    _DespachoDetalleId = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string DespachoId
        {
            get
            {
                return _DespachoId;
            }

            set
            {
                if (value != _DespachoId)
                {
                    _DespachoId = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string OrdenProduccionInsumoId
        {
            get
            {
                return _OrdenProduccionInsumoId;
            }

            set
            {
                if (value != _OrdenProduccionInsumoId)
                {
                    _OrdenProduccionInsumoId = value;
                    NotifyPropertyChanged();
                }
            }
        }

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

        public void CopyOf(DespachoDetalleViewModel viewModel)
        {
            _IsNew = viewModel.IsNew;
            _IsOld = viewModel.IsOld;
            _DespachoDetalleId = viewModel.DespachoDetalleId;
            _DespachoId = viewModel.DespachoId;
            _OrdenProduccionInsumoId = viewModel.OrdenProduccionInsumoId;
            _VentaDetalleId = viewModel.VentaDetalleId;
            _MercaderiaId = viewModel.MercaderiaId;
            _UnidadMedidaId = viewModel.UnidadMedidaId;
            _Cantidad = viewModel.Cantidad;
            _CodigoMercaderia = viewModel.CodigoMercaderia;
            _NombreMercaderia = viewModel.NombreMercaderia;
            _UnidadMedida = viewModel.UnidadMedida;
        }

        private DespachoDetalle ToModel()
        {
            DespachoDetalle model = new DespachoDetalle
            {
                DespachoDetalleId = _DespachoDetalleId,
                DespachoId = _DespachoId,
                OrdenProduccionInsumoId = _OrdenProduccionInsumoId,
                VentaDetalleId = _VentaDetalleId,
                MercaderiaId = _MercaderiaId,
                UnidadMedidaId = _UnidadMedidaId,
                Cantidad = _Cantidad
            };

            return model;
        }

        public void Grabar(ApplicationDbContext Context)
        {
            DespachoDetalle model = this.ToModel();

            if (IsNew) Context.DespachoDetalles.Add(model);
            else
            {
                if (IsOld) Context.Entry(model).State = EntityState.Modified;
            }
        }

        #endregion
    }
}
