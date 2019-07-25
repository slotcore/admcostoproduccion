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
        private readonly ApplicationDbContext Context = new ApplicationDbContext();
        private VentaViewModel ViewModel = new VentaViewModel();
        private List<CentroLogisticoViewModel> centroLogisticoViewModels = new List<CentroLogisticoViewModel>();

        #region Propiedades
        public bool IsNew { get; set; }
        public ObservableListSource<VentaViewModel> ViewModelList { get; set; }
        #endregion

        #region Constructor
        public MntVentaForm(VentaViewModel viewModel
            , ObservableListSource<VentaViewModel> viewModelList)
        {
            InitializeComponent();
            IsNew = false;
            viewModel.CopyTo(ref ViewModel);
            ViewModelList = viewModelList;
            ventaViewModelBindingSource.DataSource = ViewModel;
            //
            CargarCombos();
        }

        public MntVentaForm(ObservableListSource<VentaViewModel> viewModelList)
        {
            InitializeComponent();
            IsNew = true;
            ViewModelList = viewModelList;
            ventaViewModelBindingSource.DataSource = ViewModel;
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

        }
        #endregion

        #region Eventos Privados

        private void Grabar()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                ventaViewModelBindingSource.EndEdit();

                var centroLogisticoViewModel = (CentroLogisticoViewModel)centroLogisticoViewModelBindingSource.Current;

                ViewModel.CentroLogisticoId = centroLogisticoViewModel.CentroLogisticoId;
                ViewModel.CentroLogistico = centroLogisticoViewModel.Nombre;

                var model = ViewModel.ToModel();
                if (IsNew)
                {
                    Context.Ventas.Add(model);
                    Context.SaveChanges();
                    //
                    ViewModel.VentaId = model.VentaId;
                    ViewModelList.Add(ViewModel);
                }
                else
                {
                    Context.Entry(model).State = EntityState.Modified;
                    Context.SaveChanges();
                    //
                    var viewModel = ViewModelList
                        .Where(o => o.VentaId == ViewModel.VentaId)
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

        private void AgregarDetalle()
        {
            try
            {
                var frm = new MntVentaDetalleForm(ViewModel.VentaDetalleViewModels);
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

        private void CargarCombos()
        {
            var centroLogisticos = Context.CentroLogisticos.ToList();
            foreach (var centroLogistico in centroLogisticos)
            {
                centroLogisticoViewModels.Add(new CentroLogisticoViewModel(centroLogistico));
            }
            centroLogisticoViewModelBindingSource.DataSource = centroLogisticoViewModels;
        }
        #endregion
    }
}
