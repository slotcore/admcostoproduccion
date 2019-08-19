using AdmCostoProduccion.Common.Data;
using AdmCostoProduccion.Common.Models.Inventario;
using AdmCostoProduccion.Common.ViewModels.CompraVenta;
using AdmCostoProduccion.Common.ViewModels.Inventario;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmCostoProduccion.Common.Commands.Inventario
{
    public static class InventarioCommand
    {
        public static void GenerarRecepcion(CompraViewModel compraViewModel, ApplicationDbContext context)
        {
            var recepcion = context.Recepcions
                .Where(o => o.CompraId == compraViewModel.CompraId)
                .FirstOrDefault();
            //Correlativo
            var correlativo = AplicacionCommand.GetCorrelativo("RE");
            //TipoRecepcion
            var tipoRecepcion = context.TipoRecepcions
                .Where(o => o.Codigo == "CO")
                .FirstOrDefault();
            if (tipoRecepcion == null)
                throw new Exception("No existe configurado tipo Recepcion CO - Compra");

            //Recepcion
            var recepcionId = Guid.NewGuid().ToString();
            if (recepcion == null)
            {
                context.Database.ExecuteSqlCommand(
                    SqlResource.Recepcion_Insert,
                        new SqlParameter("@RecepcionId", recepcionId),
                        new SqlParameter("@Codigo", correlativo),
                        new SqlParameter("@Observacion", string.Format("Asociado a compra: {0}", compraViewModel.NumeroDocumento)),
                        new SqlParameter("@TipoRecepcionId", tipoRecepcion.TipoRecepcionId),
                        new SqlParameter("@AlmacenId", 0),
                        new SqlParameter("@OrdenProduccionId", DBNull.Value),
                        new SqlParameter("@CompraId", compraViewModel.CompraId),
                        new SqlParameter("@UsuarioCreacion", DBNull.Value),
                        new SqlParameter("@FechaCreacion", DateTime.Now),
                        new SqlParameter("@Eliminado", false)
                );
            }
            else
            {
                recepcionId = recepcion.RecepcionId;
                context.Database.ExecuteSqlCommand(
                    SqlResource.Recepcion_Update,
                        new SqlParameter("@RecepcionId", recepcionId),
                        new SqlParameter("@Codigo", correlativo),
                        new SqlParameter("@Observacion", string.Format("Asociado a compra: {0}", compraViewModel.NumeroDocumento)),
                        new SqlParameter("@TipoRecepcionId", tipoRecepcion.TipoRecepcionId),
                        new SqlParameter("@AlmacenId", 0),
                        new SqlParameter("@OrdenProduccionId", DBNull.Value),
                        new SqlParameter("@CompraId", compraViewModel.CompraId),
                        new SqlParameter("@UsuarioUltimaActualizacion", DBNull.Value),
                        new SqlParameter("@FechaUltimaActualizacion", DateTime.Now),
                        new SqlParameter("@Eliminado", false)
                );
            }
            foreach (var compraDetalleViewModel in compraViewModel.CompraDetalleViewModels)
            {
                ////Se busca si ya tiene asociado alguna recepcion
                ////Kardex
                //Kardex kardex = ordenServicio.Kardexs
                //    .Where(o => o.AlmacenId == compraViewModel.AlmacenId)
                //    .FirstOrDefault();
                //var kardexId = Guid.NewGuid().ToString();
                //if (kardex == null)
                //{
                //    context.Database.ExecuteSqlCommand(
                //        SqlResource.Kardex_Insert,
                //            new SqlParameter("@KardexId", kardexId),
                //            new SqlParameter("@CantidadSaldo", compraDetalleViewModel.Cantidad),
                //            new SqlParameter("@CantidadEntrada", compraDetalleViewModel.Cantidad),
                //            new SqlParameter("@CantidadSalida", 0),
                //            new SqlParameter("@OrdenServicioId", recepcionId),
                //            new SqlParameter("@AlmacenId", compraViewModel.AlmacenId),
                //            new SqlParameter("@UsuarioCreacion", DBNull.Value),
                //            new SqlParameter("@FechaCreacion", DateTime.Now),
                //            new SqlParameter("@Eliminado", false)
                //    );
                //}
                //else
                //{
                //    kardexId = kardex.KardexId;
                //    var cantidadSaldo = kardex.CantidadSaldo + compraDetalleViewModel.Cantidad - cantidadAnterior;
                //    var cantidadEntrada = kardex.CantidadEntrada + compraDetalleViewModel.Cantidad - cantidadAnterior;
                //    var cantidadSalida = kardex.CantidadSalida;
                //    context.Database.ExecuteSqlCommand(
                //        SqlResource.Kardex_Update,
                //            new SqlParameter("@KardexId", kardexId),
                //            new SqlParameter("@CantidadSaldo", cantidadSaldo),
                //            new SqlParameter("@CantidadEntrada", cantidadEntrada),
                //            new SqlParameter("@CantidadSalida", cantidadSalida),
                //            new SqlParameter("@OrdenServicioId", recepcionId),
                //            new SqlParameter("@AlmacenId", compraViewModel.AlmacenId),
                //            new SqlParameter("@UsuarioUltimaActualizacion", DBNull.Value),
                //            new SqlParameter("@FechaUltimaActualizacion", DateTime.Now),
                //            new SqlParameter("@Eliminado", false)
                //    );
                //}
                ////KardexMovimiento
                //TipoMovimiento tipoMovimiento = context.TipoMovimientos
                //    .Where(o => o.Codigo == "ENT")
                //    .FirstOrDefault();
                //var kardexMovimientoId = Guid.NewGuid().ToString();
                //if (recepcion == null)
                //{
                //    context.Database.ExecuteSqlCommand(
                //        SqlResource.KardexMovimiento_Insert,
                //            new SqlParameter("@KardexMovimientoId", kardexMovimientoId),
                //            new SqlParameter("@Cantidad", compraDetalleViewModel.Cantidad),
                //            new SqlParameter("@KardexId", kardexId),
                //            new SqlParameter("@TipoMovimientoId", tipoMovimiento.TipoMovimientoId),
                //            new SqlParameter("@RecepcionDetalleId", compraDetalleViewModel.RecepcionDetalleId),
                //            new SqlParameter("@DespachoDetalleId", DBNull.Value),
                //            new SqlParameter("@MercaderiaId", compraDetalleViewModel.MercaderiaId),
                //            new SqlParameter("@UnidadMedidaId", compraDetalleViewModel.UnidadMedidaId),
                //            new SqlParameter("@UsuarioCreacion", DBNull.Value),
                //            new SqlParameter("@FechaCreacion", DateTime.Now),
                //            new SqlParameter("@Eliminado", false)
                //    );
                //}
                //else
                //{
                //    kardexMovimientoId = recepcion.KardexMovimientoId;
                //    context.Database.ExecuteSqlCommand(
                //        SqlResource.KardexMovimiento_Update,
                //            new SqlParameter("@KardexMovimientoId", kardexMovimientoId),
                //            new SqlParameter("@Cantidad", compraDetalleViewModel.Cantidad),
                //            new SqlParameter("@KardexId", kardexId),
                //            new SqlParameter("@TipoMovimientoId", tipoMovimiento.TipoMovimientoId),
                //            new SqlParameter("@RecepcionDetalleId", compraDetalleViewModel.RecepcionDetalleId),
                //            new SqlParameter("@DespachoDetalleId", DBNull.Value),
                //            new SqlParameter("@MercaderiaId", compraDetalleViewModel.MercaderiaId),
                //            new SqlParameter("@UnidadMedidaId", compraDetalleViewModel.UnidadMedidaId),
                //            new SqlParameter("@UsuarioUltimaActualizacion", DBNull.Value),
                //            new SqlParameter("@FechaUltimaActualizacion", DateTime.Now),
                //            new SqlParameter("@Eliminado", false)
                //    );
                //}
            }
        }

        public static void GenerarMovimientoRecepcion(RecepcionViewModel recepcionViewModel, ApplicationDbContext context)
        {
            foreach (var recepcionDetalleViewModel in recepcionViewModel.RecepcionDetalleViewModels)
            {
                //Se busca si ya tiene asociado algun movimiento
                double cantidadAnterior = 0;
                var kardexMovimiento = context.KardexMovimientos
                    .Where(o => o.RecepcionDetalleId == recepcionDetalleViewModel.RecepcionDetalleId)
                    .FirstOrDefault();
                if (kardexMovimiento != null)
                {
                    cantidadAnterior = kardexMovimiento.Cantidad;
                }

                var ordenServicio = context.OrdenServicios
                    .Where(o => o.MercaderiaId == recepcionDetalleViewModel.MercaderiaId)
                    .FirstOrDefault();

                //OrdenServicio
                var ordenServicioId = Guid.NewGuid().ToString();
                if (ordenServicio == null)
                {
                    context.Database.ExecuteSqlCommand(
                        SqlResource.OrdenServicio_Insert,
                            new SqlParameter("@OrdenServicioId", ordenServicioId),
                            new SqlParameter("@CantidadSaldo", recepcionDetalleViewModel.Cantidad),
                            new SqlParameter("@CantidadEntrada", recepcionDetalleViewModel.Cantidad),
                            new SqlParameter("@CantidadSalida", 0),
                            new SqlParameter("@MercaderiaId", recepcionDetalleViewModel.MercaderiaId),
                            new SqlParameter("@UsuarioCreacion", DBNull.Value),
                            new SqlParameter("@FechaCreacion", DateTime.Now),
                            new SqlParameter("@Eliminado", false)
                    );
                }
                else
                {
                    ordenServicioId = ordenServicio.OrdenServicioId;
                    var cantidadSaldo = ordenServicio.CantidadSaldo + recepcionDetalleViewModel.Cantidad - cantidadAnterior;
                    var cantidadEntrada = ordenServicio.CantidadEntrada + recepcionDetalleViewModel.Cantidad - cantidadAnterior;
                    var cantidadSalida = ordenServicio.CantidadSalida;
                    context.Database.ExecuteSqlCommand(
                        SqlResource.OrdenServicio_Update,
                            new SqlParameter("@OrdenServicioId", ordenServicioId),
                            new SqlParameter("@CantidadSaldo", cantidadSaldo),
                            new SqlParameter("@CantidadEntrada", cantidadEntrada),
                            new SqlParameter("@CantidadSalida", cantidadSalida),
                            new SqlParameter("@MercaderiaId", recepcionDetalleViewModel.MercaderiaId),
                            new SqlParameter("@UsuarioUltimaActualizacion", DBNull.Value),
                            new SqlParameter("@FechaUltimaActualizacion", DateTime.Now),
                            new SqlParameter("@Eliminado", false)
                    );
                }
                //Kardex
                Kardex kardex = ordenServicio.Kardexs
                    .Where(o => o.AlmacenId == recepcionViewModel.AlmacenId)
                    .FirstOrDefault();
                var kardexId = Guid.NewGuid().ToString();
                if (kardex == null)
                {
                    context.Database.ExecuteSqlCommand(
                        SqlResource.Kardex_Insert,
                            new SqlParameter("@KardexId", kardexId),
                            new SqlParameter("@CantidadSaldo", recepcionDetalleViewModel.Cantidad),
                            new SqlParameter("@CantidadEntrada", recepcionDetalleViewModel.Cantidad),
                            new SqlParameter("@CantidadSalida", 0),
                            new SqlParameter("@OrdenServicioId", ordenServicioId),
                            new SqlParameter("@AlmacenId", recepcionViewModel.AlmacenId),
                            new SqlParameter("@UsuarioCreacion", DBNull.Value),
                            new SqlParameter("@FechaCreacion", DateTime.Now),
                            new SqlParameter("@Eliminado", false)
                    );
                }
                else
                {
                    kardexId = kardex.KardexId;
                    var cantidadSaldo = kardex.CantidadSaldo + recepcionDetalleViewModel.Cantidad - cantidadAnterior;
                    var cantidadEntrada = kardex.CantidadEntrada + recepcionDetalleViewModel.Cantidad - cantidadAnterior;
                    var cantidadSalida = kardex.CantidadSalida;
                    context.Database.ExecuteSqlCommand(
                        SqlResource.Kardex_Update,
                            new SqlParameter("@KardexId", kardexId),
                            new SqlParameter("@CantidadSaldo", cantidadSaldo),
                            new SqlParameter("@CantidadEntrada", cantidadEntrada),
                            new SqlParameter("@CantidadSalida", cantidadSalida),
                            new SqlParameter("@OrdenServicioId", ordenServicioId),
                            new SqlParameter("@AlmacenId", recepcionViewModel.AlmacenId),
                            new SqlParameter("@UsuarioUltimaActualizacion", DBNull.Value),
                            new SqlParameter("@FechaUltimaActualizacion", DateTime.Now),
                            new SqlParameter("@Eliminado", false)
                    );
                }
                //KardexMovimiento
                TipoMovimiento tipoMovimiento = context.TipoMovimientos
                    .Where(o => o.Codigo == "ENT")
                    .FirstOrDefault();
                var kardexMovimientoId = Guid.NewGuid().ToString();
                if (kardexMovimiento == null)
                {
                    context.Database.ExecuteSqlCommand(
                        SqlResource.KardexMovimiento_Insert,
                            new SqlParameter("@KardexMovimientoId", kardexMovimientoId),
                            new SqlParameter("@Cantidad", recepcionDetalleViewModel.Cantidad),
                            new SqlParameter("@KardexId", kardexId),
                            new SqlParameter("@TipoMovimientoId", tipoMovimiento.TipoMovimientoId),
                            new SqlParameter("@RecepcionDetalleId", recepcionDetalleViewModel.RecepcionDetalleId),
                            new SqlParameter("@DespachoDetalleId", DBNull.Value),
                            new SqlParameter("@MercaderiaId", recepcionDetalleViewModel.MercaderiaId),
                            new SqlParameter("@UnidadMedidaId", recepcionDetalleViewModel.UnidadMedidaId),
                            new SqlParameter("@UsuarioCreacion", DBNull.Value),
                            new SqlParameter("@FechaCreacion", DateTime.Now),
                            new SqlParameter("@Eliminado", false)
                    );
                }
                else
                {
                    kardexMovimientoId = kardexMovimiento.KardexMovimientoId;
                    context.Database.ExecuteSqlCommand(
                        SqlResource.KardexMovimiento_Update,
                            new SqlParameter("@KardexMovimientoId", kardexMovimientoId),
                            new SqlParameter("@Cantidad", recepcionDetalleViewModel.Cantidad),
                            new SqlParameter("@KardexId", kardexId),
                            new SqlParameter("@TipoMovimientoId", tipoMovimiento.TipoMovimientoId),
                            new SqlParameter("@RecepcionDetalleId", recepcionDetalleViewModel.RecepcionDetalleId),
                            new SqlParameter("@DespachoDetalleId", DBNull.Value),
                            new SqlParameter("@MercaderiaId", recepcionDetalleViewModel.MercaderiaId),
                            new SqlParameter("@UnidadMedidaId", recepcionDetalleViewModel.UnidadMedidaId),
                            new SqlParameter("@UsuarioUltimaActualizacion", DBNull.Value),
                            new SqlParameter("@FechaUltimaActualizacion", DateTime.Now),
                            new SqlParameter("@Eliminado", false)
                    );
                }
            }
        }

        public static void GenerarMovimientoSalida(DespachoViewModel despachoViewModel, ApplicationDbContext context)
        {
            foreach (var despachoDetalleViewModel in despachoViewModel.DespachoDetalleViewModels)
            {
                //Se busca si ya tiene asociado algun movimiento
                double cantidadAnterior = 0;
                var kardexMovimiento = context.KardexMovimientos
                    .Where(o => o.DespachoDetalleId == despachoDetalleViewModel.DespachoDetalleId)
                    .FirstOrDefault();
                if (kardexMovimiento != null)
                {
                    cantidadAnterior = kardexMovimiento.Cantidad;
                }

                var ordenServicio = context.OrdenServicios
                    .Where(o => o.MercaderiaId == despachoDetalleViewModel.MercaderiaId)
                    .FirstOrDefault();

                //OrdenServicio
                var ordenServicioId = Guid.NewGuid().ToString();
                if (ordenServicio == null)
                {
                    context.Database.ExecuteSqlCommand(
                        SqlResource.OrdenServicio_Insert,
                            new SqlParameter("@OrdenServicioId", ordenServicioId),
                            new SqlParameter("@CantidadSaldo", -despachoDetalleViewModel.Cantidad),
                            new SqlParameter("@CantidadEntrada", 0),
                            new SqlParameter("@CantidadSalida", despachoDetalleViewModel.Cantidad),
                            new SqlParameter("@MercaderiaId", despachoDetalleViewModel.MercaderiaId),
                            new SqlParameter("@UsuarioCreacion", DBNull.Value),
                            new SqlParameter("@FechaCreacion", DateTime.Now),
                            new SqlParameter("@Eliminado", false)
                    );
                }
                else
                {
                    ordenServicioId = ordenServicio.OrdenServicioId;
                    var cantidadSaldo = ordenServicio.CantidadSaldo - despachoDetalleViewModel.Cantidad + cantidadAnterior;
                    var cantidadEntrada = ordenServicio.CantidadEntrada;
                    var cantidadSalida = ordenServicio.CantidadSalida + despachoDetalleViewModel.Cantidad - cantidadAnterior;
                    context.Database.ExecuteSqlCommand(
                        SqlResource.OrdenServicio_Update,
                            new SqlParameter("@OrdenServicioId", ordenServicioId),
                            new SqlParameter("@CantidadSaldo", cantidadSaldo),
                            new SqlParameter("@CantidadEntrada", cantidadEntrada),
                            new SqlParameter("@CantidadSalida", cantidadSalida),
                            new SqlParameter("@MercaderiaId", despachoDetalleViewModel.MercaderiaId),
                            new SqlParameter("@UsuarioUltimaActualizacion", DBNull.Value),
                            new SqlParameter("@FechaUltimaActualizacion", DateTime.Now),
                            new SqlParameter("@Eliminado", false)
                    );
                }
                //Kardex
                Kardex kardex = ordenServicio.Kardexs
                    .Where(o => o.AlmacenId == despachoViewModel.AlmacenId)
                    .FirstOrDefault();
                var kardexId = Guid.NewGuid().ToString();
                if (kardex == null)
                {
                    context.Database.ExecuteSqlCommand(
                        SqlResource.Kardex_Insert,
                            new SqlParameter("@KardexId", kardexId),
                            new SqlParameter("@CantidadSaldo", -despachoDetalleViewModel.Cantidad),
                            new SqlParameter("@CantidadEntrada", 0),
                            new SqlParameter("@CantidadSalida", despachoDetalleViewModel.Cantidad),
                            new SqlParameter("@OrdenServicioId", ordenServicioId),
                            new SqlParameter("@AlmacenId", despachoViewModel.AlmacenId),
                            new SqlParameter("@UsuarioCreacion", DBNull.Value),
                            new SqlParameter("@FechaCreacion", DateTime.Now),
                            new SqlParameter("@Eliminado", false)
                    );
                }
                else
                {
                    kardexId = kardex.KardexId;
                    var cantidadSaldo = kardex.CantidadSaldo - despachoDetalleViewModel.Cantidad + cantidadAnterior;
                    var cantidadEntrada = kardex.CantidadEntrada;
                    var cantidadSalida = kardex.CantidadSalida + despachoDetalleViewModel.Cantidad - cantidadAnterior;
                    context.Database.ExecuteSqlCommand(
                        SqlResource.Kardex_Update,
                            new SqlParameter("@KardexId", kardexId),
                            new SqlParameter("@CantidadSaldo", cantidadSaldo),
                            new SqlParameter("@CantidadEntrada", cantidadEntrada),
                            new SqlParameter("@CantidadSalida", cantidadSalida),
                            new SqlParameter("@OrdenServicioId", ordenServicioId),
                            new SqlParameter("@AlmacenId", despachoViewModel.AlmacenId),
                            new SqlParameter("@UsuarioUltimaActualizacion", DBNull.Value),
                            new SqlParameter("@FechaUltimaActualizacion", DateTime.Now),
                            new SqlParameter("@Eliminado", false)
                    );
                }
                //KardexMovimiento
                TipoMovimiento tipoMovimiento = context.TipoMovimientos
                    .Where(o => o.Codigo == "SAL")
                    .FirstOrDefault();
                if (tipoMovimiento == null)
                {
                    throw new Exception("Tipo movimiento SAL - Salida no registrado");
                }
                var kardexMovimientoId = Guid.NewGuid().ToString();
                if (kardexMovimiento == null)
                {
                    context.Database.ExecuteSqlCommand(
                        SqlResource.KardexMovimiento_Insert,
                            new SqlParameter("@KardexMovimientoId", kardexMovimientoId),
                            new SqlParameter("@Cantidad", despachoDetalleViewModel.Cantidad),
                            new SqlParameter("@KardexId", kardexId),
                            new SqlParameter("@TipoMovimientoId", tipoMovimiento.TipoMovimientoId),
                            new SqlParameter("@RecepcionDetalleId", DBNull.Value),
                            new SqlParameter("@DespachoDetalleId", despachoDetalleViewModel.DespachoDetalleId),
                            new SqlParameter("@MercaderiaId", despachoDetalleViewModel.MercaderiaId),
                            new SqlParameter("@UnidadMedidaId", despachoDetalleViewModel.UnidadMedidaId),
                            new SqlParameter("@UsuarioCreacion", DBNull.Value),
                            new SqlParameter("@FechaCreacion", DateTime.Now),
                            new SqlParameter("@Eliminado", false)
                    );
                }
                else
                {
                    kardexMovimientoId = kardexMovimiento.KardexMovimientoId;
                    context.Database.ExecuteSqlCommand(
                        SqlResource.KardexMovimiento_Update,
                            new SqlParameter("@KardexMovimientoId", kardexMovimientoId),
                            new SqlParameter("@Cantidad", despachoDetalleViewModel.Cantidad),
                            new SqlParameter("@KardexId", kardexId),
                            new SqlParameter("@TipoMovimientoId", tipoMovimiento.TipoMovimientoId),
                            new SqlParameter("@RecepcionDetalleId", DBNull.Value),
                            new SqlParameter("@DespachoDetalleId", despachoDetalleViewModel.DespachoDetalleId),
                            new SqlParameter("@MercaderiaId", despachoDetalleViewModel.MercaderiaId),
                            new SqlParameter("@UnidadMedidaId", despachoDetalleViewModel.UnidadMedidaId),
                            new SqlParameter("@UsuarioUltimaActualizacion", DBNull.Value),
                            new SqlParameter("@FechaUltimaActualizacion", DateTime.Now),
                            new SqlParameter("@Eliminado", false)
                    );
                }
            }
        }
    }
}
