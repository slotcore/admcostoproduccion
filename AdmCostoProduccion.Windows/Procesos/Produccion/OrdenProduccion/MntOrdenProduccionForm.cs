using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Data;
using AdmCostoProduccion.Common.Forms;
using AdmCostoProduccion.Common.ViewModels.Inventario;
using AdmCostoProduccion.Common.ViewModels.Maestro;
using AdmCostoProduccion.Common.ViewModels.Produccion;
using AdmCostoProduccion.Windows.Prompt;
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

namespace AdmCostoProduccion.Windows.Procesos.Produccion.OrdenProduccion
{
    public partial class MntOrdenProduccionForm : BaseForm
    {
        #region Propiedades
        private OrdenProduccionViewModel ViewModel = new OrdenProduccionViewModel();
        private ObservableListSource<OrdenProduccionViewModel> ViewModelList;
        private List<PlantaFabricacionViewModel> plantaFabricacionViewModels;
        private List<UnidadMedidaViewModel> unidadMedidaViewModels;
        private List<ProcedimientoProduccionViewModel> procedimientoProduccionViewModels;
        #endregion

        #region Constructor
        public MntOrdenProduccionForm(OrdenProduccionViewModel viewModel
            , ObservableListSource<OrdenProduccionViewModel> viewModelList)
            :base(false)
        {
            InitializeComponent();
            ViewModel.CopyOf(viewModel);
            ViewModelList = viewModelList;
            ordenProduccionViewModelBindingSource.DataSource = ViewModel;
            //
            CargarCombos();
        }

        public MntOrdenProduccionForm(ObservableListSource<OrdenProduccionViewModel> viewModelList)
            :base(true)
        {
            InitializeComponent();
            ViewModel = new OrdenProduccionViewModel();
            ViewModelList = viewModelList;
            ordenProduccionViewModelBindingSource.DataSource = ViewModel;
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
            ordenProduccionViewModelBindingSource.CancelEdit();
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

        private void BuscarMercaderiaButton_Click(object sender, EventArgs e)
        {
            BuscarMercaderia();
        }
        #endregion

        #region Eventos Privados

        private void Grabar()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                ordenProduccionViewModelBindingSource.EndEdit();
                var plantaFabricacion = (PlantaFabricacionViewModel)plantaFabricacionViewModelBindingSource.Current;
                var unidadMedida = (UnidadMedidaViewModel)unidadMedidaViewModelBindingSource.Current;
                var procedimientoProduccion = (ProcedimientoProduccionViewModel)procedimientoProduccionViewModelBindingSource.Current;

                if (plantaFabricacion == null) throw new Exception("Debe de seleccionar planta de fabricación");
                if (unidadMedida == null) throw new Exception("Debe de seleccionar unidad de medida");
                if (procedimientoProduccion == null) throw new Exception("Debe de seleccionar procedimiento de producción");

                ViewModel.PlantaFabricacionId = plantaFabricacion.PlantaFabricacionId;
                ViewModel.PlantaFabricacion = plantaFabricacion.Nombre;
                ViewModel.UnidadMedidaId = unidadMedida.UnidadMedidaId;
                ViewModel.UnidadMedida = unidadMedida.Nombre;
                ViewModel.ProcedimientoProduccionId = procedimientoProduccion.ProcedimientoProduccionId;
                ViewModel.ProcedimientoProduccion = procedimientoProduccion.Nombre;
                ViewModel.Grabar();

                if (IsNew) ViewModelList.Add(ViewModel);
                else
                {
                    var viewModel = ViewModelList
                        .Where(o => o.OrdenProduccionId == ViewModel.OrdenProduccionId)
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
                var frm = new MntOrdenProduccionInsumoForm(ViewModel.OrdenProduccionId, ViewModel.OrdenProduccionInsumoViewModels);
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
                var viewModel = (OrdenProduccionInsumoViewModel)ordenProduccionInsumoViewModelsBindingSource.Current;
                var frm = new MntOrdenProduccionInsumoForm(viewModel, ViewModel.OrdenProduccionInsumoViewModels);
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
                    var viewModelDetail = (OrdenProduccionInsumoViewModel)ordenProduccionInsumoViewModelsBindingSource.Current;
                    ViewModel.OrdenProduccionInsumoViewModels.RemoveItem(viewModelDetail);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Ocurrió un error al eliminar el registro, mensaje de error: {0}", ex.Message)
                    , "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuscarMercaderia()
        {
            try
            {
                var formprompt = new MercaderiaPromptForm(mercaderiaTextBox.Text);
                if (formprompt.ShowDialog() == DialogResult.OK)
                {
                    var mercaderiaViewModel = formprompt.MercaderiaViewModel;
                    ViewModel.CodigoMercaderia = mercaderiaViewModel.Codigo;
                    ViewModel.NombreMercaderia = mercaderiaViewModel.Nombre;
                    ViewModel.MercaderiaId = mercaderiaViewModel.MercaderiaId;
                    CargarProcedimientos();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message
                    , "Buscar Mercadería", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
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
                var plantaFabricacion = plantaFabricacions
                    .Where(o => o.PlantaFabricacionId == ViewModel.PlantaFabricacionId)
                    .FirstOrDefault();
                plantaFabricacionIdComboBox.SelectedItem = plantaFabricacion;
            }
            //
            var unidadMedidas = context.UnidadMedidas.ToList();
            unidadMedidaViewModels = new List<UnidadMedidaViewModel>();
            foreach (var unidadMedida in unidadMedidas)
            {
                unidadMedidaViewModels.Add(new UnidadMedidaViewModel(unidadMedida));
            }
            unidadMedidaViewModelBindingSource.DataSource = unidadMedidaViewModels;
            if (!IsNew)
            {
                var unidadMedida = unidadMedidas
                    .Where(o => o.UnidadMedidaId == ViewModel.UnidadMedidaId)
                    .FirstOrDefault();
                unidadMedidaIdComboBox.SelectedItem = unidadMedida;
            }
            //
            if (!IsNew)
            {
                CargarProcedimientos();
            }
        }

        private void CargarProcedimientos()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            procedimientoProduccionViewModelBindingSource.DataSource = null;
            var procedimientoProduccions = context.ProcedimientoProduccions
                .Where(o => o.MercaderiaId == ViewModel.MercaderiaId)
                .ToList();
            if (procedimientoProduccions.Count == 0)
                throw new Exception("La mercaderia no tiene procedimiento de producción");

            procedimientoProduccionViewModels = new List<ProcedimientoProduccionViewModel>();
            foreach (var procedimientoProduccion in procedimientoProduccions)
            {
                procedimientoProduccionViewModels.Add(new ProcedimientoProduccionViewModel(procedimientoProduccion));
            }
            procedimientoProduccionViewModelBindingSource.DataSource = procedimientoProduccionViewModels;            
            if (!IsNew)
            {
                var procedimientoProduccion = procedimientoProduccions
                    .Where(o => o.ProcedimientoProduccionId == ViewModel.ProcedimientoProduccionId)
                    .FirstOrDefault();
                procedimientoProduccionIdComboBox.SelectedItem = procedimientoProduccion;
            }
        }
        #endregion
    }
}
