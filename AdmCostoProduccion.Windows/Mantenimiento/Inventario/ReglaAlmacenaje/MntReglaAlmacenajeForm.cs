using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Data;
using AdmCostoProduccion.Common.ViewModels.Inventario;
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

namespace AdmCostoProduccion.Windows.Mantenimiento.Inventario.ReglaAlmacenaje
{
    public partial class MntReglaAlmacenajeForm : KryptonForm
    {
        #region Propiedades
        private ReglaAlmacenajeViewModel ViewModel = new ReglaAlmacenajeViewModel();
        private ObservableListSource<ReglaAlmacenajeViewModel> ViewModelList;
        private List<AlmacenViewModel> almacenViewModels;
        private List<FamiliaMercaderiaViewModel> familiaMercaderiaViewModels;
        #endregion

        #region Constructor
        public MntReglaAlmacenajeForm(ReglaAlmacenajeViewModel viewModel
            , ObservableListSource<ReglaAlmacenajeViewModel> viewModelList)
        {
            InitializeComponent();
            ViewModel.CopyOf(viewModel);
            ViewModelList = viewModelList;
            CargarCombos();
            reglaAlmacenajeViewModelBindingSource.DataSource = ViewModel;
        }

        public MntReglaAlmacenajeForm(ObservableListSource<ReglaAlmacenajeViewModel> viewModelList)
        {
            InitializeComponent();
            ViewModel = new ReglaAlmacenajeViewModel();
            ViewModelList = viewModelList;
            CargarCombos();
            reglaAlmacenajeViewModelBindingSource.DataSource = ViewModel;
        }
        #endregion

        #region Eventos de Formulario
        private void GrabarButton_Click(object sender, EventArgs e)
        {
            Grabar();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            reglaAlmacenajeViewModelBindingSource.CancelEdit();
            this.Close();
        }
        #endregion

        #region Eventos Privados

        private void Grabar()
        {
            try
            {
                bool IsNew = ViewModel.IsNew;
                Cursor = Cursors.WaitCursor;
                reglaAlmacenajeViewModelBindingSource.EndEdit();
                ViewModel.Grabar();
                if (IsNew) ViewModelList.Add(ViewModel);
                else
                {
                    var viewModel = ViewModelList
                        .Where(o => o.ReglaAlmacenajeId == ViewModel.ReglaAlmacenajeId)
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
            using (var context = new ApplicationDbContext())
            {
                var almacens = context.Almacens.ToList();
                var familiaMercaderias = context.FamiliaMercaderias.ToList();
                almacenViewModels = new List<AlmacenViewModel>();
                familiaMercaderiaViewModels = new List<FamiliaMercaderiaViewModel>();

                foreach(var almacen in almacens)
                {
                    almacenViewModels.Add(new AlmacenViewModel(almacen));
                }

                foreach (var familiaMercaderia in familiaMercaderias)
                {
                    familiaMercaderiaViewModels.Add(new FamiliaMercaderiaViewModel(familiaMercaderia));
                }

                almacenViewModelBindingSource.DataSource = almacenViewModels;
                familiaMercaderiaViewModelBindingSource.DataSource = familiaMercaderiaViewModels;
            }
        }
        #endregion
    }
}
