using AdmCostoProduccion.Common.Data;
using AdmCostoProduccion.Common.Models.Inventario;
using AdmCostoProduccion.Common.ViewModels.CompraVenta;
using AdmCostoProduccion.Common.ViewModels.Inventario;
using AdmCostoProduccion.Common.ViewModels.Produccion;
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
        #region Eventos Privados
        static object Iif(bool expression, object truePart, object falsePart) { return expression ? truePart : falsePart; }

        private static void InsertRecepcion(RecepcionViewModel recepcionViewModel, ApplicationDbContext context)
        {
            context.Database.ExecuteSqlCommand(
                SqlResource.Recepcion_Insert,
                    new SqlParameter("@RecepcionId", recepcionViewModel.RecepcionId),
                    new SqlParameter("@Codigo", recepcionViewModel.Codigo),
                    new SqlParameter("@Fecha", recepcionViewModel.Fecha),
                    new SqlParameter("@Observacion", recepcionViewModel.Observacion),
                    new SqlParameter("@TipoRecepcionId", recepcionViewModel.TipoRecepcionId),
                    new SqlParameter("@AlmacenId", recepcionViewModel.AlmacenId),
                    new SqlParameter("@InventarioInicialId",
                        Iif(string.IsNullOrEmpty(recepcionViewModel.InventarioInicialId),
                            DBNull.Value,
                            recepcionViewModel.InventarioInicialId)),
                    new SqlParameter("@AjusteInventarioId",
                        Iif(string.IsNullOrEmpty(recepcionViewModel.AjusteInventarioId),
                            DBNull.Value,
                            recepcionViewModel.AjusteInventarioId)),
                    new SqlParameter("@OrdenProduccionId",
                        Iif(string.IsNullOrEmpty(recepcionViewModel.OrdenProduccionId),
                            DBNull.Value,
                            recepcionViewModel.OrdenProduccionId)),
                    new SqlParameter("@CompraId",
                        Iif(string.IsNullOrEmpty(recepcionViewModel.CompraId),
                            DBNull.Value,
                            recepcionViewModel.CompraId)),
                    new SqlParameter("@UsuarioCreacion", DBNull.Value),
                    new SqlParameter("@FechaCreacion", DateTime.Now),
                    new SqlParameter("@Eliminado", false)
                );
        }

        private static void UpdateRecepcion(RecepcionViewModel recepcionViewModel, ApplicationDbContext context)
        {
            context.Database.ExecuteSqlCommand(
                SqlResource.Recepcion_Update,
                    new SqlParameter("@RecepcionId", recepcionViewModel.RecepcionId),
                    new SqlParameter("@Codigo", recepcionViewModel.Codigo),
                    new SqlParameter("@Fecha", recepcionViewModel.Fecha),
                    new SqlParameter("@Observacion", recepcionViewModel.Observacion),
                    new SqlParameter("@TipoRecepcionId", recepcionViewModel.TipoRecepcionId),
                    new SqlParameter("@AlmacenId", recepcionViewModel.AlmacenId),
                    new SqlParameter("@InventarioInicialId",
                        Iif(string.IsNullOrEmpty(recepcionViewModel.InventarioInicialId),
                            DBNull.Value,
                            recepcionViewModel.InventarioInicialId)),
                    new SqlParameter("@AjusteInventarioId",
                        Iif(string.IsNullOrEmpty(recepcionViewModel.AjusteInventarioId),
                            DBNull.Value,
                            recepcionViewModel.AjusteInventarioId)),
                    new SqlParameter("@OrdenProduccionId",
                        Iif(string.IsNullOrEmpty(recepcionViewModel.OrdenProduccionId),
                            DBNull.Value,
                            recepcionViewModel.OrdenProduccionId)),
                    new SqlParameter("@CompraId",
                        Iif(string.IsNullOrEmpty(recepcionViewModel.CompraId),
                            DBNull.Value,
                            recepcionViewModel.CompraId)),
                    new SqlParameter("@UsuarioUltimaActualizacion", DBNull.Value),
                    new SqlParameter("@FechaUltimaActualizacion", DateTime.Now),
                    new SqlParameter("@Eliminado", false)
            );
        }

        private static void InsertRecepcionDetalle(RecepcionDetalleViewModel recepcionViewModel, ApplicationDbContext context)
        {

            context.Database.ExecuteSqlCommand(
                SqlResource.RecepcionDetalle_Insert,
                    new SqlParameter("@RecepcionDetalleId", recepcionViewModel.RecepcionDetalleId),
                    new SqlParameter("@Cantidad", recepcionViewModel.Cantidad),
                    new SqlParameter("@RecepcionId", recepcionViewModel.RecepcionId),
                    new SqlParameter("@MercaderiaId", recepcionViewModel.MercaderiaId),
                    new SqlParameter("@UnidadMedidaId", recepcionViewModel.UnidadMedidaId),
                    new SqlParameter("@InventarioInicialDetalleId"
                        , Iif(string.IsNullOrEmpty(recepcionViewModel.InventarioInicialDetalleId)
                            , DBNull.Value
                            , recepcionViewModel.InventarioInicialDetalleId)),
                    new SqlParameter("@AjusteInventarioDetalleId"
                        , Iif(string.IsNullOrEmpty(recepcionViewModel.AjusteInventarioDetalleId)
                            , DBNull.Value
                            , recepcionViewModel.AjusteInventarioDetalleId)),
                    new SqlParameter("@OrdenProduccionInsumoId"
                        , Iif(string.IsNullOrEmpty(recepcionViewModel.OrdenProduccionInsumoId)
                            , DBNull.Value
                            , recepcionViewModel.OrdenProduccionInsumoId)),
                    new SqlParameter("@CompraDetalleId",
                        Iif(string.IsNullOrEmpty(recepcionViewModel.CompraDetalleId),
                            DBNull.Value,
                            recepcionViewModel.CompraDetalleId)),
                    new SqlParameter("@UsuarioCreacion", DBNull.Value),
                    new SqlParameter("@FechaCreacion", DateTime.Now),
                    new SqlParameter("@Eliminado", false)
            );
        }

        private static void UpdateRecepcionDetalle(RecepcionDetalleViewModel recepcionViewModel, ApplicationDbContext context)
        {

            context.Database.ExecuteSqlCommand(
                SqlResource.RecepcionDetalle_Update,
                    new SqlParameter("@RecepcionDetalleId", recepcionViewModel.RecepcionDetalleId),
                    new SqlParameter("@Cantidad", recepcionViewModel.Cantidad),
                    new SqlParameter("@RecepcionId", recepcionViewModel.RecepcionId),
                    new SqlParameter("@MercaderiaId", recepcionViewModel.MercaderiaId),
                    new SqlParameter("@UnidadMedidaId", recepcionViewModel.UnidadMedidaId),
                    new SqlParameter("@InventarioInicialDetalleId"
                        , Iif(string.IsNullOrEmpty(recepcionViewModel.InventarioInicialDetalleId)
                            , DBNull.Value
                            , recepcionViewModel.InventarioInicialDetalleId)),
                    new SqlParameter("@AjusteInventarioDetalleId"
                        , Iif(string.IsNullOrEmpty(recepcionViewModel.AjusteInventarioDetalleId)
                            , DBNull.Value
                            , recepcionViewModel.AjusteInventarioDetalleId)),
                    new SqlParameter("@OrdenProduccionInsumoId",
                        Iif(string.IsNullOrEmpty(recepcionViewModel.OrdenProduccionInsumoId),
                            DBNull.Value,
                            recepcionViewModel.OrdenProduccionInsumoId)),
                    new SqlParameter("@CompraDetalleId",
                        Iif(string.IsNullOrEmpty(recepcionViewModel.CompraDetalleId),
                            DBNull.Value,
                            recepcionViewModel.CompraDetalleId)),
                    new SqlParameter("@UsuarioUltimaActualizacion", DBNull.Value),
                    new SqlParameter("@FechaUltimaActualizacion", DateTime.Now),
                    new SqlParameter("@Eliminado", false)
            );
        }

        private static void InsertDespacho(DespachoViewModel recepcionViewModel, ApplicationDbContext context)
        {
            context.Database.ExecuteSqlCommand(
                SqlResource.Despacho_Insert,
                    new SqlParameter("@DespachoId", recepcionViewModel.DespachoId),
                    new SqlParameter("@Codigo", recepcionViewModel.Codigo),
                    new SqlParameter("@Fecha", recepcionViewModel.Fecha),
                    new SqlParameter("@Observacion", recepcionViewModel.Observacion),
                    new SqlParameter("@TipoDespachoId", recepcionViewModel.TipoDespachoId),
                    new SqlParameter("@AlmacenId", recepcionViewModel.AlmacenId),
                    new SqlParameter("@AjusteInventarioId",
                        Iif(string.IsNullOrEmpty(recepcionViewModel.AjusteInventarioId),
                            DBNull.Value,
                            recepcionViewModel.AjusteInventarioId)),
                    new SqlParameter("@OrdenProduccionId",
                        Iif(string.IsNullOrEmpty(recepcionViewModel.OrdenProduccionId),
                            DBNull.Value,
                            recepcionViewModel.OrdenProduccionId)),
                    new SqlParameter("@VentaId",
                        Iif(string.IsNullOrEmpty(recepcionViewModel.VentaId),
                            DBNull.Value,
                            recepcionViewModel.VentaId)),
                    new SqlParameter("@UsuarioCreacion", DBNull.Value),
                    new SqlParameter("@FechaCreacion", DateTime.Now),
                    new SqlParameter("@Eliminado", false)
                );
        }

        private static void UpdateDespacho(DespachoViewModel recepcionViewModel, ApplicationDbContext context)
        {
            context.Database.ExecuteSqlCommand(
                SqlResource.Despacho_Update,
                    new SqlParameter("@DespachoId", recepcionViewModel.DespachoId),
                    new SqlParameter("@Codigo", recepcionViewModel.Codigo),
                    new SqlParameter("@Fecha", recepcionViewModel.Fecha),
                    new SqlParameter("@Observacion", recepcionViewModel.Observacion),
                    new SqlParameter("@TipoDespachoId", recepcionViewModel.TipoDespachoId),
                    new SqlParameter("@AlmacenId", recepcionViewModel.AlmacenId),
                    new SqlParameter("@AjusteInventarioId",
                        Iif(string.IsNullOrEmpty(recepcionViewModel.AjusteInventarioId),
                            DBNull.Value,
                            recepcionViewModel.AjusteInventarioId)),
                    new SqlParameter("@OrdenProduccionId",
                        Iif(string.IsNullOrEmpty(recepcionViewModel.OrdenProduccionId),
                            DBNull.Value,
                            recepcionViewModel.OrdenProduccionId)),
                    new SqlParameter("@VentaId",
                        Iif(string.IsNullOrEmpty(recepcionViewModel.VentaId),
                            DBNull.Value,
                            recepcionViewModel.VentaId)),
                    new SqlParameter("@UsuarioUltimaActualizacion", DBNull.Value),
                    new SqlParameter("@FechaUltimaActualizacion", DateTime.Now),
                    new SqlParameter("@Eliminado", false)
            );
        }

        private static void InsertDespachoDetalle(DespachoDetalleViewModel recepcionViewModel, ApplicationDbContext context)
        {
            context.Database.ExecuteSqlCommand(
                SqlResource.DespachoDetalle_Insert,
                    new SqlParameter("@DespachoDetalleId", recepcionViewModel.DespachoDetalleId),
                    new SqlParameter("@Cantidad", recepcionViewModel.Cantidad),
                    new SqlParameter("@DespachoId", recepcionViewModel.DespachoId),
                    new SqlParameter("@MercaderiaId", recepcionViewModel.MercaderiaId),
                    new SqlParameter("@UnidadMedidaId", recepcionViewModel.UnidadMedidaId),
                    new SqlParameter("@AjusteInventarioDetalleId"
                        , Iif(string.IsNullOrEmpty(recepcionViewModel.AjusteInventarioDetalleId)
                            , DBNull.Value
                            , recepcionViewModel.AjusteInventarioDetalleId)),
                    new SqlParameter("@OrdenProduccionInsumoId"
                        , Iif(string.IsNullOrEmpty(recepcionViewModel.OrdenProduccionInsumoId)
                            , DBNull.Value
                            , recepcionViewModel.OrdenProduccionInsumoId)),
                    new SqlParameter("@VentaDetalleId",
                        Iif(string.IsNullOrEmpty(recepcionViewModel.VentaDetalleId),
                            DBNull.Value,
                            recepcionViewModel.VentaDetalleId)),
                    new SqlParameter("@UsuarioCreacion", DBNull.Value),
                    new SqlParameter("@FechaCreacion", DateTime.Now),
                    new SqlParameter("@Eliminado", false)
            );
        }

        private static void UpdateDespachoDetalle(DespachoDetalleViewModel recepcionViewModel, ApplicationDbContext context)
        {
            context.Database.ExecuteSqlCommand(
                SqlResource.DespachoDetalle_Update,
                    new SqlParameter("@DespachoDetalleId", recepcionViewModel.DespachoDetalleId),
                    new SqlParameter("@Cantidad", recepcionViewModel.Cantidad),
                    new SqlParameter("@DespachoId", recepcionViewModel.DespachoId),
                    new SqlParameter("@MercaderiaId", recepcionViewModel.MercaderiaId),
                    new SqlParameter("@UnidadMedidaId", recepcionViewModel.UnidadMedidaId),
                    new SqlParameter("@AjusteInventarioDetalleId"
                        , Iif(string.IsNullOrEmpty(recepcionViewModel.AjusteInventarioDetalleId)
                            , DBNull.Value
                            , recepcionViewModel.AjusteInventarioDetalleId)),
                    new SqlParameter("@OrdenProduccionInsumoId",
                        Iif(string.IsNullOrEmpty(recepcionViewModel.OrdenProduccionInsumoId),
                            DBNull.Value,
                            recepcionViewModel.OrdenProduccionInsumoId)),
                    new SqlParameter("@VentaDetalleId",
                        Iif(string.IsNullOrEmpty(recepcionViewModel.VentaDetalleId),
                            DBNull.Value,
                            recepcionViewModel.VentaDetalleId)),
                    new SqlParameter("@UsuarioUltimaActualizacion", DBNull.Value),
                    new SqlParameter("@FechaUltimaActualizacion", DateTime.Now),
                    new SqlParameter("@Eliminado", false)
            );
        }
        #endregion

        public static void GenerarRecepcion(OrdenProduccionViewModel ordenProduccionViewModel, ApplicationDbContext context)
        {
            //Mercaderia
            var mercaderia = context.Mercaderias
                .Where(o => o.MercaderiaId == ordenProduccionViewModel.MercaderiaId)
                .FirstOrDefault();
            //ReglaAlmacenaje
            var reglaAlmacenaje = context.ReglaAlmacenajes
                .Where(o => o.FamiliaMercaderiaId == mercaderia.FamiliaMercaderiaId)
                .FirstOrDefault();
            //TipoRecepcion
            var tipoRecepcion = context.TipoRecepcions
                .Where(o => o.Codigo == "OP")
                .FirstOrDefault();
            if (tipoRecepcion == null)
                throw new Exception("No existe configurado tipo Recepcion CO - OrdenProduccion");

            //Se verifica si existe la recepcion
            var recepcion = context.Recepcions
                .Where(o => o.OrdenProduccionId == ordenProduccionViewModel.OrdenProduccionId)
                .FirstOrDefault();

            RecepcionViewModel recepcionViewModel = null;
            if (recepcion != null)
            {
                recepcionViewModel = new RecepcionViewModel(recepcion);
            }

            //Recepcion
            var recepcionId = Guid.NewGuid().ToString();
            if (recepcionViewModel == null)
            {
                //Correlativo
                var correlativo = AplicacionCommand.GetCorrelativo("RE");

                recepcionViewModel = new RecepcionViewModel
                {
                    RecepcionId = recepcionId,
                    Codigo = correlativo,
                    Fecha = ordenProduccionViewModel.Fecha,
                    Observacion = string.Format("Asociado a ordenProduccion: {0}", ordenProduccionViewModel.Codigo),
                    TipoRecepcionId = tipoRecepcion.TipoRecepcionId,
                    AlmacenId = reglaAlmacenaje.AlmacenId,
                    InventarioInicialId = string.Empty,
                    AjusteInventarioId = string.Empty,
                    OrdenProduccionId = ordenProduccionViewModel.OrdenProduccionId,
                    CompraId = string.Empty
                };

                InsertRecepcion(recepcionViewModel, context);
            }
            else
            {
                recepcionId = recepcion.RecepcionId;

                recepcionViewModel.Fecha = ordenProduccionViewModel.Fecha;
                recepcionViewModel.Observacion = string.Format("Asociado a ordenProduccion: {0}", ordenProduccionViewModel.Codigo);
                recepcionViewModel.TipoRecepcionId = tipoRecepcion.TipoRecepcionId;
                recepcionViewModel.AlmacenId = reglaAlmacenaje.AlmacenId;
                recepcionViewModel.InventarioInicialId = string.Empty;
                recepcionViewModel.AjusteInventarioId = string.Empty;
                recepcionViewModel.OrdenProduccionId = ordenProduccionViewModel.OrdenProduccionId;
                recepcionViewModel.CompraId = string.Empty;

                UpdateRecepcion(recepcionViewModel, context);
            }
            //Se busca si ya tiene asociado algun detalle
            //RecepcionDetalle
            var recepcionDetalleViewModel = recepcionViewModel.RecepcionDetalleViewModels
                .FirstOrDefault();
            var recepcionDetalleId = Guid.NewGuid().ToString();
            if (recepcionDetalleViewModel == null)
            {
                recepcionDetalleViewModel = new RecepcionDetalleViewModel
                {
                    RecepcionDetalleId = recepcionDetalleId,
                    Cantidad = ordenProduccionViewModel.Cantidad,
                    RecepcionId = recepcionId,
                    MercaderiaId = ordenProduccionViewModel.MercaderiaId,
                    UnidadMedidaId = ordenProduccionViewModel.UnidadMedidaId,
                    InventarioInicialDetalleId = string.Empty,
                    AjusteInventarioDetalleId = string.Empty,
                    OrdenProduccionInsumoId = string.Empty,
                    CompraDetalleId = string.Empty
                };
                recepcionViewModel.RecepcionDetalleViewModels.Add(recepcionDetalleViewModel);
                InsertRecepcionDetalle(recepcionDetalleViewModel, context);
            }
            else
            {
                recepcionDetalleId = recepcionDetalleViewModel.RecepcionDetalleId;

                recepcionDetalleViewModel.Cantidad = ordenProduccionViewModel.Cantidad;
                recepcionDetalleViewModel.RecepcionId = recepcionId;
                recepcionDetalleViewModel.MercaderiaId = ordenProduccionViewModel.MercaderiaId;
                recepcionDetalleViewModel.UnidadMedidaId = ordenProduccionViewModel.UnidadMedidaId;
                recepcionDetalleViewModel.InventarioInicialDetalleId = string.Empty;
                recepcionDetalleViewModel.AjusteInventarioDetalleId = string.Empty;
                recepcionDetalleViewModel.OrdenProduccionInsumoId = string.Empty;
                recepcionDetalleViewModel.CompraDetalleId = string.Empty;

                UpdateRecepcionDetalle(recepcionDetalleViewModel, context);
            }

            //Se generan los movimientos asociados            
            GenerarMovimientoIngreso(recepcionViewModel, context);
        } 

        public static void GenerarRecepcion(CompraViewModel compraViewModel, ApplicationDbContext context)
        {
            List<RecepcionViewModel> recepcionViewModels = new List<RecepcionViewModel>();

            //Se verifica si existen recepciones asociadas
            var recepcions = context.Recepcions
                .Where(o => o.CompraId == compraViewModel.CompraId)
                .ToList();
            //Se carga las recepciones al listado
            foreach (var recepcion in recepcions)
            {
                recepcionViewModels.Add(new RecepcionViewModel(recepcion));
            }

            foreach (var compraDetalleViewModel in compraViewModel.CompraDetalleViewModels)
            {
                //Mercaderia
                var mercaderia = context.Mercaderias
                    .Where(o => o.MercaderiaId == compraDetalleViewModel.MercaderiaId)
                    .FirstOrDefault();
                //ReglaAlmacenaje
                var reglaAlmacenaje = context.ReglaAlmacenajes
                    .Where(o => o.FamiliaMercaderiaId == mercaderia.FamiliaMercaderiaId)
                    .FirstOrDefault();
                if (reglaAlmacenaje == null)
                    throw new Exception(string.Format("No existe configurado regla de almacenaje para la familia: {0}"
                        , mercaderia.FamiliaMercaderia.Nombre));
                //TipoRecepcion
                var tipoRecepcion = context.TipoRecepcions
                    .Where(o => o.Codigo == "CO")
                    .FirstOrDefault();
                if (tipoRecepcion == null)
                    throw new Exception("No existe configurado tipo Recepcion CO - Compra");

                //Se verifica si existe la recepcion
                RecepcionViewModel recepcionViewModel = recepcionViewModels
                    .Where(o => o.AlmacenId == reglaAlmacenaje.AlmacenId)
                    .FirstOrDefault();

                //Recepcion
                var recepcionId = Guid.NewGuid().ToString();
                if (recepcionViewModel == null)
                {
                    //Correlativo
                    var correlativo = AplicacionCommand.GetCorrelativo("RE");

                    recepcionViewModel = new RecepcionViewModel
                    {
                        RecepcionId = recepcionId,
                        Codigo = correlativo,
                        Fecha = compraViewModel.Fecha,
                        Observacion = string.Format("Asociado a compra: {0}", compraViewModel.NumeroDocumento),
                        TipoRecepcionId = tipoRecepcion.TipoRecepcionId,
                        AlmacenId = reglaAlmacenaje.AlmacenId,
                        InventarioInicialId = string.Empty,
                        AjusteInventarioId = string.Empty,
                        OrdenProduccionId = string.Empty,
                        CompraId = compraViewModel.CompraId
                    };
                    recepcionViewModels.Add(recepcionViewModel);
                    InsertRecepcion(recepcionViewModel, context);
                }
                else
                {
                    recepcionId = recepcionViewModel.RecepcionId;
                    //
                    recepcionViewModel.Fecha = compraViewModel.Fecha;
                    recepcionViewModel.Observacion = string.Format("Asociado a compra: {0}", compraViewModel.NumeroDocumento);
                    recepcionViewModel.TipoRecepcionId = tipoRecepcion.TipoRecepcionId;
                    recepcionViewModel.AlmacenId = reglaAlmacenaje.AlmacenId;
                    recepcionViewModel.InventarioInicialId = string.Empty;
                    recepcionViewModel.AjusteInventarioId = string.Empty;
                    recepcionViewModel.OrdenProduccionId = string.Empty;
                    recepcionViewModel.CompraId = compraViewModel.CompraId;

                    UpdateRecepcion(recepcionViewModel, context);
                }
                //Se busca si ya tiene asociado algun detalle
                //RecepcionDetalle
                RecepcionDetalleViewModel recepcionDetalleViewModel = recepcionViewModel.RecepcionDetalleViewModels
                    .Where(o => o.CompraDetalleId == compraDetalleViewModel.CompraDetalleId)
                    .FirstOrDefault();
                var recepcionDetalleId = Guid.NewGuid().ToString();
                if (recepcionDetalleViewModel == null)
                {
                    recepcionDetalleViewModel = new RecepcionDetalleViewModel
                    {
                        RecepcionDetalleId = recepcionDetalleId,
                        Cantidad = compraDetalleViewModel.Cantidad,
                        RecepcionId = recepcionId,
                        MercaderiaId = compraDetalleViewModel.MercaderiaId,
                        UnidadMedidaId = compraDetalleViewModel.UnidadMedidaId,
                        InventarioInicialDetalleId = string.Empty,
                        AjusteInventarioDetalleId = string.Empty,
                        OrdenProduccionInsumoId = string.Empty,
                        CompraDetalleId = compraDetalleViewModel.CompraDetalleId
                    };
                    recepcionViewModel.RecepcionDetalleViewModels.Add(recepcionDetalleViewModel);
                    InsertRecepcionDetalle(recepcionDetalleViewModel, context);
                }
                else
                {
                    recepcionDetalleId = recepcionDetalleViewModel.RecepcionDetalleId;
                    //
                    recepcionDetalleViewModel.RecepcionDetalleId = recepcionDetalleId;
                    recepcionDetalleViewModel.Cantidad = compraDetalleViewModel.Cantidad;
                    recepcionDetalleViewModel.RecepcionId = recepcionId;
                    recepcionDetalleViewModel.MercaderiaId = compraDetalleViewModel.MercaderiaId;
                    recepcionDetalleViewModel.UnidadMedidaId = compraDetalleViewModel.UnidadMedidaId;
                    recepcionDetalleViewModel.InventarioInicialDetalleId = string.Empty;
                    recepcionDetalleViewModel.AjusteInventarioDetalleId = string.Empty;
                    recepcionDetalleViewModel.OrdenProduccionInsumoId = string.Empty;
                    recepcionDetalleViewModel.CompraDetalleId = compraDetalleViewModel.CompraDetalleId;

                    UpdateRecepcionDetalle(recepcionDetalleViewModel, context);
                }
            }

            //Se generan los movimientos asociados
            foreach (var recepcionViewModel in recepcionViewModels)
            {
                GenerarMovimientoIngreso(recepcionViewModel, context);
            }
        }

        public static void GenerarRecepcion(InventarioInicialViewModel inventarioInicialViewModel, ApplicationDbContext context)
        {
            List<RecepcionViewModel> recepcionViewModels = new List<RecepcionViewModel>();

            //Se verifica si existen recepciones asociadas
            var recepcions = context.Recepcions
                .Where(o => o.InventarioInicialId == inventarioInicialViewModel.InventarioInicialId)
                .ToList();
            //Se carga las recepciones al listado
            foreach (var recepcion in recepcions)
            {
                recepcionViewModels.Add(new RecepcionViewModel(recepcion));
            }

            foreach (var inventarioInicialDetalleViewModel in inventarioInicialViewModel.InventarioInicialDetalleViewModels)
            {
                //Mercaderia
                var mercaderia = context.Mercaderias
                    .Where(o => o.MercaderiaId == inventarioInicialDetalleViewModel.MercaderiaId)
                    .FirstOrDefault();
                //ReglaAlmacenaje
                var reglaAlmacenaje = context.ReglaAlmacenajes
                    .Where(o => o.FamiliaMercaderiaId == mercaderia.FamiliaMercaderiaId)
                    .FirstOrDefault();
                if (reglaAlmacenaje == null)
                    throw new Exception(string.Format("No existe configurado regla de almacenaje para la familia: {0}"
                        , mercaderia.FamiliaMercaderia.Nombre));
                //TipoRecepcion
                var tipoRecepcion = context.TipoRecepcions
                    .Where(o => o.Codigo == "INV")
                    .FirstOrDefault();
                if (tipoRecepcion == null)
                    throw new Exception("No existe configurado tipo Recepcion INV - Inventario Inicial");

                //Se verifica si existe la recepcion
                RecepcionViewModel recepcionViewModel = recepcionViewModels
                    .Where(o => o.AlmacenId == reglaAlmacenaje.AlmacenId)
                    .FirstOrDefault();

                //Recepcion
                var recepcionId = Guid.NewGuid().ToString();
                if (recepcionViewModel == null)
                {
                    //Correlativo
                    var correlativo = AplicacionCommand.GetCorrelativo("RE");

                    recepcionViewModel = new RecepcionViewModel
                    {
                        RecepcionId = recepcionId,
                        Codigo = correlativo,
                        Fecha = inventarioInicialViewModel.Fecha,
                        Observacion = string.Format("Asociado a Inventario inicial: {0}", inventarioInicialViewModel.Codigo),
                        TipoRecepcionId = tipoRecepcion.TipoRecepcionId,
                        AlmacenId = reglaAlmacenaje.AlmacenId,
                        InventarioInicialId = inventarioInicialViewModel.InventarioInicialId,
                        AjusteInventarioId = string.Empty,
                        OrdenProduccionId = string.Empty,
                        CompraId = string.Empty
                    };
                    recepcionViewModels.Add(recepcionViewModel);
                    InsertRecepcion(recepcionViewModel, context);
                }
                else
                {
                    recepcionId = recepcionViewModel.RecepcionId;
                    //
                    recepcionViewModel.Fecha = inventarioInicialViewModel.Fecha;
                    recepcionViewModel.Observacion = string.Format("Asociado a Inventario inicial: {0}", inventarioInicialViewModel.Codigo);
                    recepcionViewModel.TipoRecepcionId = tipoRecepcion.TipoRecepcionId;
                    recepcionViewModel.AlmacenId = reglaAlmacenaje.AlmacenId;
                    recepcionViewModel.InventarioInicialId = inventarioInicialViewModel.InventarioInicialId;
                    recepcionViewModel.AjusteInventarioId = string.Empty;
                    recepcionViewModel.OrdenProduccionId = string.Empty;
                    recepcionViewModel.CompraId = string.Empty;

                    UpdateRecepcion(recepcionViewModel, context);
                }
                //Se busca si ya tiene asociado algun detalle
                //RecepcionDetalle
                RecepcionDetalleViewModel recepcionDetalleViewModel = recepcionViewModel.RecepcionDetalleViewModels
                    .Where(o => o.InventarioInicialDetalleId == inventarioInicialDetalleViewModel.InventarioInicialDetalleId)
                    .FirstOrDefault();
                var recepcionDetalleId = Guid.NewGuid().ToString();
                if (recepcionDetalleViewModel == null)
                {
                    recepcionDetalleViewModel = new RecepcionDetalleViewModel
                    {
                        RecepcionDetalleId = recepcionDetalleId,
                        Cantidad = inventarioInicialDetalleViewModel.Cantidad,
                        RecepcionId = recepcionId,
                        MercaderiaId = inventarioInicialDetalleViewModel.MercaderiaId,
                        UnidadMedidaId = inventarioInicialDetalleViewModel.UnidadMedidaId,
                        InventarioInicialDetalleId = inventarioInicialDetalleViewModel.InventarioInicialDetalleId,
                        AjusteInventarioDetalleId = string.Empty,
                        OrdenProduccionInsumoId = string.Empty,
                        CompraDetalleId = string.Empty
                    };
                    recepcionViewModel.RecepcionDetalleViewModels.Add(recepcionDetalleViewModel);
                    InsertRecepcionDetalle(recepcionDetalleViewModel, context);
                }
                else
                {
                    recepcionDetalleId = recepcionDetalleViewModel.RecepcionDetalleId;
                    //
                    recepcionDetalleViewModel.RecepcionDetalleId = recepcionDetalleId;
                    recepcionDetalleViewModel.Cantidad = inventarioInicialDetalleViewModel.Cantidad;
                    recepcionDetalleViewModel.RecepcionId = recepcionId;
                    recepcionDetalleViewModel.MercaderiaId = inventarioInicialDetalleViewModel.MercaderiaId;
                    recepcionDetalleViewModel.UnidadMedidaId = inventarioInicialDetalleViewModel.UnidadMedidaId;
                    recepcionDetalleViewModel.InventarioInicialDetalleId = inventarioInicialDetalleViewModel.InventarioInicialDetalleId;
                    recepcionDetalleViewModel.AjusteInventarioDetalleId = string.Empty;
                    recepcionDetalleViewModel.OrdenProduccionInsumoId = string.Empty;
                    recepcionDetalleViewModel.CompraDetalleId = string.Empty;

                    UpdateRecepcionDetalle(recepcionDetalleViewModel, context);
                }
            }

            //Se generan los movimientos asociados
            foreach (var recepcionViewModel in recepcionViewModels)
            {
                GenerarMovimientoIngreso(recepcionViewModel, context);
            }
        }

        public static void GenerarRecepcion(AjusteInventarioViewModel ajusteInventarioViewModel, ApplicationDbContext context)
        {
            List<RecepcionViewModel> recepcionViewModels = new List<RecepcionViewModel>();

            //Se verifica si existen recepciones asociadas
            var recepcions = context.Recepcions
                .Where(o => o.AjusteInventarioId == ajusteInventarioViewModel.AjusteInventarioId)
                .ToList();
            //Se carga las recepciones al listado
            foreach (var recepcion in recepcions)
            {
                recepcionViewModels.Add(new RecepcionViewModel(recepcion));
            }

            foreach (var ajusteInventarioDetalleViewModel in ajusteInventarioViewModel.AjusteInventarioDetalleViewModels)
            {
                //Mercaderia
                var mercaderia = context.Mercaderias
                    .Where(o => o.MercaderiaId == ajusteInventarioDetalleViewModel.MercaderiaId)
                    .FirstOrDefault();
                //ReglaAlmacenaje
                var reglaAlmacenaje = context.ReglaAlmacenajes
                    .Where(o => o.FamiliaMercaderiaId == mercaderia.FamiliaMercaderiaId)
                    .FirstOrDefault();
                if (reglaAlmacenaje == null)
                    throw new Exception(string.Format("No existe configurado regla de almacenaje para la familia: {0}"
                        , mercaderia.FamiliaMercaderia.Nombre));
                //TipoRecepcion
                var tipoRecepcion = context.TipoRecepcions
                    .Where(o => o.Codigo == "AJT")
                    .FirstOrDefault();
                if (tipoRecepcion == null)
                    throw new Exception("No existe configurado tipo Recepcion AJT - Ajuste de Inventario");

                //Se verifica si existe la recepcion
                RecepcionViewModel recepcionViewModel = recepcionViewModels
                    .Where(o => o.AlmacenId == reglaAlmacenaje.AlmacenId)
                    .FirstOrDefault();

                //Recepcion
                var recepcionId = Guid.NewGuid().ToString();
                if (recepcionViewModel == null)
                {
                    //Correlativo
                    var correlativo = AplicacionCommand.GetCorrelativo("RE");

                    recepcionViewModel = new RecepcionViewModel
                    {
                        RecepcionId = recepcionId,
                        Codigo = correlativo,
                        Fecha = ajusteInventarioViewModel.Fecha,
                        Observacion = string.Format("Asociado a ajuste de inventario: {0}", ajusteInventarioViewModel.Codigo),
                        TipoRecepcionId = tipoRecepcion.TipoRecepcionId,
                        AlmacenId = reglaAlmacenaje.AlmacenId,
                        InventarioInicialId = string.Empty,
                        AjusteInventarioId = ajusteInventarioViewModel.AjusteInventarioId,
                        OrdenProduccionId = string.Empty,
                        CompraId = string.Empty
                    };
                    recepcionViewModels.Add(recepcionViewModel);
                    InsertRecepcion(recepcionViewModel, context);
                }
                else
                {
                    recepcionId = recepcionViewModel.RecepcionId;
                    //
                    recepcionViewModel.Fecha = ajusteInventarioViewModel.Fecha;
                    recepcionViewModel.Observacion = string.Format("Asociado a ajuste de inventario: {0}", ajusteInventarioViewModel.Codigo);
                    recepcionViewModel.TipoRecepcionId = tipoRecepcion.TipoRecepcionId;
                    recepcionViewModel.AlmacenId = reglaAlmacenaje.AlmacenId;
                    recepcionViewModel.InventarioInicialId = string.Empty;
                    recepcionViewModel.AjusteInventarioId = ajusteInventarioViewModel.AjusteInventarioId;
                    recepcionViewModel.OrdenProduccionId = string.Empty;
                    recepcionViewModel.CompraId = string.Empty;

                    UpdateRecepcion(recepcionViewModel, context);
                }
                //Se busca si ya tiene asociado algun detalle
                //RecepcionDetalle
                RecepcionDetalleViewModel recepcionDetalleViewModel = recepcionViewModel.RecepcionDetalleViewModels
                    .Where(o => o.AjusteInventarioDetalleId == ajusteInventarioDetalleViewModel.AjusteInventarioDetalleId)
                    .FirstOrDefault();
                var recepcionDetalleId = Guid.NewGuid().ToString();
                if (recepcionDetalleViewModel == null)
                {
                    recepcionDetalleViewModel = new RecepcionDetalleViewModel
                    {
                        RecepcionDetalleId = recepcionDetalleId,
                        Cantidad = ajusteInventarioDetalleViewModel.Cantidad,
                        RecepcionId = recepcionId,
                        MercaderiaId = ajusteInventarioDetalleViewModel.MercaderiaId,
                        UnidadMedidaId = ajusteInventarioDetalleViewModel.UnidadMedidaId,
                        InventarioInicialDetalleId = string.Empty,
                        AjusteInventarioDetalleId = ajusteInventarioDetalleViewModel.AjusteInventarioDetalleId,
                        OrdenProduccionInsumoId = string.Empty,
                        CompraDetalleId = string.Empty
                    };
                    recepcionViewModel.RecepcionDetalleViewModels.Add(recepcionDetalleViewModel);
                    InsertRecepcionDetalle(recepcionDetalleViewModel, context);
                }
                else
                {
                    recepcionDetalleId = recepcionDetalleViewModel.RecepcionDetalleId;
                    //
                    recepcionDetalleViewModel.RecepcionDetalleId = recepcionDetalleId;
                    recepcionDetalleViewModel.Cantidad = ajusteInventarioDetalleViewModel.Cantidad;
                    recepcionDetalleViewModel.RecepcionId = recepcionId;
                    recepcionDetalleViewModel.MercaderiaId = ajusteInventarioDetalleViewModel.MercaderiaId;
                    recepcionDetalleViewModel.UnidadMedidaId = ajusteInventarioDetalleViewModel.UnidadMedidaId;
                    recepcionDetalleViewModel.InventarioInicialDetalleId = string.Empty;
                    recepcionDetalleViewModel.AjusteInventarioDetalleId = ajusteInventarioDetalleViewModel.AjusteInventarioDetalleId;
                    recepcionDetalleViewModel.OrdenProduccionInsumoId = string.Empty;
                    recepcionDetalleViewModel.CompraDetalleId = string.Empty;

                    UpdateRecepcionDetalle(recepcionDetalleViewModel, context);
                }
            }

            //Se generan los movimientos asociados
            foreach (var recepcionViewModel in recepcionViewModels)
            {
                GenerarMovimientoIngreso(recepcionViewModel, context);
            }
        }

        public static void GenerarDespacho(OrdenProduccionViewModel ordenProduccionViewModel, ApplicationDbContext context)
        {
            List<DespachoViewModel> despachoViewModels = new List<DespachoViewModel>();
            //Se verifica si existe la despacho
            var despachos = context.Despachos
                .Where(o => o.OrdenProduccionId == ordenProduccionViewModel.OrdenProduccionId)
                .ToList();

            foreach (var despacho in despachos)
            {
                despachoViewModels.Add(new DespachoViewModel(despacho));
            }

            foreach (var ordenProduccionInsumoViewModel in ordenProduccionViewModel.OrdenProduccionInsumoViewModels)
            {
                //Mercaderia
                var mercaderia = context.Mercaderias
                    .Where(o => o.MercaderiaId == ordenProduccionInsumoViewModel.MercaderiaId)
                    .FirstOrDefault();
                //ReglaAlmacenaje
                var reglaAlmacenaje = context.ReglaAlmacenajes
                    .Where(o => o.FamiliaMercaderiaId == mercaderia.FamiliaMercaderiaId)
                    .FirstOrDefault();
                //TipoDespacho
                var tipoDespacho = context.TipoDespachos
                    .Where(o => o.Codigo == "OP")
                    .FirstOrDefault();
                if (tipoDespacho == null)
                    throw new Exception("No existe configurado tipo Despacho OP - OrdenProduccion");

                //Se verifica si existe la despacho
                var despachoViewModel = despachoViewModels
                    .Where(o => o.AlmacenId == reglaAlmacenaje.AlmacenId)
                    .FirstOrDefault();

                //Despacho
                var despachoId = Guid.NewGuid().ToString();
                if (despachoViewModel == null)
                {
                    //Correlativo
                    var correlativo = AplicacionCommand.GetCorrelativo("DE");

                    despachoViewModel = new DespachoViewModel
                    {
                        DespachoId = despachoId,
                        Codigo = correlativo,
                        Fecha = ordenProduccionViewModel.Fecha,
                        Observacion = string.Format("Asociado a ordenProduccion: {0}", ordenProduccionViewModel.Codigo),
                        TipoDespachoId = tipoDespacho.TipoDespachoId,
                        AlmacenId = reglaAlmacenaje.AlmacenId,
                        OrdenProduccionId = ordenProduccionViewModel.OrdenProduccionId,
                        VentaId = string.Empty
                    };
                    despachoViewModels.Add(despachoViewModel);

                    InsertDespacho(despachoViewModel, context);
                }
                else
                {
                    despachoId = despachoViewModel.DespachoId;

                    despachoViewModel.Fecha = ordenProduccionViewModel.Fecha;
                    despachoViewModel.Observacion = string.Format("Asociado a ordenProduccion: {0}", ordenProduccionViewModel.Codigo);
                    despachoViewModel.TipoDespachoId = tipoDespacho.TipoDespachoId;
                    despachoViewModel.AlmacenId = reglaAlmacenaje.AlmacenId;
                    despachoViewModel.OrdenProduccionId = ordenProduccionViewModel.OrdenProduccionId;
                    despachoViewModel.VentaId = string.Empty;

                    UpdateDespacho(despachoViewModel, context);
                }
                //Se busca si ya tiene asociado algun detalle
                //DespachoDetalle
                var despachoDetalleViewModel = despachoViewModel.DespachoDetalleViewModels
                    .Where(o => o.OrdenProduccionInsumoId == ordenProduccionInsumoViewModel.OrdenProduccionInsumoId)
                    .FirstOrDefault();
                var despachoDetalleId = Guid.NewGuid().ToString();
                if (despachoDetalleViewModel == null)
                {
                    despachoDetalleViewModel = new DespachoDetalleViewModel
                    {
                        DespachoDetalleId = despachoDetalleId,
                        Cantidad = ordenProduccionInsumoViewModel.Cantidad,
                        DespachoId = despachoId,
                        MercaderiaId = ordenProduccionInsumoViewModel.MercaderiaId,
                        UnidadMedidaId = ordenProduccionInsumoViewModel.UnidadMedidaId,
                        OrdenProduccionInsumoId = ordenProduccionInsumoViewModel.OrdenProduccionInsumoId,
                        VentaDetalleId = string.Empty
                    };
                    despachoViewModel.DespachoDetalleViewModels.Add(despachoDetalleViewModel);

                    InsertDespachoDetalle(despachoDetalleViewModel, context);
                }
                else
                {
                    despachoDetalleId = despachoDetalleViewModel.DespachoDetalleId;

                    despachoDetalleViewModel.Cantidad = ordenProduccionInsumoViewModel.Cantidad;
                    despachoDetalleViewModel.DespachoId = despachoId;
                    despachoDetalleViewModel.MercaderiaId = ordenProduccionInsumoViewModel.MercaderiaId;
                    despachoDetalleViewModel.UnidadMedidaId = ordenProduccionInsumoViewModel.UnidadMedidaId;
                    despachoDetalleViewModel.OrdenProduccionInsumoId = ordenProduccionInsumoViewModel.OrdenProduccionInsumoId;
                    despachoDetalleViewModel.VentaDetalleId = string.Empty;

                    UpdateDespachoDetalle(despachoDetalleViewModel, context);
                }
            }

            //Se generan los movimientos asociados
            foreach (var despachoViewModel in despachoViewModels)
            {
                GenerarMovimientoSalida(despachoViewModel, context);
            }
        }

        public static void GenerarDespacho(VentaViewModel ventaViewModel, ApplicationDbContext context)
        {
            List<DespachoViewModel> despachoViewModels = new List<DespachoViewModel>();

            //Se verifica si existe la despacho
            var despachos = context.Despachos
                .Where(o => o.VentaId == ventaViewModel.VentaId)
                .ToList();

            foreach (var despacho in despachos)
            {
                despachoViewModels.Add(new DespachoViewModel(despacho));
            }

            foreach (var ventaDetalleViewModel in ventaViewModel.VentaDetalleViewModels)
            {
                //Mercaderia
                var mercaderia = context.Mercaderias
                    .Where(o => o.MercaderiaId == ventaDetalleViewModel.MercaderiaId)
                    .FirstOrDefault();
                //ReglaAlmacenaje
                var reglaAlmacenaje = context.ReglaAlmacenajes
                    .Where(o => o.FamiliaMercaderiaId == mercaderia.FamiliaMercaderiaId)
                    .FirstOrDefault();
                //TipoDespacho
                var tipoDespacho = context.TipoDespachos
                    .Where(o => o.Codigo == "VE")
                    .FirstOrDefault();
                if (tipoDespacho == null)
                    throw new Exception("No existe configurado tipo Despacho CO - Venta");

                //Se verifica si existe la despacho
                var despachoViewModel = despachoViewModels
                    .Where(o => o.AlmacenId == reglaAlmacenaje.AlmacenId)
                    .FirstOrDefault();

                //Despacho
                var despachoId = Guid.NewGuid().ToString();
                if (despachoViewModel == null)
                {
                    //Correlativo
                    var correlativo = AplicacionCommand.GetCorrelativo("DE");

                    despachoViewModel = new DespachoViewModel
                    {
                        DespachoId = despachoId,
                        Codigo = correlativo,
                        Fecha = ventaViewModel.Fecha,
                        Observacion = string.Format("Asociado a venta: {0}", ventaViewModel.NumeroDocumento),
                        TipoDespachoId = tipoDespacho.TipoDespachoId,
                        AlmacenId = reglaAlmacenaje.AlmacenId,
                        OrdenProduccionId = string.Empty,
                        VentaId = ventaViewModel.VentaId
                    };
                    despachoViewModels.Add(despachoViewModel);

                    InsertDespacho(despachoViewModel, context);
                }
                else
                {
                    despachoId = despachoViewModel.DespachoId;

                    despachoViewModel.Fecha = ventaViewModel.Fecha;
                    despachoViewModel.Observacion = string.Format("Asociado a venta: {0}", ventaViewModel.NumeroDocumento);
                    despachoViewModel.TipoDespachoId = tipoDespacho.TipoDespachoId;
                    despachoViewModel.AlmacenId = reglaAlmacenaje.AlmacenId;
                    despachoViewModel.OrdenProduccionId = string.Empty;
                    despachoViewModel.VentaId = ventaViewModel.VentaId;

                    UpdateDespacho(despachoViewModel, context);
                }
                //Se busca si ya tiene asociado algun detalle
                //DespachoDetalle
                var despachoDetalleViewModel = despachoViewModel.DespachoDetalleViewModels
                    .Where(o => o.VentaDetalleId == ventaDetalleViewModel.VentaDetalleId)
                    .FirstOrDefault();
                var despachoDetalleId = Guid.NewGuid().ToString();
                if (despachoDetalleViewModel == null)
                {
                    despachoDetalleViewModel = new DespachoDetalleViewModel
                    {
                        DespachoDetalleId = despachoDetalleId,
                        Cantidad = ventaDetalleViewModel.Cantidad,
                        DespachoId = despachoId,
                        MercaderiaId = ventaDetalleViewModel.MercaderiaId,
                        UnidadMedidaId = ventaDetalleViewModel.UnidadMedidaId,
                        OrdenProduccionInsumoId = string.Empty,
                        VentaDetalleId = ventaDetalleViewModel.VentaDetalleId
                    };
                    despachoViewModel.DespachoDetalleViewModels.Add(despachoDetalleViewModel);

                    InsertDespachoDetalle(despachoDetalleViewModel, context);
                }
                else
                {
                    despachoDetalleId = despachoDetalleViewModel.DespachoDetalleId;

                    despachoDetalleViewModel.Cantidad = ventaDetalleViewModel.Cantidad;
                    despachoDetalleViewModel.DespachoId = despachoId;
                    despachoDetalleViewModel.MercaderiaId = ventaDetalleViewModel.MercaderiaId;
                    despachoDetalleViewModel.UnidadMedidaId = ventaDetalleViewModel.UnidadMedidaId;
                    despachoDetalleViewModel.OrdenProduccionInsumoId = string.Empty;
                    despachoDetalleViewModel.VentaDetalleId = ventaDetalleViewModel.VentaDetalleId;

                    UpdateDespachoDetalle(despachoDetalleViewModel, context);
                }
            }

            //Se generan los movimientos asociados
            foreach (var despachoViewModel in despachoViewModels)
            {
                GenerarMovimientoSalida(despachoViewModel, context);
            }
        }

        public static void GenerarDespacho(AjusteInventarioViewModel ajusteInventarioViewModel, ApplicationDbContext context)
        {
            List<DespachoViewModel> despachoViewModels = new List<DespachoViewModel>();

            //Se verifica si existe la despacho
            var despachos = context.Despachos
                .Where(o => o.AjusteInventarioId == ajusteInventarioViewModel.AjusteInventarioId)
                .ToList();

            foreach (var despacho in despachos)
            {
                despachoViewModels.Add(new DespachoViewModel(despacho));
            }

            foreach (var ajusteInventarioDetalleViewModel in ajusteInventarioViewModel.AjusteInventarioDetalleViewModels)
            {
                //Mercaderia
                var mercaderia = context.Mercaderias
                    .Where(o => o.MercaderiaId == ajusteInventarioDetalleViewModel.MercaderiaId)
                    .FirstOrDefault();
                //ReglaAlmacenaje
                var reglaAlmacenaje = context.ReglaAlmacenajes
                    .Where(o => o.FamiliaMercaderiaId == mercaderia.FamiliaMercaderiaId)
                    .FirstOrDefault();
                //TipoDespacho
                var tipoDespacho = context.TipoDespachos
                    .Where(o => o.Codigo == "AJT")
                    .FirstOrDefault();
                if (tipoDespacho == null)
                    throw new Exception("No existe configurado tipo Despacho AJT - Ajuste de Inventario");

                //Se verifica si existe la despacho
                var despachoViewModel = despachoViewModels
                    .Where(o => o.AlmacenId == reglaAlmacenaje.AlmacenId)
                    .FirstOrDefault();

                //Despacho
                var despachoId = Guid.NewGuid().ToString();
                if (despachoViewModel == null)
                {
                    //Correlativo
                    var correlativo = AplicacionCommand.GetCorrelativo("DE");

                    despachoViewModel = new DespachoViewModel
                    {
                        DespachoId = despachoId,
                        Codigo = correlativo,
                        Fecha = ajusteInventarioViewModel.Fecha,
                        Observacion = string.Format("Asociado a ajuste de inventario: {0}", ajusteInventarioViewModel.Codigo),
                        TipoDespachoId = tipoDespacho.TipoDespachoId,
                        AlmacenId = reglaAlmacenaje.AlmacenId,
                        AjusteInventarioId = ajusteInventarioViewModel.AjusteInventarioId,
                        OrdenProduccionId = string.Empty,
                        VentaId = string.Empty
                    };
                    despachoViewModels.Add(despachoViewModel);

                    InsertDespacho(despachoViewModel, context);
                }
                else
                {
                    despachoId = despachoViewModel.DespachoId;

                    despachoViewModel.Fecha = ajusteInventarioViewModel.Fecha;
                    despachoViewModel.Observacion = string.Format("Asociado a ajuste de inventario: {0}", ajusteInventarioViewModel.Codigo);
                    despachoViewModel.TipoDespachoId = tipoDespacho.TipoDespachoId;
                    despachoViewModel.AlmacenId = reglaAlmacenaje.AlmacenId;
                    despachoViewModel.AjusteInventarioId = ajusteInventarioViewModel.AjusteInventarioId;
                    despachoViewModel.OrdenProduccionId = string.Empty;
                    despachoViewModel.VentaId = string.Empty;

                    UpdateDespacho(despachoViewModel, context);
                }
                //Se busca si ya tiene asociado algun detalle
                //DespachoDetalle
                var despachoDetalleViewModel = despachoViewModel.DespachoDetalleViewModels
                    .Where(o => o.AjusteInventarioDetalleId == ajusteInventarioDetalleViewModel.AjusteInventarioDetalleId)
                    .FirstOrDefault();
                var despachoDetalleId = Guid.NewGuid().ToString();
                if (despachoDetalleViewModel == null)
                {
                    despachoDetalleViewModel = new DespachoDetalleViewModel
                    {
                        DespachoDetalleId = despachoDetalleId,
                        Cantidad = ajusteInventarioDetalleViewModel.Cantidad,
                        DespachoId = despachoId,
                        MercaderiaId = ajusteInventarioDetalleViewModel.MercaderiaId,
                        UnidadMedidaId = ajusteInventarioDetalleViewModel.UnidadMedidaId,
                        AjusteInventarioDetalleId = ajusteInventarioDetalleViewModel.AjusteInventarioDetalleId,
                        OrdenProduccionInsumoId = string.Empty,
                        VentaDetalleId = string.Empty
                    };
                    despachoViewModel.DespachoDetalleViewModels.Add(despachoDetalleViewModel);

                    InsertDespachoDetalle(despachoDetalleViewModel, context);
                }
                else
                {
                    despachoDetalleId = despachoDetalleViewModel.DespachoDetalleId;

                    despachoDetalleViewModel.Cantidad = ajusteInventarioDetalleViewModel.Cantidad;
                    despachoDetalleViewModel.DespachoId = despachoId;
                    despachoDetalleViewModel.MercaderiaId = ajusteInventarioDetalleViewModel.MercaderiaId;
                    despachoDetalleViewModel.UnidadMedidaId = ajusteInventarioDetalleViewModel.UnidadMedidaId;
                    despachoDetalleViewModel.AjusteInventarioDetalleId = ajusteInventarioDetalleViewModel.AjusteInventarioDetalleId;
                    despachoDetalleViewModel.OrdenProduccionInsumoId = string.Empty;
                    despachoDetalleViewModel.VentaDetalleId = string.Empty;

                    UpdateDespachoDetalle(despachoDetalleViewModel, context);
                }
            }

            //Se generan los movimientos asociados
            foreach (var despachoViewModel in despachoViewModels)
            {
                GenerarMovimientoSalida(despachoViewModel, context);
            }
        }

        public static void GenerarMovimientoIngreso(RecepcionViewModel recepcionViewModel, ApplicationDbContext context)
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
                            new SqlParameter("@CantidadSalida", value: 0),
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
                Kardex kardex = ordenServicio?.Kardexs
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
                            new SqlParameter("@CantidadSalida", value: 0),
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
                            new SqlParameter("@Fecha", recepcionViewModel.Fecha),
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
                            new SqlParameter("@Fecha", recepcionViewModel.Fecha),
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
                    var mercaderia = context.Mercaderias.FirstOrDefault(o => o.MercaderiaId == despachoDetalleViewModel.MercaderiaId);
                    throw new Exception(string.Format("Saldo negativo en orden de servicio, mercaderia: {0}"
                        , mercaderia.Nombre));

                    //context.Database.ExecuteSqlCommand(
                    //    SqlResource.OrdenServicio_Insert,
                    //        new SqlParameter("@OrdenServicioId", ordenServicioId),
                    //        new SqlParameter("@CantidadSaldo", -despachoDetalleViewModel.Cantidad),
                    //        new SqlParameter("@CantidadEntrada", value: 0),
                    //        new SqlParameter("@CantidadSalida", despachoDetalleViewModel.Cantidad),
                    //        new SqlParameter("@MercaderiaId", despachoDetalleViewModel.MercaderiaId),
                    //        new SqlParameter("@UsuarioCreacion", DBNull.Value),
                    //        new SqlParameter("@FechaCreacion", DateTime.Now),
                    //        new SqlParameter("@Eliminado", false)
                    //);
                }
                else
                {
                    ordenServicioId = ordenServicio.OrdenServicioId;
                    var cantidadSaldo = ordenServicio.CantidadSaldo - despachoDetalleViewModel.Cantidad + cantidadAnterior;
                    var cantidadEntrada = ordenServicio.CantidadEntrada;
                    var cantidadSalida = ordenServicio.CantidadSalida + despachoDetalleViewModel.Cantidad - cantidadAnterior;

                    if (cantidadSaldo < 0)
                    {
                        var mercaderia = context.Mercaderias.FirstOrDefault(o => o.MercaderiaId == despachoDetalleViewModel.MercaderiaId);
                        throw new Exception(string.Format("Saldo negativo en orden de servicio, mercaderia: {0}"
                            , mercaderia.Nombre));
                    }

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
                Kardex kardex = ordenServicio?.Kardexs
                    .Where(o => o.AlmacenId == despachoViewModel.AlmacenId)
                    .FirstOrDefault();
                var kardexId = Guid.NewGuid().ToString();
                if (kardex == null)
                {
                    var mercaderia = context.Mercaderias.FirstOrDefault(o => o.MercaderiaId == despachoDetalleViewModel.MercaderiaId);
                    var almacen = context.Almacens.FirstOrDefault(o => o.AlmacenId == despachoViewModel.AlmacenId);

                    throw new Exception(string.Format("Saldo negativo en kardex, mercaderia: {0}, almacen: {1}"
                        , mercaderia.Nombre
                        , almacen.Nombre));

                    //context.Database.ExecuteSqlCommand(
                    //    SqlResource.Kardex_Insert,
                    //        new SqlParameter("@KardexId", kardexId),
                    //        new SqlParameter("@CantidadSaldo", -despachoDetalleViewModel.Cantidad),
                    //        new SqlParameter("@CantidadEntrada", value: 0),
                    //        new SqlParameter("@CantidadSalida", despachoDetalleViewModel.Cantidad),
                    //        new SqlParameter("@OrdenServicioId", ordenServicioId),
                    //        new SqlParameter("@AlmacenId", despachoViewModel.AlmacenId),
                    //        new SqlParameter("@UsuarioCreacion", DBNull.Value),
                    //        new SqlParameter("@FechaCreacion", DateTime.Now),
                    //        new SqlParameter("@Eliminado", false)
                    //);
                }
                else
                {
                    kardexId = kardex.KardexId;
                    var cantidadSaldo = kardex.CantidadSaldo - despachoDetalleViewModel.Cantidad + cantidadAnterior;
                    var cantidadEntrada = kardex.CantidadEntrada;
                    var cantidadSalida = kardex.CantidadSalida + despachoDetalleViewModel.Cantidad - cantidadAnterior;
                    if (cantidadSaldo < 0)
                    {
                        var mercaderia = context.Mercaderias.FirstOrDefault(o => o.MercaderiaId == despachoDetalleViewModel.MercaderiaId);
                        var almacen = context.Almacens.FirstOrDefault(o => o.AlmacenId == despachoViewModel.AlmacenId);

                        throw new Exception(string.Format("Saldo negativo en kardex, mercaderia: {0}, almacen: {1}"
                            , mercaderia.Nombre
                            , almacen.Nombre));
                    }
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
                            new SqlParameter("@Fecha", despachoViewModel.Fecha),
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
                            new SqlParameter("@Fecha", despachoViewModel.Fecha),
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
