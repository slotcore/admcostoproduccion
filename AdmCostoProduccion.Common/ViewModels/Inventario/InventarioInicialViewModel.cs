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
    public class InventarioInicialViewModel : ObjectBase
    {
        #region Constructor

        public InventarioInicialViewModel()
        {
            _IsNew = true;
            _InventarioInicialId = Guid.NewGuid().ToString();
        }

        public InventarioInicialViewModel(InventarioInicial model)
        {
            _InventarioInicialId = model.InventarioInicialId;
            _AlmacenId = model.AlmacenId;
            _Codigo = model.Codigo;
            _Nombre = model.Nombre;
            _Descripcion = model.Descripcion;
            _Fecha = model.Fecha;
            _Observacion = model.Observacion;
            _Almacen = model.Almacen.Nombre;

            foreach (var child in model.InventarioInicialDetalles)
            {
                InventarioInicialDetalleViewModels.Add(new InventarioInicialDetalleViewModel(child));
            }
        }

        #endregion

        #region Propiedades privadas

        private string _InventarioInicialId;

        private string _AlmacenId;

        private string _Codigo;

        private string _Nombre;

        private string _Descripcion;

        private DateTime _Fecha;

        private string _Observacion;

        private string _Almacen;

        private ObservableListSource<InventarioInicialDetalleViewModel> _InventarioInicialDetalleViewModels
            = new ObservableListSource<InventarioInicialDetalleViewModel>();

        #endregion

        #region Propiedades publicas

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

        public ObservableListSource<InventarioInicialDetalleViewModel> InventarioInicialDetalleViewModels
        {
            get
            {
                return _InventarioInicialDetalleViewModels;
            }
            set
            {
                if (value != _InventarioInicialDetalleViewModels)
                {
                    _InventarioInicialDetalleViewModels = value;
                    NotifyPropertyChanged();
                }
            }
        }

        #endregion

        #region Metodos Publicos

        public void CopyOf(InventarioInicialViewModel viewModel)
        {
            _IsNew = viewModel.IsNew;
            _IsOld = viewModel.IsOld;
            _InventarioInicialId = viewModel.InventarioInicialId;
            _AlmacenId = viewModel.AlmacenId;
            _Codigo = viewModel.Codigo;
            _Nombre = viewModel.Nombre;
            _Descripcion = viewModel.Descripcion;
            _Fecha = viewModel.Fecha;
            _Observacion = viewModel.Observacion;
            _Almacen = viewModel.Almacen;
            _InventarioInicialDetalleViewModels = viewModel.InventarioInicialDetalleViewModels;
        }

        public InventarioInicial ToModel()
        {
            InventarioInicial model = new InventarioInicial
            {
                InventarioInicialId = _InventarioInicialId,
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
                    InventarioInicial model = this.ToModel();

                    if (IsNew)
                    {
                        context.InventarioInicials.Add(model);
                    }
                    else
                    {
                        if (IsOld)
                        {
                            context.Entry(model).State = EntityState.Modified;
                        }
                    }
                    //Childs
                    foreach (InventarioInicialDetalleViewModel viewModel in InventarioInicialDetalleViewModels)
                    {
                        viewModel.Grabar(context);
                    }
                    //Childs deletes
                    foreach (var viewModel in InventarioInicialDetalleViewModels.GetRemoveItems())
                    {
                        viewModel.Eliminar(context);
                    }
                    try
                    { 
                        context.SaveChanges();
                        //Se genera el movimiento de Recepcion
                        InventarioCommand.GenerarRecepcion(this, context);
                        _IsNew = false;
                        _IsOld = false;
                        _InventarioInicialId = model.InventarioInicialId;
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

            InventarioInicial model = this.ToModel();
            foreach (var viewInventarioInicialDetalle in InventarioInicialDetalleViewModels)
            {
                viewInventarioInicialDetalle.Eliminar(Context);
            }
            Context.Entry(model).State = EntityState.Deleted;
            Context.SaveChanges();
        }

        #endregion
    }
}
