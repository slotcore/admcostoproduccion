using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Data;
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

namespace AdmCostoProduccion.Windows.Mantenimiento.Maestro.PlantaFabricacion
{
    public partial class MntPlantaFabricacionForm : KryptonForm
    {
        #region Propiedades
        private PlantaFabricacionViewModel ViewModel = new PlantaFabricacionViewModel();
        private ObservableListSource<PlantaFabricacionViewModel> ViewModelList;
        private List<CentroLogisticoViewModel> centroLogisticoViewModels;
        #endregion

        #region Constructor
        public MntPlantaFabricacionForm(PlantaFabricacionViewModel viewModel
            , ObservableListSource<PlantaFabricacionViewModel> viewModelList)
        {
            InitializeComponent();
            ViewModel = new PlantaFabricacionViewModel();
            ViewModel.CopyOf(viewModel);
            ViewModelList = viewModelList;
            plantaFabricacionViewModelBindingSource.DataSource = ViewModel;
            CargarCombos();
        }

        public MntPlantaFabricacionForm(ObservableListSource<PlantaFabricacionViewModel> viewModelList)
        {
            InitializeComponent();
            ViewModel = new PlantaFabricacionViewModel();
            ViewModelList = viewModelList;
            plantaFabricacionViewModelBindingSource.DataSource = ViewModel;
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
            plantaFabricacionViewModelBindingSource.CancelEdit();
            this.Close();
        }
        #endregion

        #region Eventos Privados

        private void Grabar()
        {
            try
            {
                bool IsNew = ViewModel.IsNew;
                Cursor = Cursors.WaitCursor;
                plantaFabricacionViewModelBindingSource.EndEdit();

                CentroLogisticoViewModel centroLogisticoViewModel
                    = (CentroLogisticoViewModel)centroLogisticoViewModelBindingSource.Current;
                if (centroLogisticoViewModel == null)
                    throw new Exception("Debe seleccionar un Centro Logistico");
                ViewModel.CentroLogisticoId = centroLogisticoViewModel.CentroLogisticoId;
                ViewModel.CentroLogistico = centroLogisticoViewModel.Nombre;

                ViewModel.Grabar();
                if (IsNew) ViewModelList.Add(ViewModel);
                else
                {
                    var viewModel = ViewModelList
                        .Where(o => o.PlantaFabricacionId == ViewModel.PlantaFabricacionId)
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

        private void CargarCombos()
        {
            using (var context = new ApplicationDbContext())
            {
                var centroLogisticos = context.CentroLogisticos.ToList();
                centroLogisticoViewModels = new List<CentroLogisticoViewModel>();
                foreach (var centroLogistico in centroLogisticos)
                {
                    centroLogisticoViewModels.Add(new CentroLogisticoViewModel(centroLogistico));
                }
                centroLogisticoViewModelBindingSource.DataSource = centroLogisticoViewModels;
                if (!string.IsNullOrEmpty(ViewModel.CentroLogisticoId))
                {
                    CentroLogisticoViewModel centroLogisticoViewModel = centroLogisticoViewModels
                        .Where(o => o.CentroLogisticoId == ViewModel.CentroLogisticoId)
                        .FirstOrDefault();
                    centroLogisticoIdComboBox.SelectedItem = centroLogisticoViewModel;
                }
            }
        }
        #endregion
    }
}
