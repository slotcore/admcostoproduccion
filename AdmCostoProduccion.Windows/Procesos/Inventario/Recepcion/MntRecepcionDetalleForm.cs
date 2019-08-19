using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Data;
using AdmCostoProduccion.Common.Forms;
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

namespace AdmCostoProduccion.Windows.Procesos.Inventario.Recepcion
{
    public partial class MntRecepcionDetalleForm : BaseForm
    {
        #region Propiedades
        private RecepcionDetalleViewModel ViewModel;
        private ObservableListSource<RecepcionDetalleViewModel> ViewModelList;
        private List<UnidadMedidaViewModel> unidadMedidaViewModels;
        #endregion

        #region Constructor
        public MntRecepcionDetalleForm(RecepcionDetalleViewModel viewModel
            , ObservableListSource<RecepcionDetalleViewModel> viewModelList):base(false)
        {
            InitializeComponent();
            ViewModel.CopyOf(viewModel);
            ViewModelList = viewModelList;
            recepcionDetalleViewModelBindingSource.DataSource = ViewModel;
            //
            CargarCombos();
        }

        public MntRecepcionDetalleForm(string parentId
            , ObservableListSource<RecepcionDetalleViewModel> viewModelList):base(true)
        {
            InitializeComponent();
            ViewModel = new RecepcionDetalleViewModel(parentId);
            ViewModelList = viewModelList;
            recepcionDetalleViewModelBindingSource.DataSource = ViewModel;
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
            recepcionDetalleViewModelBindingSource.CancelEdit();
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
                recepcionDetalleViewModelBindingSource.EndEdit();
                UnidadMedidaViewModel unidadMedida = (UnidadMedidaViewModel)unidadMedidaViewModelBindingSource.Current;
                ViewModel.UnidadMedida = unidadMedida.Nombre;
                ViewModel.UnidadMedidaId = unidadMedida.UnidadMedidaId;

                if (IsNew) ViewModelList.Add(ViewModel);
                else
                {
                    var viewModel = ViewModelList
                        .Where(o => o.RecepcionDetalleId == ViewModel.RecepcionDetalleId)
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
