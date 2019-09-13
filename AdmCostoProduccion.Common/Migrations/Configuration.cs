namespace AdmCostoProduccion.Common.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AdmCostoProduccion.Common.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AdmCostoProduccion.Common.Data.ApplicationDbContext context)
        {
            context.AplicacionConfiguracions.AddOrUpdate(x => x.AplicacionConfiguracionId,
                new Models.Aplicacion.AplicacionConfiguracion()
                {
                    AplicacionConfiguracionId = "2da60039-7315-4837-86fb-7a6fa2f28081",
                    OrdenProduccionGeneraMovimiento = true,
                    OrdenProduccionGeneraMovimientoInsumos = true,
                    CompraGeneraRecepcion = true,
                    VentaGeneraDespacho = true
                }
                );

            context.AplicacionCorrelativos.AddOrUpdate(x => x.AplicacionCorrelativoId,
                new Models.Aplicacion.AplicacionCorrelativo()
                {
                    AplicacionCorrelativoId = "d40dba73-a81f-4310-88c3-10fa53bc1ff0",
                    Codigo = "RE",
                    Nombre = "Recepcion",
                    Prefijo = "RE",
                    NumeroDigitos = 4,
                    Correlativo = 1
                },
                new Models.Aplicacion.AplicacionCorrelativo()
                {
                    AplicacionCorrelativoId = "d29a523b-25e5-4d19-9b35-e76f6e9c7886",
                    Codigo = "DE",
                    Nombre = "Despacho",
                    Prefijo = "DE",
                    NumeroDigitos = 4,
                    Correlativo = 1
                }
                );

            context.CentroLogisticos.AddOrUpdate(x => x.CentroLogisticoId,
                new Models.Maestro.CentroLogistico()
                {
                    CentroLogisticoId = "d40dba73-a81f-4310-88c3-10fa53bc1ff0",
                    Codigo = "VES",
                    Nombre = "Villa el Salvador",
                    Descripcion = "Centro Villa el Salvador"
                },
                new Models.Maestro.CentroLogistico()
                {
                    CentroLogisticoId = "e4bc125c-c6b3-4cfc-9a9f-da7ec171d4f5",
                    Codigo = "LRN",
                    Nombre = "Lurin",
                    Descripcion = "Centro Lurin"
                }
                );

            context.PlantaFabricacions.AddOrUpdate(x => x.PlantaFabricacionId,
                new Models.Maestro.PlantaFabricacion()
                {
                    PlantaFabricacionId = "eb7e7ef5-6ad4-4f83-82c6-fad120685b3a",
                    CentroLogisticoId = "d40dba73-a81f-4310-88c3-10fa53bc1ff0",
                    Codigo = "VES",
                    Nombre = "Villa el Salvador",
                    Descripcion = "Planta Villa el Salvador"
                },
                new Models.Maestro.PlantaFabricacion()
                {
                    PlantaFabricacionId = "7455a04d-fc97-4de5-99a1-3dd9afc2a8e0",
                    CentroLogisticoId = "e4bc125c-c6b3-4cfc-9a9f-da7ec171d4f5",
                    Codigo = "LRN",
                    Nombre = "Lurin",
                    Descripcion = "Planta Lurin"
                }
                );

            context.Almacens.AddOrUpdate(x => x.AlmacenId,
                new Models.Maestro.Almacen()
                {
                    AlmacenId = "0a070f84-e77a-4d92-ae01-df33ed2f5972",
                    CentroLogisticoId = "d40dba73-a81f-4310-88c3-10fa53bc1ff0",
                    Codigo = "MAQ",
                    Nombre = "Maquinarias",
                    Descripcion = "Almacén Maquinarias"
                },
                new Models.Maestro.Almacen()
                {
                    AlmacenId = "04cb3c51-0e18-49db-b5f7-46e3cc3e45cb",
                    CentroLogisticoId = "e4bc125c-c6b3-4cfc-9a9f-da7ec171d4f5",
                    Codigo = "INS",
                    Nombre = "Insumos",
                    Descripcion = "Almacén Insumos"
                },
                new Models.Maestro.Almacen()
                {
                    AlmacenId = "815c5f06-4058-4414-a401-a3d8dde1e4e5",
                    CentroLogisticoId = "e4bc125c-c6b3-4cfc-9a9f-da7ec171d4f5",
                    Codigo = "PTI",
                    Nombre = "Productos Intermedios",
                    Descripcion = "Almacén Productos Intermedios"
                },
                new Models.Maestro.Almacen()
                {
                    AlmacenId = "995b23fd-da1d-4fcf-bd15-e10c0b9282d8",
                    CentroLogisticoId = "e4bc125c-c6b3-4cfc-9a9f-da7ec171d4f5",
                    Codigo = "PTR",
                    Nombre = "Terminados",
                    Descripcion = "Almacén de Terminados"
                }
                );

            context.TipoMercaderias.AddOrUpdate(x => x.TipoMercaderiaId,
                new Models.Inventario.TipoMercaderia()
                {
                    TipoMercaderiaId = "83e68896-cfe1-4876-a70c-7da0e9b2c161",
                    Codigo = "INS",
                    Nombre = "Insumo",
                    Descripcion = "Tipo de Mercadería Insumo"
                },
                new Models.Inventario.TipoMercaderia()
                {
                    TipoMercaderiaId = "892a3052-9ca4-4795-a8d6-13f54218b08d",
                    Codigo = "ITM",
                    Nombre = "Intermedio",
                    Descripcion = "Tipo de Mercaderia Intermedio"
                },
                new Models.Inventario.TipoMercaderia()
                {
                    TipoMercaderiaId = "dfabf38e-4a86-472f-ab7e-731622b7fcb6",
                    Codigo = "TRM",
                    Nombre = "Terminado",
                    Descripcion = "Tipo de Mercaderia Terminado"
                }
                );

            context.FamiliaMercaderias.AddOrUpdate(x => x.FamiliaMercaderiaId,
                new Models.Inventario.FamiliaMercaderia()
                {
                    FamiliaMercaderiaId = "246b795a-70f7-4d6e-bafb-da3e25e9dc46",
                    Codigo = "EMB",
                    Nombre = "Embases",
                    Descripcion = "Familia Embases"
                },
                new Models.Inventario.FamiliaMercaderia()
                {
                    FamiliaMercaderiaId = "2fb1132d-3a73-48a1-8860-e96020f9ab51",
                    Codigo = "PUL",
                    Nombre = "Pulpas",
                    Descripcion = "Familia Pulpas"
                },
                new Models.Inventario.FamiliaMercaderia()
                {
                    FamiliaMercaderiaId = "c239a610-07d2-42be-995d-1cec2b89ed8e",
                    Codigo = "MER",
                    Nombre = "Mermeladas",
                    Descripcion = "Familia Mermeladas"
                }
                );

            context.Mercaderias.AddOrUpdate(x => x.MercaderiaId,
                new Models.Inventario.Mercaderia()
                {
                    MercaderiaId = "210018b1-cca5-4a81-b894-8a70e8e04ceb",
                    TipoMercaderiaId = "dfabf38e-4a86-472f-ab7e-731622b7fcb6",
                    FamiliaMercaderiaId = "c239a610-07d2-42be-995d-1cec2b89ed8e",
                    Codigo = "PT1",
                    Nombre = "Terminado 1",
                    Descripcion = "Terminado 1"
                },
                new Models.Inventario.Mercaderia()
                {
                    MercaderiaId = "37ba7a61-3f1c-4ad7-83fd-969a7c696df4",
                    TipoMercaderiaId = "dfabf38e-4a86-472f-ab7e-731622b7fcb6",
                    FamiliaMercaderiaId = "c239a610-07d2-42be-995d-1cec2b89ed8e",
                    Codigo = "PT2",
                    Nombre = "Terminado 2",
                    Descripcion = "Terminado 2"
                },
                new Models.Inventario.Mercaderia()
                {
                    MercaderiaId = "ced79691-8e40-4d2a-8cbf-1684a11c12ec",
                    TipoMercaderiaId = "892a3052-9ca4-4795-a8d6-13f54218b08d",
                    FamiliaMercaderiaId = "2fb1132d-3a73-48a1-8860-e96020f9ab51",
                    Codigo = "PI1",
                    Nombre = "Intermedio 1",
                    Descripcion = "Intermedio 1"
                },
                new Models.Inventario.Mercaderia()
                {
                    MercaderiaId = "16251351-a5cf-4ea7-8551-eea81bcb8061",
                    TipoMercaderiaId = "892a3052-9ca4-4795-a8d6-13f54218b08d",
                    FamiliaMercaderiaId = "2fb1132d-3a73-48a1-8860-e96020f9ab51",
                    Codigo = "PI2",
                    Nombre = "Intermedio 2",
                    Descripcion = "Intermedio 2"
                },
                new Models.Inventario.Mercaderia()
                {
                    MercaderiaId = "2f468afd-3a78-4ca5-8797-c42173f2b600",
                    TipoMercaderiaId = "83e68896-cfe1-4876-a70c-7da0e9b2c161",
                    FamiliaMercaderiaId = "246b795a-70f7-4d6e-bafb-da3e25e9dc46",
                    Codigo = "INS1",
                    Nombre = "Insumo 1",
                    Descripcion = "Insumo 1"
                },
                new Models.Inventario.Mercaderia()
                {
                    MercaderiaId = "de860651-52b0-4833-bee4-b9a3219dafd7",
                    TipoMercaderiaId = "83e68896-cfe1-4876-a70c-7da0e9b2c161",
                    FamiliaMercaderiaId = "246b795a-70f7-4d6e-bafb-da3e25e9dc46",
                    Codigo = "INS2",
                    Nombre = "Insumo 2",
                    Descripcion = "Insumo 2"
                },
                new Models.Inventario.Mercaderia()
                {
                    MercaderiaId = "5ff346b9-4bb5-416a-8ff6-864e92bc8f83",
                    TipoMercaderiaId = "83e68896-cfe1-4876-a70c-7da0e9b2c161",
                    FamiliaMercaderiaId = "246b795a-70f7-4d6e-bafb-da3e25e9dc46",
                    Codigo = "INS3",
                    Nombre = "Insumo 3",
                    Descripcion = "Insumo 3"
                },
                new Models.Inventario.Mercaderia()
                {
                    MercaderiaId = "42cb9f44-2172-4d0c-a581-fe08faf36183",
                    TipoMercaderiaId = "83e68896-cfe1-4876-a70c-7da0e9b2c161",
                    FamiliaMercaderiaId = "246b795a-70f7-4d6e-bafb-da3e25e9dc46",
                    Codigo = "INS4",
                    Nombre = "Insumo 4",
                    Descripcion = "Insumo 4"
                }
                );

            context.ReglaAlmacenajes.AddOrUpdate(x => x.ReglaAlmacenajeId,
                new Models.Inventario.ReglaAlmacenaje()
                {
                    ReglaAlmacenajeId = "4a2d1b3b-c7a7-4411-a564-c0f7e5ee43bf",
                    AlmacenId = "04cb3c51-0e18-49db-b5f7-46e3cc3e45cb",
                    FamiliaMercaderiaId = "246b795a-70f7-4d6e-bafb-da3e25e9dc46",
                    Codigo = "ALMEMB",
                    Nombre = "Embases",
                    Descripcion = "Regla Almacenaje Embases"
                },
                new Models.Inventario.ReglaAlmacenaje()
                {
                    ReglaAlmacenajeId = "aa479e4b-95da-4541-adb2-c7bcbf1d17e2",
                    AlmacenId = "815c5f06-4058-4414-a401-a3d8dde1e4e5",
                    FamiliaMercaderiaId = "246b795a-70f7-4d6e-bafb-da3e25e9dc46",
                    Codigo = "ALMPI",
                    Nombre = "Productos Intermedios",
                    Descripcion = "Regla Almacenaje Productos Intermedios"
                },
                new Models.Inventario.ReglaAlmacenaje()
                {
                    ReglaAlmacenajeId = "ad8caf90-77d4-464e-993b-e04754abc448",
                    AlmacenId = "995b23fd-da1d-4fcf-bd15-e10c0b9282d8",
                    FamiliaMercaderiaId = "c239a610-07d2-42be-995d-1cec2b89ed8e",
                    Codigo = "ALMPT",
                    Nombre = "Productos Terminados",
                    Descripcion = "Regla Almacenaje Productos Terminados"
                }
                );

            context.UnidadMedidas.AddOrUpdate(x => x.UnidadMedidaId,
                new Models.Inventario.UnidadMedida()
                {
                    UnidadMedidaId = "2212fdbc-d540-43ec-a233-e92fb57c66db",
                    Codigo = "KG",
                    Nombre = "Kilogramo",
                    Descripcion = "Unidad Kilogramo",
                    Simbolo = "Kg."
                },
                new Models.Inventario.UnidadMedida()
                {
                    UnidadMedidaId = "bfe914ac-09a8-4c50-b0f2-2da6b7324672",
                    Codigo = "UN",
                    Nombre = "Unidad",
                    Descripcion = "Unidad",
                    Simbolo = "Und."
                }
                );

            context.TipoRecepcions.AddOrUpdate(x => x.TipoRecepcionId,
                new Models.Inventario.TipoRecepcion()
                {
                    TipoRecepcionId = "537a0f27-9c5c-4723-a575-7e88d38f5061",
                    Codigo = "INV",
                    Nombre = "Inventario",
                    Descripcion = "Recepcion por Inventario",
                    Proceso = "InventarioInicial"
                },
                new Models.Inventario.TipoRecepcion()
                {
                    TipoRecepcionId = "ac6658bd-19d2-46e3-991b-9059e0dd90b8",
                    Codigo = "AJT",
                    Nombre = "Ajuste",
                    Descripcion = "Recepcion por Ajuste",
                    Proceso = "AjusteInventario"
                },
                new Models.Inventario.TipoRecepcion()
                {
                    TipoRecepcionId = "d096e85d-1a5f-4e83-8f5a-55b755d2ddb5",
                    Codigo = "CO",
                    Nombre = "Compra",
                    Descripcion = "Recepcion por Compra",
                    Proceso = "Compra"
                },
                new Models.Inventario.TipoRecepcion()
                {
                    TipoRecepcionId = "d2b623bb-c6f3-4290-8f93-f46208127d5b",
                    Codigo = "OP",
                    Nombre = "Orden de Producción",
                    Descripcion = "Recepcion por Orden de Producción",
                    Proceso = "OrdenProduccion"
                }
                );

            context.TipoDespachos.AddOrUpdate(x => x.TipoDespachoId,
                new Models.Inventario.TipoDespacho()
                {
                    TipoDespachoId = "24a60691-e6c9-449b-956c-0d9cff985dcb",
                    Codigo = "AJT",
                    Nombre = "Ajuste",
                    Descripcion = "Despacho por Ajuste",
                    Proceso = "AjusteInventario"
                },
                new Models.Inventario.TipoDespacho()
                {
                    TipoDespachoId = "1ff58bf0-4942-4e49-90ee-ec8a51e6c1f0",
                    Codigo = "OP",
                    Nombre = "Orden de Producción",
                    Descripcion = "Despacho por Orden de Producción",
                    Proceso = "OrdenProduccion"
                },
                new Models.Inventario.TipoDespacho()
                {
                    TipoDespachoId = "3bd5581f-a7a2-42d7-88c9-f19bfcb14ff1",
                    Codigo = "VE",
                    Nombre = "Venta",
                    Descripcion = "Despacho por Venta",
                    Proceso = "Venta"
                }
                );

            context.TipoAjusteInventarios.AddOrUpdate(x => x.TipoAjusteInventarioId,
                new Models.Inventario.TipoAjusteInventario()
                {
                    TipoAjusteInventarioId = "e93d4da8-78d1-428c-baf6-fa90f6513d1f",
                    Codigo = "AJI",
                    Nombre = "Ingreso",
                    Descripcion = "Ajuste de Ingreso"
                },
                new Models.Inventario.TipoAjusteInventario()
                {
                    TipoAjusteInventarioId = "75be7cc6-dc4e-415a-9f81-624d79893c94",
                    Codigo = "AJS",
                    Nombre = "Salida",
                    Descripcion = "Ajuste de Salida"
                }
                );

            context.TipoMovimientos.AddOrUpdate(x => x.TipoMovimientoId,
                new Models.Inventario.TipoMovimiento()
                {
                    TipoMovimientoId = "f59f5561-b902-4b39-a423-0cdd57f21814",
                    Codigo = "ENT",
                    Nombre = "Entrada",
                    Descripcion = "Movimiento de Entrada"
                },
                new Models.Inventario.TipoMovimiento()
                {
                    TipoMovimientoId = "14f6f815-1799-4f5c-8937-a466dc7968cc",
                    Codigo = "SAL",
                    Nombre = "Salida",
                    Descripcion = "Movimiento de Salida"
                }
                );
        }
    }
}
