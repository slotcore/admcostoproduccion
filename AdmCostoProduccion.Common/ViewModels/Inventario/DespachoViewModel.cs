using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Data;
using AdmCostoProduccion.Common.Enum;
using AdmCostoProduccion.Common.Models.Inventario;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace AdmCostoProduccion.Common.ViewModels.Inventario
{
    public class DespachoViewModel : ObjectBase
    {
        #region Constructor

        public DespachoViewModel()
        {
            _IsNew = true;
        }

        public DespachoViewModel(Despacho model)
        {
            _DespachoId = model.DespachoId;
            _TipoDespachoId = model.TipoDespachoId;
            _AlmacenId = model.AlmacenId;
            _OrdenProduccionId = model.OrdenProduccionId;
            _VentaId = model.VentaId;
            _Codigo = model.Codigo;
            _Observacion = model.Observacion;
            _TipoDespacho = model.TipoDespacho.Nombre;
            _Almacen = model.Almacen.Nombre;

            if (model.Venta != null)
            {
                _TipoDocumentoRelacionado = TipoDocumentoEnum.Venta;
                _NumeroDocumentoRelacionado = model.Venta.NumeroDocumento;
            }
            if (model.OrdenProduccion != null)
            {
                _TipoDocumentoRelacionado = TipoDocumentoEnum.OrdenProduccion;
                _NumeroDocumentoRelacionado = model.OrdenProduccion.Codigo;
            }

            foreach (var recepcionDetalle in model.DespachoDetalles)
            {
                DespachoDetalleViewModels.Add(new DespachoDetalleViewModel(recepcionDetalle));
            }
        }

        #endregion

        #region Propiedades privadas

        private int _DespachoId;

        private int _TipoDespachoId;

        private int _AlmacenId;

        private int? _OrdenProduccionId;

        private int? _VentaId;

        private string _Codigo;

        private string _Observacion;

        private string _TipoDespacho;

        private string _Almacen;

        private string _TipoDocumentoRelacionado;

        private string _NumeroDocumentoRelacionado;

        private ObservableListSource<DespachoDetalleViewModel> _DespachoDetalleViewModels 
            = new ObservableListSource<DespachoDetalleViewModel>();

        #endregion

        #region Propiedades publicas

        public int DespachoId
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

        public int TipoDespachoId
        {
            get
            {
                return _TipoDespachoId;
            }

            set
            {
                if (value != _TipoDespachoId)
                {
                    _TipoDespachoId = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public int AlmacenId
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

        public int? OrdenProduccionId
        {
            get
            {
                return _OrdenProduccionId;
            }

            set
            {
                if (value != _OrdenProduccionId)
                {
                    _OrdenProduccionId = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public int? VentaId
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

        public string Codigo
        {
            get
            {
                return _Codigo;
            }

            set
            {
                if (value != _Codigo)
                {
                    _Codigo = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Observacion
        {
            get
            {
                return _Observacion;
            }

            set
            {
                if (value != _Observacion)
                {
                    _Observacion = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string TipoDespacho
        {
            get
            {
                return _TipoDespacho;
            }

            set
            {
                if (value != _TipoDespacho)
                {
                    _TipoDespacho = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Almacen
        {
            get
            {
                return _Almacen;
            }

            set
            {
                if (value != _Almacen)
                {
                    _Almacen = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string TipoDocumentoRelacionado
        {
            get
            {
                return _TipoDocumentoRelacionado;
            }

            set
            {
                if (value != _TipoDocumentoRelacionado)
                {
                    _TipoDocumentoRelacionado = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string NumeroDocumentoRelacionado
        {
            get
            {
                return _NumeroDocumentoRelacionado;
            }

            set
            {
                if (value != _NumeroDocumentoRelacionado)
                {
                    _NumeroDocumentoRelacionado = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public virtual ObservableListSource<DespachoDetalleViewModel> DespachoDetalleViewModels
        {
            get
            {
                return _DespachoDetalleViewModels;
            }
            set
            {
                if (value != _DespachoDetalleViewModels)
                {
                    _DespachoDetalleViewModels = value;
                    NotifyPropertyChanged();
                }
            }
        }

        #endregion

        #region Metodos Publicos

        public void CopyOf(DespachoViewModel viewModel)
        {
            _IsNew = viewModel.IsNew;
            _IsOld = viewModel.IsOld;
            _DespachoId = viewModel.DespachoId;
            _TipoDespachoId = viewModel.TipoDespachoId;
            _AlmacenId = viewModel.AlmacenId;
            _OrdenProduccionId = viewModel.OrdenProduccionId;
            _VentaId = viewModel.VentaId;
            _Codigo = viewModel.Codigo;
            _Observacion = viewModel.Observacion;
            _TipoDespacho = viewModel.TipoDespacho;
            _Almacen = viewModel.Almacen;
            _TipoDocumentoRelacionado = viewModel.TipoDocumentoRelacionado;
            _NumeroDocumentoRelacionado = viewModel.NumeroDocumentoRelacionado;
            _DespachoDetalleViewModels = viewModel.DespachoDetalleViewModels;
        }

        private Despacho ToModel()
        {
            Despacho model = new Despacho
            {
                DespachoId = _DespachoId,
                TipoDespachoId = _TipoDespachoId,
                AlmacenId = _AlmacenId,
                OrdenProduccionId = _OrdenProduccionId,
                VentaId = _VentaId,
                Codigo = _Codigo,
                Observacion = _Observacion
            };

            return model;
        }

        public void Grabar()
        {
            ApplicationDbContext Context = new ApplicationDbContext();
            Despacho model = this.ToModel();

            if (IsNew)
            {
                Context.Despachos.Add(model);
            }
            else
            {
                if (IsOld)
                {
                    Context.Entry(model).State = EntityState.Modified;
                }
            }
            if (DespachoDetalleViewModels.Count > 0)
            {
                foreach (DespachoDetalleViewModel viewModel in DespachoDetalleViewModels)
                {
                    viewModel.Grabar(Context);
                }
            }
            Context.SaveChanges();
            _IsNew = false;
            _IsOld = false;
            _DespachoId = model.DespachoId;
        }

        #endregion
    }
}
