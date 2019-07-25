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

namespace AdmCostoProduccion.Windows.Procesos.CompraVenta.Venta
{
    public partial class MntVentaDetalleForm : KryptonForm
    {
        private readonly ApplicationDbContext Context = new ApplicationDbContext();
        private VentaDetalleViewModel ViewModel = new VentaDetalleViewModel();

        #region Propiedades
        public bool IsNew { get; set; }
        public ObservableListSource<VentaDetalleViewModel> ViewModelList { get; set; }
        #endregion

        #region Constructor
        public MntVentaDetalleForm(VentaDetalleViewModel viewModel
            , ObservableListSource<VentaDetalleViewModel> viewModelList)
        {
            InitializeComponent();
            IsNew = false;
            viewModel.CopyTo(ref ViewModel);
            ViewModelList = viewModelList;
            ventaDetalleViewModelBindingSource.DataSource = ViewModel;
        }

        public MntVentaDetalleForm(ObservableListSource<VentaDetalleViewModel> viewModelList)
        {
            InitializeComponent();
            IsNew = true;
            ViewModelList = viewModelList;
            ventaDetalleViewModelBindingSource.DataSource = ViewModel;
        }
        #endregion

        #region Eventos de Formulario
        private void GrabarButton_Click(object sender, EventArgs e)
        {
            Grabar();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            ventaDetalleViewModelBindingSource.CancelEdit();
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
                ventaDetalleViewModelBindingSource.EndEdit();
                var mercaderiaViewModel = (MercaderiaViewModel)mercaderiaTextBox.Tag;
                if (mercaderiaViewModel == null) throw new Exception("Debe se seleccionar una mercadería");
                ViewModel.MercaderiaId = mercaderiaViewModel.MercaderiaId;
                ViewModel.CodigoMercaderia = mercaderiaViewModel.Codigo;
                ViewModel.NombreMercaderia = mercaderiaViewModel.Nombre;

                var model = ViewModel.ToModel();
                if (IsNew)
                {
                    //Context.VentaDetalles.Add(model);
                    //Context.SaveChanges();
                    //
                    ViewModel.VentaDetalleId = model.VentaDetalleId;
                    ViewModelList.Add(ViewModel);
                }
                else
                {
                    //Context.Entry(model).State = EntityState.Modified;
                    //Context.SaveChanges();
                    //
                    var viewModel = ViewModelList
                        .Where(o => o.VentaDetalleId == ViewModel.VentaDetalleId)
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
        #endregion
    }
}
