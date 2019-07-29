using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Data;
using AdmCostoProduccion.Common.Enum;
using AdmCostoProduccion.Common.Models.Inventario;
using System;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace AdmCostoProduccion.Common.ViewModels.Inventario
{
    public class RecepcionViewModel : ObjectBase
    {
        #region Constructor

        public RecepcionViewModel()
        {
            _IsNew = true;
        }

        public RecepcionViewModel(Recepcion model)
        {
            _RecepcionId = model.RecepcionId;
            _TipoRecepcionId = model.TipoRecepcionId;
            _AlmacenId = model.AlmacenId;
            _OrdenProduccionId = model.OrdenProduccionId;
            _CompraId = model.CompraId;
            _Codigo = model.Codigo;
            _Observacion = model.Observacion;
            _TipoRecepcion = model.TipoRecepcion.Nombre;
            _Almacen = model.Almacen.Nombre;

            if (model.Compra != null)
            {
                _TipoDocumentoRelacionado = TipoDocumentoEnum.Compra;
                _NumeroDocumentoRelacionado = model.Compra.NumeroDocumento;
            }
            if (model.OrdenProduccion != null)
            {
                _TipoDocumentoRelacionado = TipoDocumentoEnum.OrdenProduccion;
                _NumeroDocumentoRelacionado = model.OrdenProduccion.Codigo;
            }

            foreach (var child in model.RecepcionDetalles)
            {
                RecepcionDetalleViewModels.Add(new RecepcionDetalleViewModel(child));
            }
        }

        #endregion

        #region Propiedades privadas

        private int _RecepcionId;

        private int _TipoRecepcionId;

        private int _AlmacenId;

        private int? _OrdenProduccionId;

        private int? _CompraId;

        private string _Codigo;

        private string _Observacion;

        private string _TipoRecepcion;

        private string _Almacen;

        private string _TipoDocumentoRelacionado;

        private string _NumeroDocumentoRelacionado;

        private ObservableListSource<RecepcionDetalleViewModel> _RecepcionDetalleViewModels
            = new ObservableListSource<RecepcionDetalleViewModel>();

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

        public int? CompraId
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

        public ObservableListSource<RecepcionDetalleViewModel> RecepcionDetalleViewModels
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

        public void CopyOf(RecepcionViewModel viewModel)
        {
            _IsNew = viewModel.IsNew;
            _IsOld = viewModel.IsOld;
            _RecepcionId = viewModel.RecepcionId;
            _TipoRecepcionId = viewModel.TipoRecepcionId;
            _AlmacenId = viewModel.AlmacenId;
            _OrdenProduccionId = viewModel.OrdenProduccionId;
            _CompraId = viewModel.CompraId;
            _Codigo = viewModel.Codigo;
            _Observacion = viewModel.Observacion;
            _TipoRecepcion = viewModel.TipoRecepcion;
            _Almacen = viewModel.Almacen;
            _TipoDocumentoRelacionado = viewModel.TipoDocumentoRelacionado;
            _NumeroDocumentoRelacionado = viewModel.NumeroDocumentoRelacionado;
            _RecepcionDetalleViewModels = viewModel.RecepcionDetalleViewModels;
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

            return model;
        }

        public void Grabar()
        {
            ApplicationDbContext Context = new ApplicationDbContext();
            Recepcion model = this.ToModel();

            if (IsNew)
            {
                Context.Recepcions.Add(model);
            }
            else
            {
                if (IsOld)
                {
                    Context.Entry(model).State = EntityState.Modified;
                }
            }
            //Childs
            foreach (RecepcionDetalleViewModel viewModel in RecepcionDetalleViewModels)
            {
                viewModel.Grabar(Context);
            }
            //Childs deletes
            foreach (var viewModel in RecepcionDetalleViewModels.GetRemoveItems())
            {
                viewModel.Eliminar(Context);
            }
            Context.SaveChanges();
            _IsNew = false;
            _IsOld = false;
            _RecepcionId = model.RecepcionId;
        }

        public void Eliminar()
        {
            ApplicationDbContext Context = new ApplicationDbContext();

            Recepcion model = this.ToModel();
            foreach (var viewModelChild in RecepcionDetalleViewModels)
            {
                viewModelChild.Eliminar(Context);
            }
            Context.Entry(model).State = EntityState.Deleted;
            Context.SaveChanges();
        }

        #endregion
    }
}
