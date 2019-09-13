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

namespace AdmCostoProduccion.Windows.Mantenimiento.Maestro.Almacen
{
    public partial class MntAlmacenForm : KryptonForm
    {
        #region Propiedades
        private AlmacenViewModel ViewModel = new AlmacenViewModel();
        private ObservableListSource<AlmacenViewModel> ViewModelList;
        private List<CentroLogisticoViewModel> centroLogisticoViewModels;
        #endregion

        #region Constructor
        public MntAlmacenForm(AlmacenViewModel viewModel
            , ObservableListSource<AlmacenViewModel> viewModelList)
        {
            InitializeComponent();
            ViewModel = new AlmacenViewModel();
            ViewModel.CopyOf(viewModel);
            ViewModelList = viewModelList;
            almacenViewModelBindingSource.DataSource = ViewModel;
        }

        public MntAlmacenForm(ObservableListSource<AlmacenViewModel> viewModelList)
        {
            InitializeComponent();
            ViewModel = new AlmacenViewModel();
            ViewModelList = viewModelList;
            almacenViewModelBindingSource.DataSource = ViewModel;
        }
        #endregion

        #region Eventos de Formulario
        private void GrabarButton_Click(object sender, EventArgs e)
        {
            Grabar();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            almacenViewModelBindingSource.CancelEdit();
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
                almacenViewModelBindingSource.EndEdit();

                CentroLogisticoViewModel centroLogisticoViewModel
                    = (CentroLogisticoViewModel)centroLogisticoViewModelBindingSource.Current;
                if (centroLogisticoViewModel == null)
                    throw new Exception("Debe seleccionar un centro logístico");
                ViewModel.CentroLogisticoId = centroLogisticoViewModel.CentroLogisticoId;
                ViewModel.CentroLogistico = centroLogisticoViewModel.Nombre;

                ViewModel.Grabar();
                if (IsNew) ViewModelList.Add(ViewModel);
                else
                {
                    var viewModel = ViewModelList
                        .Where(o => o.AlmacenId == ViewModel.AlmacenId)
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
