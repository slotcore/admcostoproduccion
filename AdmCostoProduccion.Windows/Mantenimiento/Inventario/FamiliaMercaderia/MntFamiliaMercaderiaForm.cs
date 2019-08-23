using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.ViewModels.Inventario;
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

namespace AdmCostoProduccion.Windows.Mantenimiento.Inventario.FamiliaMercaderia
{
    public partial class MntFamiliaMercaderiaForm : KryptonForm
    {
        #region Propiedades
        private FamiliaMercaderiaViewModel ViewModel = new FamiliaMercaderiaViewModel();
        private ObservableListSource<FamiliaMercaderiaViewModel> ViewModelList;
        #endregion

        #region Constructor
        public MntFamiliaMercaderiaForm(FamiliaMercaderiaViewModel viewModel
            , ObservableListSource<FamiliaMercaderiaViewModel> viewModelList)
        {
            InitializeComponent();
            ViewModel.CopyOf(viewModel);
            ViewModelList = viewModelList;
            familiaMercaderiaViewModelBindingSource.DataSource = ViewModel;
        }

        public MntFamiliaMercaderiaForm(ObservableListSource<FamiliaMercaderiaViewModel> viewModelList)
        {
            InitializeComponent();
            ViewModel = new FamiliaMercaderiaViewModel();
            ViewModelList = viewModelList;
            familiaMercaderiaViewModelBindingSource.DataSource = ViewModel;
        }
        #endregion

        #region Eventos de Formulario
        private void GrabarButton_Click(object sender, EventArgs e)
        {
            Grabar();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            familiaMercaderiaViewModelBindingSource.CancelEdit();
            this.Close();
        }
        #endregion

        #region Eventos Privados

        private void Grabar()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                familiaMercaderiaViewModelBindingSource.EndEdit();
                ViewModel.Grabar();
                if (ViewModel.IsNew) ViewModelList.Add(ViewModel);
                else
                {
                    var viewModel = ViewModelList
                        .Where(o => o.FamiliaMercaderiaId == ViewModel.FamiliaMercaderiaId)
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
