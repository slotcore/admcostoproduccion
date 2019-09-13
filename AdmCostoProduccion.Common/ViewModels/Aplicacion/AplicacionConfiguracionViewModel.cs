using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Data;
using AdmCostoProduccion.Common.Models.Aplicacion;
using System;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace AdmCostoProduccion.Common.ViewModels.Aplicacion
{
    public class AplicacionConfiguracionViewModel : ObjectBase
    {
        #region Constructor

        public AplicacionConfiguracionViewModel()
        {
            _IsNew = true;
            _AplicacionConfiguracionId = Guid.NewGuid().ToString();
        }

        public AplicacionConfiguracionViewModel(AplicacionConfiguracion model)
        {
            _AplicacionConfiguracionId = model.AplicacionConfiguracionId;
            _RecepcionGeneraMovimiento = model.CompraGeneraRecepcion;
            _DespachoGeneraMovimiento = model.VentaGeneraDespacho;
            _OrdenProduccionGeneraMovimiento = model.OrdenProduccionGeneraMovimiento;
            _OrdenProduccionGeneraMovimientoInsumos = model.OrdenProduccionGeneraMovimientoInsumos;
        }

        #endregion

        #region Propiedades privadas

        private string _AplicacionConfiguracionId;

        private bool _RecepcionGeneraMovimiento;

        private bool _DespachoGeneraMovimiento;

        private bool _OrdenProduccionGeneraMovimiento;

        private bool _OrdenProduccionGeneraMovimientoInsumos;

        #endregion

        #region Propiedades publicas

        public string AplicacionConfiguracionId
        {
            get
            {
                return _AplicacionConfiguracionId;
            }

            set
            {
                if (value != _AplicacionConfiguracionId)
                {
                    _AplicacionConfiguracionId = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public bool RecepcionGeneraMovimiento
        {
            get
            {
                return _RecepcionGeneraMovimiento;
            }

            set
            {
                if (value != _RecepcionGeneraMovimiento)
                {
                    _RecepcionGeneraMovimiento = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public bool DespachoGeneraMovimiento
        {
            get
            {
                return _DespachoGeneraMovimiento;
            }

            set
            {
                if (value != _DespachoGeneraMovimiento)
                {
                    _DespachoGeneraMovimiento = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public bool OrdenProduccionGeneraMovimiento
        {
            get
            {
                return _OrdenProduccionGeneraMovimiento;
            }

            set
            {
                if (value != _OrdenProduccionGeneraMovimiento)
                {
                    _OrdenProduccionGeneraMovimiento = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public bool OrdenProduccionGeneraMovimientoInsumos
        {
            get
            {
                return _OrdenProduccionGeneraMovimientoInsumos;
            }

            set
            {
                if (value != _OrdenProduccionGeneraMovimientoInsumos)
                {
                    _OrdenProduccionGeneraMovimientoInsumos = value;
                    NotifyPropertyChanged();
                }
            }
        }

        #endregion

        #region Metodos Publicos

        public void CopyOf(AplicacionConfiguracionViewModel viewModel)
        {
            _IsNew = viewModel.IsNew;
            _IsOld = viewModel.IsOld;
            _AplicacionConfiguracionId = viewModel.AplicacionConfiguracionId;
            _RecepcionGeneraMovimiento = viewModel.RecepcionGeneraMovimiento;
            _DespachoGeneraMovimiento = viewModel.DespachoGeneraMovimiento;
            _OrdenProduccionGeneraMovimiento = viewModel.OrdenProduccionGeneraMovimiento;
            _OrdenProduccionGeneraMovimientoInsumos = viewModel.OrdenProduccionGeneraMovimientoInsumos;
        }

        public AplicacionConfiguracion ToModel()
        {
            AplicacionConfiguracion model = new AplicacionConfiguracion
            {
                AplicacionConfiguracionId = _AplicacionConfiguracionId,
                CompraGeneraRecepcion = _RecepcionGeneraMovimiento,
                VentaGeneraDespacho = _DespachoGeneraMovimiento,
                OrdenProduccionGeneraMovimiento = _OrdenProduccionGeneraMovimiento,
                OrdenProduccionGeneraMovimientoInsumos = _OrdenProduccionGeneraMovimientoInsumos
            };

            return model;
        }

        public void Grabar()
        {
            ApplicationDbContext Context = new ApplicationDbContext();
            AplicacionConfiguracion model = ToModel();

            if (IsNew)
            {
                Context.AplicacionConfiguracions.Add(model);
            }
            else
            {
                if (IsOld)
                {
                    Context.Entry(model).State = EntityState.Modified;
                }
            }
            Context.SaveChanges();
            _IsNew = false;
            _IsOld = false;
            _AplicacionConfiguracionId = model.AplicacionConfiguracionId;
        }

        #endregion
    }
}
