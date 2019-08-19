using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Models.Produccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdmCostoProduccion.Common.ViewModels.Produccion
{
    public class ProcedimientoProduccionViewModel : ObjectBase
    {
        #region Constructor

        public ProcedimientoProduccionViewModel()
        {
            _ProcedimientoProduccionId = Guid.NewGuid().ToString();
        }

        public ProcedimientoProduccionViewModel(ProcedimientoProduccion model)
        {
            ProcedimientoProduccionId = model.ProcedimientoProduccionId;
            MercaderiaId = model.MercaderiaId;
            UnidadMedidaId = model.UnidadMedidaId;
            Codigo = model.Codigo;
            Nombre = model.Nombre;
            Descripcion = model.Descripcion;
            Cantidad = model.Cantidad;
            CodigoMercaderia = model.Mercaderia.Codigo;
            NombreMercaderia = model.Mercaderia.Nombre;
            UnidadMedida = model.UnidadMedida.Simbolo;

            ProcedimientoProduccionInsumoViewModels 
                = new ObservableListSource<ProcedimientoProduccionInsumoViewModel>();

            foreach (var procedimientoProduccionInsumo in model.ProcedimientoProduccionInsumos)
            {
                ProcedimientoProduccionInsumoViewModels
                    .Add(new ProcedimientoProduccionInsumoViewModel(procedimientoProduccionInsumo));
            }
        }

        #endregion

        #region Propiedades privadas

        private string _ProcedimientoProduccionId;

        private string _MercaderiaId;

        private string _UnidadMedidaId;

        private string _Codigo;

        private string _Nombre;

        private string _Descripcion;

        private double _Cantidad;

        private string _CodigoMercaderia;

        private string _NombreMercaderia;

        private string _UnidadMedida;

        private ObservableListSource<ProcedimientoProduccionInsumoViewModel> _ProcedimientoProduccionInsumoViewModels 
            = new ObservableListSource<ProcedimientoProduccionInsumoViewModel>();

        #endregion

        #region Propiedades publicas

        public string ProcedimientoProduccionId
        {
            get
            {
                return _ProcedimientoProduccionId;
            }

            set
            {
                if (value != _ProcedimientoProduccionId)
                {
                    _ProcedimientoProduccionId = value;
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

        public virtual ObservableListSource<ProcedimientoProduccionInsumoViewModel> ProcedimientoProduccionInsumoViewModels
        {
            get
            {
                return _ProcedimientoProduccionInsumoViewModels;
            }
            set
            {
                if (value != _ProcedimientoProduccionInsumoViewModels)
                {
                    _ProcedimientoProduccionInsumoViewModels = value;
                    NotifyPropertyChanged();
                }
            }
        }

        #endregion

        #region Metodos Publicos

        public void CopyTo(ref ProcedimientoProduccionViewModel viewModel)
        {
            viewModel.ProcedimientoProduccionId = _ProcedimientoProduccionId;
            viewModel.MercaderiaId = _MercaderiaId;
            viewModel.UnidadMedidaId = _UnidadMedidaId;
            viewModel.Codigo = _Codigo;
            viewModel.Nombre = _Nombre;
            viewModel.Descripcion = _Descripcion;
            viewModel.Cantidad = _Cantidad;
            viewModel.CodigoMercaderia = _CodigoMercaderia;
            viewModel.NombreMercaderia = _NombreMercaderia;
            viewModel.UnidadMedida = _UnidadMedida;

            viewModel.ProcedimientoProduccionInsumoViewModels 
                = _ProcedimientoProduccionInsumoViewModels;
        }

        public ProcedimientoProduccion ToModel()
        {
            ProcedimientoProduccion model = new ProcedimientoProduccion
            {
                ProcedimientoProduccionId = _ProcedimientoProduccionId,
                MercaderiaId = _MercaderiaId,
                UnidadMedidaId = _UnidadMedidaId,
                Codigo = _Codigo,
                Nombre = _Nombre,
                Descripcion = _Descripcion,
                Cantidad = _Cantidad
            };

            model.ProcedimientoProduccionInsumos = new List<ProcedimientoProduccionInsumo>();
            foreach (var procedimientoProduccionInsumoViewModel in _ProcedimientoProduccionInsumoViewModels)
            {
                model.ProcedimientoProduccionInsumos.Add(procedimientoProduccionInsumoViewModel.ToModel());
            }

            return model;
        }

        #endregion
    }
}
