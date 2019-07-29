using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Data;
using AdmCostoProduccion.Common.ViewModels.CompraVenta;
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

namespace AdmCostoProduccion.Windows.Procesos.CompraVenta.Compra
{
    public partial class MntCompraForm : KryptonForm
    {
        #region Propiedades
        private CompraViewModel ViewModel = new CompraViewModel();
        private ObservableListSource<CompraViewModel> ViewModelList;
        private List<CentroLogisticoViewModel> centroLogisticoViewModels;
        #endregion

        #region Constructor
        public MntCompraForm(CompraViewModel viewModel
            , ObservableListSource<CompraViewModel> viewModelList)
        {
            InitializeComponent();
            ViewModel.CopyOf(viewModel);
            ViewModelList = viewModelList;
            compraViewModelBindingSource.DataSource = ViewModel;
            //
            CargarCombos();
        }

        public MntCompraForm(ObservableListSource<CompraViewModel> viewModelList)
        {
            InitializeComponent();
            ViewModel = new CompraViewModel();
            ViewModelList = viewModelList;
            compraViewModelBindingSource.DataSource = ViewModel;
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
            compraViewModelBindingSource.CancelEdit();
            this.Close();
        }

        private void AgregarDetalleButton_Click(object sender, EventArgs e)
        {
            AgregarDetalle();
        }

        private void ModificarDetalleButton_Click(object sender, EventArgs e)
        {
            ModificarDetalle();
        }

        private void EliminarDetalleButton_Click(object sender, EventArgs e)
        {
            EliminarDetalle();
        }
        #endregion

        #region Eventos Privados

        private void Grabar()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                bool IsNew = ViewModel.IsNew;
                compraViewModelBindingSource.EndEdit();
                var centroLogisticoViewModel = (CentroLogisticoViewModel)centroLogisticoViewModelBindingSource.Current;
                ViewModel.CentroLogisticoId = centroLogisticoViewModel.CentroLogisticoId;
                ViewModel.CentroLogistico = centroLogisticoViewModel.Nombre;
                ViewModel.Grabar();
                if (IsNew) ViewModelList.Add(ViewModel);
                else
                {
                    var viewModel = ViewModelList
                        .Where(o => o.CompraId == ViewModel.CompraId)
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

        private void AgregarDetalle()
        {
            try
            {
                var frm = new MntCompraDetalleForm(ViewModel.CompraId, ViewModel.CompraDetalleViewModels);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Ocurrió un error al agregar, mensaje de error: {0}", ex.Message)
                    , "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ModificarDetalle()
        {
            try
            {
                var viewModel = (CompraDetalleViewModel)compraDetalleViewModelsBindingSource.Current;
                var frm = new MntCompraDetalleForm(viewModel, ViewModel.CompraDetalleViewModels);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Ocurrió un error al modificar, mensaje de error: {0}", ex.Message)
                    , "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarDetalle()
        {
            try
            {
                if (MessageBox.Show("¿Seguro desea eliminar el registro?", "Eliminar"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var viewModelDetail = (CompraDetalleViewModel)compraDetalleViewModelsBindingSource.Current;
                    ViewModel.CompraDetalleViewModels.RemoveItem(viewModelDetail);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Ocurrió un error al eliminar el registro, mensaje de error: {0}", ex.Message)
                    , "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarCombos()
        {
            ApplicationDbContext context = new ApplicationDbContext();
            var centroLogisticos = context.CentroLogisticos.ToList();
            centroLogisticoViewModels = new List<CentroLogisticoViewModel>();
            foreach (var centroLogistico in centroLogisticos)
            {
                centroLogisticoViewModels.Add(new CentroLogisticoViewModel(centroLogistico));
            }
            centroLogisticoViewModelBindingSource.DataSource = centroLogisticoViewModels;
        }
        #endregion
    }
}
