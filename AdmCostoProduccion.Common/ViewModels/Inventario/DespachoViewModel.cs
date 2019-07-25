using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Models.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdmCostoProduccion.Common.ViewModels.Inventario
{
    public class DespachoViewModel : ObjectBase
    {
        #region Constructor

        public DespachoViewModel()
        {
        }

        public DespachoViewModel(Despacho model)
        {
            DespachoId = model.DespachoId;
            TipoDespachoId = model.TipoDespachoId;
            AlmacenId = model.AlmacenId;
            OrdenProduccionId = model.OrdenProduccionId;
            VentaId = model.VentaId;
            Codigo = model.Codigo;
            Observacion = model.Observacion;
            TipoDespacho = model.TipoDespacho.Nombre;
            Almacen = model.Almacen.Nombre;
            OrdenProduccion = model.OrdenProduccion.Codigo;
            Venta = model.Venta.NumeroDocumento;
            

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

        private int _OrdenProduccionId;

        private int _VentaId;

        private string _Codigo;

        private string _Observacion;

        private string _TipoDespacho;

        private string _Almacen;

        private string _OrdenProduccion;

        private string _Venta;

        private string _DocumentoRelacionado;

        private ObservableListSource<DespachoDetalleViewModel> _DespachoDetalleViewModels = new ObservableListSource<DespachoDetalleViewModel>();

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

        public int OrdenProduccionId
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

        public int VentaId
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

        public string OrdenProduccion
        {
            get
            {
                return _OrdenProduccion;
            }

            set
            {
                if (value != _OrdenProduccion)
                {
                    _OrdenProduccion = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Venta
        {
            get
            {
                return _Venta;
            }

            set
            {
                if (value != _Venta)
                {
                    _Venta = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string DocumentoRelacionado
        {
            get
            {
                return _DocumentoRelacionado;
            }

            set
            {
                if (value != _DocumentoRelacionado)
                {
                    _DocumentoRelacionado = value;
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

        public void CopyTo(ref DespachoViewModel viewModel)
        {
            viewModel.DespachoId = _DespachoId;
            viewModel.TipoDespachoId = _TipoDespachoId;
            viewModel.AlmacenId = _AlmacenId;
            viewModel.OrdenProduccionId = _OrdenProduccionId;
            viewModel.VentaId = _VentaId;
            viewModel.Codigo = _Codigo;
            viewModel.Observacion = _Observacion;
            viewModel.TipoDespacho = _TipoDespacho;
            viewModel.Almacen = _Almacen;
            viewModel.OrdenProduccion = _OrdenProduccion;
            viewModel.Venta = _Venta;
        }

        public Despacho ToModel()
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

            model.DespachoDetalles = new List<DespachoDetalle>();
            foreach (var viewModel in DespachoDetalleViewModels)
            {
                model.DespachoDetalles.Add(viewModel.ToModel());
            }

            return model;
        }

        #endregion
    }
}
