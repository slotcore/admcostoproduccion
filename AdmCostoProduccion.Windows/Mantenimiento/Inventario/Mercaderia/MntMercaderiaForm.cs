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

namespace AdmCostoProduccion.Windows.Mantenimiento.Inventario.Mercaderia
{
    public partial class MntMercaderiaForm : KryptonForm
    {
        private readonly ApplicationDbContext Context = new ApplicationDbContext();
        private MercaderiaViewModel ViewModel = new MercaderiaViewModel();

        private List<TipoMercaderiaViewModel> TipoMercaderiaViewModels = new List<TipoMercaderiaViewModel>();

        #region Propiedades
        public bool IsNew { get; set; }
        public ObservableListSource<MercaderiaViewModel> ViewModelList { get; set; }
        #endregion

        #region Constructor
        public MntMercaderiaForm(MercaderiaViewModel viewModel
            , ObservableListSource<MercaderiaViewModel> viewModelList)
        {
            InitializeComponent();
            IsNew = false;
            viewModel.CopyTo(ref ViewModel);
            ViewModelList = viewModelList;
            mercaderiaViewModelBindingSource.DataSource = ViewModel;
            //
            CargarCombos();
        }

        public MntMercaderiaForm(ObservableListSource<MercaderiaViewModel> viewModelList)
        {
            InitializeComponent();
            IsNew = true;
            ViewModelList = viewModelList;
            mercaderiaViewModelBindingSource.DataSource = ViewModel;
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
            mercaderiaViewModelBindingSource.CancelEdit();
            this.Close();
        }
        #endregion

        #region Eventos Privados

        private void CargarCombos()
        {
            var TipoMercaderias = new ApplicationDbContext().TipoMercaderias.ToList();
            foreach (var model in TipoMercaderias)
            {
                TipoMercaderiaViewModels.Add(new TipoMercaderiaViewModel(model));
            }
            tipoMercaderiaViewModelBindingSource.DataSource = TipoMercaderiaViewModels;
        }

        private void Grabar()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                mercaderiaViewModelBindingSource.EndEdit();

                var tipoMercaderiaViewModel = (TipoMercaderiaViewModel)tipoMercaderiaViewModelBindingSource.Current;
                ViewModel.TipoMercaderiaId = tipoMercaderiaViewModel.TipoMercaderiaId;
                ViewModel.TipoMercaderia = tipoMercaderiaViewModel.Nombre;

                var model = ViewModel.ToModel();
                if (IsNew)
                {
                    Context.Mercaderias.Add(model);
                    Context.SaveChanges();
                    //
                    ViewModel.MercaderiaId = model.MercaderiaId;
                    ViewModelList.Add(ViewModel);
                }
                else
                {
                    Context.Entry(model).State = EntityState.Modified;
                    Context.SaveChanges();
                    //
                    var viewModel = ViewModelList
                        .Where(o => o.MercaderiaId == ViewModel.MercaderiaId)
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
