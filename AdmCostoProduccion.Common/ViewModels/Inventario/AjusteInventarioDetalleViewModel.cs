using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Data;
using AdmCostoProduccion.Common.Models.Inventario;
using System;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace AdmCostoProduccion.Common.ViewModels.Inventario
{
    public class AjusteInventarioDetalleViewModel : ObjectBase
    {
        #region Constructor

        public AjusteInventarioDetalleViewModel()
        {
            _IsNew = true;
            _AjusteInventarioDetalleId = Guid.NewGuid().ToString();
        }

        public AjusteInventarioDetalleViewModel(string parentId)
        {
            _IsNew = true;
            _AjusteInventarioId = parentId;
            _AjusteInventarioDetalleId = Guid.NewGuid().ToString();
        }

        public AjusteInventarioDetalleViewModel(AjusteInventarioDetalle model)
        {
            _AjusteInventarioDetalleId = model.AjusteInventarioDetalleId;
            _AjusteInventarioId = model.AjusteInventarioId;
            _MercaderiaId = model.MercaderiaId;
            _UnidadMedidaId = model.UnidadMedidaId;
            _Cantidad = model.Cantidad;
            _Costo = model.Costo;
            _CodigoMercaderia = model.Mercaderia.Nombre;
            _NombreMercaderia = model.Mercaderia.Nombre;
            _UnidadMedida = model.UnidadMedida.Nombre;
        }

        #endregion

        #region Propiedades privadas

        private string _AjusteInventarioDetalleId;

        private string _AjusteInventarioId;

        private string _MercaderiaId;

        private string _UnidadMedidaId;

        private double _Cantidad;

        private double _Costo;

        private string _CodigoMercaderia;

        private string _NombreMercaderia;

        private string _UnidadMedida;

        #endregion

        #region Propiedades publicas

        public string AjusteInventarioDetalleId
        {
            get
            {
                return _AjusteInventarioDetalleId;
            }

            set
            {
                if (value != _AjusteInventarioDetalleId)
                {
                    _AjusteInventarioDetalleId = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string AjusteInventarioId
        {
            get
            {
                return _AjusteInventarioId;
            }

            set
            {
                if (value != _AjusteInventarioId)
                {
                    _AjusteInventarioId = value;
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

        public double Costo
        {
            get
            {
                return _Costo;
            }

            set
            {
                if (value != _Costo)
                {
                    _Costo = value;
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

        public void CopyOf(AjusteInventarioDetalleViewModel viewModel)
        {
            _IsNew = viewModel.IsNew;
            _IsOld = viewModel.IsOld;
            _AjusteInventarioDetalleId = viewModel.AjusteInventarioDetalleId;
            _AjusteInventarioId = viewModel.AjusteInventarioId;
            _MercaderiaId = viewModel.MercaderiaId;
            _UnidadMedidaId = viewModel.UnidadMedidaId;
            _Cantidad = viewModel.Cantidad;
            _Costo = viewModel.Costo;
            _CodigoMercaderia = viewModel.CodigoMercaderia;
            _NombreMercaderia = viewModel.NombreMercaderia;
            _UnidadMedida = viewModel.UnidadMedida;
        }

        public AjusteInventarioDetalle ToModel()
        {
            AjusteInventarioDetalle model = new AjusteInventarioDetalle
            {
                AjusteInventarioDetalleId = _AjusteInventarioDetalleId,
                AjusteInventarioId = _AjusteInventarioId,
                MercaderiaId = _MercaderiaId,
                UnidadMedidaId = _UnidadMedidaId,
                Cantidad = _Cantidad,
                Costo = _Costo
            };

            return model;
        }

        public void Grabar(ApplicationDbContext Context)
        {
            AjusteInventarioDetalle model = this.ToModel();

            if (IsNew) Context.AjusteInventarioDetalles.Add(model);
            else
            {
                if (IsOld) Context.Entry(model).State = EntityState.Modified;
            }
        }

        public void Eliminar(ApplicationDbContext Context)
        {
            if (!IsNew)
            {
                AjusteInventarioDetalle model = this.ToModel();
                Context.Entry(model).State = EntityState.Deleted;
            }
        }

        #endregion
    }
}
