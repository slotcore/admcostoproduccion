using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Data;
using AdmCostoProduccion.Common.ViewModels.Inventario;
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

namespace AdmCostoProduccion.Windows.Mantenimiento.Inventario.Despacho
{
    public partial class MntDespachoForm : KryptonForm
    {
        private readonly ApplicationDbContext Context = new ApplicationDbContext();
        private DespachoViewModel ViewModel = new DespachoViewModel();

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
            viewModel.CopyTo(ref ViewModel);
            ViewModelList = viewModelList;
            despachoViewModelBindingSource.DataSource = ViewModel;
        }

        public MntDespachoForm(ObservableListSource<DespachoViewModel> viewModelList)
        {
            InitializeComponent();
            IsNew = true;
            ViewModelList = viewModelList;
            despachoViewModelBindingSource.DataSource = ViewModel;
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

        }

        private void AgregarDetalleButton_Click(object sender, EventArgs e)
        {

        }

        private void ModificarDetalleButton_Click(object sender, EventArgs e)
        {

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
                despachoViewModelBindingSource.EndEdit();

                var model = ViewModel.ToModel();
                if (IsNew)
                {
                    Context.Despachos.Add(model);
                    Context.SaveChanges();
                    //
                    ViewModel.DespachoId = model.DespachoId;
                    ViewModelList.Add(ViewModel);
                }
                else
                {
                    Context.Entry(model).State = EntityState.Modified;
                    Context.SaveChanges();
                    //
                    var viewModel = ViewModelList
                        .Where(o => o.DespachoId == ViewModel.DespachoId)
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
        #endregion
    }
}
