using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Data;
using AdmCostoProduccion.Common.Models.Inventario;
using System;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace AdmCostoProduccion.Common.ViewModels.Inventario
{
    public class KardexMovimientoViewModel : ObjectBase
    {
        #region Constructor

        public KardexMovimientoViewModel(string parentId)
        {
            _IsNew = true;
            _KardexId = parentId;
            _KardexMovimientoId = Guid.NewGuid().ToString();
        }

        public KardexMovimientoViewModel(KardexMovimiento model)
        {
            _KardexMovimientoId = model.KardexMovimientoId;
            _KardexId = model.KardexId;
            _TipoMovimientoId = model.TipoMovimientoId;
            _RecepcionDetalleId = model.RecepcionDetalleId;
            _DespachoDetalleId = model.DespachoDetalleId;
            _MercaderiaId = model.MercaderiaId;
            _UnidadMedidaId = model.UnidadMedidaId;
            _Cantidad = model.Cantidad;
        }

        #endregion

        #region Propiedades privadas

        private string _KardexMovimientoId;

        private string _KardexId;

        private string _TipoMovimientoId;

        private string _RecepcionDetalleId;

        private string _DespachoDetalleId;

        private string _MercaderiaId;

        private string _UnidadMedidaId;

        private double _Cantidad;

        #endregion

        #region Propiedades publicas

        public string KardexMovimientoId
        {
            get
            {
                return _KardexMovimientoId;
            }

            set
            {
                if (value != _KardexMovimientoId)
                {
                    _KardexMovimientoId = value;
                    NotifyPropertyChanged();
                }
            }
        }

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

        public string TipoMovimientoId
        {
            get
            {
                return _TipoMovimientoId;
            }

            set
            {
                if (value != _TipoMovimientoId)
                {
                    _TipoMovimientoId = value;
                    NotifyPropertyChanged();
                }
            }
        }

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

        #endregion

        #region Metodos Publicos

        public void CopyOf(KardexMovimientoViewModel viewModel)
        {
            _IsNew = viewModel.IsNew;
            _IsOld = viewModel.IsOld;
            _KardexMovimientoId = viewModel.KardexMovimientoId;
            _KardexId = viewModel.KardexId;
            _TipoMovimientoId = viewModel.TipoMovimientoId;
            _RecepcionDetalleId = viewModel.RecepcionDetalleId;
            _DespachoDetalleId = viewModel.DespachoDetalleId;
            _MercaderiaId = viewModel.MercaderiaId;
            _UnidadMedidaId = viewModel.UnidadMedidaId;
            _Cantidad = viewModel.Cantidad;
        }

        public KardexMovimiento ToModel()
        {
            KardexMovimiento model = new KardexMovimiento
            {
                KardexMovimientoId = _KardexMovimientoId,
                KardexId = _KardexId,
                TipoMovimientoId = _TipoMovimientoId,
                RecepcionDetalleId = _RecepcionDetalleId,
                DespachoDetalleId = _DespachoDetalleId,
                MercaderiaId = _MercaderiaId,
                UnidadMedidaId = _UnidadMedidaId,
                Cantidad = _Cantidad
            };

            return model;
        }

        public void Grabar(ApplicationDbContext Context)
        {
            KardexMovimiento model = this.ToModel();

            if (IsNew) Context.KardexMovimientos.Add(model);
            else
            {
                if (IsOld) Context.Entry(model).State = EntityState.Modified;
            }
        }

        public void Eliminar(ApplicationDbContext Context)
        {
            if (!IsNew)
            {
                KardexMovimiento model = this.ToModel();
                Context.Entry(model).State = EntityState.Deleted;
            }
        }

        #endregion
    }
}
