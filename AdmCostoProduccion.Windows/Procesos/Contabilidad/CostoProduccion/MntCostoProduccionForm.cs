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
    public partial class MntCostoProduccionForm : KryptonForm
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
        {
            InitializeComponent();
            ViewModel.CopyOf(viewModel);
            ViewModelList = viewModelList;
            costoProduccionViewModelBindingSource.DataSource = ViewModel;
            //
            CargarCombos();
        }

        public MntCostoProduccionForm(ObservableListSource<CostoProduccionViewModel> viewModelList)
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
        #endregion

        #region Eventos Privados

        private void Grabar()
        {
            try
            {
                bool IsNew = ViewModel.IsNew;
                Cursor = Cursors.WaitCursor;
                costoProduccionViewModelBindingSource.EndEdit();
                
                PlantaFabricacionViewModel plantaFabricacionViewModel
                    = (PlantaFabricacionViewModel)plantaFabricacionViewModelBindingSource.Current;
                if (plantaFabricacionViewModel == null)
                    throw new Exception("Debe seleccionar una planta");
                ViewModel.PlantaFabricacionId = plantaFabricacionViewModel.PlantaFabricacionId;
                ViewModel.PlantaFabricacion = plantaFabricacionViewModel.Nombre;

                ConfiguracionValorizacionViewModel configuracionValorizacionViewModel
                    = (ConfiguracionValorizacionViewModel)configuracionValorizacionViewModelBindingSource.Current;
                if (configuracionValorizacionViewModel == null)
                    throw new Exception("Debe seleccionar una configuración");
                ViewModel.ConfiguracionValorizacionId = configuracionValorizacionViewModel.ConfiguracionValorizacionId;
                ViewModel.ConfiguracionValorizacion = configuracionValorizacionViewModel.Nombre;

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

        private void CargarCombos()
        {
            using (var context = new ApplicationDbContext())
            {
                //
                var plantaFabricacions = context.PlantaFabricacions.ToList();
                plantaFabricacionViewModels = new List<PlantaFabricacionViewModel>();
                foreach (var plantaFabricacion in plantaFabricacions)
                {
                    plantaFabricacionViewModels.Add(new PlantaFabricacionViewModel(plantaFabricacion));
                }
                plantaFabricacionViewModelBindingSource.DataSource = plantaFabricacionViewModels;
                if (!string.IsNullOrEmpty(ViewModel.PlantaFabricacionId))
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
                if (!string.IsNullOrEmpty(ViewModel.ConfiguracionValorizacionId))
                {
                    var configuracionValorizacionViewModel = configuracionValorizacionViewModels
                        .Where(o => o.ConfiguracionValorizacionId == ViewModel.ConfiguracionValorizacionId)
                        .FirstOrDefault();
                    configuracionValorizacionComboBox.SelectedItem = configuracionValorizacionViewModel;
                }
            }
        }

        #endregion
    }
}
