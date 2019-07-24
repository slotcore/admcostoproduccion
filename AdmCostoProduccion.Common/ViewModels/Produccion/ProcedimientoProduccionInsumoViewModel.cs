using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Models.Produccion;
using System;
using System.Linq;
using System.Text;

namespace AdmCostoProduccion.Common.ViewModels.Produccion
{
    public class ProcedimientoProduccionInsumoViewModel : ObjectBase
    {
        #region Constructor

        public ProcedimientoProduccionInsumoViewModel()
        {
        }

        public ProcedimientoProduccionInsumoViewModel(ProcedimientoProduccionInsumo model)
        {
            ProcedimientoProduccionInsumoId = model.ProcedimientoProduccionInsumoId;
            ProcedimientoProduccionId = model.ProcedimientoProduccionId;
            MercaderiaId = model.MercaderiaId;
            UnidadMedidaId = model.UnidadMedidaId;
            Cantidad = model.Cantidad;
            CodigoMercaderia = model.Mercaderia.Codigo;
            NombreMercaderia = model.Mercaderia.Nombre;
            UnidadMedida = model.UnidadMedida.Simbolo;
        }

        #endregion

        #region Propiedades privadas

        private int _ProcedimientoProduccionInsumoId;

        private int _ProcedimientoProduccionId;

        private int _MercaderiaId;

        private int _UnidadMedidaId;

        private double _Cantidad;

        private string _CodigoMercaderia;

        private string _NombreMercaderia;

        private string _UnidadMedida;

        #endregion

        #region Propiedades publicas

        public int ProcedimientoProduccionInsumoId
        {
            get
            {
                return _ProcedimientoProduccionInsumoId;
            }

            set
            {
                if (value != _ProcedimientoProduccionInsumoId)
                {
                    _ProcedimientoProduccionInsumoId = value;
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

        public void CopyTo(ref ProcedimientoProduccionInsumoViewModel viewModel)
        {
            viewModel.ProcedimientoProduccionInsumoId = _ProcedimientoProduccionInsumoId;
            viewModel.ProcedimientoProduccionId = _ProcedimientoProduccionId;
            viewModel.MercaderiaId = _MercaderiaId;
            viewModel.UnidadMedidaId = _UnidadMedidaId;
            viewModel.Cantidad = _Cantidad;
            viewModel.CodigoMercaderia = _CodigoMercaderia;
            viewModel.NombreMercaderia = _NombreMercaderia;
            viewModel.UnidadMedida = _UnidadMedida;
        }

        public ProcedimientoProduccionInsumo ToModel()
        {
            ProcedimientoProduccionInsumo model = new ProcedimientoProduccionInsumo
            {
                ProcedimientoProduccionInsumoId = _ProcedimientoProduccionInsumoId,
                ProcedimientoProduccionId = _ProcedimientoProduccionId,
                MercaderiaId = _MercaderiaId,
                UnidadMedidaId = _UnidadMedidaId,
                Cantidad = _Cantidad
            };

            return model;
        }

        #endregion
    }
}
