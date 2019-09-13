using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Data;
using AdmCostoProduccion.Common.Models.Produccion;
using System;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace AdmCostoProduccion.Common.ViewModels.Produccion
{
    public class OrdenProduccionInsumoViewModel : ObjectBase
    {
        #region Constructor

        public OrdenProduccionInsumoViewModel()
        {
        }
        public OrdenProduccionInsumoViewModel(string parentId)
        {
            _IsNew = true;
            _OrdenProduccionId = parentId;
            _OrdenProduccionInsumoId = Guid.NewGuid().ToString();
        }

        public OrdenProduccionInsumoViewModel(OrdenProduccionInsumo model)
        {
            _OrdenProduccionInsumoId = model.OrdenProduccionInsumoId;
            _OrdenProduccionId = model.OrdenProduccionId;
            _MercaderiaId = model.MercaderiaId;
            _UnidadMedidaId = model.UnidadMedidaId;
            _Cantidad = model.Cantidad;
            _CodigoMercaderia = model.Mercaderia.Codigo;
            _NombreMercaderia = model.Mercaderia.Nombre;
            _UnidadMedida = model.UnidadMedida.Nombre;
        }

        #endregion

        #region Propiedades privadas

        private string _OrdenProduccionInsumoId;

        private string _OrdenProduccionId;

        private string _MercaderiaId;

        private string _UnidadMedidaId;

        private double _Cantidad;

        private string _CodigoMercaderia;

        private string _NombreMercaderia;

        private string _UnidadMedida;

        #endregion

        #region Propiedades publicas

        public string OrdenProduccionInsumoId
        {
            get
            {
                return _OrdenProduccionInsumoId;
            }

            set
            {
                if (value != _OrdenProduccionInsumoId)
                {
                    _OrdenProduccionInsumoId = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string OrdenProduccionId
        {
            get
            {
                return _OrdenProduccionId;
            }

            set
            {
                if (value != _OrdenProduccionId)
                {
                    _OrdenProduccionId = value;
                    NotifyPropertyChanged();
                }
            }
        }

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

        public string UnidadMedidaId
        {
            get
            {
                return _UnidadMedidaId;
            }

            set
            {
                if (value != _UnidadMedidaId)
                {
                    _UnidadMedidaId = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public double Cantidad
        {
            get
            {
                return _Cantidad;
            }

            set
            {
                if (value != _Cantidad)
                {
                    _Cantidad = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string CodigoMercaderia
        {
            get
            {
                return _CodigoMercaderia;
            }

            set
            {
                if (value != _CodigoMercaderia)
                {
                    _CodigoMercaderia = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string NombreMercaderia
        {
            get
            {
                return _NombreMercaderia;
            }

            set
            {
                if (value != _NombreMercaderia)
                {
                    _NombreMercaderia = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string UnidadMedida
        {
            get
            {
                return _UnidadMedida;
            }

            set
            {
                if (value != _UnidadMedida)
                {
                    _UnidadMedida = value;
                    NotifyPropertyChanged();
                }
            }
        }

        #endregion

        #region Metodos Publicos

        public void CopyOf(OrdenProduccionInsumoViewModel viewModel)
        {
            _IsNew = viewModel.IsNew;
            _IsOld = viewModel.IsOld;
            _OrdenProduccionInsumoId = viewModel.OrdenProduccionInsumoId;
            _OrdenProduccionId = viewModel.OrdenProduccionId;
            _MercaderiaId = viewModel.MercaderiaId;
            _UnidadMedidaId = viewModel.UnidadMedidaId;
            _Cantidad = viewModel.Cantidad;
            _CodigoMercaderia = viewModel.CodigoMercaderia;
            _NombreMercaderia = viewModel.NombreMercaderia;
            _UnidadMedida = viewModel.UnidadMedida;
        }

        public OrdenProduccionInsumo ToModel()
        {
            OrdenProduccionInsumo model = new OrdenProduccionInsumo
            {
                OrdenProduccionInsumoId = _OrdenProduccionInsumoId,
                OrdenProduccionId = _OrdenProduccionId,
                MercaderiaId = _MercaderiaId,
                UnidadMedidaId = _UnidadMedidaId,
                Cantidad = _Cantidad
            };

            return model;
        }

        public void Grabar(ApplicationDbContext Context)
        {
            OrdenProduccionInsumo model = this.ToModel();

            if (IsNew) Context.OrdenProduccionInsumos.Add(model);
            else
            {
                if (IsOld) Context.Entry(model).State = EntityState.Modified;
            }
        }

        public void Eliminar(ApplicationDbContext Context)
        {
            if (!IsNew)
            {
                OrdenProduccionInsumo model = this.ToModel();
                Context.Entry(model).State = EntityState.Deleted;
            }
        }

        #endregion
    }
}
