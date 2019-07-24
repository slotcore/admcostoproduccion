using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Data;
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

namespace AdmCostoProduccion.Windows.Maestro.Almacen
{
    public partial class MntAlmacenForm : KryptonForm
    {
        private readonly ApplicationDbContext Context = new ApplicationDbContext();
        private AlmacenViewModel AlmacenViewModel = new AlmacenViewModel();

        #region Propiedades
        public bool IsNew { get; set; }
        public ObservableListSource<AlmacenViewModel> AlmacenViewModels { get; set; }
        public List<CentroLogisticoViewModel> CentroLogisticoViewModels { get; set; }
        #endregion

        #region Constructor
        public MntAlmacenForm(AlmacenViewModel AlmacenViewModel
            , ObservableListSource<AlmacenViewModel> AlmacenViewModels)
        {
            InitializeComponent();
            IsNew = false;
            AlmacenViewModel.CopyTo(ref this.AlmacenViewModel);
            this.AlmacenViewModels = AlmacenViewModels;
            almacenViewModelBindingSource.DataSource = this.AlmacenViewModel;
            //
            CargarCombos();
        }

        public MntAlmacenForm(ObservableListSource<AlmacenViewModel> AlmacenViewModels)
        {
            InitializeComponent();
            IsNew = true;
            this.AlmacenViewModels = AlmacenViewModels;
            almacenViewModelBindingSource.DataSource = AlmacenViewModel;
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
            almacenViewModelBindingSource.CancelEdit();
            this.Close();
        }
        #endregion

        #region Eventos Privados

        private void CargarCombos()
        {
            var centroLogisticos = new ApplicationDbContext().CentroLogisticos.ToList();
            CentroLogisticoViewModels = new List<CentroLogisticoViewModel>();

            foreach (var centroLogistico in centroLogisticos)
            {
                CentroLogisticoViewModels.Add(new CentroLogisticoViewModel(centroLogistico));
            }

            centroLogisticoViewModelBindingSource.DataSource = CentroLogisticoViewModels;
            centroLogisticoIdComboBox.SelectedValue = AlmacenViewModel.CentroLogisticoId;
        }

        private void Grabar()
        {
            try
            {
                almacenViewModelBindingSource.EndEdit();
                var centroLogisticoViewModel = (CentroLogisticoViewModel)centroLogisticoViewModelBindingSource.Current;

                AlmacenViewModel.CentroLogisticoId = centroLogisticoViewModel.CentroLogisticoId;
                AlmacenViewModel.CentroLogistico = centroLogisticoViewModel.Nombre;

                Common.Models.Maestro.Almacen almacen = AlmacenViewModel.ToModel();
                if (IsNew)
                {
                    Context.Almacens.Add(almacen);
                    Context.SaveChanges();
                    //
                    AlmacenViewModel.AlmacenId = almacen.AlmacenId;
                    AlmacenViewModels.Add(AlmacenViewModel);
                }
                else
                {
                    Context.Entry(almacen).State = EntityState.Modified;
                    Context.SaveChanges();
                    //
                    var _AlmacenViewModel = AlmacenViewModels
                        .Where(o => o.AlmacenId == AlmacenViewModel.AlmacenId)
                        .FirstOrDefault();
                    AlmacenViewModel.CopyTo(ref _AlmacenViewModel);
                }
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Ocurrió un error al grabar, mensaje de error: {0}", ex.Message)
                    , "Grabar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
