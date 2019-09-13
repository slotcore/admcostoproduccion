using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Data;
using AdmCostoProduccion.Common.Models.Inventario;
using System;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace AdmCostoProduccion.Common.ViewModels.Inventario
{
    public class TipoAjusteInventarioViewModel : ObjectBase
    {
        #region Constructor

        public TipoAjusteInventarioViewModel()
        {
            _IsNew = true;
            _TipoAjusteInventarioId = Guid.NewGuid().ToString();
        }

        public TipoAjusteInventarioViewModel(TipoAjusteInventario model)
        {
            _TipoAjusteInventarioId = model.TipoAjusteInventarioId;
            _Codigo = model.Codigo;
            _Nombre = model.Nombre;
            _Descripcion = model.Descripcion;
        }

        #endregion

        #region Propiedades privadas

        private string _TipoAjusteInventarioId;

        private string _Codigo;

        private string _Nombre;

        private string _Descripcion;

        #endregion

        #region Propiedades publicas

        public string TipoAjusteInventarioId
        {
            get
            {
                return _TipoAjusteInventarioId;
            }

            set
            {
                if (value != _TipoAjusteInventarioId)
                {
                    _TipoAjusteInventarioId = value;
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

        public void CopyOf(TipoAjusteInventarioViewModel viewModel)
        {
            _IsNew = viewModel.IsNew;
            _IsOld = viewModel.IsOld;
            _TipoAjusteInventarioId = viewModel.TipoAjusteInventarioId;
            _Codigo = viewModel.Codigo;
            _Nombre = viewModel.Nombre;
            _Descripcion = viewModel.Descripcion;
        }

        public TipoAjusteInventario ToModel()
        {
            TipoAjusteInventario model = new TipoAjusteInventario
            {
                TipoAjusteInventarioId = _TipoAjusteInventarioId,
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
                TipoAjusteInventario model = this.ToModel();

                if (IsNew)
                {
                    context.TipoAjusteInventarios.Add(model);
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
                _TipoAjusteInventarioId = model.TipoAjusteInventarioId;
            }
        }

        public void Eliminar()
        {
            using (var context = new ApplicationDbContext())
            {
                TipoAjusteInventario model = this.ToModel();
                context.Entry(model).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        #endregion
    }
}
