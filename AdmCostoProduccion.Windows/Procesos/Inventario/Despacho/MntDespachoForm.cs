using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Data;
using AdmCostoProduccion.Common.Enum;
using AdmCostoProduccion.Common.Models.Inventario;
using AdmCostoProduccion.Common.ViewModels.CompraVenta;
using AdmCostoProduccion.Common.ViewModels.Inventario;
using AdmCostoProduccion.Common.ViewModels.Maestro;
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

namespace AdmCostoProduccion.Windows.Procesos.Inventario.Despacho
{
    public partial class MntDespachoForm : KryptonForm
    {
        private readonly ApplicationDbContext Context = new ApplicationDbContext();
        private DespachoViewModel ViewModel = new DespachoViewModel();
        private List<AlmacenViewModel> almacenViewModels = new List<AlmacenViewModel>();

        #region Propiedades
        public bool IsNew { get; set; }
        public ObservableListSource<DespachoViewModel> ViewModelList { get; set; }
        #endregion

        #region Constructor
        public MntDespachoForm(DespachoViewModel viewModel
            , ObservableListSource<DespachoViewModel> viewModelList)
        {
            InitializeComponent();
            IsNew = false;
            ViewModel.CopyOf(viewModel);
            ViewModelList = viewModelList;
            CargarCombos();
            despachoViewModelBindingSource.DataSource = ViewModel;
        }

        public MntDespachoForm(ObservableListSource<DespachoViewModel> viewModelList)
        {
            InitializeComponent();
            IsNew = true;
            ViewModel = new DespachoViewModel();
            ViewModelList = viewModelList;
            despachoViewModelBindingSource.DataSource = ViewModel;
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
            despachoViewModelBindingSource.CancelEdit();
            this.Close();
        }

        private void BuscarDocumentoButton_Click(object sender, EventArgs e)
        {
            BuscarDocumentos();
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

        private void TipoDocumentoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ViewModel.NumeroDocumentoRelacionado = string.Empty;
            //ViewModel.VentaId = 0;
            //ViewModel.OrdenProduccionId = 0;
        }
        #endregion

        #region Eventos Privados

        private void Grabar()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                despachoViewModelBindingSource.EndEdit();
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
                        .Where(o => o.DespachoId == ViewModel.DespachoId)
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
            var almacens = Context.Almacens.ToList();
            foreach (var almacen in almacens)
            {
                almacenViewModels.Add(new AlmacenViewModel(almacen));
            }
            almacenViewModelBindingSource.DataSource = almacenViewModels;
            //
            tipoDocumentoComboBox.Items.Add(TipoDocumentoEnum.Venta);
            tipoDocumentoComboBox.Items.Add(TipoDocumentoEnum.OrdenProduccion);

            //
            if (!IsNew)
            {
                tipoDocumentoComboBox.SelectedItem = ViewModel.TipoDespacho;
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
                        case TipoDocumentoEnum.Venta:
                            var formpromptventa = new VentaPromptForm();
                            if (formpromptventa.ShowDialog() == DialogResult.OK)
                            {
                                var ventaViewModel = formpromptventa.VentaViewModel;
                                ViewModel.TipoDocumentoRelacionado = TipoDocumentoEnum.Venta;
                                ViewModel.NumeroDocumentoRelacionado = ventaViewModel.NumeroDocumento;
                                ViewModel.VentaId = ventaViewModel.VentaId;
                            }
                            else
                            {
                                ViewModel.NumeroDocumentoRelacionado = string.Empty;
                                ViewModel.VentaId = string.Empty;
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

        private void AgregarDetalle()
        {
            try
            {
                var frm = new MntDespachoDetalleForm(ViewModel.DespachoId, ViewModel.DespachoDetalleViewModels);
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
                var viewModel = (DespachoDetalleViewModel)despachoDetalleViewModelsBindingSource.Current;
                var frm = new MntDespachoDetalleForm(viewModel, ViewModel.DespachoDetalleViewModels);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Ocurrió un error al modificar, mensaje de error: {0}", ex.Message)
                    , "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarTipo()
        {
            if (tipoDocumentoComboBox.SelectedItem != null)
            {
                TipoDespacho tipoDespacho = null;
                switch (tipoDocumentoComboBox.SelectedItem.ToString())
                {
                    case TipoDocumentoEnum.Venta:                        
                        tipoDespacho = Context.TipoDespachos.Where(o => o.Proceso.Equals("Venta")).FirstOrDefault();
                        break;
                    case TipoDocumentoEnum.OrdenProduccion:
                        tipoDespacho = Context.TipoDespachos.Where(o => o.Proceso.Equals("OrdenProduccion")).FirstOrDefault();
                        break;
                }
                if (tipoDespacho != null)
                {
                    ViewModel.TipoDespacho = tipoDespacho.Nombre;
                    ViewModel.TipoDespachoId = tipoDespacho.TipoDespachoId;
                }
            }
            else
            {
                ViewModel.TipoDespacho = string.Empty;
                ViewModel.TipoDespachoId = string.Empty;
            }
        }
        #endregion
    }
}
