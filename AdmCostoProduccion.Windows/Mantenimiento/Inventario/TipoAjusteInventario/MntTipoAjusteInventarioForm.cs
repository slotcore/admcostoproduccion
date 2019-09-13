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

namespace AdmCostoProduccion.Windows.Mantenimiento.Inventario.TipoAjusteInventario
{
    public partial class MntTipoAjusteInventarioForm : KryptonForm
    {
        #region Propiedades
        private TipoAjusteInventarioViewModel ViewModel = new TipoAjusteInventarioViewModel();
        private ObservableListSource<TipoAjusteInventarioViewModel> ViewModelList;
        #endregion

        #region Constructor
        public MntTipoAjusteInventarioForm(TipoAjusteInventarioViewModel viewModel
            , ObservableListSource<TipoAjusteInventarioViewModel> viewModelList)
        {
            InitializeComponent();
            ViewModel = new TipoAjusteInventarioViewModel();
            ViewModel.CopyOf(viewModel);
            ViewModelList = viewModelList;
            tipoAjusteInventarioViewModelBindingSource.DataSource = ViewModel;
        }

        public MntTipoAjusteInventarioForm(ObservableListSource<TipoAjusteInventarioViewModel> viewModelList)
        {
            InitializeComponent();
            ViewModel = new TipoAjusteInventarioViewModel();
            ViewModelList = viewModelList;
            tipoAjusteInventarioViewModelBindingSource.DataSource = ViewModel;
        }
        #endregion

        #region Eventos de Formulario
        private void GrabarButton_Click(object sender, EventArgs e)
        {
            Grabar();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            tipoAjusteInventarioViewModelBindingSource.CancelEdit();
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
                tipoAjusteInventarioViewModelBindingSource.EndEdit();
                ViewModel.Grabar();
                if (IsNew) ViewModelList.Add(ViewModel);
                else
                {
                    var viewModel = ViewModelList
                        .Where(o => o.TipoAjusteInventarioId == ViewModel.TipoAjusteInventarioId)
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
