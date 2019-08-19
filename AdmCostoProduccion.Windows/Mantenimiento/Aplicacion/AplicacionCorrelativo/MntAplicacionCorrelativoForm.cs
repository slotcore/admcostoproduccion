using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.ViewModels.Aplicacion;
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

namespace AdmCostoProduccion.Windows.Mantenimiento.Aplicacion.AplicacionCorrelativo
{
    public partial class MntAplicacionCorrelativoForm : KryptonForm
    {
        #region Propiedades
        private AplicacionCorrelativoViewModel ViewModel = new AplicacionCorrelativoViewModel();
        private ObservableListSource<AplicacionCorrelativoViewModel> ViewModelList;
        #endregion

        #region Constructor
        public MntAplicacionCorrelativoForm(AplicacionCorrelativoViewModel viewModel
            , ObservableListSource<AplicacionCorrelativoViewModel> viewModelList)
        {
            InitializeComponent();
            ViewModel.CopyOf(viewModel);
            ViewModelList = viewModelList;
            aplicacionCorrelativoViewModelBindingSource.DataSource = ViewModel;
        }

        public MntAplicacionCorrelativoForm(ObservableListSource<AplicacionCorrelativoViewModel> viewModelList)
        {
            InitializeComponent();
            ViewModel = new AplicacionCorrelativoViewModel();
            ViewModelList = viewModelList;
            aplicacionCorrelativoViewModelBindingSource.DataSource = ViewModel;
        }
        #endregion

        #region Eventos de Formulario
        private void GrabarButton_Click(object sender, EventArgs e)
        {
            Grabar();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            aplicacionCorrelativoViewModelBindingSource.CancelEdit();
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
                aplicacionCorrelativoViewModelBindingSource.EndEdit();
                ViewModel.Grabar();
                if (IsNew) ViewModelList.Add(ViewModel);
                else
                {
                    var viewModel = ViewModelList
                        .Where(o => o.AplicacionCorrelativoId == ViewModel.AplicacionCorrelativoId)
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
