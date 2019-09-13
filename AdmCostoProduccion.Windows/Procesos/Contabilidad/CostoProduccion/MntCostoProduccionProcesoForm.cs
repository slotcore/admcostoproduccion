using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Data;
using AdmCostoProduccion.Common.Models.Contabilidad;
using AdmCostoProduccion.Common.Models.Inventario;
using AdmCostoProduccion.Common.Models.Produccion;
using AdmCostoProduccion.Common.ViewModels.Contabilidad;
using AdmCostoProduccion.Common.ViewModels.Maestro;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdmCostoProduccion.Windows.Procesos.Contabilidad.CostoProduccion
{
    public partial class MntCostoProduccionProcesoForm : KryptonForm
    {
        #region Propiedades
        private CostoProduccionViewModel ViewModel = new CostoProduccionViewModel();
        private ObservableListSource<CostoProduccionViewModel> ViewModelList;
        private List<PlantaFabricacionViewModel> plantaFabricacionViewModels;
        private List<ConfiguracionValorizacionViewModel> configuracionValorizacionViewModels;
        #endregion

        #region Constructor
        public MntCostoProduccionProcesoForm(CostoProduccionViewModel viewModel
            , ObservableListSource<CostoProduccionViewModel> viewModelList)
        {
            InitializeComponent();
            ViewModel.CopyOf(viewModel);
            ViewModelList = viewModelList;
            costoProduccionViewModelBindingSource.DataSource = ViewModel;
        }

        public MntCostoProduccionProcesoForm(ObservableListSource<CostoProduccionViewModel> viewModelList)
        {
            InitializeComponent();
            ViewModel = new CostoProduccionViewModel();
            ViewModelList = viewModelList;
            costoProduccionViewModelBindingSource.DataSource = ViewModel;
        }
        #endregion

        #region Eventos de Formulario
        private void GrabarButton_Click(object sender, EventArgs e)
        {
            Grabar();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            costoProduccionViewModelBindingSource.CancelEdit();
            this.Close();
        }

        private void AgregarDetalleButton_Click(object sender, EventArgs e)
        {
            AgregarDetalle();
        }

        private void ModificarDetalleButton_Click(object sender, EventArgs e)
        {
            ModificarDetalle();
        }

        private void EliminarDetalleButton_Click(object sender, EventArgs e)
        {
            EliminarDetalle();
        }

        private void BuscarAgregarOrdenesButton_Click(object sender, EventArgs e)
        {
            BuscarAgregarOrdenes();
        }

        private void ProcesarMpButton_Click(object sender, EventArgs e)
        {
            using (var context = new ApplicationDbContext())
            {
                var costoProduccion = context.CostoProduccions
                    .FirstOrDefault(o => o.CostoProduccionId == ViewModel.CostoProduccionId);
                ProcesarMp(costoProduccion);
            }
        }
        #endregion

        #region Eventos Privados

        private void Grabar()
        {
            try
            {
                bool IsNew = ViewModel.IsNew;
                Cursor = Cursors.WaitCursor;
                costoProduccionViewModelBindingSource.EndEdit();
                ViewModel.Grabar();
                if (IsNew) ViewModelList.Add(ViewModel);
                else
                {
                    var viewModel = ViewModelList
                        .Where(o => o.CostoProduccionId == ViewModel.CostoProduccionId)
                        .FirstOrDefault();
                    viewModel.CopyOf(ViewModel);
                }
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Ocurrió un error al grabar, mensaje de error: {0}", ex.Message)
                    , "Grabar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void AgregarDetalle()
        {
            try
            {
                var frm = new MntCostoOrdenProduccionForm(ViewModel.CostoProduccionId, ViewModel.CostoOrdenProduccionViewModels);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Ocurrió un error al agregar, mensaje de error: {0}", ex.Message)
                    , "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ModificarDetalle()
        {
            try
            {
                var viewModel = (CostoOrdenProduccionViewModel)costoOrdenProduccionViewModelsBindingSource.Current;
                var frm = new MntCostoOrdenProduccionForm(viewModel, ViewModel.CostoOrdenProduccionViewModels);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Ocurrió un error al modificar, mensaje de error: {0}", ex.Message)
                    , "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarDetalle()
        {
            try
            {
                if (MessageBox.Show("¿Seguro desea eliminar el registro?", "Eliminar"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var viewModelDetail = (CostoOrdenProduccionViewModel)costoOrdenProduccionViewModelsBindingSource.Current;
                    ViewModel.CostoOrdenProduccionViewModels.RemoveItem(viewModelDetail);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Ocurrió un error al eliminar el registro, mensaje de error: {0}", ex.Message)
                    , "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuscarAgregarOrdenes()
        {
            ViewModel.CostoOrdenProduccionViewModels.Clear();
            using (var context = new ApplicationDbContext())
            {
                var ordenProduccions = context.OrdenProduccions
                    .Where(o => o.PlantaFabricacionId == ViewModel.PlantaFabricacionId
                        && o.Fecha >= fechaInicioDateTimePicker.Value
                        && o.Fecha <= fechaFinDateTimePicker.Value)
                    .ToList();

                foreach (var ordenProduccion in ordenProduccions)
                {
                    var recepcion = ordenProduccion.Recepcions.FirstOrDefault();
                    if (recepcion == null)
                        throw new Exception(string.Format("La Orden: {0} no cuenta con recepcion asociada"
                            , ordenProduccion.Codigo));
                    var recepcionDetalle = recepcion.RecepcionDetalles.FirstOrDefault();
                    if (recepcionDetalle == null)
                        throw new Exception(string.Format("La Recepcion: {0} no cuenta con detalles"
                            , recepcion.Codigo));
                    var kardexMovimiento = recepcionDetalle.KardexMovimientos.FirstOrDefault();
                    if (kardexMovimiento == null)
                        throw new Exception(string.Format("La Recepcion: {0} no cuenta con movimiento de kardex asociado"
                            , recepcion.Codigo));

                    CostoOrdenProduccionViewModel costoOrdenProduccionViewModel = new CostoOrdenProduccionViewModel(ViewModel.CostoProduccionId);
                    costoOrdenProduccionViewModel.OrdenProduccionId = ordenProduccion.OrdenProduccionId;
                    costoOrdenProduccionViewModel.KardexMovimientoId = kardexMovimiento.KardexMovimientoId;
                    costoOrdenProduccionViewModel.OrdenProduccion = ordenProduccion.Codigo;
                    costoOrdenProduccionViewModel.CodigoMercaderia = ordenProduccion.Mercaderia.Codigo;
                    costoOrdenProduccionViewModel.NombreMercaderia = ordenProduccion.Mercaderia.Nombre;
                    costoOrdenProduccionViewModel.ProcedimientoProduccion = ordenProduccion.ProcedimientoProduccion.Nombre;
                    costoOrdenProduccionViewModel.UnidadMedida = ordenProduccion.UnidadMedida.Nombre;
                    costoOrdenProduccionViewModel.Cantidad = ordenProduccion.Cantidad;

                    ViewModel.CostoOrdenProduccionViewModels.Add(costoOrdenProduccionViewModel);
                }
            }
        }

        private void ProcesarMp(Common.Models.Contabilidad.CostoProduccion costoProduccion)
        {
            foreach (var costOrdenProduccionViewModel in ViewModel.CostoOrdenProduccionViewModels)
            {
                ProcesaInsumos(costoProduccion, fechaInicioDateTimePicker.Value, fechaFinDateTimePicker.Value);
                ProcesaIntermedios(ViewModel.FechaInicio, ViewModel.FechaFin);
                ProcesaTerminados(ViewModel.FechaInicio, ViewModel.FechaFin);
                CosteaMercaderia(costoProduccion, costOrdenProduccionViewModel.CodigoMercaderia, ViewModel.FechaInicio, ViewModel.FechaFin);
            }
        }

        private void CosteaMercaderia(Common.Models.Contabilidad.CostoProduccion costoProduccion, string mercaderiaId, DateTime fechaInicio, DateTime fechaFin)
        {
            using (var context = new ApplicationDbContext())
            {
                var mercaderiaMovimientoViewModel 
                    = MercaderiaMovimientoViewModel.CargarMovimientoMercaderia(fechaInicio.AddDays(-1), mercaderiaId);

                //detalle de recepciones en fecha
                var recepcionDetalleIds = from r in context.Recepcions
                                           join d in context.RecepcionDetalles on r.RecepcionId equals d.RecepcionId
                                           where r.Fecha >= fechaInicio && r.Fecha <= fechaFin
                                           select d.RecepcionDetalleId;
                //detalle de despachos en fecha
                var despachoDetalleIds = from r in context.Despachos
                                            join d in context.DespachoDetalles
                                            on r.DespachoId equals d.DespachoId
                                            where r.Fecha >= fechaInicio && r.Fecha <= fechaFin
                                            select d.DespachoDetalleId;
                //movimientos asociados ordenados por fecha y tipo de movimiento
                var kardexMovimientos = context.KardexMovimientos
                    .Where(o => recepcionDetalleIds.Contains(o.RecepcionDetalleId)
                        || despachoDetalleIds.Contains(o.DespachoDetalleId))
                    .OrderBy(o => o.Fecha)
                    .ThenBy(o => o.TipoMovimiento.Codigo)
                    .ToList();

                double cantidadAcumulada = mercaderiaMovimientoViewModel.SaldoActual;
                double cantidadAcumuladaEntrada = mercaderiaMovimientoViewModel.SaldoActual;
                double costoAcumulado = mercaderiaMovimientoViewModel.CostoActual;
                double costoUnitarioPromedio = mercaderiaMovimientoViewModel.CostoActual / mercaderiaMovimientoViewModel.SaldoActual;
                double costoMovimiento = 0;
                double costoUnitarioMovimiento = 0;

                foreach (var kardexMovimiento in kardexMovimientos)
                {
                    var costoProduccionMovimiento = context.CostoProduccionMovimientos
                        .Where(o => o.KardexMovimientoId == kardexMovimiento.KardexMovimientoId)
                        .FirstOrDefault();

                    switch (kardexMovimiento.TipoMovimiento.Codigo)
                    {
                        case "ENT":
                            cantidadAcumulada += kardexMovimiento.Cantidad;
                            cantidadAcumuladaEntrada += kardexMovimiento.Cantidad;

                            if (costoProduccionMovimiento == null)
                            {
                                costoMovimiento = CosteoKardexMovimiento(costoProduccion, kardexMovimiento, context);
                                costoUnitarioMovimiento = costoMovimiento / kardexMovimiento.Cantidad;
                                costoAcumulado += costoMovimiento;
                                costoUnitarioPromedio = costoAcumulado / cantidadAcumulada;

                                //Se graba el costo del movimiento
                                var costoProduccionMovimientodb = new CostoProduccionMovimiento
                                {
                                    CostoProduccionId = costoProduccion.CostoProduccionId,
                                    KardexMovimientoId = kardexMovimiento.KardexMovimientoId,
                                    CostoMp = costoMovimiento,
                                    CostoUnitario = costoUnitarioMovimiento,
                                    CostoUnitarioPromedio = costoUnitarioPromedio
                                };
                                context.CostoProduccionMovimientos.Add(costoProduccionMovimientodb);
                                context.SaveChanges();
                            }
                            else
                            {
                                costoMovimiento = costoProduccionMovimiento.Costo;
                                costoUnitarioMovimiento = costoProduccionMovimiento.CostoUnitario;
                                costoAcumulado += costoProduccionMovimiento.Costo;
                                costoUnitarioPromedio = costoAcumulado / cantidadAcumulada;
                                
                                //Se valida que coincidan los costos promedios por si hubo cambios
                                if (costoUnitarioPromedio != costoProduccionMovimiento.CostoUnitarioPromedio)
                                {
                                    costoProduccionMovimiento.CostoUnitarioPromedio = costoUnitarioPromedio;
                                    context.Entry(costoProduccionMovimiento).State = EntityState.Modified;
                                    context.SaveChanges();
                                }
                            }
                            break;

                        case "SAL":
                            cantidadAcumulada -= kardexMovimiento.Cantidad;
                            cantidadAcumuladaEntrada += kardexMovimiento.Cantidad;
                            costoMovimiento = costoUnitarioPromedio * kardexMovimiento.Cantidad;
                            costoUnitarioMovimiento = costoUnitarioPromedio;
                            costoAcumulado -= costoMovimiento;

                            if (costoProduccionMovimiento == null)
                            {
                                //Se graba el costo del movimiento
                                var costoProduccionMovimientodb = new CostoProduccionMovimiento
                                {
                                    CostoProduccionId = costoProduccion.CostoProduccionId,
                                    KardexMovimientoId = kardexMovimiento.KardexMovimientoId,
                                    CostoMp = costoMovimiento,
                                    CostoUnitario = costoUnitarioMovimiento,
                                    CostoUnitarioPromedio = costoUnitarioPromedio
                                };
                                context.CostoProduccionMovimientos.Add(costoProduccionMovimientodb);
                                context.SaveChanges();
                            }
                            else
                            {
                                //Se valida que coincidan los costos promedios por si hubo cambios
                                if (costoUnitarioPromedio != costoProduccionMovimiento.CostoUnitarioPromedio)
                                {
                                    costoProduccionMovimiento.CostoMp = costoMovimiento;
                                    costoProduccionMovimiento.CostoUnitario = costoUnitarioMovimiento;
                                    costoProduccionMovimiento.CostoUnitarioPromedio = costoUnitarioPromedio;
                                    context.Entry(costoProduccionMovimiento).State = EntityState.Modified;
                                    context.SaveChanges();
                                }
                            }
                            break;
                    }
                }
            }
        }

        private double CosteoKardexMovimiento(Common.Models.Contabilidad.CostoProduccion costoProduccion, KardexMovimiento kardexMovimiento, ApplicationDbContext context)
        {
            double costoMovimientoDetalle = 0;
            switch (kardexMovimiento.TipoMovimiento.Codigo)
            {
                case "ENT":
                    var recepcion = context.RecepcionDetalles
                        .FirstOrDefault(o => o.RecepcionDetalleId == kardexMovimiento.RecepcionDetalleId)
                        .Recepcion;
                    //Orden de Produccion
                    if (!string.IsNullOrEmpty(recepcion.OrdenProduccionId))
                    {
                        var ordenProduccion = context.OrdenProduccions
                            .Where(o => o.OrdenProduccionId == recepcion.OrdenProduccionId)
                            .FirstOrDefault();
                        costoMovimientoDetalle = CosteoOrdenProduccion(costoProduccion, ordenProduccion, context);
                    }
                    //Compra
                    if (!string.IsNullOrEmpty(recepcion.CompraId))
                    {
                        var compraDetalle = context.CompraDetalles
                            .Where(o => o.CompraDetalleId == kardexMovimiento.RecepcionDetalle.CompraDetalleId)
                            .FirstOrDefault();
                        costoMovimientoDetalle = compraDetalle.PrecioTotal;
                    }
                    break;
                case "SAL":
                    CosteaMercaderia(costoProduccion, kardexMovimiento.MercaderiaId, fechaInicioDateTimePicker.Value, kardexMovimiento.Fecha);
                    costoMovimientoDetalle = context.CostoProduccionMovimientos
                        .FirstOrDefault(o => o.KardexMovimientoId == kardexMovimiento.KardexMovimientoId)
                        .Costo;
                    break;
            }
            return costoMovimientoDetalle;
        }

        private double CosteoOrdenProduccion(Common.Models.Contabilidad.CostoProduccion costoProduccion, OrdenProduccion ordenProduccion, ApplicationDbContext context)
        {
            double costeoOrdenProduccion = 0;
            foreach (var ordenProduccionInsumo in ordenProduccion.OrdenProduccionInsumos)
            {
                var kardexMovimientoId = (from rd in context.RecepcionDetalles
                                         join km in context.KardexMovimientos on rd.RecepcionDetalleId equals km.RecepcionDetalleId
                                         where rd.OrdenProduccionInsumoId == ordenProduccionInsumo.OrdenProduccionInsumoId
                                         select km.KardexMovimientoId)
                                         .FirstOrDefault();
                var costoProduccionMovimiento = context.CostoProduccionMovimientos
                    .Where(o => o.KardexMovimientoId == kardexMovimientoId)
                    .FirstOrDefault();

                if (costoProduccionMovimiento != null)
                    costeoOrdenProduccion += costoProduccionMovimiento.Costo;
                else
                {
                    var kardexMovimiento = context.KardexMovimientos.FirstOrDefault(o => o.KardexMovimientoId == kardexMovimientoId);
                    costeoOrdenProduccion += CosteoKardexMovimiento(costoProduccion, kardexMovimiento, context);
                }
            }

            return costeoOrdenProduccion;
        }

        private void ProcesaInsumos(Common.Models.Contabilidad.CostoProduccion costoProduccion, DateTime fechaInicio, DateTime fechaFin)
        {
            using (var context = new ApplicationDbContext())
            {
                var tipoMercaderia = context.TipoMercaderias
                    .Where(o => o.Codigo == "INS")
                    .FirstOrDefault();
                var mercaderias = (from k in context.KardexMovimientos
                                        where k.Mercaderia.TipoMercaderiaId == tipoMercaderia.TipoMercaderiaId
                                            && k.Fecha >= fechaInicio && k.Fecha <= fechaFin
                                        group k by k.MercaderiaId into g
                                        select g.FirstOrDefault().Mercaderia).ToList();

                foreach (var mercaderia in mercaderias)
                {
                    CosteaMercaderia(costoProduccion, mercaderia.MercaderiaId, fechaInicio, fechaFin);
                }
            }
        }

        private void ProcesaIntermedios(DateTime fechaInicio, DateTime fechaFin)
        {
            throw new NotImplementedException();
        }

        private void ProcesaTerminados(DateTime fechaInicio, DateTime fechaFin)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
