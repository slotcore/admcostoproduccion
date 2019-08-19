using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Data;
using AdmCostoProduccion.Common.Forms;
using AdmCostoProduccion.Common.ViewModels.Inventario;
using AdmCostoProduccion.Common.ViewModels.Produccion;
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

namespace AdmCostoProduccion.Windows.Procesos.Produccion.OrdenProduccion
{
    public partial class MntOrdenProduccionInsumoForm : BaseForm
    {
        #region Propiedades
        private OrdenProduccionInsumoViewModel ViewModel;
        private ObservableListSource<OrdenProduccionInsumoViewModel> ViewModelList;
        private List<UnidadMedidaViewModel> unidadMedidaViewModels;
        #endregion

        #region Constructor
        public MntOrdenProduccionInsumoForm(OrdenProduccionInsumoViewModel viewModel
            , ObservableListSource<OrdenProduccionInsumoViewModel> viewModelList):base(false)
        {
            InitializeComponent();
            ViewModel.CopyOf(viewModel);
            ViewModelList = viewModelList;
            ordenProduccionInsumoViewModelBindingSource.DataSource = ViewModel;
            //
            CargarCombos();
        }

        public MntOrdenProduccionInsumoForm(string parentId
            , ObservableListSource<OrdenProduccionInsumoViewModel> viewModelList):base(true)
        {
            InitializeComponent();
            ViewModel = new OrdenProduccionInsumoViewModel(parentId);
            ViewModelList = viewModelList;
            ordenProduccionInsumoViewModelBindingSource.DataSource = ViewModel;
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
            ordenProduccionInsumoViewModelBindingSource.CancelEdit();
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
                ordenProduccionInsumoViewModelBindingSource.EndEdit();
                UnidadMedidaViewModel unidadMedidaView = (UnidadMedidaViewModel)unidadMedidaViewModelBindingSource.Current;
                if (unidadMedidaView == null) throw new Exception("Debe seleccionar unidad de medida");
                ViewModel.UnidadMedidaId = unidadMedidaView.UnidadMedidaId;
                ViewModel.UnidadMedida = unidadMedidaView.Nombre;

                if (IsNew) ViewModelList.Add(ViewModel);
                else
                {
                    var viewModel = ViewModelList
                        .Where(o => o.OrdenProduccionInsumoId == ViewModel.OrdenProduccionInsumoId)
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
            ApplicationDbContext context = new ApplicationDbContext();
            var unidadMedidas = context.UnidadMedidas.ToList();
            unidadMedidaViewModels = new List<UnidadMedidaViewModel>();
            foreach (var unidadMedida in unidadMedidas)
            {
                unidadMedidaViewModels.Add(new UnidadMedidaViewModel(unidadMedida));
            }
            unidadMedidaViewModelBindingSource.DataSource = unidadMedidaViewModels;
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
