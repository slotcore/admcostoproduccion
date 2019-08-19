using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Data;
using AdmCostoProduccion.Common.Models.Contabilidad;
using System;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace AdmCostoProduccion.Common.ViewModels.Contabilidad
{
    public class CostoOrdenProduccionViewModel : ObjectBase
    {
        #region Constructor

        public CostoOrdenProduccionViewModel(string parentId)
        {
            _IsNew = true;
            _CostoProduccionId = parentId;
            _CostoOrdenProduccionId = Guid.NewGuid().ToString();
        }

        public CostoOrdenProduccionViewModel(CostoOrdenProduccion model)
        {
            _CostoOrdenProduccionId = model.CostoOrdenProduccionId;
            _CostoProduccionId = model.CostoProduccionId;
            _OrdenProduccionId = model.OrdenProduccionId;
            _KardexMovimientoId = model.KardexMovimientoId;
            _FactorDistribucion = model.FactorDistribucion;
            _CostoMp = model.CostoMp;
            _CostoMod = model.CostoMod;
            _CostoCif = model.CostoCif;
            _CodigoMercaderia = model.OrdenProduccion.Mercaderia.Codigo;
            _NombreMercaderia = model.OrdenProduccion.Mercaderia.Nombre;
            _ProcedimientoProduccion = model.OrdenProduccion.ProcedimientoProduccion.Nombre;
            _UnidadMedida = model.OrdenProduccion.UnidadMedida.Nombre;
            _Cantidad = model.OrdenProduccion.Cantidad;
            _OrdenProduccion = model.OrdenProduccion.Codigo;
        }

        #endregion

        #region Propiedades privadas

        private string _CostoOrdenProduccionId;

        private string _CostoProduccionId;

        private string _OrdenProduccionId;

        private string _KardexMovimientoId;

        private double _FactorDistribucion;

        private double _CostoMp;

        private double _CostoMod;

        private double _CostoCif;

        private string _OrdenProduccion;

        private string _CodigoMercaderia;

        private string _NombreMercaderia;

        private string _ProcedimientoProduccion;

        private string _UnidadMedida;

        private double _Cantidad;

        #endregion

        #region Propiedades publicas

        public string CostoOrdenProduccionId
        {
            get
            {
                return _CostoOrdenProduccionId;
            }

            set
            {
                if (value != _CostoOrdenProduccionId)
                {
                    _CostoOrdenProduccionId = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string CostoProduccionId
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

        public string KardexMovimientoId
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

        public string OrdenProduccion
        {
            get
            {
                return _OrdenProduccion;
            }

            set
            {
                if (value != _OrdenProduccion)
                {
                    _OrdenProduccion = value;
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

        #endregion

        #region Metodos Publicos

        public void CopyOf(CostoOrdenProduccionViewModel viewModel)
        {
            _IsNew = viewModel.IsNew;
            _IsOld = viewModel.IsOld;
            _CostoOrdenProduccionId = viewModel.CostoOrdenProduccionId;
            _CostoProduccionId = viewModel.CostoProduccionId;
            _OrdenProduccionId = viewModel.OrdenProduccionId;
            _KardexMovimientoId = viewModel.KardexMovimientoId;
            _FactorDistribucion = viewModel.FactorDistribucion;
            _CostoMp = viewModel.CostoMp;
            _CostoMod = viewModel.CostoMod;
            _CostoCif = viewModel.CostoCif;
            _CodigoMercaderia = viewModel.CodigoMercaderia;
            _NombreMercaderia = viewModel.NombreMercaderia;
            _ProcedimientoProduccion = viewModel.ProcedimientoProduccion;
            _UnidadMedida = viewModel.UnidadMedida;
            _Cantidad = viewModel.CostoCif;
            _OrdenProduccion = viewModel.OrdenProduccion;
        }

        public CostoOrdenProduccion ToModel()
        {
            CostoOrdenProduccion model = new CostoOrdenProduccion
            {
                CostoOrdenProduccionId = _CostoOrdenProduccionId,
                CostoProduccionId = _CostoProduccionId,
                OrdenProduccionId = _OrdenProduccionId,
                KardexMovimientoId = _KardexMovimientoId,
                FactorDistribucion = _FactorDistribucion,
                CostoMp = _CostoMp,
                CostoMod = _CostoMod,
                CostoCif = _CostoCif
            };

            return model;
        }

        public void Grabar(ApplicationDbContext Context)
        {
            CostoOrdenProduccion model = this.ToModel();

            if (IsNew) Context.CostoOrdenProduccions.Add(model);
            else
            {
                if (IsOld) Context.Entry(model).State = EntityState.Modified;
            }
        }

        public void Eliminar(ApplicationDbContext Context)
        {
            if (!IsNew)
            {
                CostoOrdenProduccion model = this.ToModel();
                Context.Entry(model).State = EntityState.Deleted;
            }
        }

        #endregion
    }
}
