namespace AdmCostoProduccion.Common.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Almacens",
                c => new
                    {
                        AlmacenId = c.Int(nullable: false, identity: true),
                        Codigo = c.String(),
                        Nombre = c.String(),
                        Descripcion = c.String(),
                        CentroLogisticoId = c.Int(nullable: false),
                        UsuarioCreacion = c.String(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioUltimaActualizacion = c.String(),
                        FechaUltimaActualizacion = c.DateTime(),
                        Eliminado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.AlmacenId)
                .ForeignKey("dbo.CentroLogisticoes", t => t.CentroLogisticoId)
                .Index(t => t.CentroLogisticoId);
            
            CreateTable(
                "dbo.CentroLogisticoes",
                c => new
                    {
                        CentroLogisticoId = c.Int(nullable: false, identity: true),
                        Codigo = c.String(),
                        Nombre = c.String(),
                        Descripcion = c.String(),
                        UsuarioCreacion = c.String(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioUltimaActualizacion = c.String(),
                        FechaUltimaActualizacion = c.DateTime(),
                        Eliminado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CentroLogisticoId);
            
            CreateTable(
                "dbo.PlantaFabricacions",
                c => new
                    {
                        PlantaFabricacionId = c.Int(nullable: false, identity: true),
                        Codigo = c.String(),
                        Nombre = c.String(),
                        Descripcion = c.String(),
                        CentroLogisticoId = c.Int(nullable: false),
                        UsuarioCreacion = c.String(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioUltimaActualizacion = c.String(),
                        FechaUltimaActualizacion = c.DateTime(),
                        Eliminado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.PlantaFabricacionId)
                .ForeignKey("dbo.CentroLogisticoes", t => t.CentroLogisticoId)
                .Index(t => t.CentroLogisticoId);
            
            CreateTable(
                "dbo.OrdenProduccions",
                c => new
                    {
                        OrdenProduccionId = c.Int(nullable: false, identity: true),
                        Codigo = c.String(),
                        Descripcion = c.String(),
                        Fecha = c.DateTime(nullable: false),
                        Cantidad = c.Double(nullable: false),
                        Lote = c.String(),
                        PlantaFabricacionId = c.Int(nullable: false),
                        MercaderiaId = c.Int(nullable: false),
                        ProcedimientoProduccionId = c.Int(nullable: false),
                        UnidadMedidaId = c.Int(nullable: false),
                        UsuarioCreacion = c.String(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioUltimaActualizacion = c.String(),
                        FechaUltimaActualizacion = c.DateTime(),
                        Eliminado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.OrdenProduccionId)
                .ForeignKey("dbo.UnidadMedidas", t => t.UnidadMedidaId)
                .ForeignKey("dbo.ProcedimientoProduccions", t => t.ProcedimientoProduccionId)
                .ForeignKey("dbo.Mercaderias", t => t.MercaderiaId)
                .ForeignKey("dbo.PlantaFabricacions", t => t.PlantaFabricacionId)
                .Index(t => t.PlantaFabricacionId)
                .Index(t => t.MercaderiaId)
                .Index(t => t.ProcedimientoProduccionId)
                .Index(t => t.UnidadMedidaId);
            
            CreateTable(
                "dbo.CostoOrdenProduccions",
                c => new
                    {
                        CostoOrdenProduccionId = c.Int(nullable: false, identity: true),
                        FactorDistribucion = c.Double(nullable: false),
                        CostoMp = c.Double(nullable: false),
                        CostoMod = c.Double(nullable: false),
                        CostoCif = c.Double(nullable: false),
                        CostoProduccionId = c.Int(nullable: false),
                        OrdenProduccionId = c.Int(nullable: false),
                        KardexMovimientoId = c.Int(nullable: false),
                        UsuarioCreacion = c.String(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioUltimaActualizacion = c.String(),
                        FechaUltimaActualizacion = c.DateTime(),
                        Eliminado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CostoOrdenProduccionId)
                .ForeignKey("dbo.CostoProduccions", t => t.CostoProduccionId)
                .ForeignKey("dbo.KardexMovimientoes", t => t.KardexMovimientoId)
                .ForeignKey("dbo.OrdenProduccions", t => t.OrdenProduccionId)
                .Index(t => t.CostoProduccionId)
                .Index(t => t.OrdenProduccionId)
                .Index(t => t.KardexMovimientoId);
            
            CreateTable(
                "dbo.CostoProduccions",
                c => new
                    {
                        CostoProduccionId = c.Int(nullable: false, identity: true),
                        Codigo = c.String(),
                        Nombre = c.String(),
                        Descripcion = c.String(),
                        FechaInicio = c.DateTime(nullable: false),
                        FechaFin = c.DateTime(nullable: false),
                        CostoMod = c.Double(nullable: false),
                        CostoCif = c.Double(nullable: false),
                        AlmacenId = c.Int(nullable: false),
                        ConfiguracionValorizacionId = c.Int(nullable: false),
                        UsuarioCreacion = c.String(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioUltimaActualizacion = c.String(),
                        FechaUltimaActualizacion = c.DateTime(),
                        Eliminado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CostoProduccionId)
                .ForeignKey("dbo.Almacens", t => t.AlmacenId)
                .ForeignKey("dbo.ConfiguracionValorizacions", t => t.ConfiguracionValorizacionId)
                .Index(t => t.AlmacenId)
                .Index(t => t.ConfiguracionValorizacionId);
            
            CreateTable(
                "dbo.ConfiguracionValorizacions",
                c => new
                    {
                        ConfiguracionValorizacionId = c.Int(nullable: false, identity: true),
                        Codigo = c.String(),
                        Nombre = c.String(),
                        Descripcion = c.String(),
                        MetodoValorizacionId = c.Int(nullable: false),
                        DistribucionValorizacionId = c.Int(nullable: false),
                        UsuarioCreacion = c.String(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioUltimaActualizacion = c.String(),
                        FechaUltimaActualizacion = c.DateTime(),
                        Eliminado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ConfiguracionValorizacionId)
                .ForeignKey("dbo.DistribucionValorizacions", t => t.DistribucionValorizacionId)
                .ForeignKey("dbo.MetodoValorizacions", t => t.MetodoValorizacionId)
                .Index(t => t.MetodoValorizacionId)
                .Index(t => t.DistribucionValorizacionId);
            
            CreateTable(
                "dbo.DistribucionValorizacions",
                c => new
                    {
                        DistribucionValorizacionId = c.Int(nullable: false, identity: true),
                        Codigo = c.String(),
                        Nombre = c.String(),
                        Descripcion = c.String(),
                        UsuarioCreacion = c.String(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioUltimaActualizacion = c.String(),
                        FechaUltimaActualizacion = c.DateTime(),
                        Eliminado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.DistribucionValorizacionId);
            
            CreateTable(
                "dbo.MetodoValorizacions",
                c => new
                    {
                        MetodoValorizacionId = c.Int(nullable: false, identity: true),
                        Codigo = c.String(),
                        Nombre = c.String(),
                        Descripcion = c.String(),
                        UsuarioCreacion = c.String(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioUltimaActualizacion = c.String(),
                        FechaUltimaActualizacion = c.DateTime(),
                        Eliminado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.MetodoValorizacionId);
            
            CreateTable(
                "dbo.KardexMovimientoes",
                c => new
                    {
                        KardexMovimientoId = c.Int(nullable: false, identity: true),
                        Cantidad = c.Double(nullable: false),
                        KardexId = c.Int(nullable: false),
                        TipoMovimientoId = c.Int(nullable: false),
                        RecepcionDetalleId = c.Int(nullable: false),
                        DespachoDetalleId = c.Int(nullable: false),
                        MercaderiaId = c.Int(nullable: false),
                        UnidadMedidaId = c.Int(nullable: false),
                        UsuarioCreacion = c.String(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioUltimaActualizacion = c.String(),
                        FechaUltimaActualizacion = c.DateTime(),
                        Eliminado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.KardexMovimientoId)
                .ForeignKey("dbo.RecepcionDetalles", t => t.RecepcionDetalleId)
                .ForeignKey("dbo.UnidadMedidas", t => t.UnidadMedidaId)
                .ForeignKey("dbo.Mercaderias", t => t.MercaderiaId)
                .ForeignKey("dbo.Kardexes", t => t.KardexId)
                .ForeignKey("dbo.DespachoDetalles", t => t.DespachoDetalleId)
                .ForeignKey("dbo.TipoMovimientoes", t => t.TipoMovimientoId)
                .Index(t => t.KardexId)
                .Index(t => t.TipoMovimientoId)
                .Index(t => t.RecepcionDetalleId)
                .Index(t => t.DespachoDetalleId)
                .Index(t => t.MercaderiaId)
                .Index(t => t.UnidadMedidaId);
            
            CreateTable(
                "dbo.DespachoDetalles",
                c => new
                    {
                        DespachoDetalleId = c.Int(nullable: false, identity: true),
                        Cantidad = c.Double(nullable: false),
                        DespachoId = c.Int(nullable: false),
                        MercaderiaId = c.Int(nullable: false),
                        UnidadMedidaId = c.Int(nullable: false),
                        OrdenProduccionInsumoId = c.Int(),
                        VentaDetalleId = c.Int(),
                        UsuarioCreacion = c.String(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioUltimaActualizacion = c.String(),
                        FechaUltimaActualizacion = c.DateTime(),
                        Eliminado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.DespachoDetalleId)
                .ForeignKey("dbo.Despachoes", t => t.DespachoId)
                .ForeignKey("dbo.VentaDetalles", t => t.VentaDetalleId)
                .ForeignKey("dbo.OrdenProduccionInsumoes", t => t.OrdenProduccionInsumoId)
                .ForeignKey("dbo.UnidadMedidas", t => t.UnidadMedidaId)
                .ForeignKey("dbo.Mercaderias", t => t.MercaderiaId)
                .Index(t => t.DespachoId)
                .Index(t => t.MercaderiaId)
                .Index(t => t.UnidadMedidaId)
                .Index(t => t.OrdenProduccionInsumoId)
                .Index(t => t.VentaDetalleId);
            
            CreateTable(
                "dbo.Despachoes",
                c => new
                    {
                        DespachoId = c.Int(nullable: false, identity: true),
                        Codigo = c.String(),
                        Observacion = c.String(),
                        TipoDespachoId = c.Int(nullable: false),
                        AlmacenId = c.Int(nullable: false),
                        OrdenProduccionId = c.Int(),
                        VentaId = c.Int(),
                        UsuarioCreacion = c.String(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioUltimaActualizacion = c.String(),
                        FechaUltimaActualizacion = c.DateTime(),
                        Eliminado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.DespachoId)
                .ForeignKey("dbo.Almacens", t => t.AlmacenId)
                .ForeignKey("dbo.OrdenProduccions", t => t.OrdenProduccionId)
                .ForeignKey("dbo.TipoDespachoes", t => t.TipoDespachoId)
                .ForeignKey("dbo.Ventas", t => t.VentaId)
                .Index(t => t.TipoDespachoId)
                .Index(t => t.AlmacenId)
                .Index(t => t.OrdenProduccionId)
                .Index(t => t.VentaId);
            
            CreateTable(
                "dbo.TipoDespachoes",
                c => new
                    {
                        TipoDespachoId = c.Int(nullable: false, identity: true),
                        Codigo = c.String(),
                        Nombre = c.String(),
                        Descripcion = c.String(),
                        Proceso = c.String(),
                        UsuarioCreacion = c.String(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioUltimaActualizacion = c.String(),
                        FechaUltimaActualizacion = c.DateTime(),
                        Eliminado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.TipoDespachoId);
            
            CreateTable(
                "dbo.Ventas",
                c => new
                    {
                        VentaId = c.Int(nullable: false, identity: true),
                        NumeroDocumento = c.String(),
                        Fecha = c.DateTime(nullable: false),
                        Descripcion = c.String(),
                        CentroLogisticoId = c.Int(nullable: false),
                        UsuarioCreacion = c.String(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioUltimaActualizacion = c.String(),
                        FechaUltimaActualizacion = c.DateTime(),
                        Eliminado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.VentaId)
                .ForeignKey("dbo.CentroLogisticoes", t => t.CentroLogisticoId)
                .Index(t => t.CentroLogisticoId);
            
            CreateTable(
                "dbo.VentaDetalles",
                c => new
                    {
                        VentaDetalleId = c.Int(nullable: false, identity: true),
                        Cantidad = c.Double(nullable: false),
                        PrecioUnitario = c.Double(nullable: false),
                        VentaId = c.Int(nullable: false),
                        MercaderiaId = c.Int(nullable: false),
                        UsuarioCreacion = c.String(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioUltimaActualizacion = c.String(),
                        FechaUltimaActualizacion = c.DateTime(),
                        Eliminado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.VentaDetalleId)
                .ForeignKey("dbo.Mercaderias", t => t.MercaderiaId)
                .ForeignKey("dbo.Ventas", t => t.VentaId)
                .Index(t => t.VentaId)
                .Index(t => t.MercaderiaId);
            
            CreateTable(
                "dbo.Mercaderias",
                c => new
                    {
                        MercaderiaId = c.Int(nullable: false, identity: true),
                        Codigo = c.String(),
                        Nombre = c.String(),
                        Descripcion = c.String(),
                        TipoMercaderiaId = c.Int(nullable: false),
                        UsuarioCreacion = c.String(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioUltimaActualizacion = c.String(),
                        FechaUltimaActualizacion = c.DateTime(),
                        Eliminado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.MercaderiaId)
                .ForeignKey("dbo.TipoMercaderias", t => t.TipoMercaderiaId)
                .Index(t => t.TipoMercaderiaId);
            
            CreateTable(
                "dbo.CompraDetalles",
                c => new
                    {
                        CompraDetalleId = c.Int(nullable: false, identity: true),
                        Cantidad = c.Double(nullable: false),
                        PrecioUnitario = c.Double(nullable: false),
                        PrecioTotal = c.Double(nullable: false),
                        CompraId = c.Int(nullable: false),
                        MercaderiaId = c.Int(nullable: false),
                        UsuarioCreacion = c.String(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioUltimaActualizacion = c.String(),
                        FechaUltimaActualizacion = c.DateTime(),
                        Eliminado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CompraDetalleId)
                .ForeignKey("dbo.Compras", t => t.CompraId)
                .ForeignKey("dbo.Mercaderias", t => t.MercaderiaId)
                .Index(t => t.CompraId)
                .Index(t => t.MercaderiaId);
            
            CreateTable(
                "dbo.Compras",
                c => new
                    {
                        CompraId = c.Int(nullable: false, identity: true),
                        NumeroDocumento = c.String(),
                        Fecha = c.DateTime(nullable: false),
                        Descripcion = c.String(),
                        CentroLogisticoId = c.Int(nullable: false),
                        UsuarioCreacion = c.String(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioUltimaActualizacion = c.String(),
                        FechaUltimaActualizacion = c.DateTime(),
                        Eliminado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CompraId)
                .ForeignKey("dbo.CentroLogisticoes", t => t.CentroLogisticoId)
                .Index(t => t.CentroLogisticoId);
            
            CreateTable(
                "dbo.Recepcions",
                c => new
                    {
                        RecepcionId = c.Int(nullable: false, identity: true),
                        Codigo = c.String(),
                        Observacion = c.String(),
                        TipoRecepcionId = c.Int(nullable: false),
                        AlmacenId = c.Int(nullable: false),
                        OrdenProduccionId = c.Int(),
                        CompraId = c.Int(),
                        UsuarioCreacion = c.String(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioUltimaActualizacion = c.String(),
                        FechaUltimaActualizacion = c.DateTime(),
                        Eliminado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.RecepcionId)
                .ForeignKey("dbo.Almacens", t => t.AlmacenId)
                .ForeignKey("dbo.Compras", t => t.CompraId)
                .ForeignKey("dbo.OrdenProduccions", t => t.OrdenProduccionId)
                .ForeignKey("dbo.TipoRecepcions", t => t.TipoRecepcionId)
                .Index(t => t.TipoRecepcionId)
                .Index(t => t.AlmacenId)
                .Index(t => t.OrdenProduccionId)
                .Index(t => t.CompraId);
            
            CreateTable(
                "dbo.RecepcionDetalles",
                c => new
                    {
                        RecepcionDetalleId = c.Int(nullable: false, identity: true),
                        Cantidad = c.Double(nullable: false),
                        RecepcionId = c.Int(nullable: false),
                        MercaderiaId = c.Int(nullable: false),
                        UnidadMedidaId = c.Int(nullable: false),
                        OrdenProduccionInsumoId = c.Int(),
                        CompraDetalleId = c.Int(),
                        UsuarioCreacion = c.String(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioUltimaActualizacion = c.String(),
                        FechaUltimaActualizacion = c.DateTime(),
                        Eliminado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.RecepcionDetalleId)
                .ForeignKey("dbo.CompraDetalles", t => t.CompraDetalleId)
                .ForeignKey("dbo.Mercaderias", t => t.MercaderiaId)
                .ForeignKey("dbo.OrdenProduccionInsumoes", t => t.OrdenProduccionInsumoId)
                .ForeignKey("dbo.UnidadMedidas", t => t.UnidadMedidaId)
                .ForeignKey("dbo.Recepcions", t => t.RecepcionId)
                .Index(t => t.RecepcionId)
                .Index(t => t.MercaderiaId)
                .Index(t => t.UnidadMedidaId)
                .Index(t => t.OrdenProduccionInsumoId)
                .Index(t => t.CompraDetalleId);
            
            CreateTable(
                "dbo.OrdenProduccionInsumoes",
                c => new
                    {
                        OrdenProduccionInsumoId = c.Int(nullable: false, identity: true),
                        Cantidad = c.Double(nullable: false),
                        OrdenProduccionId = c.Int(nullable: false),
                        MercaderiaId = c.Int(nullable: false),
                        UnidadMedidaId = c.Int(nullable: false),
                        UsuarioCreacion = c.String(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioUltimaActualizacion = c.String(),
                        FechaUltimaActualizacion = c.DateTime(),
                        Eliminado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.OrdenProduccionInsumoId)
                .ForeignKey("dbo.Mercaderias", t => t.MercaderiaId)
                .ForeignKey("dbo.OrdenProduccions", t => t.OrdenProduccionId)
                .ForeignKey("dbo.UnidadMedidas", t => t.UnidadMedidaId)
                .Index(t => t.OrdenProduccionId)
                .Index(t => t.MercaderiaId)
                .Index(t => t.UnidadMedidaId);
            
            CreateTable(
                "dbo.UnidadMedidas",
                c => new
                    {
                        UnidadMedidaId = c.Int(nullable: false, identity: true),
                        Codigo = c.String(),
                        Nombre = c.String(),
                        Descripcion = c.String(),
                        Simbolo = c.String(),
                        UsuarioCreacion = c.String(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioUltimaActualizacion = c.String(),
                        FechaUltimaActualizacion = c.DateTime(),
                        Eliminado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.UnidadMedidaId);
            
            CreateTable(
                "dbo.ProcedimientoProduccionInsumoes",
                c => new
                    {
                        ProcedimientoProduccionInsumoId = c.Int(nullable: false, identity: true),
                        Cantidad = c.Double(nullable: false),
                        ProcedimientoProduccionId = c.Int(nullable: false),
                        MercaderiaId = c.Int(nullable: false),
                        UnidadMedidaId = c.Int(nullable: false),
                        UsuarioCreacion = c.String(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioUltimaActualizacion = c.String(),
                        FechaUltimaActualizacion = c.DateTime(),
                        Eliminado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ProcedimientoProduccionInsumoId)
                .ForeignKey("dbo.Mercaderias", t => t.MercaderiaId)
                .ForeignKey("dbo.ProcedimientoProduccions", t => t.ProcedimientoProduccionId)
                .ForeignKey("dbo.UnidadMedidas", t => t.UnidadMedidaId)
                .Index(t => t.ProcedimientoProduccionId)
                .Index(t => t.MercaderiaId)
                .Index(t => t.UnidadMedidaId);
            
            CreateTable(
                "dbo.ProcedimientoProduccions",
                c => new
                    {
                        ProcedimientoProduccionId = c.Int(nullable: false, identity: true),
                        Codigo = c.String(),
                        Nombre = c.String(),
                        Descripcion = c.String(),
                        Cantidad = c.Double(nullable: false),
                        MercaderiaId = c.Int(nullable: false),
                        UnidadMedidaId = c.Int(nullable: false),
                        UsuarioCreacion = c.String(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioUltimaActualizacion = c.String(),
                        FechaUltimaActualizacion = c.DateTime(),
                        Eliminado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ProcedimientoProduccionId)
                .ForeignKey("dbo.Mercaderias", t => t.MercaderiaId)
                .ForeignKey("dbo.UnidadMedidas", t => t.UnidadMedidaId)
                .Index(t => t.MercaderiaId)
                .Index(t => t.UnidadMedidaId);
            
            CreateTable(
                "dbo.TipoRecepcions",
                c => new
                    {
                        TipoRecepcionId = c.Int(nullable: false, identity: true),
                        Codigo = c.String(),
                        Nombre = c.String(),
                        Descripcion = c.String(),
                        Proceso = c.String(),
                        UsuarioCreacion = c.String(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioUltimaActualizacion = c.String(),
                        FechaUltimaActualizacion = c.DateTime(),
                        Eliminado = c.Boolean(nullable: false),
                        TipoRecepcion_TipoRecepcionId = c.Int(),
                    })
                .PrimaryKey(t => t.TipoRecepcionId)
                .ForeignKey("dbo.TipoRecepcions", t => t.TipoRecepcion_TipoRecepcionId)
                .Index(t => t.TipoRecepcion_TipoRecepcionId);
            
            CreateTable(
                "dbo.OrdenServicios",
                c => new
                    {
                        OrdenServicioId = c.Int(nullable: false, identity: true),
                        CantidadSaldo = c.Double(nullable: false),
                        CantidadEntrada = c.Double(nullable: false),
                        CantidadSalida = c.Double(nullable: false),
                        MercaderiaId = c.Int(nullable: false),
                        UsuarioCreacion = c.String(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioUltimaActualizacion = c.String(),
                        FechaUltimaActualizacion = c.DateTime(),
                        Eliminado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.OrdenServicioId)
                .ForeignKey("dbo.Mercaderias", t => t.MercaderiaId)
                .Index(t => t.MercaderiaId);
            
            CreateTable(
                "dbo.Kardexes",
                c => new
                    {
                        KardexId = c.Int(nullable: false, identity: true),
                        CantidadSaldo = c.Double(nullable: false),
                        CantidadEntrada = c.Double(nullable: false),
                        CantidadSalida = c.Double(nullable: false),
                        OrdenServicioId = c.Int(nullable: false),
                        AlmacenId = c.Int(nullable: false),
                        UsuarioCreacion = c.String(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioUltimaActualizacion = c.String(),
                        FechaUltimaActualizacion = c.DateTime(),
                        Eliminado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.KardexId)
                .ForeignKey("dbo.Almacens", t => t.AlmacenId)
                .ForeignKey("dbo.OrdenServicios", t => t.OrdenServicioId)
                .Index(t => t.OrdenServicioId)
                .Index(t => t.AlmacenId);
            
            CreateTable(
                "dbo.TipoMercaderias",
                c => new
                    {
                        TipoMercaderiaId = c.Int(nullable: false, identity: true),
                        Codigo = c.String(),
                        Nombre = c.String(),
                        Descripcion = c.String(),
                        UsuarioCreacion = c.String(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioUltimaActualizacion = c.String(),
                        FechaUltimaActualizacion = c.DateTime(),
                        Eliminado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.TipoMercaderiaId);
            
            CreateTable(
                "dbo.TipoMovimientoes",
                c => new
                    {
                        TipoMovimientoId = c.Int(nullable: false, identity: true),
                        Codigo = c.String(),
                        Nombre = c.String(),
                        Descripcion = c.String(),
                        UsuarioCreacion = c.String(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioUltimaActualizacion = c.String(),
                        FechaUltimaActualizacion = c.DateTime(),
                        Eliminado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.TipoMovimientoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrdenProduccions", "PlantaFabricacionId", "dbo.PlantaFabricacions");
            DropForeignKey("dbo.CostoOrdenProduccions", "OrdenProduccionId", "dbo.OrdenProduccions");
            DropForeignKey("dbo.KardexMovimientoes", "TipoMovimientoId", "dbo.TipoMovimientoes");
            DropForeignKey("dbo.DespachoDetalles", "MercaderiaId", "dbo.Mercaderias");
            DropForeignKey("dbo.KardexMovimientoes", "DespachoDetalleId", "dbo.DespachoDetalles");
            DropForeignKey("dbo.VentaDetalles", "VentaId", "dbo.Ventas");
            DropForeignKey("dbo.VentaDetalles", "MercaderiaId", "dbo.Mercaderias");
            DropForeignKey("dbo.Mercaderias", "TipoMercaderiaId", "dbo.TipoMercaderias");
            DropForeignKey("dbo.OrdenServicios", "MercaderiaId", "dbo.Mercaderias");
            DropForeignKey("dbo.Kardexes", "OrdenServicioId", "dbo.OrdenServicios");
            DropForeignKey("dbo.KardexMovimientoes", "KardexId", "dbo.Kardexes");
            DropForeignKey("dbo.Kardexes", "AlmacenId", "dbo.Almacens");
            DropForeignKey("dbo.OrdenProduccions", "MercaderiaId", "dbo.Mercaderias");
            DropForeignKey("dbo.KardexMovimientoes", "MercaderiaId", "dbo.Mercaderias");
            DropForeignKey("dbo.CompraDetalles", "MercaderiaId", "dbo.Mercaderias");
            DropForeignKey("dbo.Recepcions", "TipoRecepcionId", "dbo.TipoRecepcions");
            DropForeignKey("dbo.TipoRecepcions", "TipoRecepcion_TipoRecepcionId", "dbo.TipoRecepcions");
            DropForeignKey("dbo.RecepcionDetalles", "RecepcionId", "dbo.Recepcions");
            DropForeignKey("dbo.RecepcionDetalles", "UnidadMedidaId", "dbo.UnidadMedidas");
            DropForeignKey("dbo.ProcedimientoProduccionInsumoes", "UnidadMedidaId", "dbo.UnidadMedidas");
            DropForeignKey("dbo.ProcedimientoProduccions", "UnidadMedidaId", "dbo.UnidadMedidas");
            DropForeignKey("dbo.ProcedimientoProduccionInsumoes", "ProcedimientoProduccionId", "dbo.ProcedimientoProduccions");
            DropForeignKey("dbo.OrdenProduccions", "ProcedimientoProduccionId", "dbo.ProcedimientoProduccions");
            DropForeignKey("dbo.ProcedimientoProduccions", "MercaderiaId", "dbo.Mercaderias");
            DropForeignKey("dbo.ProcedimientoProduccionInsumoes", "MercaderiaId", "dbo.Mercaderias");
            DropForeignKey("dbo.OrdenProduccions", "UnidadMedidaId", "dbo.UnidadMedidas");
            DropForeignKey("dbo.OrdenProduccionInsumoes", "UnidadMedidaId", "dbo.UnidadMedidas");
            DropForeignKey("dbo.KardexMovimientoes", "UnidadMedidaId", "dbo.UnidadMedidas");
            DropForeignKey("dbo.DespachoDetalles", "UnidadMedidaId", "dbo.UnidadMedidas");
            DropForeignKey("dbo.RecepcionDetalles", "OrdenProduccionInsumoId", "dbo.OrdenProduccionInsumoes");
            DropForeignKey("dbo.OrdenProduccionInsumoes", "OrdenProduccionId", "dbo.OrdenProduccions");
            DropForeignKey("dbo.OrdenProduccionInsumoes", "MercaderiaId", "dbo.Mercaderias");
            DropForeignKey("dbo.DespachoDetalles", "OrdenProduccionInsumoId", "dbo.OrdenProduccionInsumoes");
            DropForeignKey("dbo.RecepcionDetalles", "MercaderiaId", "dbo.Mercaderias");
            DropForeignKey("dbo.KardexMovimientoes", "RecepcionDetalleId", "dbo.RecepcionDetalles");
            DropForeignKey("dbo.RecepcionDetalles", "CompraDetalleId", "dbo.CompraDetalles");
            DropForeignKey("dbo.Recepcions", "OrdenProduccionId", "dbo.OrdenProduccions");
            DropForeignKey("dbo.Recepcions", "CompraId", "dbo.Compras");
            DropForeignKey("dbo.Recepcions", "AlmacenId", "dbo.Almacens");
            DropForeignKey("dbo.CompraDetalles", "CompraId", "dbo.Compras");
            DropForeignKey("dbo.Compras", "CentroLogisticoId", "dbo.CentroLogisticoes");
            DropForeignKey("dbo.DespachoDetalles", "VentaDetalleId", "dbo.VentaDetalles");
            DropForeignKey("dbo.Despachoes", "VentaId", "dbo.Ventas");
            DropForeignKey("dbo.Ventas", "CentroLogisticoId", "dbo.CentroLogisticoes");
            DropForeignKey("dbo.Despachoes", "TipoDespachoId", "dbo.TipoDespachoes");
            DropForeignKey("dbo.Despachoes", "OrdenProduccionId", "dbo.OrdenProduccions");
            DropForeignKey("dbo.DespachoDetalles", "DespachoId", "dbo.Despachoes");
            DropForeignKey("dbo.Despachoes", "AlmacenId", "dbo.Almacens");
            DropForeignKey("dbo.CostoOrdenProduccions", "KardexMovimientoId", "dbo.KardexMovimientoes");
            DropForeignKey("dbo.CostoOrdenProduccions", "CostoProduccionId", "dbo.CostoProduccions");
            DropForeignKey("dbo.ConfiguracionValorizacions", "MetodoValorizacionId", "dbo.MetodoValorizacions");
            DropForeignKey("dbo.ConfiguracionValorizacions", "DistribucionValorizacionId", "dbo.DistribucionValorizacions");
            DropForeignKey("dbo.CostoProduccions", "ConfiguracionValorizacionId", "dbo.ConfiguracionValorizacions");
            DropForeignKey("dbo.CostoProduccions", "AlmacenId", "dbo.Almacens");
            DropForeignKey("dbo.PlantaFabricacions", "CentroLogisticoId", "dbo.CentroLogisticoes");
            DropForeignKey("dbo.Almacens", "CentroLogisticoId", "dbo.CentroLogisticoes");
            DropIndex("dbo.Kardexes", new[] { "AlmacenId" });
            DropIndex("dbo.Kardexes", new[] { "OrdenServicioId" });
            DropIndex("dbo.OrdenServicios", new[] { "MercaderiaId" });
            DropIndex("dbo.TipoRecepcions", new[] { "TipoRecepcion_TipoRecepcionId" });
            DropIndex("dbo.ProcedimientoProduccions", new[] { "UnidadMedidaId" });
            DropIndex("dbo.ProcedimientoProduccions", new[] { "MercaderiaId" });
            DropIndex("dbo.ProcedimientoProduccionInsumoes", new[] { "UnidadMedidaId" });
            DropIndex("dbo.ProcedimientoProduccionInsumoes", new[] { "MercaderiaId" });
            DropIndex("dbo.ProcedimientoProduccionInsumoes", new[] { "ProcedimientoProduccionId" });
            DropIndex("dbo.OrdenProduccionInsumoes", new[] { "UnidadMedidaId" });
            DropIndex("dbo.OrdenProduccionInsumoes", new[] { "MercaderiaId" });
            DropIndex("dbo.OrdenProduccionInsumoes", new[] { "OrdenProduccionId" });
            DropIndex("dbo.RecepcionDetalles", new[] { "CompraDetalleId" });
            DropIndex("dbo.RecepcionDetalles", new[] { "OrdenProduccionInsumoId" });
            DropIndex("dbo.RecepcionDetalles", new[] { "UnidadMedidaId" });
            DropIndex("dbo.RecepcionDetalles", new[] { "MercaderiaId" });
            DropIndex("dbo.RecepcionDetalles", new[] { "RecepcionId" });
            DropIndex("dbo.Recepcions", new[] { "CompraId" });
            DropIndex("dbo.Recepcions", new[] { "OrdenProduccionId" });
            DropIndex("dbo.Recepcions", new[] { "AlmacenId" });
            DropIndex("dbo.Recepcions", new[] { "TipoRecepcionId" });
            DropIndex("dbo.Compras", new[] { "CentroLogisticoId" });
            DropIndex("dbo.CompraDetalles", new[] { "MercaderiaId" });
            DropIndex("dbo.CompraDetalles", new[] { "CompraId" });
            DropIndex("dbo.Mercaderias", new[] { "TipoMercaderiaId" });
            DropIndex("dbo.VentaDetalles", new[] { "MercaderiaId" });
            DropIndex("dbo.VentaDetalles", new[] { "VentaId" });
            DropIndex("dbo.Ventas", new[] { "CentroLogisticoId" });
            DropIndex("dbo.Despachoes", new[] { "VentaId" });
            DropIndex("dbo.Despachoes", new[] { "OrdenProduccionId" });
            DropIndex("dbo.Despachoes", new[] { "AlmacenId" });
            DropIndex("dbo.Despachoes", new[] { "TipoDespachoId" });
            DropIndex("dbo.DespachoDetalles", new[] { "VentaDetalleId" });
            DropIndex("dbo.DespachoDetalles", new[] { "OrdenProduccionInsumoId" });
            DropIndex("dbo.DespachoDetalles", new[] { "UnidadMedidaId" });
            DropIndex("dbo.DespachoDetalles", new[] { "MercaderiaId" });
            DropIndex("dbo.DespachoDetalles", new[] { "DespachoId" });
            DropIndex("dbo.KardexMovimientoes", new[] { "UnidadMedidaId" });
            DropIndex("dbo.KardexMovimientoes", new[] { "MercaderiaId" });
            DropIndex("dbo.KardexMovimientoes", new[] { "DespachoDetalleId" });
            DropIndex("dbo.KardexMovimientoes", new[] { "RecepcionDetalleId" });
            DropIndex("dbo.KardexMovimientoes", new[] { "TipoMovimientoId" });
            DropIndex("dbo.KardexMovimientoes", new[] { "KardexId" });
            DropIndex("dbo.ConfiguracionValorizacions", new[] { "DistribucionValorizacionId" });
            DropIndex("dbo.ConfiguracionValorizacions", new[] { "MetodoValorizacionId" });
            DropIndex("dbo.CostoProduccions", new[] { "ConfiguracionValorizacionId" });
            DropIndex("dbo.CostoProduccions", new[] { "AlmacenId" });
            DropIndex("dbo.CostoOrdenProduccions", new[] { "KardexMovimientoId" });
            DropIndex("dbo.CostoOrdenProduccions", new[] { "OrdenProduccionId" });
            DropIndex("dbo.CostoOrdenProduccions", new[] { "CostoProduccionId" });
            DropIndex("dbo.OrdenProduccions", new[] { "UnidadMedidaId" });
            DropIndex("dbo.OrdenProduccions", new[] { "ProcedimientoProduccionId" });
            DropIndex("dbo.OrdenProduccions", new[] { "MercaderiaId" });
            DropIndex("dbo.OrdenProduccions", new[] { "PlantaFabricacionId" });
            DropIndex("dbo.PlantaFabricacions", new[] { "CentroLogisticoId" });
            DropIndex("dbo.Almacens", new[] { "CentroLogisticoId" });
            DropTable("dbo.TipoMovimientoes");
            DropTable("dbo.TipoMercaderias");
            DropTable("dbo.Kardexes");
            DropTable("dbo.OrdenServicios");
            DropTable("dbo.TipoRecepcions");
            DropTable("dbo.ProcedimientoProduccions");
            DropTable("dbo.ProcedimientoProduccionInsumoes");
            DropTable("dbo.UnidadMedidas");
            DropTable("dbo.OrdenProduccionInsumoes");
            DropTable("dbo.RecepcionDetalles");
            DropTable("dbo.Recepcions");
            DropTable("dbo.Compras");
            DropTable("dbo.CompraDetalles");
            DropTable("dbo.Mercaderias");
            DropTable("dbo.VentaDetalles");
            DropTable("dbo.Ventas");
            DropTable("dbo.TipoDespachoes");
            DropTable("dbo.Despachoes");
            DropTable("dbo.DespachoDetalles");
            DropTable("dbo.KardexMovimientoes");
            DropTable("dbo.MetodoValorizacions");
            DropTable("dbo.DistribucionValorizacions");
            DropTable("dbo.ConfiguracionValorizacions");
            DropTable("dbo.CostoProduccions");
            DropTable("dbo.CostoOrdenProduccions");
            DropTable("dbo.OrdenProduccions");
            DropTable("dbo.PlantaFabricacions");
            DropTable("dbo.CentroLogisticoes");
            DropTable("dbo.Almacens");
        }
    }
}
