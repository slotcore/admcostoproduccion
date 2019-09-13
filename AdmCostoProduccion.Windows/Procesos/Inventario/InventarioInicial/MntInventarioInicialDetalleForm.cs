using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Data;
using AdmCostoProduccion.Common.ViewModels.Inventario;
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

namespace AdmCostoProduccion.Windows.Procesos.Inventario.InventarioInicial
{
    public partial class MntInventarioInicialDetalleForm : KryptonForm
    {
        #region Propiedades
        private InventarioInicialDetalleViewModel ViewModel;
        private ObservableListSource<InventarioInicialDetalleViewModel> ViewModelList;
        private List<UnidadMedidaViewModel> unidadMedidaViewModels;
        #endregion

        #region Constructor
        public MntInventarioInicialDetalleForm(InventarioInicialDetalleViewModel viewModel
            , ObservableListSource<InventarioInicialDetalleViewModel> viewModelList)
        {
            InitializeComponent();
            ViewModel.CopyOf(viewModel);
            ViewModelList = viewModelList;
            inventarioInicialDetalleViewModelBindingSource.DataSource = ViewModel;
            CargarCombos();
        }

        public MntInventarioInicialDetalleForm(string parentId, ObservableListSource<InventarioInicialDetalleViewModel> viewModelList)
        {
            InitializeComponent();
            ViewModel = new InventarioInicialDetalleViewModel(parentId);
            ViewModelList = viewModelList;
            inventarioInicialDetalleViewModelBindingSource.DataSource = ViewModel;
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
            inventarioInicialDetalleViewModelBindingSource.CancelEdit();
            this.Close();
        }

        private void BuscarMercaderiaButton_Click(object sender, EventArgs e)
        {
            BuscarMercaderia();
        }
        #endregion

        #region Eventos Privados

        private void Grabar()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                inventarioInicialDetalleViewModelBindingSource.EndEdit();

                UnidadMedidaViewModel unidadMedidaViewModel
                    = (UnidadMedidaViewModel)unidadMedidaViewModelBindingSource.Current;
                if (unidadMedidaViewModel == null)
                    throw new Exception("Debe seleccionar una unidad de medida");
                ViewModel.UnidadMedidaId = unidadMedidaViewModel.UnidadMedidaId;
                ViewModel.UnidadMedida = unidadMedidaViewModel.Nombre;

                if (ViewModel.IsNew) ViewModelList.Add(ViewModel);
                else
                {
                    var viewModel = ViewModelList
                        .Where(o => o.InventarioInicialDetalleId == ViewModel.InventarioInicialDetalleId)
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
                var unidadMedidas = context.UnidadMedidas.ToList();
                unidadMedidaViewModels = new List<UnidadMedidaViewModel>();
                foreach (var unidadMedida in unidadMedidas)
                {
                    unidadMedidaViewModels.Add(new UnidadMedidaViewModel(unidadMedida));
                }
                unidadMedidaViewModelBindingSource.DataSource = unidadMedidaViewModels;
                if (!string.IsNullOrEmpty(ViewModel.UnidadMedidaId))
                {
                    UnidadMedidaViewModel unidadMedidaViewModel = unidadMedidaViewModels
                        .Where(o => o.UnidadMedidaId == ViewModel.UnidadMedidaId)
                        .FirstOrDefault();
                    unidadMedidaComboBox.SelectedItem = unidadMedidaViewModel;
                }
            }
        }

        private void BuscarMercaderia()
        {
            try
            {
                var formprompt = new MercaderiaPromptForm(mercaderiaTextBox.Text);
                if (formprompt.ShowDialog() == DialogResult.OK)
                {
                    var mercaderiaViewModel = formprompt.MercaderiaViewModel;
                    ViewModel.MercaderiaId = mercaderiaViewModel.MercaderiaId;
                    ViewModel.CodigoMercaderia = mercaderiaViewModel.Codigo;
                    ViewModel.NombreMercaderia = mercaderiaViewModel.Nombre;
                }

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
