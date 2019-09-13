using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Data;
using AdmCostoProduccion.Common.Models.Inventario;
using System;
using System.Data.Entity;
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

        public RecepcionDetalleViewModel(string parentId)
        {
            _IsNew = true;
            _RecepcionId = parentId;
            _RecepcionDetalleId = Guid.NewGuid().ToString();
        }

        public RecepcionDetalleViewModel(RecepcionDetalle model)
        {
            _RecepcionDetalleId = model.RecepcionDetalleId;
            _RecepcionId = model.RecepcionId;
            _InventarioInicialDetalleId = model.InventarioInicialDetalleId;
            _AjusteInventarioDetalleId = model.AjusteInventarioDetalleId;
            _OrdenProduccionInsumoId = model.OrdenProduccionInsumoId;
            _CompraDetalleId = model.CompraDetalleId;
            _MercaderiaId = model.MercaderiaId;
            _UnidadMedidaId = model.UnidadMedidaId;
            _Cantidad = model.Cantidad;
            _CodigoMercaderia = model.Mercaderia.Codigo;
            _NombreMercaderia = model.Mercaderia.Nombre;
            _UnidadMedida = model.UnidadMedida.Nombre;
        }

        #endregion

        #region Propiedades privadas

        private string _RecepcionDetalleId;

        private string _RecepcionId;

        private string _InventarioInicialDetalleId;

        private string _AjusteInventarioDetalleId;

        private string _OrdenProduccionInsumoId;

        private string _CompraDetalleId;

        private string _MercaderiaId;

        private string _UnidadMedidaId;

        private double _Cantidad;

        private string _CodigoMercaderia;

        private string _NombreMercaderia;

        private string _UnidadMedida;

        #endregion

        #region Propiedades publicas

        public string RecepcionDetalleId
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

        public string RecepcionId
        {
            get
            {
                return _RecepcionId;
            }

            set
            {
                if (value != _RecepcionId)
                {
                    _RecepcionId = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string InventarioInicialDetalleId
        {
            get
            {
                return _InventarioInicialDetalleId;
            }

            set
            {
                if (value != _InventarioInicialDetalleId)
                {
                    _InventarioInicialDetalleId = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string AjusteInventarioDetalleId
        {
            get
            {
                return _AjusteInventarioDetalleId;
            }

            set
            {
                if (value != _AjusteInventarioDetalleId)
                {
                    _AjusteInventarioDetalleId = value;
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

        public void CopyOf(RecepcionDetalleViewModel viewModel)
        {
            _IsNew = viewModel.IsNew;
            _IsOld = viewModel.IsOld;
            _RecepcionDetalleId = viewModel.RecepcionDetalleId;
            _RecepcionId = viewModel.RecepcionId;
            _InventarioInicialDetalleId = viewModel.InventarioInicialDetalleId;
            _AjusteInventarioDetalleId = viewModel.AjusteInventarioDetalleId;
            _OrdenProduccionInsumoId = viewModel.OrdenProduccionInsumoId;
            _CompraDetalleId = viewModel.CompraDetalleId;
            _MercaderiaId = viewModel.MercaderiaId;
            _UnidadMedidaId = viewModel.UnidadMedidaId;
            _Cantidad = viewModel.Cantidad;
            _CodigoMercaderia = viewModel.CodigoMercaderia;
            _NombreMercaderia = viewModel.NombreMercaderia;
            _UnidadMedida = viewModel.UnidadMedida;
        }

        public RecepcionDetalle ToModel()
        {
            RecepcionDetalle model = new RecepcionDetalle
            {
                RecepcionDetalleId = _RecepcionDetalleId,
                RecepcionId = _RecepcionId,
                InventarioInicialDetalleId = _InventarioInicialDetalleId,
                AjusteInventarioDetalleId = _AjusteInventarioDetalleId,
                OrdenProduccionInsumoId = _OrdenProduccionInsumoId,
                CompraDetalleId = _CompraDetalleId,
                MercaderiaId = _MercaderiaId,
                UnidadMedidaId = _UnidadMedidaId,
                Cantidad = _Cantidad
            };

            return model;
        }

        public void Grabar(ApplicationDbContext Context)
        {
            RecepcionDetalle model = this.ToModel();

            if (IsNew) Context.RecepcionDetalles.Add(model);
            else
            {
                if (IsOld) Context.Entry(model).State = EntityState.Modified;
            }
        }

        public void Eliminar(ApplicationDbContext Context)
        {
            if (!IsNew)
            {
                RecepcionDetalle model = this.ToModel();
                Context.Entry(model).State = EntityState.Deleted;
            }
        }

        #endregion
    }
}
