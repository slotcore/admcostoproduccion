using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Data;
using AdmCostoProduccion.Common.ViewModels.Inventario;
using AdmCostoProduccion.Common.ViewModels.Produccion;
using AdmCostoProduccion.Windows.Mantenimiento.Produccion.ProcedimientoProduccionInsumo;
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

namespace AdmCostoProduccion.Windows.Mantenimiento.Produccion.ProcedimientoProduccion
{
    public partial class MntProcedimientoProduccionForm : KryptonForm
    {
        private readonly ApplicationDbContext Context = new ApplicationDbContext();
        private ProcedimientoProduccionViewModel ViewModel = new ProcedimientoProduccionViewModel();
        private List<UnidadMedidaViewModel> unidadMedidaViewModels = new List<UnidadMedidaViewModel>();

        #region Propiedades
        public bool IsNew { get; set; }
        public ObservableListSource<ProcedimientoProduccionViewModel> ViewModelList { get; set; }
        #endregion

        #region Constructor
        public MntProcedimientoProduccionForm(ProcedimientoProduccionViewModel viewModel
            , ObservableListSource<ProcedimientoProduccionViewModel> viewModelList)
        {
            InitializeComponent();
            IsNew = false;
            viewModel.CopyTo(ref ViewModel);
            ViewModelList = viewModelList;
            procedimientoProduccionViewModelBindingSource.DataSource = ViewModel;
            //
            CargarCombos();
        }

        public MntProcedimientoProduccionForm(ObservableListSource<ProcedimientoProduccionViewModel> viewModelList)
        {
            InitializeComponent();
            IsNew = true;
            ViewModelList = viewModelList;
            procedimientoProduccionViewModelBindingSource.DataSource = ViewModel;
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
            procedimientoProduccionViewModelBindingSource.CancelEdit();
            this.Close();
        }

        private void BuscarMercaderiaButton_Click(object sender, EventArgs e)
        {
            BuscarMercaderia();
        }

        private void AgregarInsumoButton_Click(object sender, EventArgs e)
        {
            AgregarInsumo();
        }

        private void ModificarInsumoButton_Click(object sender, EventArgs e)
        {
            ModificarInsumo();
        }

        private void EliminarInsumoButton_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Eventos Privados

        private void Grabar()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                procedimientoProduccionViewModelBindingSource.EndEdit();

                var unidadMedidaViewModel = (UnidadMedidaViewModel)unidadMedidaViewModelBindingSource.Current;
                var mercaderiaViewModel = (MercaderiaViewModel)mercaderiaTextBox.Tag;

                if (unidadMedidaViewModel == null) throw new Exception("Debe de seleccionar una unidad de medida");
                if (mercaderiaViewModel == null) throw new Exception("Debe se seleccionar una mercadería");

                ViewModel.UnidadMedidaId = unidadMedidaViewModel.UnidadMedidaId;
                ViewModel.UnidadMedida = unidadMedidaViewModel.Nombre;
                ViewModel.MercaderiaId = mercaderiaViewModel.MercaderiaId;
                ViewModel.CodigoMercaderia = mercaderiaViewModel.Codigo;
                ViewModel.NombreMercaderia = mercaderiaViewModel.Nombre;

                var model = ViewModel.ToModel();
                if (IsNew)
                {
                    Context.ProcedimientoProduccions.Add(model);
                    Context.SaveChanges();
                    //
                    ViewModel.ProcedimientoProduccionId = model.ProcedimientoProduccionId;
                    ViewModelList.Add(ViewModel);
                }
                else
                {
                    Context.Entry(model).State = EntityState.Modified;
                    Context.SaveChanges();
                    //
                    var viewModel = ViewModelList
                        .Where(o => o.ProcedimientoProduccionId == ViewModel.ProcedimientoProduccionId)
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
                var formprompt = new MercaderiaPromptForm();
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

        private void AgregarInsumo()
        {
            try
            {
                var frm = new MntProcedimientoProduccionInsumoForm(ViewModel.ProcedimientoProduccionInsumoViewModels);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Ocurrió un error al agregar, mensaje de error: {0}", ex.Message)
                    , "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ModificarInsumo()
        {
            try
            {
                var viewModel = (ProcedimientoProduccionInsumoViewModel)procedimientoProduccionInsumoViewModelsBindingSource.Current;
                var frm = new MntProcedimientoProduccionInsumoForm(viewModel, ViewModel.ProcedimientoProduccionInsumoViewModels);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Ocurrió un error al modificar, mensaje de error: {0}", ex.Message)
                    , "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
