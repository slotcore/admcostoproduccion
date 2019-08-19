using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.ViewModels.Contabilidad;
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

namespace AdmCostoProduccion.Windows.Procesos.Contabilidad.CostoProduccion
{
    public partial class MntCostoOrdenProduccionForm : KryptonForm
    {
        #region Propiedades
        private CostoOrdenProduccionViewModel ViewModel;
        private ObservableListSource<CostoOrdenProduccionViewModel> ViewModelList;
        #endregion

        #region Constructor
        public MntCostoOrdenProduccionForm(CostoOrdenProduccionViewModel viewModel
            , ObservableListSource<CostoOrdenProduccionViewModel> viewModelList)
        {
            InitializeComponent();
            ViewModel.CopyOf(viewModel);
            ViewModelList = viewModelList;
            costoOrdenProduccionViewModelBindingSource.DataSource = ViewModel;
        }

        public MntCostoOrdenProduccionForm(string parentId, ObservableListSource<CostoOrdenProduccionViewModel> viewModelList)
        {
            InitializeComponent();
            ViewModel = new CostoOrdenProduccionViewModel(parentId);
            ViewModelList = viewModelList;
            costoOrdenProduccionViewModelBindingSource.DataSource = ViewModel;
        }
        #endregion

        #region Eventos de Formulario
        private void GrabarButton_Click(object sender, EventArgs e)
        {
            Grabar();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            costoOrdenProduccionViewModelBindingSource.CancelEdit();
            this.Close();
        }

        private void BuscarOrdenProduccionButton_Click(object sender, EventArgs e)
        {
            BuscarOrdenProduccion();
        }
        #endregion

        #region Eventos Privados

        private void Grabar()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                costoOrdenProduccionViewModelBindingSource.EndEdit();

                if (ViewModel.IsNew) ViewModelList.Add(ViewModel);
                else
                {
                    var viewModel = ViewModelList
                        .Where(o => o.CostoOrdenProduccionId == ViewModel.CostoOrdenProduccionId)
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

        private void BuscarOrdenProduccion()
        {
            try
            {
                var formprompt = new OrdenProduccionPromptForm(ordenProduccionTextBox.Text);
                if (formprompt.ShowDialog() == DialogResult.OK)
                {
                    var ordenProduccionViewModel = formprompt.OrdenProduccionViewModel;
                    ViewModel.OrdenProduccionId = ordenProduccionViewModel.OrdenProduccionId;
                    ViewModel.OrdenProduccion = ordenProduccionViewModel.Codigo;
                    ViewModel.CodigoMercaderia = ordenProduccionViewModel.CodigoMercaderia;
                    ViewModel.NombreMercaderia = ordenProduccionViewModel.NombreMercaderia;
                    ViewModel.ProcedimientoProduccion = ordenProduccionViewModel.ProcedimientoProduccion;
                    ViewModel.UnidadMedida = ordenProduccionViewModel.UnidadMedida;
                    ViewModel.Cantidad = ordenProduccionViewModel.Cantidad;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Ocurrió un error al buscar, error: {0}", ex.Message)
                    , "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
        #endregion
    }
}
