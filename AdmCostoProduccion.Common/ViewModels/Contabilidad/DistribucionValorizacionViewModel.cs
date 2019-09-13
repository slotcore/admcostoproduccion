using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Data;
using AdmCostoProduccion.Common.Models.Contabilidad;
using System;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace AdmCostoProduccion.Common.ViewModels.Contabilidad
{
    public class DistribucionValorizacionViewModel : ObjectBase
    {
        #region Constructor

        public DistribucionValorizacionViewModel()
        {
            _IsNew = true;
            _DistribucionValorizacionId = Guid.NewGuid().ToString();
        }

        public DistribucionValorizacionViewModel(DistribucionValorizacion model)
        {
            _DistribucionValorizacionId = model.DistribucionValorizacionId;
            _Codigo = model.Codigo;
            _Nombre = model.Nombre;
            _Descripcion = model.Descripcion;
        }

        #endregion

        #region Propiedades privadas

        private string _DistribucionValorizacionId;

        private string _Codigo;

        private string _Nombre;

        private string _Descripcion;

        #endregion

        #region Propiedades publicas

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

        #endregion

        #region Metodos Publicos

        public void CopyOf(DistribucionValorizacionViewModel viewModel)
        {
            _IsNew = viewModel.IsNew;
            _IsOld = viewModel.IsOld;
            _DistribucionValorizacionId = viewModel.DistribucionValorizacionId;
            _Codigo = viewModel.Codigo;
            _Nombre = viewModel.Nombre;
            _Descripcion = viewModel.Descripcion;
        }

        public DistribucionValorizacion ToModel()
        {
            DistribucionValorizacion model = new DistribucionValorizacion
            {
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
                DistribucionValorizacion model = this.ToModel();

                if (IsNew)
                {
                    context.DistribucionValorizacions.Add(model);
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
                _DistribucionValorizacionId = model.DistribucionValorizacionId;
            }
        }

        public void Eliminar()
        {
            using (var context = new ApplicationDbContext())
            {
                DistribucionValorizacion model = this.ToModel();
                context.Entry(model).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        #endregion
    }
}
