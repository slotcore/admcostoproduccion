namespace AdmCostoProduccion.Common.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialmigration : DbMigration
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
                        Nombre = c.String(),
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
                .ForeignKey("dbo.DespachoDetalles", t => t.DespachoDetalleId)
                .ForeignKey("dbo.Mercaderias", t => t.MercaderiaId)
                .ForeignKey("dbo.RecepcionDetalles", t => t.RecepcionDetalleId)
                .ForeignKey("dbo.UnidadMedidas", t => t.UnidadMedidaId)
                .ForeignKey("dbo.Kardexes", t => t.KardexId)
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
                        DespachoDetalleId = c.Int(nullable: false),
                        Cantidad = c.Double(nullable: false),
                        DespachoId = c.Int(nullable: false),
                        OrdenProduccionInsumoId = c.Int(nullable: false),
                        MercaderiaId = c.Int(nullable: false),
                        UnidadMedidaId = c.Int(nullable: false),
                        UsuarioCreacion = c.String(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioUltimaActualizacion = c.String(),
                        FechaUltimaActualizacion = c.DateTime(),
                        Eliminado = c.Boolean(nullable: false),
                        Mercaderia_MercaderiaId = c.Int(),
                    })
                .PrimaryKey(t => t.DespachoDetalleId)
                .ForeignKey("dbo.Despachoes", t => t.DespachoId)
                .ForeignKey("dbo.Mercaderias", t => t.Mercaderia_MercaderiaId)
                .ForeignKey("dbo.OrdenProduccionInsumoes", t => t.OrdenProduccionInsumoId)
                .ForeignKey("dbo.UnidadMedidas", t => t.UnidadMedidaId)
                .ForeignKey("dbo.Mercaderias", t => t.DespachoDetalleId)
                .Index(t => t.DespachoDetalleId)
                .Index(t => t.DespachoId)
                .Index(t => t.OrdenProduccionInsumoId)
                .Index(t => t.UnidadMedidaId)
                .Index(t => t.Mercaderia_MercaderiaId);
            
            CreateTable(
                "dbo.Despachoes",
                c => new
                    {
                        DespachoId = c.Int(nullable: false, identity: true),
                        Codigo = c.String(),
                        Observacion = c.String(),
                        TipoDespachoId = c.Int(nullable: false),
                        AlmacenId = c.Int(nullable: false),
                        OrdenProduccionId = c.Int(nullable: false),
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
                .Index(t => t.TipoDespachoId)
                .Index(t => t.AlmacenId)
                .Index(t => t.OrdenProduccionId);
            
            CreateTable(
                "dbo.TipoDespachoes",
                c => new
                    {
                        TipoDespachoId = c.Int(nullable: false, identity: true),
                        Codigo = c.String(),
                        Nombre = c.String(),
                        Descripcion = c.String(),
                        UsuarioCreacion = c.String(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioUltimaActualizacion = c.String(),
                        FechaUltimaActualizacion = c.DateTime(),
                        Eliminado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.TipoDespachoId);
            
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
                "dbo.RecepcionDetalles",
                c => new
                    {
                        RecepcionDetalleId = c.Int(nullable: false, identity: true),
                        Cantidad = c.Double(nullable: false),
                        RecepcionId = c.Int(nullable: false),
                        OrdenProduccionInsumoId = c.Int(nullable: false),
                        MercaderiaId = c.Int(nullable: false),
                        UnidadMedidaId = c.Int(nullable: false),
                        UsuarioCreacion = c.String(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioUltimaActualizacion = c.String(),
                        FechaUltimaActualizacion = c.DateTime(),
                        Eliminado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.RecepcionDetalleId)
                .ForeignKey("dbo.Mercaderias", t => t.MercaderiaId)
                .ForeignKey("dbo.OrdenProduccionInsumoes", t => t.OrdenProduccionInsumoId)
                .ForeignKey("dbo.Recepcions", t => t.RecepcionId)
                .ForeignKey("dbo.UnidadMedidas", t => t.UnidadMedidaId)
                .Index(t => t.RecepcionId)
                .Index(t => t.OrdenProduccionInsumoId)
                .Index(t => t.MercaderiaId)
                .Index(t => t.UnidadMedidaId);
            
            CreateTable(
                "dbo.Recepcions",
                c => new
                    {
                        RecepcionId = c.Int(nullable: false, identity: true),
                        Codigo = c.String(),
                        Observacion = c.String(),
                        TipoRecepcionId = c.Int(nullable: false),
                        AlmacenId = c.Int(nullable: false),
                        OrdenProduccionId = c.Int(nullable: false),
                        UsuarioCreacion = c.String(),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioUltimaActualizacion = c.String(),
                        FechaUltimaActualizacion = c.DateTime(),
                        Eliminado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.RecepcionId)
                .ForeignKey("dbo.Almacens", t => t.AlmacenId)
                .ForeignKey("dbo.OrdenProduccions", t => t.OrdenProduccionId)
                .ForeignKey("dbo.TipoRecepcions", t => t.TipoRecepcionId)
                .Index(t => t.TipoRecepcionId)
                .Index(t => t.AlmacenId)
                .Index(t => t.OrdenProduccionId);
            
            CreateTable(
                "dbo.TipoRecepcions",
                c => new
                    {
                        TipoRecepcionId = c.Int(nullable: false, identity: true),
                        Codigo = c.String(),
                        Nombre = c.String(),
                        Descripcion = c.String(),
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
            DropForeignKey("dbo.DespachoDetalles", "DespachoDetalleId", "dbo.Mercaderias");
            DropForeignKey("dbo.Mercaderias", "TipoMercaderiaId", "dbo.TipoMercaderias");
            DropForeignKey("dbo.OrdenServicios", "MercaderiaId", "dbo.Mercaderias");
            DropForeignKey("dbo.Kardexes", "OrdenServicioId", "dbo.OrdenServicios");
            DropForeignKey("dbo.KardexMovimientoes", "KardexId", "dbo.Kardexes");
            DropForeignKey("dbo.Kardexes", "AlmacenId", "dbo.Almacens");
            DropForeignKey("dbo.OrdenProduccions", "MercaderiaId", "dbo.Mercaderias");
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
            DropForeignKey("dbo.Recepcions", "TipoRecepcionId", "dbo.TipoRecepcions");
            DropForeignKey("dbo.TipoRecepcions", "TipoRecepcion_TipoRecepcionId", "dbo.TipoRecepcions");
            DropForeignKey("dbo.RecepcionDetalles", "RecepcionId", "dbo.Recepcions");
            DropForeignKey("dbo.Recepcions", "OrdenProduccionId", "dbo.OrdenProduccions");
            DropForeignKey("dbo.Recepcions", "AlmacenId", "dbo.Almacens");
            DropForeignKey("dbo.RecepcionDetalles", "OrdenProduccionInsumoId", "dbo.OrdenProduccionInsumoes");
            DropForeignKey("dbo.RecepcionDetalles", "MercaderiaId", "dbo.Mercaderias");
            DropForeignKey("dbo.KardexMovimientoes", "RecepcionDetalleId", "dbo.RecepcionDetalles");
            DropForeignKey("dbo.OrdenProduccionInsumoes", "OrdenProduccionId", "dbo.OrdenProduccions");
            DropForeignKey("dbo.OrdenProduccionInsumoes", "MercaderiaId", "dbo.Mercaderias");
            DropForeignKey("dbo.DespachoDetalles", "OrdenProduccionInsumoId", "dbo.OrdenProduccionInsumoes");
            DropForeignKey("dbo.KardexMovimientoes", "MercaderiaId", "dbo.Mercaderias");
            DropForeignKey("dbo.DespachoDetalles", "Mercaderia_MercaderiaId", "dbo.Mercaderias");
            DropForeignKey("dbo.KardexMovimientoes", "DespachoDetalleId", "dbo.DespachoDetalles");
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
            DropIndex("dbo.ProcedimientoProduccions", new[] { "UnidadMedidaId" });
            DropIndex("dbo.ProcedimientoProduccions", new[] { "MercaderiaId" });
            DropIndex("dbo.ProcedimientoProduccionInsumoes", new[] { "UnidadMedidaId" });
            DropIndex("dbo.ProcedimientoProduccionInsumoes", new[] { "MercaderiaId" });
            DropIndex("dbo.ProcedimientoProduccionInsumoes", new[] { "ProcedimientoProduccionId" });
            DropIndex("dbo.TipoRecepcions", new[] { "TipoRecepcion_TipoRecepcionId" });
            DropIndex("dbo.Recepcions", new[] { "OrdenProduccionId" });
            DropIndex("dbo.Recepcions", new[] { "AlmacenId" });
            DropIndex("dbo.Recepcions", new[] { "TipoRecepcionId" });
            DropIndex("dbo.RecepcionDetalles", new[] { "UnidadMedidaId" });
            DropIndex("dbo.RecepcionDetalles", new[] { "MercaderiaId" });
            DropIndex("dbo.RecepcionDetalles", new[] { "OrdenProduccionInsumoId" });
            DropIndex("dbo.RecepcionDetalles", new[] { "RecepcionId" });
            DropIndex("dbo.OrdenProduccionInsumoes", new[] { "UnidadMedidaId" });
            DropIndex("dbo.OrdenProduccionInsumoes", new[] { "MercaderiaId" });
            DropIndex("dbo.OrdenProduccionInsumoes", new[] { "OrdenProduccionId" });
            DropIndex("dbo.Mercaderias", new[] { "TipoMercaderiaId" });
            DropIndex("dbo.Despachoes", new[] { "OrdenProduccionId" });
            DropIndex("dbo.Despachoes", new[] { "AlmacenId" });
            DropIndex("dbo.Despachoes", new[] { "TipoDespachoId" });
            DropIndex("dbo.DespachoDetalles", new[] { "Mercaderia_MercaderiaId" });
            DropIndex("dbo.DespachoDetalles", new[] { "UnidadMedidaId" });
            DropIndex("dbo.DespachoDetalles", new[] { "OrdenProduccionInsumoId" });
            DropIndex("dbo.DespachoDetalles", new[] { "DespachoId" });
            DropIndex("dbo.DespachoDetalles", new[] { "DespachoDetalleId" });
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
            DropTable("dbo.ProcedimientoProduccions");
            DropTable("dbo.ProcedimientoProduccionInsumoes");
            DropTable("dbo.UnidadMedidas");
            DropTable("dbo.TipoRecepcions");
            DropTable("dbo.Recepcions");
            DropTable("dbo.RecepcionDetalles");
            DropTable("dbo.OrdenProduccionInsumoes");
            DropTable("dbo.Mercaderias");
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
