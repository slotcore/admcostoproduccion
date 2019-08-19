using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Data;
using AdmCostoProduccion.Common.Models.Aplicacion;
using System;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace AdmCostoProduccion.Common.ViewModels.Aplicacion
{
    public class AplicacionCorrelativoViewModel : ObjectBase
    {
        #region Constructor

        public AplicacionCorrelativoViewModel()
        {
            _IsNew = true;
            _AplicacionCorrelativoId = Guid.NewGuid().ToString();
        }

        public AplicacionCorrelativoViewModel(AplicacionCorrelativo model)
        {
            _AplicacionCorrelativoId = model.AplicacionCorrelativoId;
            _Codigo = model.Codigo;
            _Nombre = model.Nombre;
            _Prefijo = model.Prefijo;
            _NumeroDigitos = model.NumeroDigitos;
            _Correlativo = model.Correlativo;
        }

        #endregion

        #region Propiedades privadas

        private string _AplicacionCorrelativoId;

        private string _Codigo;

        private string _Nombre;

        private string _Prefijo;

        private int _NumeroDigitos;

        private int _Correlativo;

        #endregion

        #region Propiedades publicas

        public string AplicacionCorrelativoId
        {
            get
            {
                return _AplicacionCorrelativoId;
            }

            set
            {
                if (value != _AplicacionCorrelativoId)
                {
                    _AplicacionCorrelativoId = value;
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

        public string Prefijo
        {
            get
            {
                return _Prefijo;
            }

            set
            {
                if (value != _Prefijo)
                {
                    _Prefijo = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public int NumeroDigitos
        {
            get
            {
                return _NumeroDigitos;
            }

            set
            {
                if (value != _NumeroDigitos)
                {
                    _NumeroDigitos = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public int Correlativo
        {
            get
            {
                return _Correlativo;
            }

            set
            {
                if (value != _Correlativo)
                {
                    _Correlativo = value;
                    NotifyPropertyChanged();
                }
            }
        }

        #endregion

        #region Metodos Publicos

        public void CopyOf(AplicacionCorrelativoViewModel viewModel)
        {
            _IsNew = viewModel.IsNew;
            _IsOld = viewModel.IsOld;
            _AplicacionCorrelativoId = viewModel.AplicacionCorrelativoId;
            _Codigo = viewModel.Codigo;
            _Nombre = viewModel.Nombre;
            _Prefijo = viewModel.Prefijo;
            _NumeroDigitos = viewModel.NumeroDigitos;
            _Correlativo = viewModel.Correlativo;
        }

        public AplicacionCorrelativo ToModel()
        {
            AplicacionCorrelativo model = new AplicacionCorrelativo
            {
                AplicacionCorrelativoId = _AplicacionCorrelativoId,
                Codigo = _Codigo,
                Nombre = _Nombre,
                Prefijo = _Prefijo,
                NumeroDigitos = _NumeroDigitos,
                Correlativo = _Correlativo
            };

            return model;
        }

        public void Grabar()
        {
            ApplicationDbContext Context = new ApplicationDbContext();
            AplicacionCorrelativo model = this.ToModel();

            if (IsNew)
            {
                Context.AplicacionCorrelativos.Add(model);
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
            _AplicacionCorrelativoId = model.AplicacionCorrelativoId;
        }

        public void Eliminar()
        {
            using (var context = new ApplicationDbContext())
            {
                AplicacionCorrelativo model = this.ToModel();
                context.Entry(model).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        #endregion
    }
}
