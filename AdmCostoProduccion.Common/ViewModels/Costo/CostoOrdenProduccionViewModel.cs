using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Models.Contabilidad;
using System;
using System.Linq;
using System.Text;

namespace AdmCostoProduccion.Common.ViewModels.Costo
{
    public class CostoOrdenProduccionViewModel : ObjectBase
    {
        #region Constructor

        public CostoOrdenProduccionViewModel(CostoOrdenProduccion model)
        {
            _CostoProduccionId = model.CostoProduccionId;
            _OrdenProduccionId = model.OrdenProduccionId;
            _KardexMovimientoId = model.KardexMovimientoId;
            _Fecha = model.OrdenProduccion.Fecha.ToString("dd/MM/yyy");
            _CodigoOrdenProduccion = model.OrdenProduccion.Codigo;
            _CodigoMercaderia = model.OrdenProduccion.Mercaderia.Codigo;
            _NombreMercaderia = model.OrdenProduccion.Mercaderia.Nombre;
            _CodigoProcedimientoProduccion = model.OrdenProduccion.ProcedimientoProduccion.Codigo;
            _UnidadMedida = model.OrdenProduccion.UnidadMedida.Simbolo;
            _Cantidad = model.OrdenProduccion.Cantidad;
            _FactorDistribucion = model.FactorDistribucion;
            _CostoMp = model.CostoMp;
            _CostoMod = model.CostoMod;
            _CostoCif = model.CostoCif;
        }

        #endregion

        #region Propiedades privadas

        private int _CostoProduccionId;

        private int _OrdenProduccionId;

        private int _KardexMovimientoId;

        private string _Fecha;

        private string _CodigoOrdenProduccion;

        private string _CodigoMercaderia;

        private string _NombreMercaderia;

        private string _CodigoProcedimientoProduccion;

        private string _UnidadMedida;

        private double _Cantidad;

        private double _FactorDistribucion;

        private double _CostoMp;

        private double _CostoMod;

        private double _CostoCif;

        #endregion

        #region Propiedades publicas

        public int CostoProduccionId
        {
            get
            {
                return _CostoProduccionId;
            }

            set
            {
                if (value != _CostoProduccionId)
                {
                    _CostoProduccionId = value;
                    NotifyPropertyChanged();
                }
            }
        }

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

        public int KardexMovimientoId
        {
            get
            {
                return _KardexMovimientoId;
            }

            set
            {
                if (value != _KardexMovimientoId)
                {
                    _KardexMovimientoId = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Fecha
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

        public string CodigoOrdenProduccion
        {
            get
            {
                return _CodigoOrdenProduccion;
            }

            set
            {
                if (value != _CodigoOrdenProduccion)
                {
                    _CodigoOrdenProduccion = value;
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

        public string CodigoProcedimientoProduccion
        {
            get
            {
                return _CodigoProcedimientoProduccion;
            }

            set
            {
                if (value != _CodigoProcedimientoProduccion)
                {
                    _CodigoProcedimientoProduccion = value;
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

        public double FactorDistribucion
        {
            get
            {
                return _FactorDistribucion;
            }

            set
            {
                if (value != _FactorDistribucion)
                {
                    _FactorDistribucion = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public double CostoMp
        {
            get
            {
                return _CostoMp;
            }

            set
            {
                if (value != _CostoMp)
                {
                    _CostoMp = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public double CostoMod
        {
            get
            {
                return _CostoMod;
            }

            set
            {
                if (value != _CostoMod)
                {
                    _CostoMod = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public double CostoCif
        {
            get
            {
                return _CostoCif;
            }

            set
            {
                if (value != _CostoCif)
                {
                    _CostoCif = value;
                    NotifyPropertyChanged();
                }
            }
        }

        #endregion
    }
}
