using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Models.Produccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdmCostoProduccion.Common.ViewModels.Produccion
{
    public class OrdenProduccionViewModel : ObjectBase
    {
        #region Constructor

        public OrdenProduccionViewModel()
        {
        }

        public OrdenProduccionViewModel(OrdenProduccion model)
        {
            OrdenProduccionId = model.OrdenProduccionId;
            PlantaFabricacionId = model.PlantaFabricacionId;
            MercaderiaId = model.MercaderiaId;
            ProcedimientoProduccionId = model.ProcedimientoProduccionId;
            UnidadMedidaId = model.UnidadMedidaId;
            Codigo = model.Codigo;
            Fecha = model.Fecha;
            Cantidad = model.Cantidad;
            Lote = model.Lote;
            CodigoMercaderia = model.Mercaderia.Codigo;
            NombreMercaderia = model.Mercaderia.Nombre;
            ProcedimientoProduccion = model.ProcedimientoProduccion.Nombre;
            UnidadMedida = model.UnidadMedida.Nombre;

            foreach (var ordenProduccionInsumo in model.OrdenProduccionInsumos)
            {
                OrdenProduccionInsumoViewModels.Add(new OrdenProduccionInsumoViewModel(ordenProduccionInsumo));
            }
        }

        #endregion

        #region Propiedades privadas

        private int _OrdenProduccionId;

        private int _PlantaFabricacionId;

        private int _MercaderiaId;

        private int _ProcedimientoProduccionId;

        private int _UnidadMedidaId;

        private string _Codigo;

        private DateTime _Fecha;

        private double _Cantidad;

        private string _Lote;

        private string _CodigoMercaderia;

        private string _NombreMercaderia;

        private string _ProcedimientoProduccion;

        private string _UnidadMedida;

        private ObservableListSource<OrdenProduccionInsumoViewModel> _OrdenProduccionInsumoViewModels 
            = new ObservableListSource<OrdenProduccionInsumoViewModel>();

        #endregion

        #region Propiedades publicas

        public int OrdenProduccionId
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

        public int PlantaFabricacionId
        {
            get
            {
                return _PlantaFabricacionId;
            }

            set
            {
                if (value != _PlantaFabricacionId)
                {
                    _PlantaFabricacionId = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public int MercaderiaId
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

        public int ProcedimientoProduccionId
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

        public int UnidadMedidaId
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

        public DateTime Fecha
        {
            get
            {
                return _Fecha;
            }

            set
            {
                if (value != _Fecha)
                {
                    _Fecha = value;
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

        public string Lote
        {
            get
            {
                return _Lote;
            }

            set
            {
                if (value != _Lote)
                {
                    _Lote = value;
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

        public string ProcedimientoProduccion
        {
            get
            {
                return _ProcedimientoProduccion;
            }

            set
            {
                if (value != _ProcedimientoProduccion)
                {
                    _ProcedimientoProduccion = value;
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

        public virtual ObservableListSource<OrdenProduccionInsumoViewModel> OrdenProduccionInsumoViewModels
        {
            get
            {
                return _OrdenProduccionInsumoViewModels;
            }
            set
            {
                if (value != _OrdenProduccionInsumoViewModels)
                {
                    _OrdenProduccionInsumoViewModels = value;
                    NotifyPropertyChanged();
                }
            }
        }

        #endregion

        #region Metodos Publicos

        public void CopyTo(ref OrdenProduccionViewModel viewModel)
        {
            viewModel.OrdenProduccionId = _OrdenProduccionId;
            viewModel.PlantaFabricacionId = _PlantaFabricacionId;
            viewModel.MercaderiaId = _MercaderiaId;
            viewModel.ProcedimientoProduccionId = _ProcedimientoProduccionId;
            viewModel.UnidadMedidaId = _UnidadMedidaId;
            viewModel.Codigo = _Codigo;
            viewModel.Fecha = _Fecha;
            viewModel.Cantidad = _Cantidad;
            viewModel.Lote = _Lote;
            viewModel.CodigoMercaderia = CodigoMercaderia;
            viewModel.NombreMercaderia = NombreMercaderia;
            viewModel.ProcedimientoProduccion = ProcedimientoProduccion;
            viewModel.UnidadMedida = UnidadMedida;
        }

        public OrdenProduccion ToModel()
        {
            OrdenProduccion model = new OrdenProduccion
            {
                OrdenProduccionId = _OrdenProduccionId,
                PlantaFabricacionId = _PlantaFabricacionId,
                MercaderiaId = _MercaderiaId,
                ProcedimientoProduccionId = _ProcedimientoProduccionId,
                UnidadMedidaId = _UnidadMedidaId,
                Codigo = _Codigo,
                Fecha = _Fecha,
                Cantidad = _Cantidad,
                Lote = _Lote
            };

            model.OrdenProduccionInsumos = new List<OrdenProduccionInsumo>();
            foreach (var ordenProduccionInsumoViewModel in OrdenProduccionInsumoViewModels)
            {
                model.OrdenProduccionInsumos.Add(ordenProduccionInsumoViewModel.ToModel());
            }

            return model;
        }

        #endregion
    }
}
