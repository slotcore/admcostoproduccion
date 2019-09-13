using AdmCostoProduccion.Common.Classes;
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

namespace AdmCostoProduccion.Windows.Mantenimiento.Contabilidad.DistribucionValorizacion
{
    public partial class MntDistribucionValorizacionForm : KryptonForm
    {
        #region Propiedades
        private DistribucionValorizacionViewModel ViewModel = new DistribucionValorizacionViewModel();
        private ObservableListSource<DistribucionValorizacionViewModel> ViewModelList;
        #endregion

        #region Constructor
        public MntDistribucionValorizacionForm(DistribucionValorizacionViewModel viewModel
            , ObservableListSource<DistribucionValorizacionViewModel> viewModelList)
        {
            InitializeComponent();
            ViewModel = new DistribucionValorizacionViewModel();
            ViewModel.CopyOf(viewModel);
            ViewModelList = viewModelList;
            distribucionValorizacionViewModelBindingSource.DataSource = ViewModel;
        }

        public MntDistribucionValorizacionForm(ObservableListSource<DistribucionValorizacionViewModel> viewModelList)
        {
            InitializeComponent();
            ViewModel = new DistribucionValorizacionViewModel();
            ViewModelList = viewModelList;
            distribucionValorizacionViewModelBindingSource.DataSource = ViewModel;
        }
        #endregion

        #region Eventos de Formulario
        private void GrabarButton_Click(object sender, EventArgs e)
        {
            Grabar();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            distribucionValorizacionViewModelBindingSource.CancelEdit();
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
                distribucionValorizacionViewModelBindingSource.EndEdit();
                ViewModel.Grabar();
                if (IsNew) ViewModelList.Add(ViewModel);
                else
                {
                    var viewModel = ViewModelList
                        .Where(o => o.DistribucionValorizacionId == ViewModel.DistribucionValorizacionId)
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
        #endregion
    }
}
