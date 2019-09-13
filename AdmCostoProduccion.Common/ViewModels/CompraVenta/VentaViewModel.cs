using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Commands.Inventario;
using AdmCostoProduccion.Common.Data;
using AdmCostoProduccion.Common.Models.CompraVenta;
using System;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace AdmCostoProduccion.Common.ViewModels.CompraVenta
{
    public class VentaViewModel : ObjectBase
    {
        #region Constructor

        public VentaViewModel()
        {
            _IsNew = true;
            _VentaId = Guid.NewGuid().ToString();
            _Fecha = DateTime.Today;
        }

        public VentaViewModel(Venta model)
        {
            _VentaId = model.VentaId;
            _CentroLogisticoId = model.CentroLogisticoId;
            _NumeroDocumento = model.NumeroDocumento;
            _Fecha = model.Fecha;
            _Descripcion = model.Descripcion;
            _CentroLogistico = model.CentroLogistico.Nombre;

            foreach (var child in model.VentaDetalles)
            {
                VentaDetalleViewModels.Add(new VentaDetalleViewModel(child));
            }
        }

        #endregion

        #region Propiedades privadas

        private string _VentaId;

        private string _CentroLogisticoId;

        private string _NumeroDocumento;

        private DateTime _Fecha;

        private string _Descripcion;

        private string _CentroLogistico;

        private ObservableListSource<VentaDetalleViewModel> _VentaDetalleViewModels
            = new ObservableListSource<VentaDetalleViewModel>();

        #endregion

        #region Propiedades publicas

        public string VentaId
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

        public string CentroLogisticoId
        {
            get
            {
                return _CentroLogisticoId;
            }

            set
            {
                if (value != _CentroLogisticoId)
                {
                    _CentroLogisticoId = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string NumeroDocumento
        {
            get
            {
                return _NumeroDocumento;
            }

            set
            {
                if (value != _NumeroDocumento)
                {
                    _NumeroDocumento = value;
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

        public string CentroLogistico
        {
            get
            {
                return _CentroLogistico;
            }

            set
            {
                if (value != _CentroLogistico)
                {
                    _CentroLogistico = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public ObservableListSource<VentaDetalleViewModel> VentaDetalleViewModels
        {
            get
            {
                return _VentaDetalleViewModels;
            }
            set
            {
                if (value != _VentaDetalleViewModels)
                {
                    _VentaDetalleViewModels = value;
                    NotifyPropertyChanged();
                }
            }
        }

        #endregion

        #region Metodos Publicos

        public void CopyOf(VentaViewModel viewModel)
        {
            _IsNew = viewModel.IsNew;
            _IsOld = viewModel.IsOld;
            _VentaId = viewModel.VentaId;
            _CentroLogisticoId = viewModel.CentroLogisticoId;
            _NumeroDocumento = viewModel.NumeroDocumento;
            _Fecha = viewModel.Fecha;
            _Descripcion = viewModel.Descripcion;
            _CentroLogistico = viewModel.CentroLogistico;
            _VentaDetalleViewModels = viewModel.VentaDetalleViewModels;
        }

        public Venta ToModel()
        {
            Venta model = new Venta
            {
                VentaId = _VentaId,
                CentroLogisticoId = _CentroLogisticoId,
                NumeroDocumento = _NumeroDocumento,
                Fecha = _Fecha,
                Descripcion = _Descripcion
            };

            return model;
        }

        public void Grabar()
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                using (var dbContextTransaction = context.Database.BeginTransaction())
                {
                    Venta model = this.ToModel();

                    if (IsNew)
                    {
                        context.Ventas.Add(model);
                    }
                    else
                    {
                        if (IsOld)
                        {
                            context.Entry(model).State = EntityState.Modified;
                        }
                    }
                    //Childs
                    foreach (VentaDetalleViewModel viewModel in VentaDetalleViewModels)
                    {
                        viewModel.Grabar(context);
                    }
                    //Childs deletes
                    foreach (var viewModel in VentaDetalleViewModels.GetRemoveItems())
                    {
                        viewModel.Eliminar(context);
                    }

                    try
                    {
                        context.SaveChanges();
                        var aplicacionConfiguracion = context.AplicacionConfiguracions.FirstOrDefault();
                        if (aplicacionConfiguracion == null) throw new Exception("No existe registro de configuración¡¡");
                        if (aplicacionConfiguracion.VentaGeneraDespacho)
                        {
                            //Se genera el despacho
                            InventarioCommand.GenerarDespacho(this, context);
                        }
                        dbContextTransaction.Commit();

                        _IsNew = false;
                        _IsOld = false;
                        _VentaId = model.VentaId;
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

            Venta model = this.ToModel();
            foreach (var viewModelChild in VentaDetalleViewModels)
            {
                viewModelChild.Eliminar(Context);
            }
            Context.Entry(model).State = EntityState.Deleted;
            Context.SaveChanges();
        }

        #endregion
    }
}
