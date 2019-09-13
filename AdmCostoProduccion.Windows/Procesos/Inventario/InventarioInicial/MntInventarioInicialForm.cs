using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Data;
using AdmCostoProduccion.Common.ViewModels.Inventario;
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

namespace AdmCostoProduccion.Windows.Procesos.Inventario.InventarioInicial
{
    public partial class MntInventarioInicialForm : KryptonForm
    {
        #region Propiedades
        private InventarioInicialViewModel ViewModel = new InventarioInicialViewModel();
        private ObservableListSource<InventarioInicialViewModel> ViewModelList;
        private List<AlmacenViewModel> almacenViewModels;
        #endregion

        #region Constructor
        public MntInventarioInicialForm(InventarioInicialViewModel viewModel
            , ObservableListSource<InventarioInicialViewModel> viewModelList)
        {
            InitializeComponent();
            ViewModel.CopyOf(viewModel);
            ViewModelList = viewModelList;
            inventarioInicialViewModelBindingSource.DataSource = ViewModel;
            CargarCombos();
        }

        public MntInventarioInicialForm(ObservableListSource<InventarioInicialViewModel> viewModelList)
        {
            InitializeComponent();
            ViewModel = new InventarioInicialViewModel();
            ViewModelList = viewModelList;
            inventarioInicialViewModelBindingSource.DataSource = ViewModel;
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
            inventarioInicialViewModelBindingSource.CancelEdit();
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
                inventarioInicialViewModelBindingSource.EndEdit();

                AlmacenViewModel almacenViewModel
                    = (AlmacenViewModel)almacenViewModelBindingSource.Current;
                if (almacenViewModel == null)
                    throw new Exception("Debe seleccionar un almacén");
                ViewModel.AlmacenId = almacenViewModel.AlmacenId;
                ViewModel.Almacen = almacenViewModel.Nombre;

                ViewModel.Grabar();
                if (IsNew) ViewModelList.Add(ViewModel);
                else
                {
                    var viewModel = ViewModelList
                        .Where(o => o.InventarioInicialId == ViewModel.InventarioInicialId)
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
                var frm = new MntInventarioInicialDetalleForm(ViewModel.InventarioInicialId, ViewModel.InventarioInicialDetalleViewModels);
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
                var viewModel = (InventarioInicialDetalleViewModel)inventarioInicialDetalleViewModelsBindingSource.Current;
                var frm = new MntInventarioInicialDetalleForm(viewModel, ViewModel.InventarioInicialDetalleViewModels);
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
                    var viewModelDetail = (InventarioInicialDetalleViewModel)inventarioInicialDetalleViewModelsBindingSource.Current;
                    ViewModel.InventarioInicialDetalleViewModels.RemoveItem(viewModelDetail);
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
                var almacens = context.Almacens.ToList();
                almacenViewModels = new List<AlmacenViewModel>();
                foreach (var almacen in almacens)
                {
                    almacenViewModels.Add(new AlmacenViewModel(almacen));
                }
                almacenViewModelBindingSource.DataSource = almacenViewModels;
                if (!string.IsNullOrEmpty(ViewModel.AlmacenId))
                {
                    AlmacenViewModel almacenViewModel = almacenViewModels
                        .Where(o => o.AlmacenId == ViewModel.AlmacenId)
                        .FirstOrDefault();
                    almacenComboBox.SelectedItem = almacenViewModel;
                }
            }
        }
        #endregion
    }
}
