using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Data;
using AdmCostoProduccion.Common.ViewModels.Maestro;
using AdmCostoProduccion.Common.Models.Maestro;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace AdmCostoProduccion.Windows.Maestro.CentroLogistico
{
    public partial class MntCentroLogisticoForm : KryptonForm
    {
        private ApplicationDbContext Context = new ApplicationDbContext();
        public bool IsNew { get; set; }
        public CentroLogisticoViewModel CentroLogisticoViewModel { get; set; }
        public ObservableListSource<CentroLogisticoViewModel> CentroLogisticoViewModels { get; set; }
        public CentroLogisticoViewModel OldCentroLogisticoViewModel { get; set; }

        public MntCentroLogisticoForm(CentroLogisticoViewModel CentroLogisticoViewModel
            , ObservableListSource<CentroLogisticoViewModel> CentroLogisticoViewModels)
        {
            InitializeComponent();
            IsNew = false;
            this.CentroLogisticoViewModel = new CentroLogisticoViewModel(CentroLogisticoViewModel);
            this.OldCentroLogisticoViewModel = CentroLogisticoViewModel;
            this.CentroLogisticoViewModels = CentroLogisticoViewModels;
            centroLogisticoViewModelBindingSource.DataSource = this.CentroLogisticoViewModel;
        }

        public MntCentroLogisticoForm(ObservableListSource<CentroLogisticoViewModel> CentroLogisticoViewModels)
        {
            InitializeComponent();
            IsNew = true;
            CentroLogisticoViewModel = new CentroLogisticoViewModel();
            this.CentroLogisticoViewModels = CentroLogisticoViewModels;
            centroLogisticoViewModelBindingSource.DataSource = CentroLogisticoViewModel;
        }

        private void GrabarButton_Click(object sender, EventArgs e)
        {
            try
            {
                centroLogisticoViewModelBindingSource.EndEdit();
                Common.Models.Maestro.CentroLogistico centroLogistico = new Common.Models.Maestro.CentroLogistico
                {
                    CentroLogisticoId = CentroLogisticoViewModel.CentroLogisticoId,
                    Codigo = CentroLogisticoViewModel.Codigo,
                    Nombre = CentroLogisticoViewModel.Nombre,
                    Descripcion = CentroLogisticoViewModel.Descripcion
                };
                if (IsNew)
                {
                    CentroLogisticoViewModels.Add(CentroLogisticoViewModel);
                    Context.CentroLogisticos.Add(centroLogistico);
                }
                else
                {
                    OldCentroLogisticoViewModel.Codigo = CentroLogisticoViewModel.Codigo;
                    OldCentroLogisticoViewModel.Nombre = CentroLogisticoViewModel.Nombre;
                    OldCentroLogisticoViewModel.Descripcion = CentroLogisticoViewModel.Descripcion;
                    Context.Entry(centroLogistico).State = EntityState.Modified;
                }
                Context.SaveChanges();
                MessageBox.Show("Se grabó el registro correctamente", "Grabar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Ocurrió un error al grabar, mensaje de error: {0}", ex.Message)
                    , "Grabar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            centroLogisticoViewModelBindingSource.CancelEdit();
            this.Close();
        }
    }
}
