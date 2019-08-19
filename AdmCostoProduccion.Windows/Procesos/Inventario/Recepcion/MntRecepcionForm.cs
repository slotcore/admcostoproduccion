using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Data;
using AdmCostoProduccion.Common.Enum;
using AdmCostoProduccion.Common.Models.Inventario;
using AdmCostoProduccion.Common.ViewModels.Inventario;
using AdmCostoProduccion.Common.ViewModels.Maestro;
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
    public partial class MntRecepcionForm : KryptonForm
    {
        #region Propiedades
        private RecepcionViewModel ViewModel = new RecepcionViewModel();
        private ObservableListSource<RecepcionViewModel> ViewModelList;
        private List<AlmacenViewModel> almacenViewModels;
        #endregion

        #region Constructor
        public MntRecepcionForm(RecepcionViewModel viewModel
            , ObservableListSource<RecepcionViewModel> viewModelList)
        {
            InitializeComponent();
            ViewModel.CopyOf(viewModel);
            ViewModelList = viewModelList;
            recepcionViewModelBindingSource.DataSource = ViewModel;
            //
            CargarCombos();
        }

        public MntRecepcionForm(ObservableListSource<RecepcionViewModel> viewModelList)
        {
            InitializeComponent();
            ViewModel = new RecepcionViewModel();
            ViewModelList = viewModelList;
            recepcionViewModelBindingSource.DataSource = ViewModel;
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
            recepcionViewModelBindingSource.CancelEdit();
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

        private void BuscarDocumentoButton_Click(object sender, EventArgs e)
        {
            BuscarDocumentos();
        }
        #endregion

        #region Eventos Privados

        private void Grabar()
        {
            try
            {
                bool IsNew = ViewModel.IsNew;
                Cursor = Cursors.WaitCursor;
                recepcionViewModelBindingSource.EndEdit();
                //
                CargarTipo();
                //
                var almacenViewModel = (AlmacenViewModel)almacenViewModelBindingSource.Current;
                if (almacenViewModel == null) throw new Exception("Debe de seleccionar un almacén");
                ViewModel.AlmacenId = almacenViewModel.AlmacenId;
                ViewModel.Almacen = almacenViewModel.Nombre;
                ViewModel.Grabar();
                if (IsNew) ViewModelList.Add(ViewModel);
                else
                {
                    var viewModel = ViewModelList
                        .Where(o => o.RecepcionId == ViewModel.RecepcionId)
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
                var frm = new MntRecepcionDetalleForm(ViewModel.RecepcionId, ViewModel.RecepcionDetalleViewModels);
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
                var viewModel = (RecepcionDetalleViewModel)recepcionDetalleViewModelsBindingSource.Current;
                var frm = new MntRecepcionDetalleForm(viewModel, ViewModel.RecepcionDetalleViewModels);
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
                    var viewModelDetail = (RecepcionDetalleViewModel)recepcionDetalleViewModelsBindingSource.Current;
                    ViewModel.RecepcionDetalleViewModels.RemoveItem(viewModelDetail);
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
            ApplicationDbContext context = new ApplicationDbContext();
            var almacens = context.Almacens.ToList();
            almacenViewModels = new List<AlmacenViewModel>();
            foreach (var almacen in almacens)
            {
                almacenViewModels.Add(new AlmacenViewModel(almacen));
            }
            almacenViewModelBindingSource.DataSource = almacenViewModels;
            //
            tipoDocumentoComboBox.Items.Add(TipoDocumentoEnum.Compra);
            tipoDocumentoComboBox.Items.Add(TipoDocumentoEnum.OrdenProduccion);

            //
            if (!ViewModel.IsNew)
            {
                tipoDocumentoComboBox.SelectedItem = ViewModel.TipoRecepcion;
                almacenIdComboBox.SelectedItem = almacenViewModels.Where(a => a.AlmacenId == ViewModel.AlmacenId).FirstOrDefault();
            }
        }

        private void BuscarDocumentos()
        {
            try
            {
                if (tipoDocumentoComboBox.SelectedItem != null)
                {
                    switch (tipoDocumentoComboBox.SelectedItem.ToString())
                    {
                        case TipoDocumentoEnum.Compra:
                            var formpromptcompra = new CompraPromptForm();
                            if (formpromptcompra.ShowDialog() == DialogResult.OK)
                            {
                                var compraViewModel = formpromptcompra.CompraViewModel;
                                ViewModel.TipoDocumentoRelacionado = TipoDocumentoEnum.Compra;
                                ViewModel.NumeroDocumentoRelacionado = compraViewModel.NumeroDocumento;
                                ViewModel.CompraId = compraViewModel.CompraId;
                            }
                            else
                            {
                                ViewModel.NumeroDocumentoRelacionado = string.Empty;
                                ViewModel.CompraId = string.Empty;
                            }
                            break;

                        case TipoDocumentoEnum.OrdenProduccion:
                            var formpromptventaop = new OrdenProduccionPromptForm();
                            if (formpromptventaop.ShowDialog() == DialogResult.OK)
                            {
                                var opViewModel = formpromptventaop.OrdenProduccionViewModel;
                                ViewModel.TipoDocumentoRelacionado = TipoDocumentoEnum.OrdenProduccion;
                                ViewModel.NumeroDocumentoRelacionado = opViewModel.Codigo;
                                ViewModel.OrdenProduccionId = opViewModel.OrdenProduccionId;
                            }
                            else
                            {
                                ViewModel.NumeroDocumentoRelacionado = string.Empty;
                                ViewModel.OrdenProduccionId = string.Empty;
                            }
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Ocurrió un error al buscar el documento, mensaje de error: {0}", ex.Message)
                    , "Buscar Documento", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarTipo()
        {
            ApplicationDbContext context = new ApplicationDbContext();
            if (tipoDocumentoComboBox.SelectedItem != null)
            {
                TipoRecepcion tipoRecepcion = null;
                switch (tipoDocumentoComboBox.SelectedItem.ToString())
                {
                    case TipoDocumentoEnum.Compra:
                        tipoRecepcion = context.TipoRecepcions.Where(o => o.Proceso.Equals("Compra")).FirstOrDefault();
                        break;
                    case TipoDocumentoEnum.OrdenProduccion:
                        tipoRecepcion = context.TipoRecepcions.Where(o => o.Proceso.Equals("OrdenProduccion")).FirstOrDefault();
                        break;
                }
                if (tipoRecepcion != null)
                {
                    ViewModel.TipoRecepcion = tipoRecepcion.Nombre;
                    ViewModel.TipoRecepcionId = tipoRecepcion.TipoRecepcionId;
                }
            }
            else
            {
                ViewModel.TipoRecepcion = string.Empty;
                ViewModel.TipoRecepcionId = string.Empty;
            }
        }
        #endregion
    }
}
