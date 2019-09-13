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

namespace AdmCostoProduccion.Windows.Mantenimiento.Contabilidad.MetodoValorizacion
{
    public partial class MntMetodoValorizacionForm : KryptonForm
    {
        #region Propiedades
        private MetodoValorizacionViewModel ViewModel = new MetodoValorizacionViewModel();
        private ObservableListSource<MetodoValorizacionViewModel> ViewModelList;
        #endregion

        #region Constructor
        public MntMetodoValorizacionForm(MetodoValorizacionViewModel viewModel
            , ObservableListSource<MetodoValorizacionViewModel> viewModelList)
        {
            InitializeComponent();
            ViewModel = new MetodoValorizacionViewModel();
            ViewModel.CopyOf(viewModel);
            ViewModelList = viewModelList;
            metodoValorizacionViewModelBindingSource.DataSource = ViewModel;
        }

        public MntMetodoValorizacionForm(ObservableListSource<MetodoValorizacionViewModel> viewModelList)
        {
            InitializeComponent();
            ViewModel = new MetodoValorizacionViewModel();
            ViewModelList = viewModelList;
            metodoValorizacionViewModelBindingSource.DataSource = ViewModel;
        }
        #endregion

        #region Eventos de Formulario
        private void GrabarButton_Click(object sender, EventArgs e)
        {
            Grabar();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            metodoValorizacionViewModelBindingSource.CancelEdit();
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
                metodoValorizacionViewModelBindingSource.EndEdit();
                ViewModel.Grabar();
                if (IsNew) ViewModelList.Add(ViewModel);
                else
                {
                    var viewModel = ViewModelList
                        .Where(o => o.MetodoValorizacionId == ViewModel.MetodoValorizacionId)
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
