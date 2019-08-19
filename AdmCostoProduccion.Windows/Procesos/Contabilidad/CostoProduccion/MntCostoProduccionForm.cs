using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Data;
using AdmCostoProduccion.Common.Forms;
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
    public partial class MntCostoProduccionForm : BaseForm
    {
        #region Propiedades
        private CostoProduccionViewModel ViewModel = new CostoProduccionViewModel();
        private ObservableListSource<CostoProduccionViewModel> ViewModelList;
        private List<PlantaFabricacionViewModel> plantaFabricacionViewModels;
        private List<ConfiguracionValorizacionViewModel> configuracionValorizacionViewModels;
        #endregion

        #region Constructor
        public MntCostoProduccionForm(CostoProduccionViewModel viewModel
            , ObservableListSource<CostoProduccionViewModel> viewModelList)
            :base(false)
        {
            InitializeComponent();
            ViewModel.CopyOf(viewModel);
            ViewModelList = viewModelList;
            costoProduccionViewModelBindingSource.DataSource = ViewModel;
            //
            CargarCombos();
        }

        public MntCostoProduccionForm(ObservableListSource<CostoProduccionViewModel> viewModelList)
            :base(true)
        {
            InitializeComponent();
            ViewModel = new CostoProduccionViewModel();
            ViewModelList = viewModelList;
            costoProduccionViewModelBindingSource.DataSource = ViewModel;
            //
            CargarCombos();
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

        private void CargarCombos()
        {
            ApplicationDbContext context = new ApplicationDbContext();
            //
            var plantaFabricacions = context.PlantaFabricacions.ToList();
            plantaFabricacionViewModels = new List<PlantaFabricacionViewModel>();
            foreach (var plantaFabricacion in plantaFabricacions)
            {
                plantaFabricacionViewModels.Add(new PlantaFabricacionViewModel(plantaFabricacion));
            }
            plantaFabricacionViewModelBindingSource.DataSource = plantaFabricacionViewModels;
            if (!IsNew)
            {
                var plantaFabricacionViewModel = plantaFabricacionViewModels
                    .Where(o => o.PlantaFabricacionId == ViewModel.PlantaFabricacionId)
                    .FirstOrDefault();
                plantaFabricacionComboBox.SelectedItem = plantaFabricacionViewModel;
            }
            //
            var configuracionValorizacions = context.ConfiguracionValorizacions.ToList();
            configuracionValorizacionViewModels = new List<ConfiguracionValorizacionViewModel>();
            foreach (var configuracionValorizacion in configuracionValorizacions)
            {
                configuracionValorizacionViewModels.Add(new ConfiguracionValorizacionViewModel(configuracionValorizacion));
            }
            configuracionValorizacionViewModelBindingSource.DataSource = configuracionValorizacionViewModels;
            if (!IsNew)
            {
                var configuracionValorizacionViewModel = configuracionValorizacionViewModels
                    .Where(o => o.ConfiguracionValorizacionId == ViewModel.ConfiguracionValorizacionId)
                    .FirstOrDefault();
                configuracionValorizacionComboBox.SelectedItem = configuracionValorizacionViewModel;
            }
        }

        private void BuscarAgregarOrdenes()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            var plantaFabricacionViewModel = (PlantaFabricacionViewModel)plantaFabricacionViewModelBindingSource.Current;
            var ordenProduccions = context.OrdenProduccions
                .Where(o => o.PlantaFabricacionId == plantaFabricacionViewModel.PlantaFabricacionId
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
                costoOrdenProduccionViewModel.CodigoMercaderia = ordenProduccion.Mercaderia.Codigo;
                costoOrdenProduccionViewModel.NombreMercaderia = ordenProduccion.Mercaderia.Nombre;
                costoOrdenProduccionViewModel.ProcedimientoProduccion = ordenProduccion.ProcedimientoProduccion.Nombre;
                costoOrdenProduccionViewModel.UnidadMedida = ordenProduccion.UnidadMedida.Nombre;
                costoOrdenProduccionViewModel.Cantidad = ordenProduccion.Cantidad;

                ViewModel.CostoOrdenProduccionViewModels.Add(costoOrdenProduccionViewModel);
            }

        }
        #endregion
    }
}
