using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Data;
using AdmCostoProduccion.Common.Models.Inventario;
using System;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace AdmCostoProduccion.Common.ViewModels.Inventario
{
    public class ReglaAlmacenajeViewModel : ObjectBase
    {
        #region Constructor

        public ReglaAlmacenajeViewModel()
        {
            _IsNew = true;
            _ReglaAlmacenajeId = Guid.NewGuid().ToString();
        }

        public ReglaAlmacenajeViewModel(ReglaAlmacenaje model)
        {
            _ReglaAlmacenajeId = model.ReglaAlmacenajeId;
            _Codigo = model.Codigo;
            _Nombre = model.Nombre;
            _Descripcion = model.Descripcion;
            _AlmacenId = model.AlmacenId;
            _FamiliaMercaderiaId = model.FamiliaMercaderiaId;
            _Almacen = model.Almacen.Nombre;
            _FamiliaMercaderia = model.FamiliaMercaderia.Nombre;
        }

        #endregion

        #region Propiedades privadas

        private string _ReglaAlmacenajeId;

        private string _Codigo;

        private string _Nombre;

        private string _Descripcion;

        private string _AlmacenId;

        private string _FamiliaMercaderiaId;

        private string _Almacen;

        private string _FamiliaMercaderia;

        #endregion

        #region Propiedades publicas

        public string ReglaAlmacenajeId
        {
            get
            {
                return _ReglaAlmacenajeId;
            }

            set
            {
                if (value != _ReglaAlmacenajeId)
                {
                    _ReglaAlmacenajeId = value;
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

        public string AlmacenId
        {
            get
            {
                return _AlmacenId;
            }

            set
            {
                if (value != _AlmacenId)
                {
                    _AlmacenId = value;
                    NotifyPropertyChanged();
                }
            }
        }

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

        public string Almacen
        {
            get
            {
                return _Almacen;
            }

            set
            {
                if (value != _Almacen)
                {
                    _Almacen = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string FamiliaMercaderia
        {
            get
            {
                return _FamiliaMercaderia;
            }

            set
            {
                if (value != _FamiliaMercaderia)
                {
                    _FamiliaMercaderia = value;
                    NotifyPropertyChanged();
                }
            }
        }

        #endregion

        #region Metodos Publicos

        public void CopyOf(ReglaAlmacenajeViewModel viewModel)
        {
            _IsNew = viewModel.IsNew;
            _IsOld = viewModel.IsOld;
            _ReglaAlmacenajeId = viewModel.ReglaAlmacenajeId;
            _Codigo = viewModel.Codigo;
            _Nombre = viewModel.Nombre;
            _Descripcion = viewModel.Descripcion;
            _AlmacenId = viewModel.AlmacenId;
            _FamiliaMercaderiaId = viewModel.FamiliaMercaderiaId;
            _Almacen = viewModel.Almacen;
            _FamiliaMercaderia = viewModel.FamiliaMercaderia;
        }

        public ReglaAlmacenaje ToModel()
        {
            ReglaAlmacenaje model = new ReglaAlmacenaje
            {
                ReglaAlmacenajeId = _ReglaAlmacenajeId,
                Codigo = _Codigo,
                Nombre = _Nombre,
                Descripcion = _Descripcion,
                AlmacenId = _AlmacenId,
                FamiliaMercaderiaId = _FamiliaMercaderiaId
            };

            return model;
        }

        public void Grabar()
        {
            using (var context = new ApplicationDbContext())
            {
                ReglaAlmacenaje model = this.ToModel();

                if (IsNew)
                {
                    context.ReglaAlmacenajes.Add(model);
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
                _ReglaAlmacenajeId = model.ReglaAlmacenajeId;
            }
        }

        public void Eliminar()
        {
            using (var context = new ApplicationDbContext())
            {
                ReglaAlmacenaje model = this.ToModel();
                context.Entry(model).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        #endregion
    }
}
