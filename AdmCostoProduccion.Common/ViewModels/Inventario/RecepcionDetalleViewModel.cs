using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Models.Inventario;
using System;
using System.Linq;
using System.Text;

namespace AdmCostoProduccion.Common.ViewModels.Inventario
{
    public class RecepcionDetalleViewModel : ObjectBase
    {
        #region Constructor

        public RecepcionDetalleViewModel()
        {
        }

        public RecepcionDetalleViewModel(RecepcionDetalle model)
        {
            RecepcionDetalleId = model.RecepcionDetalleId;
            OrdenProduccionInsumoId = model.OrdenProduccionInsumoId;
            CompraDetalleId = model.CompraDetalleId;
            MercaderiaId = model.MercaderiaId;
            UnidadMedidaId = model.UnidadMedidaId;
            Cantidad = model.Cantidad;
            CodigoMercaderia = model.Mercaderia.Codigo;
            NombreMercaderia = model.Mercaderia.Nombre;
            UnidadMedida = model.UnidadMedida.Nombre;
        }

        #endregion

        #region Propiedades privadas

        private int _RecepcionDetalleId;

        private int? _OrdenProduccionInsumoId;

        private int? _CompraDetalleId;

        private int _MercaderiaId;

        private int _UnidadMedidaId;

        private double _Cantidad;

        private string _CodigoMercaderia;

        private string _NombreMercaderia;

        private string _UnidadMedida;

        #endregion

        #region Propiedades publicas

        public int RecepcionDetalleId
        {
            get
            {
                return _RecepcionDetalleId;
            }

            set
            {
                if (value != _RecepcionDetalleId)
                {
                    _RecepcionDetalleId = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public int? OrdenProduccionInsumoId
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

        public int? CompraDetalleId
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

        public int UnidadMedidaId
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

        public void CopyTo(ref RecepcionDetalleViewModel viewModel)
        {
            viewModel.RecepcionDetalleId = _RecepcionDetalleId;
            viewModel.OrdenProduccionInsumoId = _OrdenProduccionInsumoId;
            viewModel.CompraDetalleId = _CompraDetalleId;
            viewModel.MercaderiaId = _MercaderiaId;
            viewModel.UnidadMedidaId = _UnidadMedidaId;
            viewModel.Cantidad = _Cantidad;
            viewModel.CodigoMercaderia = _CodigoMercaderia;
            viewModel.NombreMercaderia = _NombreMercaderia;
            viewModel.UnidadMedida = _UnidadMedida;
        }

        public RecepcionDetalle ToModel()
        {
            RecepcionDetalle model = new RecepcionDetalle
            {
                RecepcionDetalleId = _RecepcionDetalleId,
                OrdenProduccionInsumoId = _OrdenProduccionInsumoId,
                CompraDetalleId = _CompraDetalleId,
                MercaderiaId = _MercaderiaId,
                UnidadMedidaId = _UnidadMedidaId,
                Cantidad = _Cantidad
            };

            return model;
        }

        #endregion
    }
}
