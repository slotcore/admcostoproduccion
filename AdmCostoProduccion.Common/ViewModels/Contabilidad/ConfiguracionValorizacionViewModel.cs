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
            _MetodoValorizacionId = model.MetodoValorizacionId;
            _DistribucionValorizacionId = model.DistribucionValorizacionId;
            _Codigo = model.Codigo;
            _Nombre = model.Nombre;
            _Descripcion = model.Descripcion;
            _MetodoValorizacion = model.MetodoValorizacion.Nombre;
            _DistribucionValorizacion = model.DistribucionValorizacion.Nombre;
        }

        #endregion

        #region Propiedades privadas

        private string _ConfiguracionValorizacionId;

        private string _MetodoValorizacionId;

        private string _DistribucionValorizacionId;

        private string _Codigo;

        private string _Nombre;

        private string _Descripcion;

        private string _MetodoValorizacion;

        private string _DistribucionValorizacion;

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

        public string MetodoValorizacionId
        {
            get
            {
                return _MetodoValorizacionId;
            }

            set
            {
                if (value != _MetodoValorizacionId)
                {
                    _MetodoValorizacionId = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string DistribucionValorizacionId
        {
            get
            {
                return _DistribucionValorizacionId;
            }

            set
            {
                if (value != _DistribucionValorizacionId)
                {
                    _DistribucionValorizacionId = value;
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

        public string MetodoValorizacion
        {
            get
            {
                return _MetodoValorizacion;
            }

            set
            {
                if (value != _MetodoValorizacion)
                {
                    _MetodoValorizacion = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string DistribucionValorizacion
        {
            get
            {
                return _DistribucionValorizacion;
            }

            set
            {
                if (value != _DistribucionValorizacion)
                {
                    _DistribucionValorizacion = value;
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
            _MetodoValorizacionId = viewModel.MetodoValorizacionId;
            _DistribucionValorizacionId = viewModel.DistribucionValorizacionId;
            _Codigo = viewModel.Codigo;
            _Nombre = viewModel.Nombre;
            _Descripcion = viewModel.Descripcion;
            _MetodoValorizacion = viewModel.MetodoValorizacion;
            _DistribucionValorizacion = viewModel.DistribucionValorizacion;
        }

        public ConfiguracionValorizacion ToModel()
        {
            ConfiguracionValorizacion model = new ConfiguracionValorizacion
            {
                ConfiguracionValorizacionId = _ConfiguracionValorizacionId,
                MetodoValorizacionId = _MetodoValorizacionId,
                DistribucionValorizacionId = _DistribucionValorizacionId,
                Codigo = _Codigo,
                Nombre = _Nombre,
                Descripcion = _Descripcion
            };

            return model;
        }

        public void Grabar()
        {
            using (var context = new ApplicationDbContext())
            {
                ConfiguracionValorizacion model = this.ToModel();

                if (IsNew)
                {
                    context.ConfiguracionValorizacions.Add(model);
                }
                else
                {
                    if (IsOld)
                    {
                        context.Entry(model).State = EntityState.Modified;
                    }
                }
                context.SaveChanges();
                _IsNew = false;
                _IsOld = false;
                _ConfiguracionValorizacionId = model.ConfiguracionValorizacionId;
            }
        }

        public void Eliminar()
        {
            using (var context = new ApplicationDbContext())
            {
                ConfiguracionValorizacion model = this.ToModel();
                context.Entry(model).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        #endregion
    }
}
