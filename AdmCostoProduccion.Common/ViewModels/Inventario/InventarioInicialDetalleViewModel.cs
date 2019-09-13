using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Data;
using AdmCostoProduccion.Common.Models.Inventario;
using System;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace AdmCostoProduccion.Common.ViewModels.Inventario
{
    public class InventarioInicialDetalleViewModel : ObjectBase
    {
        #region Constructor

        public InventarioInicialDetalleViewModel()
        {
            _IsNew = true;
            _InventarioInicialDetalleId = Guid.NewGuid().ToString();
        }

        public InventarioInicialDetalleViewModel(string parentId)
        {
            _IsNew = true;
            _InventarioInicialId = parentId;
            _InventarioInicialDetalleId = Guid.NewGuid().ToString();
        }

        public InventarioInicialDetalleViewModel(InventarioInicialDetalle model)
        {
            _InventarioInicialDetalleId = model.InventarioInicialDetalleId;
            _InventarioInicialId = model.InventarioInicialId;
            _MercaderiaId = model.MercaderiaId;
            _UnidadMedidaId = model.UnidadMedidaId;
            _Cantidad = model.Cantidad;
            _Costo = model.Costo;
            _CodigoMercaderia = model.Mercaderia.Codigo;
            _NombreMercaderia = model.Mercaderia.Nombre;
            _UnidadMedida = model.UnidadMedida.Nombre;
        }

        #endregion

        #region Propiedades privadas

        private string _InventarioInicialDetalleId;

        private string _InventarioInicialId;

        private string _MercaderiaId;

        private string _UnidadMedidaId;

        private double _Cantidad;

        private double _Costo;

        private string _CodigoMercaderia;

        private string _NombreMercaderia;

        private string _UnidadMedida;

        #endregion

        #region Propiedades publicas

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

        public string InventarioInicialId
        {
            get
            {
                return _InventarioInicialId;
            }

            set
            {
                if (value != _InventarioInicialId)
                {
                    _InventarioInicialId = value;
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

        public double Costo
        {
            get
            {
                return _Costo;
            }

            set
            {
                if (value != _Costo)
                {
                    _Costo = value;
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

        public void CopyOf(InventarioInicialDetalleViewModel viewModel)
        {
            _IsNew = viewModel.IsNew;
            _IsOld = viewModel.IsOld;
            _InventarioInicialDetalleId = viewModel.InventarioInicialDetalleId;
            _InventarioInicialId = viewModel.InventarioInicialId;
            _MercaderiaId = viewModel.MercaderiaId;
            _UnidadMedidaId = viewModel.UnidadMedidaId;
            _Cantidad = viewModel.Cantidad;
            _Costo = viewModel.Costo;
            _CodigoMercaderia = viewModel.CodigoMercaderia;
            _NombreMercaderia = viewModel.NombreMercaderia;
            _UnidadMedida = viewModel.UnidadMedida;
        }

        public InventarioInicialDetalle ToModel()
        {
            InventarioInicialDetalle model = new InventarioInicialDetalle
            {
                InventarioInicialDetalleId = _InventarioInicialDetalleId,
                InventarioInicialId = _InventarioInicialId,
                MercaderiaId = _MercaderiaId,
                UnidadMedidaId = _UnidadMedidaId,
                Cantidad = _Cantidad,
                Costo = _Costo
            };

            return model;
        }

        public void Grabar(ApplicationDbContext Context)
        {
            InventarioInicialDetalle model = this.ToModel();

            if (IsNew) Context.InventarioInicialDetalles.Add(model);
            else
            {
                if (IsOld) Context.Entry(model).State = EntityState.Modified;
            }
        }

        public void Eliminar(ApplicationDbContext Context)
        {
            if (!IsNew)
            {
                InventarioInicialDetalle model = this.ToModel();
                Context.Entry(model).State = EntityState.Deleted;
            }
        }

        #endregion
    }
}
