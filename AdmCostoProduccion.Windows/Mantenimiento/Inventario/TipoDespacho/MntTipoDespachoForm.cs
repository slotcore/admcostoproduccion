using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Data;
using AdmCostoProduccion.Common.ViewModels.Inventario;
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

namespace AdmCostoProduccion.Windows.Mantenimiento.Inventario.TipoDespacho
{
    public partial class MntTipoDespachoForm : Form
    {
        private readonly ApplicationDbContext Context = new ApplicationDbContext();
        private TipoDespachoViewModel ViewModel = new TipoDespachoViewModel();

        #region Propiedades
        public bool IsNew { get; set; }
        public ObservableListSource<TipoDespachoViewModel> ViewModelList { get; set; }
        #endregion

        #region Constructor
        public MntTipoDespachoForm(TipoDespachoViewModel viewModel
            , ObservableListSource<TipoDespachoViewModel> viewModelList)
        {
            InitializeComponent();
            IsNew = false;
            viewModel.CopyTo(ref ViewModel);
            ViewModelList = viewModelList;
            tipoDespachoViewModelBindingSource.DataSource = ViewModel;
        }

        public MntTipoDespachoForm(ObservableListSource<TipoDespachoViewModel> viewModelList)
        {
            InitializeComponent();
            IsNew = true;
            ViewModelList = viewModelList;
            tipoDespachoViewModelBindingSource.DataSource = ViewModel;
        }
        #endregion

        #region Eventos de Formulario
        private void GrabarButton_Click(object sender, EventArgs e)
        {
            Grabar();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            tipoDespachoViewModelBindingSource.CancelEdit();
            this.Close();
        }
        #endregion

        #region Eventos Privados

        private void Grabar()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                tipoDespachoViewModelBindingSource.EndEdit();

                var model = ViewModel.ToModel();
                if (IsNew)
                {
                    Context.TipoDespachos.Add(model);
                    Context.SaveChanges();
                    //
                    ViewModel.TipoDespachoId = model.TipoDespachoId;
                    ViewModelList.Add(ViewModel);
                }
                else
                {
                    Context.Entry(model).State = EntityState.Modified;
                    Context.SaveChanges();
                    //
                    var viewModel = ViewModelList
                        .Where(o => o.TipoDespachoId == ViewModel.TipoDespachoId)
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
