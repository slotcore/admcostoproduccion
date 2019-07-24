using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Models.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdmCostoProduccion.Common.ViewModels.Inventario
{
    public class RecepcionViewModel : ObjectBase
    {
        #region Constructor

        public RecepcionViewModel()
        {
        }

        public RecepcionViewModel(Recepcion model)
        {
            RecepcionId = model.RecepcionId;
            TipoRecepcionId = model.TipoRecepcionId;
            AlmacenId = model.AlmacenId;
            OrdenProduccionId = model.OrdenProduccionId;
            CompraId = model.CompraId;
            Codigo = model.Codigo;
            Observacion = model.Observacion;
            TipoRecepcion = model.TipoRecepcion.Nombre;
            Almacen = model.Almacen.Nombre;
            OrdenProduccion = model.OrdenProduccion.Codigo;
            Compra = model.Compra.NumeroDocumento;

            foreach (var recepcionDetalle in model.RecepcionDetalles)
            {
                RecepcionDetalleViewModels.Add(new RecepcionDetalleViewModel(recepcionDetalle));
            }
        }

        #endregion

        #region Propiedades privadas

        private int _RecepcionId;

        private int _TipoRecepcionId;

        private int _AlmacenId;

        private int _OrdenProduccionId;

        private int _CompraId;

        private string _Codigo;

        private string _Observacion;

        private string _TipoRecepcion;

        private string _Almacen;

        private string _OrdenProduccion;

        private string _Compra;

        private ObservableListSource<RecepcionDetalleViewModel> _RecepcionDetalleViewModels = new ObservableListSource<RecepcionDetalleViewModel>();

        #endregion

        #region Propiedades publicas

        public int RecepcionId
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

        public int TipoRecepcionId
        {
            get
            {
                return _TipoRecepcionId;
            }

            set
            {
                if (value != _TipoRecepcionId)
                {
                    _TipoRecepcionId = value;
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

        public int CompraId
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

        public string TipoRecepcion
        {
            get
            {
                return _TipoRecepcion;
            }

            set
            {
                if (value != _TipoRecepcion)
                {
                    _TipoRecepcion = value;
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

        public string Compra
        {
            get
            {
                return _Compra;
            }

            set
            {
                if (value != _Compra)
                {
                    _Compra = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public virtual ObservableListSource<RecepcionDetalleViewModel> RecepcionDetalleViewModels
        {
            get
            {
                return _RecepcionDetalleViewModels;
            }
            set
            {
                if (value != _RecepcionDetalleViewModels)
                {
                    _RecepcionDetalleViewModels = value;
                    NotifyPropertyChanged();
                }
            }
        }

        #endregion

        #region Metodos Publicos

        public void CopyTo(ref RecepcionViewModel viewModel)
        {
            viewModel.RecepcionId = _RecepcionId;
            viewModel.TipoRecepcionId = _TipoRecepcionId;
            viewModel.AlmacenId = _AlmacenId;
            viewModel.OrdenProduccionId = _OrdenProduccionId;
            viewModel.CompraId = _CompraId;
            viewModel.Codigo = _Codigo;
            viewModel.Observacion = _Observacion;
            viewModel.TipoRecepcion = _TipoRecepcion;
            viewModel.Almacen = _Almacen;
            viewModel.OrdenProduccion = _OrdenProduccion;
            viewModel.Compra = _Compra;
        }

        public Recepcion ToModel()
        {
            Recepcion model = new Recepcion
            {
                RecepcionId = _RecepcionId,
                TipoRecepcionId = _TipoRecepcionId,
                AlmacenId = _AlmacenId,
                OrdenProduccionId = _OrdenProduccionId,
                CompraId = _CompraId,
                Codigo = _Codigo,
                Observacion = _Observacion
            };

            model.RecepcionDetalles = new List<RecepcionDetalle>();
            foreach (var viewModel in RecepcionDetalleViewModels)
            {
                model.RecepcionDetalles.Add(viewModel.ToModel());
            }

            return model;
        }

        #endregion
    }
}
