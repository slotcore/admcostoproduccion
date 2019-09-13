using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmCostoProduccion.Common.ViewModels.Contabilidad
{
    public class MercaderiaMovimientoViewModel : ObjectBase
    {
        #region Constructor

        public MercaderiaMovimientoViewModel()
        {

        }

        public MercaderiaMovimientoViewModel(DateTime fechaConsulta, string mercaderiaId)
        {
            CargarMovimientoMercaderia(fechaConsulta, mercaderiaId);
        }

        #endregion

        #region Variables Privadas

        private string _MercaderiaId;

        private double _SaldoActual;

        private double _CostoActual;

        private DateTime _FechaConsulta;

        private string _CodigoMercaderia;

        private string _NombreMercaderia; 

        #endregion

        #region Propiedades
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

        public double SaldoActual
        {
            get
            {
                return _SaldoActual;
            }

            set
            {
                if (value != _SaldoActual)
                {
                    _SaldoActual = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public double CostoActual
        {
            get
            {
                return _CostoActual;
            }

            set
            {
                if (value != _CostoActual)
                {
                    _CostoActual = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public DateTime FechaConsulta
        {
            get
            {
                return _FechaConsulta;
            }

            set
            {
                if (value != _FechaConsulta)
                {
                    _FechaConsulta = value;
                    NotifyPropertyChanged();
                }
            }
        }
        #endregion

        public static MercaderiaMovimientoViewModel CargarMovimientoMercaderia(DateTime fecha, string mercaderiaId)
        {
            using (var context = new ApplicationDbContext())
            {
                //entradas
                var tipoMovimientoIngreso = context.TipoMovimientos
                    .Where(o => o.Codigo == "ENT")
                    .FirstOrDefault();

                var mercaderiaMovimientoEntradaQry = from k in context.KardexMovimientos
                                                        join p in context.CostoProduccionMovimientos on k.KardexMovimientoId equals p.KardexMovimientoId
                                                        where k.Fecha <= fecha 
                                                            && k.TipoMovimientoId == tipoMovimientoIngreso.TipoMovimientoId
                                                        select new
                                                        {
                                                            k,
                                                            Costo = p.CostoMp + p.CostoMod + p.CostoIf
                                                        } into o
                                                        group o by o.k.MercaderiaId into g
                                                        select new
                                                        {
                                                            g.FirstOrDefault().k.MercaderiaId,
                                                            CodigoMercaderia = g.FirstOrDefault().k.Mercaderia.Codigo,
                                                            NombreMercaderia = g.FirstOrDefault().k.Mercaderia.Nombre,
                                                            Cantidad = g.Sum(m => m.k.Cantidad),
                                                            Costo = g.Sum(m => m.Costo)
                                                        };

                //salidas
                var tipoMovimientoSalida = context.TipoMovimientos
                    .Where(o => o.Codigo == "SAL")
                    .FirstOrDefault();

                var mercaderiaMovimientoSalidaQry = from k in context.KardexMovimientos
                                                        join p in context.CostoProduccionMovimientos on k.KardexMovimientoId equals p.KardexMovimientoId
                                                        where k.Fecha <= fecha
                                                        && k.TipoMovimientoId == tipoMovimientoSalida.TipoMovimientoId
                                                        select new
                                                        {
                                                            k,
                                                            Costo = p.CostoMp + p.CostoMod + p.CostoIf
                                                        } into o
                                                        group o by o.k.MercaderiaId into g
                                                        select new
                                                        {
                                                            g.FirstOrDefault().k.MercaderiaId,
                                                            Cantidad = g.Sum(m => m.k.Cantidad),
                                                            Costo = g.Sum(m => m.Costo)
                                                        };

                var mercaderiaMovimientoViewModel = (from e in mercaderiaMovimientoEntradaQry
                                                        join s in mercaderiaMovimientoSalidaQry on e.MercaderiaId equals s.MercaderiaId
                                                        where e.MercaderiaId == mercaderiaId
                                                        select new MercaderiaMovimientoViewModel
                                                        {
                                                            MercaderiaId = e.MercaderiaId,
                                                            CodigoMercaderia = e.CodigoMercaderia,
                                                            NombreMercaderia = e.NombreMercaderia,
                                                            SaldoActual = e.Cantidad - s.Cantidad,
                                                            CostoActual = e.Costo - s.Costo
                                                        }).FirstOrDefault();

                return mercaderiaMovimientoViewModel;
            }
        }
    }
}
