using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Data;
using AdmCostoProduccion.Common.Models.Produccion;
using System;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace AdmCostoProduccion.Common.ViewModels.Produccion
{
    public class OrdenProduccionViewModel : ObjectBase
    {
        #region Constructor

        public OrdenProduccionViewModel()
        {
            _IsNew = true;
            _OrdenProduccionId = Guid.NewGuid().ToString();
        }

        public OrdenProduccionViewModel(OrdenProduccion model)
        {
            _OrdenProduccionId = model.OrdenProduccionId;
            _PlantaFabricacionId = model.PlantaFabricacionId;
            _MercaderiaId = model.MercaderiaId;
            _ProcedimientoProduccionId = model.ProcedimientoProduccionId;
            _UnidadMedidaId = model.ProcedimientoProduccionId;
            _Codigo = model.Codigo;
            _Fecha = model.Fecha;
            _Cantidad = model.Cantidad;
            _Lote = model.Lote;
            _PlantaFabricacion = model.PlantaFabricacion.Nombre;
            _CodigoMercaderia = model.Mercaderia.Codigo;
            _NombreMercaderia = model.Mercaderia.Nombre;
            _ProcedimientoProduccion = model.ProcedimientoProduccion.Nombre;
            _UnidadMedida = model.UnidadMedida.Nombre;

            foreach (var child in model.OrdenProduccionInsumos)
            {
                OrdenProduccionInsumoViewModels.Add(new OrdenProduccionInsumoViewModel(child));
            }
        }

        #endregion

        #region Propiedades privadas

        private string _OrdenProduccionId;

        private string _PlantaFabricacionId;

        private string _MercaderiaId;

        private string _ProcedimientoProduccionId;

        private string _UnidadMedidaId;

        private string _Codigo;

        private DateTime _Fecha;

        private double _Cantidad;

        private string _Lote;

        private string _PlantaFabricacion;

        private string _CodigoMercaderia;

        private string _NombreMercaderia;

        private string _ProcedimientoProduccion;

        private string _UnidadMedida;

        private ObservableListSource<OrdenProduccionInsumoViewModel> _OrdenProduccionInsumoViewModels
            = new ObservableListSource<OrdenProduccionInsumoViewModel>();

        #endregion

        #region Propiedades publicas

        public string OrdenProduccionId
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

        public string PlantaFabricacionId
        {
            get
            {
                return _PlantaFabricacionId;
            }

            set
            {
                if (value != _PlantaFabricacionId)
                {
                    _PlantaFabricacionId = value;
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

        public string ProcedimientoProduccionId
        {
            get
            {
                return _ProcedimientoProduccionId;
            }

            set
            {
                if (value != _ProcedimientoProduccionId)
                {
                    _ProcedimientoProduccionId = value;
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

        public string Lote
        {
            get
            {
                return _Lote;
            }

            set
            {
                if (value != _Lote)
                {
                    _Lote = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string PlantaFabricacion
        {
            get
            {
                return _PlantaFabricacion;
            }

            set
            {
                if (value != _PlantaFabricacion)
                {
                    _PlantaFabricacion = value;
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

        public string ProcedimientoProduccion
        {
            get
            {
                return _ProcedimientoProduccion;
            }

            set
            {
                if (value != _ProcedimientoProduccion)
                {
                    _ProcedimientoProduccion = value;
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

        public ObservableListSource<OrdenProduccionInsumoViewModel> OrdenProduccionInsumoViewModels
        {
            get
            {
                return _OrdenProduccionInsumoViewModels;
            }
            set
            {
                if (value != _OrdenProduccionInsumoViewModels)
                {
                    _OrdenProduccionInsumoViewModels = value;
                    NotifyPropertyChanged();
                }
            }
        }

        #endregion

        #region Metodos Publicos

        public void CopyOf(OrdenProduccionViewModel viewModel)
        {
            _IsNew = viewModel.IsNew;
            _IsOld = viewModel.IsOld;
            _OrdenProduccionId = viewModel.OrdenProduccionId;
            _PlantaFabricacionId = viewModel.PlantaFabricacionId;
            _MercaderiaId = viewModel.MercaderiaId;
            _ProcedimientoProduccionId = viewModel.ProcedimientoProduccionId;
            _UnidadMedidaId = viewModel.UnidadMedidaId;
            _Codigo = viewModel.Codigo;
            _Fecha = viewModel.Fecha;
            _Cantidad = viewModel.Cantidad;
            _Lote = viewModel.Lote;
            _PlantaFabricacion = viewModel.PlantaFabricacion;
            _CodigoMercaderia = viewModel.CodigoMercaderia;
            _NombreMercaderia = viewModel.NombreMercaderia;
            _ProcedimientoProduccion = viewModel.ProcedimientoProduccion;
            _UnidadMedida = viewModel.UnidadMedida;
            _OrdenProduccionInsumoViewModels = viewModel.OrdenProduccionInsumoViewModels;
        }

        public OrdenProduccion ToModel()
        {
            OrdenProduccion model = new OrdenProduccion
            {
                OrdenProduccionId = _OrdenProduccionId,
                PlantaFabricacionId = _PlantaFabricacionId,
                MercaderiaId = _MercaderiaId,
                ProcedimientoProduccionId = _ProcedimientoProduccionId,
                UnidadMedidaId = _UnidadMedidaId,
                Codigo = _Codigo,
                Fecha = _Fecha,
                Cantidad = _Cantidad,
                Lote = _Lote
            };

            return model;
        }

        public void Grabar()
        {
            ApplicationDbContext Context = new ApplicationDbContext();
            OrdenProduccion model = this.ToModel();

            if (IsNew)
            {
                Context.OrdenProduccions.Add(model);
            }
            else
            {
                if (IsOld)
                {
                    Context.Entry(model).State = EntityState.Modified;
                }
            }
            //Childs
            foreach (OrdenProduccionInsumoViewModel viewModel in OrdenProduccionInsumoViewModels)
            {
                viewModel.Grabar(Context);
            }
            //Childs deletes
            foreach (var viewModel in OrdenProduccionInsumoViewModels.GetRemoveItems())
            {
                viewModel.Eliminar(Context);
            }
            Context.SaveChanges();
            _IsNew = false;
            _IsOld = false;
            _OrdenProduccionId = model.OrdenProduccionId;
        }

        public void Eliminar()
        {
            ApplicationDbContext Context = new ApplicationDbContext();

            OrdenProduccion model = this.ToModel();
            foreach (var viewModelChild in OrdenProduccionInsumoViewModels)
            {
                viewModelChild.Eliminar(Context);
            }
            Context.Entry(model).State = EntityState.Deleted;
            Context.SaveChanges();
        }

        #endregion
    }
}
