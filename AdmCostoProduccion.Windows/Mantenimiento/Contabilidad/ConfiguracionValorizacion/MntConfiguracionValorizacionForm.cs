using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Data;
using AdmCostoProduccion.Common.ViewModels.Contabilidad;
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

namespace AdmCostoProduccion.Windows.Mantenimiento.Contabilidad.ConfiguracionValorizacion
{
    public partial class MntConfiguracionValorizacionForm : KryptonForm
    {
        #region Propiedades
        private ConfiguracionValorizacionViewModel ViewModel = new ConfiguracionValorizacionViewModel();
        private ObservableListSource<ConfiguracionValorizacionViewModel> ViewModelList;
        private List<MetodoValorizacionViewModel> metodoValorizacionViewModels;
        private List<DistribucionValorizacionViewModel> distribucionValorizacionViewModels;
        #endregion

        #region Constructor
        public MntConfiguracionValorizacionForm(ConfiguracionValorizacionViewModel viewModel
            , ObservableListSource<ConfiguracionValorizacionViewModel> viewModelList)
        {
            InitializeComponent();
            ViewModel = new ConfiguracionValorizacionViewModel();
            ViewModel.CopyOf(viewModel);
            ViewModelList = viewModelList;
            configuracionValorizacionViewModelBindingSource.DataSource = ViewModel;
            CargarCombos();
        }

        public MntConfiguracionValorizacionForm(ObservableListSource<ConfiguracionValorizacionViewModel> viewModelList)
        {
            InitializeComponent();
            ViewModel = new ConfiguracionValorizacionViewModel();
            ViewModelList = viewModelList;
            configuracionValorizacionViewModelBindingSource.DataSource = ViewModel;
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
            configuracionValorizacionViewModelBindingSource.CancelEdit();
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
                configuracionValorizacionViewModelBindingSource.EndEdit();

                MetodoValorizacionViewModel metodoValorizacionViewModel
                    = (MetodoValorizacionViewModel)metodoValorizacionViewModelBindingSource.Current;
                if (metodoValorizacionViewModel == null)
                    throw new Exception("Debe seleccionar un método de valorización");
                ViewModel.MetodoValorizacionId = metodoValorizacionViewModel.MetodoValorizacionId;
                ViewModel.MetodoValorizacion = metodoValorizacionViewModel.Nombre;

                DistribucionValorizacionViewModel distribucionValorizacionViewModel
                    = (DistribucionValorizacionViewModel)distribucionValorizacionViewModelBindingSource.Current;
                if (distribucionValorizacionViewModel == null)
                    throw new Exception("Debe seleccionar una distribución de valorización");
                ViewModel.DistribucionValorizacionId = distribucionValorizacionViewModel.DistribucionValorizacionId;
                ViewModel.DistribucionValorizacion = distribucionValorizacionViewModel.Nombre;

                ViewModel.Grabar();
                if (IsNew) ViewModelList.Add(ViewModel);
                else
                {
                    var viewModel = ViewModelList
                        .Where(o => o.ConfiguracionValorizacionId == ViewModel.ConfiguracionValorizacionId)
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
                var metodoValorizacions = context.MetodoValorizacions.ToList();
                metodoValorizacionViewModels = new List<MetodoValorizacionViewModel>();
                foreach (var metodoValorizacion in metodoValorizacions)
                {
                    metodoValorizacionViewModels.Add(new MetodoValorizacionViewModel(metodoValorizacion));
                }
                metodoValorizacionViewModelBindingSource.DataSource = metodoValorizacionViewModels;
                if (!string.IsNullOrEmpty(ViewModel.MetodoValorizacionId))
                {
                    MetodoValorizacionViewModel metodoValorizacionViewModel = metodoValorizacionViewModels
                        .Where(o => o.MetodoValorizacionId == ViewModel.MetodoValorizacionId)
                        .FirstOrDefault();
                    metodoValorizacionComboBox.SelectedItem = metodoValorizacionViewModel;
                }

                var distribucionValorizacions = context.DistribucionValorizacions.ToList();
                distribucionValorizacionViewModels = new List<DistribucionValorizacionViewModel>();
                foreach (var distribucionValorizacion in distribucionValorizacions)
                {
                    distribucionValorizacionViewModels.Add(new DistribucionValorizacionViewModel(distribucionValorizacion));
                }
                distribucionValorizacionViewModelBindingSource.DataSource = distribucionValorizacionViewModels;
                if (!string.IsNullOrEmpty(ViewModel.DistribucionValorizacionId))
                {
                    DistribucionValorizacionViewModel distribucionValorizacionViewModel = distribucionValorizacionViewModels
                        .Where(o => o.DistribucionValorizacionId == ViewModel.DistribucionValorizacionId)
                        .FirstOrDefault();
                    distribucionValorizacionComboBox.SelectedItem = distribucionValorizacionViewModel;
                }
            }
        }
        #endregion
    }
}
