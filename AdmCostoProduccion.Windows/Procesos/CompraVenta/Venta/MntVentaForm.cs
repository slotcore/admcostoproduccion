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

namespace AdmCostoProduccion.Windows.Procesos.CompraVenta.Venta
{
    public partial class MntVentaForm : KryptonForm
    {
        #region Propiedades
        private VentaViewModel ViewModel = new VentaViewModel();
        private ObservableListSource<VentaViewModel> ViewModelList;
        private List<CentroLogisticoViewModel> centroLogisticoViewModels;
        #endregion

        #region Constructor
        public MntVentaForm(VentaViewModel viewModel
            , ObservableListSource<VentaViewModel> viewModelList)
        {
            InitializeComponent();
            ViewModel.CopyOf(viewModel);
            ViewModelList = viewModelList;
            ventaViewModelBindingSource.DataSource = ViewModel;
            CargarCombos();
        }

        public MntVentaForm(ObservableListSource<VentaViewModel> viewModelList)
        {
            InitializeComponent();
            ViewModel = new VentaViewModel();
            ViewModelList = viewModelList;
            ventaViewModelBindingSource.DataSource = ViewModel;
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
            ventaViewModelBindingSource.CancelEdit();
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
                bool IsNew = ViewModel.IsNew;
                Cursor = Cursors.WaitCursor;
                ventaViewModelBindingSource.EndEdit();

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
                        .Where(o => o.VentaId == ViewModel.VentaId)
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
                var frm = new MntVentaDetalleForm(ViewModel.VentaId, ViewModel.VentaDetalleViewModels);
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
                var viewModel = (VentaDetalleViewModel)ventaDetalleViewModelsBindingSource.Current;
                var frm = new MntVentaDetalleForm(viewModel, ViewModel.VentaDetalleViewModels);
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
                    var viewModelDetail = (VentaDetalleViewModel)ventaDetalleViewModelsBindingSource.Current;
                    ViewModel.VentaDetalleViewModels.RemoveItem(viewModelDetail);
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
                    centroLogisticoComboBox.SelectedItem = centroLogisticoViewModel;
                }
            }
        }
        #endregion
    }
}
