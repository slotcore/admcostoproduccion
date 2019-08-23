using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Data;
using AdmCostoProduccion.Common.ViewModels.CompraVenta;
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

namespace AdmCostoProduccion.Windows.Procesos.CompraVenta.Compra
{
    public partial class MntCompraDetalleForm : KryptonForm
    {
        #region Propiedades
        private CompraDetalleViewModel ViewModel;
        private ObservableListSource<CompraDetalleViewModel> ViewModelList;
        private List<UnidadMedidaViewModel> unidadMedidaViewModels;
        #endregion

        #region Constructor
        public MntCompraDetalleForm(CompraDetalleViewModel viewModel
            , ObservableListSource<CompraDetalleViewModel> viewModelList)
        {
            InitializeComponent();
            ViewModel.CopyOf(viewModel);
            ViewModelList = viewModelList;
            CargarCombo();
            compraDetalleViewModelBindingSource.DataSource = ViewModel;
        }

        public MntCompraDetalleForm(string parentId, ObservableListSource<CompraDetalleViewModel> viewModelList)
        {
            InitializeComponent();
            ViewModel = new CompraDetalleViewModel(parentId);
            ViewModelList = viewModelList;
            CargarCombo();
            compraDetalleViewModelBindingSource.DataSource = ViewModel;
        }
        #endregion

        #region Eventos de Formulario
        private void GrabarButton_Click(object sender, EventArgs e)
        {
            Grabar();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            compraDetalleViewModelBindingSource.CancelEdit();
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
                compraDetalleViewModelBindingSource.EndEdit();

                var unidadMedidaViewModel = (UnidadMedidaViewModel)unidadMedidaViewModelBindingSource.Current;
                if (unidadMedidaViewModel == null) throw new Exception("Debe seleccionar unidad de medida¡¡");
                ViewModel.UnidadMedidaId = unidadMedidaViewModel.UnidadMedidaId;
                ViewModel.UnidadMedida = unidadMedidaViewModel.Nombre;

                if (ViewModel.IsNew) ViewModelList.Add(ViewModel);
                else
                {
                    var viewModel = ViewModelList
                        .Where(o => o.CompraDetalleId == ViewModel.CompraDetalleId)
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

        private void BuscarMercaderia()
        {
            try
            {
                var formprompt = new MercaderiaPromptForm(mercaderiaTextBox.Text);
                if (formprompt.ShowDialog() == DialogResult.OK)
                {
                    var mercaderiaViewModel = formprompt.MercaderiaViewModel;
                    ViewModel.CodigoMercaderia = mercaderiaViewModel.Codigo;
                    ViewModel.NombreMercaderia = mercaderiaViewModel.Nombre;
                    ViewModel.MercaderiaId = mercaderiaViewModel.MercaderiaId;
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

        private void CargarCombo()
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
            }
        }
        #endregion
    }
}
