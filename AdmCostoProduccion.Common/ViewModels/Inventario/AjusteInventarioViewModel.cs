using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Commands.Inventario;
using AdmCostoProduccion.Common.Data;
using AdmCostoProduccion.Common.Models.Inventario;
using System;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace AdmCostoProduccion.Common.ViewModels.Inventario
{
    public class AjusteInventarioViewModel : ObjectBase
    {
        #region Constructor

        public AjusteInventarioViewModel()
        {
            _IsNew = true;
            _AjusteInventarioId = Guid.NewGuid().ToString();
        }

        public AjusteInventarioViewModel(AjusteInventario model)
        {
            _AjusteInventarioId = model.AjusteInventarioId;
            _TipoAjusteInventarioId = model.TipoAjusteInventarioId;
            _AlmacenId = model.AlmacenId;
            _Codigo = model.Codigo;
            _Nombre = model.Nombre;
            _Descripcion = model.Descripcion;
            _Fecha = model.Fecha;
            _Observacion = model.Observacion;
            _TipoAjusteInventario = model.TipoAjusteInventario.Nombre;
            _Almacen = model.Almacen.Nombre;

            foreach (var child in model.AjusteInventarioDetalles)
            {
                AjusteInventarioDetalleViewModels.Add(new AjusteInventarioDetalleViewModel(child));
            }
        }

        #endregion

        #region Propiedades privadas

        private string _AjusteInventarioId;

        private string _TipoAjusteInventarioId;

        private string _AlmacenId;

        private string _Codigo;

        private string _Nombre;

        private string _Descripcion;

        private DateTime _Fecha;

        private string _Observacion;

        private string _TipoAjusteInventario;

        private string _Almacen;

        private ObservableListSource<AjusteInventarioDetalleViewModel> _AjusteInventarioDetalleViewModels
            = new ObservableListSource<AjusteInventarioDetalleViewModel>();

        #endregion

        #region Propiedades publicas

        public string AjusteInventarioId
        {
            get
            {
                return _AjusteInventarioId;
            }

            set
            {
                if (value != _AjusteInventarioId)
                {
                    _AjusteInventarioId = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string TipoAjusteInventarioId
        {
            get
            {
                return _TipoAjusteInventarioId;
            }

            set
            {
                if (value != _TipoAjusteInventarioId)
                {
                    _TipoAjusteInventarioId = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string AlmacenId
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

        public string Nombre
        {
            get
            {
                return _Nombre;
            }

            set
            {
                if (value != _Nombre)
                {
                    _Nombre = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Descripcion
        {
            get
            {
                return _Descripcion;
            }

            set
            {
                if (value != _Descripcion)
                {
                    _Descripcion = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public DateTime Fecha
        {
            get
            {
                return _Fecha;
            }

            set
            {
                if (value != _Fecha)
                {
                    _Fecha = value;
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

        public string TipoAjusteInventario
        {
            get
            {
                return _TipoAjusteInventario;
            }

            set
            {
                if (value != _TipoAjusteInventario)
                {
                    _TipoAjusteInventario = value;
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

        public ObservableListSource<AjusteInventarioDetalleViewModel> AjusteInventarioDetalleViewModels
        {
            get
            {
                return _AjusteInventarioDetalleViewModels;
            }
            set
            {
                if (value != _AjusteInventarioDetalleViewModels)
                {
                    _AjusteInventarioDetalleViewModels = value;
                    NotifyPropertyChanged();
                }
            }
        }

        #endregion

        #region Metodos Publicos

        public void CopyOf(AjusteInventarioViewModel viewModel)
        {
            _IsNew = viewModel.IsNew;
            _IsOld = viewModel.IsOld;
            _AjusteInventarioId = viewModel.AjusteInventarioId;
            _TipoAjusteInventarioId = viewModel.TipoAjusteInventarioId;
            _AlmacenId = viewModel.AlmacenId;
            _Codigo = viewModel.Codigo;
            _Nombre = viewModel.Nombre;
            _Descripcion = viewModel.Descripcion;
            _Fecha = viewModel.Fecha;
            _Observacion = viewModel.Observacion;
            _TipoAjusteInventario = viewModel.TipoAjusteInventario;
            _Almacen = viewModel.Almacen;
            _AjusteInventarioDetalleViewModels = viewModel.AjusteInventarioDetalleViewModels;
        }

        public AjusteInventario ToModel()
        {
            AjusteInventario model = new AjusteInventario
            {
                AjusteInventarioId = _AjusteInventarioId,
                TipoAjusteInventarioId = _TipoAjusteInventarioId,
                AlmacenId = _AlmacenId,
                Codigo = _Codigo,
                Nombre = _Nombre,
                Descripcion = _Descripcion,
                Fecha = _Fecha,
                Observacion = _Observacion
            };

            return model;
        }

        public void Grabar()
        {
            using (var context = new ApplicationDbContext())
            {
                using (var dbContextTransaction = context.Database.BeginTransaction())
                {
                    AjusteInventario model = this.ToModel();

                    if (IsNew)
                    {
                        context.AjusteInventarios.Add(model);
                    }
                    else
                    {
                        if (IsOld)
                        {
                            context.Entry(model).State = EntityState.Modified;
                        }
                    }
                    //Childs
                    foreach (AjusteInventarioDetalleViewModel viewModel in AjusteInventarioDetalleViewModels)
                    {
                        viewModel.Grabar(context);
                    }
                    //Childs deletes
                    foreach (var viewModel in AjusteInventarioDetalleViewModels.GetRemoveItems())
                    {
                        viewModel.Eliminar(context);
                    }
                    try
                    { 
                        context.SaveChanges();
                        //Se genera el movimiento
                        var tipoAjusteInventario = context.TipoAjusteInventarios
                            .FirstOrDefault(o => o.TipoAjusteInventarioId == _TipoAjusteInventarioId);
                        switch (tipoAjusteInventario.Codigo)
                        {
                            case "AJI":
                                //Recepcion
                                InventarioCommand.GenerarRecepcion(this, context);
                                break;

                            case "AJS":
                                //Despacho
                                InventarioCommand.GenerarDespacho(this, context);
                                break;

                        }
                        _IsNew = false;
                        _IsOld = false;
                        _AjusteInventarioId = model.AjusteInventarioId;
                    }
                    catch (Exception ex)
                    {
                        dbContextTransaction.Rollback();
                        throw ex;
                    }
                }
            }
        }

        public void Eliminar()
        {
            ApplicationDbContext Context = new ApplicationDbContext();

            AjusteInventario model = this.ToModel();
            foreach (var viewModelChild in AjusteInventarioDetalleViewModels)
            {
                viewModelChild.Eliminar(Context);
            }
            Context.Entry(model).State = EntityState.Deleted;
            Context.SaveChanges();
        }

        #endregion
    }
}
