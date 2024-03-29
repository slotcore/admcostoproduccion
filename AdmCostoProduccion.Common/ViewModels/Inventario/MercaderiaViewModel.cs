﻿using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Data;
using AdmCostoProduccion.Common.Models.Inventario;
using System;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace AdmCostoProduccion.Common.ViewModels.Inventario
{
    public class MercaderiaViewModel : ObjectBase
    {
        #region Constructor

        public MercaderiaViewModel()
        {
            _IsNew = true;
            _MercaderiaId = Guid.NewGuid().ToString();
        }

        public MercaderiaViewModel(Mercaderia model)
        {
            _MercaderiaId = model.MercaderiaId;
            _TipoMercaderiaId = model.TipoMercaderiaId;
            _FamiliaMercaderiaId = model.TipoMercaderiaId;
            _Codigo = model.Codigo;
            _Nombre = model.Nombre;
            _Descripcion = model.Descripcion;
            _TipoMercaderia = model.TipoMercaderia?.Nombre;
            _FamiliaMercaderia = model.FamiliaMercaderia?.Nombre;
        }

        #endregion

        #region Propiedades privadas

        private string _MercaderiaId;

        private string _TipoMercaderiaId;

        private string _FamiliaMercaderiaId;

        private string _Codigo;

        private string _Nombre;

        private string _Descripcion;

        private string _TipoMercaderia;

        private string _FamiliaMercaderia;

        #endregion

        #region Propiedades publicas

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

        public string TipoMercaderiaId
        {
            get
            {
                return _TipoMercaderiaId;
            }

            set
            {
                if (value != _TipoMercaderiaId)
                {
                    _TipoMercaderiaId = value;
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

        public string TipoMercaderia
        {
            get
            {
                return _TipoMercaderia;
            }

            set
            {
                if (value != _TipoMercaderia)
                {
                    _TipoMercaderia = value;
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

        public void CopyOf(MercaderiaViewModel viewModel)
        {
            _IsNew = viewModel.IsNew;
            _IsOld = viewModel.IsOld;
            _MercaderiaId = viewModel.MercaderiaId;
            _TipoMercaderiaId = viewModel.TipoMercaderiaId;
            _FamiliaMercaderiaId = viewModel.FamiliaMercaderiaId;
            _Codigo = viewModel.Codigo;
            _Nombre = viewModel.Nombre;
            _Descripcion = viewModel.Descripcion;
            _TipoMercaderia = viewModel.TipoMercaderia;
            _FamiliaMercaderia = viewModel.FamiliaMercaderia;
        }

        public Mercaderia ToModel()
        {
            Mercaderia model = new Mercaderia
            {
                MercaderiaId = _MercaderiaId,
                TipoMercaderiaId = _TipoMercaderiaId,
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
                Mercaderia model = this.ToModel();

                if (IsNew)
                {
                    context.Mercaderias.Add(model);
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
                _MercaderiaId = model.MercaderiaId;
            }
        }

        public void Eliminar()
        {
            using (var context = new ApplicationDbContext())
            {
                Mercaderia model = this.ToModel();
                context.Entry(model).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        #endregion
    }
}
