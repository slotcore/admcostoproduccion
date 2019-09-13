using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Data;
using AdmCostoProduccion.Common.Models.Contabilidad;
using System;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace AdmCostoProduccion.Common.ViewModels.Contabilidad
{
    public class MetodoValorizacionViewModel : ObjectBase
    {
        #region Constructor

        public MetodoValorizacionViewModel()
        {
            _IsNew = true;
            _MetodoValorizacionId = Guid.NewGuid().ToString();
        }

        public MetodoValorizacionViewModel(MetodoValorizacion model)
        {
            _MetodoValorizacionId = model.MetodoValorizacionId;
            _Codigo = model.Codigo;
            _Nombre = model.Nombre;
            _Descripcion = model.Descripcion;
        }

        #endregion

        #region Propiedades privadas

        private string _MetodoValorizacionId;

        private string _Codigo;

        private string _Nombre;

        private string _Descripcion;

        #endregion

        #region Propiedades publicas

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

        public void CopyOf(MetodoValorizacionViewModel viewModel)
        {
            _IsNew = viewModel.IsNew;
            _IsOld = viewModel.IsOld;
            _MetodoValorizacionId = viewModel.MetodoValorizacionId;
            _Codigo = viewModel.Codigo;
            _Nombre = viewModel.Nombre;
            _Descripcion = viewModel.Descripcion;
        }

        public MetodoValorizacion ToModel()
        {
            MetodoValorizacion model = new MetodoValorizacion
            {
                MetodoValorizacionId = _MetodoValorizacionId,
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
                MetodoValorizacion model = this.ToModel();

                if (IsNew)
                {
                    context.MetodoValorizacions.Add(model);
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
                _MetodoValorizacionId = model.MetodoValorizacionId;
            }
        }

        public void Eliminar()
        {
            using (var context = new ApplicationDbContext())
            {
                MetodoValorizacion model = this.ToModel();
                context.Entry(model).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        #endregion
    }
}
