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

namespace AdmCostoProduccion.Windows.Procesos.Inventario.Despacho
{
    public partial class MntDespachoDetalleForm : KryptonForm
    {
        private readonly ApplicationDbContext Context = new ApplicationDbContext();
        private DespachoDetalleViewModel ViewModel = new DespachoDetalleViewModel();
        private List<UnidadMedidaViewModel> unidadMedidaViewModels = new List<UnidadMedidaViewModel>();

        #region Propiedades
        public bool IsNew { get; set; }
        public ObservableListSource<DespachoDetalleViewModel> ViewModelList { get; set; }
        #endregion

        #region Constructor
        public MntDespachoDetalleForm(DespachoDetalleViewModel viewModel
            , ObservableListSource<DespachoDetalleViewModel> viewModelList)
        {
            InitializeComponent();
            IsNew = false;
            viewModel.CopyTo(ref ViewModel);
            ViewModelList = viewModelList;
            despachoDetalleViewModelBindingSource.DataSource = ViewModel;
            //
            CargarCombos();
        }

        public MntDespachoDetalleForm(ObservableListSource<DespachoDetalleViewModel> viewModelList)
        {
            InitializeComponent();
            IsNew = true;
            ViewModelList = viewModelList;
            despachoDetalleViewModelBindingSource.DataSource = ViewModel;
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
            despachoDetalleViewModelBindingSource.CancelEdit();
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
                despachoDetalleViewModelBindingSource.EndEdit();
                //
                var mercaderiaViewModel = (MercaderiaViewModel)mercaderiaTextBox.Tag;
                var unidadMedidaViewModel = (UnidadMedidaViewModel)unidadMedidaViewModelBindingSource.Current;

                if (mercaderiaViewModel == null) throw new Exception("Debe se seleccionar una mercadería");
                if (unidadMedidaViewModel == null) throw new Exception("Debe de seleccionar una unidad de medida");

                ViewModel.MercaderiaId = mercaderiaViewModel.MercaderiaId;
                ViewModel.CodigoMercaderia = mercaderiaViewModel.Codigo;
                ViewModel.NombreMercaderia = mercaderiaViewModel.Nombre;
                ViewModel.UnidadMedidaId = unidadMedidaViewModel.UnidadMedidaId;
                ViewModel.UnidadMedida = unidadMedidaViewModel.Nombre;

                var model = ViewModel.ToModel();
                if (IsNew)
                {
                    //Context.DespachoDetalles.Add(model);
                    //Context.SaveChanges();
                    //
                    ViewModel.DespachoDetalleId = model.DespachoDetalleId;
                    ViewModelList.Add(ViewModel);
                }
                else
                {
                    //Context.Entry(model).State = EntityState.Modified;
                    //Context.SaveChanges();
                    //
                    var viewModel = ViewModelList
                        .Where(o => o.DespachoDetalleId == ViewModel.DespachoDetalleId)
                        .FirstOrDefault();
                    ViewModel.CopyTo(ref viewModel);
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
                    mercaderiaTextBox.Tag = mercaderiaViewModel;
                    mercaderiaTextBox.Text = mercaderiaViewModel.Nombre;
                }
                else
                {
                    mercaderiaTextBox.Tag = null;
                    mercaderiaTextBox.Text = string.Empty;
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

        private void CargarCombos()
        {
            var unidadMedidas = Context.UnidadMedidas.ToList();
            foreach (var unidadMedida in unidadMedidas)
            {
                unidadMedidaViewModels.Add(new UnidadMedidaViewModel(unidadMedida));
            }
            unidadMedidaViewModelBindingSource.DataSource = unidadMedidaViewModels;
        }
        #endregion
    }
}
