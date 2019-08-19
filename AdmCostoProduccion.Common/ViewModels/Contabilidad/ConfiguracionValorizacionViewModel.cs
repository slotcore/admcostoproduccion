using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Data;
using AdmCostoProduccion.Common.Models.Contabilidad;
using System;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace AdmCostoProduccion.Common.ViewModels.Contabilidad
{
    public class ConfiguracionValorizacionViewModel : ObjectBase
    {
        #region Constructor

        public ConfiguracionValorizacionViewModel()
        {
            _IsNew = true;
            _ConfiguracionValorizacionId = Guid.NewGuid().ToString();
        }

        public ConfiguracionValorizacionViewModel(ConfiguracionValorizacion model)
        {
            _ConfiguracionValorizacionId = model.ConfiguracionValorizacionId;
            _Codigo = model.Codigo;
            _Nombre = model.Nombre;
            _Descripcion = model.Descripcion;
        }

        #endregion

        #region Propiedades privadas

        private string _ConfiguracionValorizacionId;

        private string _Codigo;

        private string _Nombre;

        private string _Descripcion;

        #endregion

        #region Propiedades publicas

        public string ConfiguracionValorizacionId
        {
            get
            {
                return _ConfiguracionValorizacionId;
            }

            set
            {
                if (value != _ConfiguracionValorizacionId)
                {
                    _ConfiguracionValorizacionId = value;
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

        #endregion

        #region Metodos Publicos

        public void CopyOf(ConfiguracionValorizacionViewModel viewModel)
        {
            _IsNew = viewModel.IsNew;
            _IsOld = viewModel.IsOld;
            _ConfiguracionValorizacionId = viewModel.ConfiguracionValorizacionId;
            _Codigo = viewModel.Codigo;
            _Nombre = viewModel.Nombre;
            _Descripcion = viewModel.Descripcion;
        }

        public ConfiguracionValorizacion ToModel()
        {
            ConfiguracionValorizacion model = new ConfiguracionValorizacion
            {
                ConfiguracionValorizacionId = _ConfiguracionValorizacionId,
                Codigo = _Codigo,
                Nombre = _Nombre,
                Descripcion = _Descripcion
            };

            return model;
        }

        public void Grabar()
        {
            ApplicationDbContext Context = new ApplicationDbContext();
            ConfiguracionValorizacion model = this.ToModel();

            if (IsNew)
            {
                Context.ConfiguracionValorizacions.Add(model);
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
            _ConfiguracionValorizacionId = model.ConfiguracionValorizacionId;
        }

        #endregion
    }
}
