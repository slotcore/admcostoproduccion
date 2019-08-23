using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Data;
using AdmCostoProduccion.Common.Models.Inventario;
using System;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace AdmCostoProduccion.Common.ViewModels.Inventario
{
    public class FamiliaMercaderiaViewModel : ObjectBase
    {
        #region Constructor

        public FamiliaMercaderiaViewModel()
        {
            _IsNew = true;
            _FamiliaMercaderiaId = Guid.NewGuid().ToString();
        }

        public FamiliaMercaderiaViewModel(FamiliaMercaderia model)
        {
            _FamiliaMercaderiaId = model.FamiliaMercaderiaId;
            _Codigo = model.Codigo;
            _Nombre = model.Nombre;
            _Descripcion = model.Descripcion;
        }

        #endregion

        #region Propiedades privadas

        private string _FamiliaMercaderiaId;

        private string _Codigo;

        private string _Nombre;

        private string _Descripcion;

        #endregion

        #region Propiedades publicas

        public string FamiliaMercaderiaId
        {
            get
            {
                return _FamiliaMercaderiaId;
            }

            set
            {
                if (value != _FamiliaMercaderiaId)
                {
                    _FamiliaMercaderiaId = value;
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

        public void CopyOf(FamiliaMercaderiaViewModel viewModel)
        {
            _IsNew = viewModel.IsNew;
            _IsOld = viewModel.IsOld;
            _FamiliaMercaderiaId = viewModel.FamiliaMercaderiaId;
            _Codigo = viewModel.Codigo;
            _Nombre = viewModel.Nombre;
            _Descripcion = viewModel.Descripcion;
        }

        public FamiliaMercaderia ToModel()
        {
            FamiliaMercaderia model = new FamiliaMercaderia
            {
                FamiliaMercaderiaId = _FamiliaMercaderiaId,
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
                FamiliaMercaderia model = this.ToModel();

                if (IsNew)
                {
                    context.FamiliaMercaderias.Add(model);
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
                _FamiliaMercaderiaId = model.FamiliaMercaderiaId;
            }
        }

        public void Eliminar()
        {
            using (var context = new ApplicationDbContext())
            {
                FamiliaMercaderia model = this.ToModel();
                context.Entry(model).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        #endregion
    }
}
