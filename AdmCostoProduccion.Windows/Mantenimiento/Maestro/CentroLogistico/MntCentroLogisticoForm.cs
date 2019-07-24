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
        private readonly ApplicationDbContext Context = new ApplicationDbContext();
        
        #region Propiedades
        public bool IsNew { get; set; }
        public CentroLogisticoViewModel CentroLogisticoViewModel { get; set; }
        public ObservableListSource<CentroLogisticoViewModel> CentroLogisticoViewModels { get; set; }
        #endregion

        #region Constructor
        public MntCentroLogisticoForm(CentroLogisticoViewModel CentroLogisticoViewModel
            , ObservableListSource<CentroLogisticoViewModel> CentroLogisticoViewModels)
        {
            InitializeComponent();
            IsNew = false;
            this.CentroLogisticoViewModel = CentroLogisticoViewModel.GetCopy();
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
        #endregion

        #region Eventos de Formulario
        private void GrabarButton_Click(object sender, EventArgs e)
        {
            Grabar();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            centroLogisticoViewModelBindingSource.CancelEdit();
            this.Close();
        }
        #endregion

        #region Eventos Privados
        private void Grabar()
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
                    Context.CentroLogisticos.Add(centroLogistico);
                    Context.SaveChanges();
                    //
                    CentroLogisticoViewModels.Add(CentroLogisticoViewModel);
                }
                else
                {
                    Context.Entry(centroLogistico).State = EntityState.Modified;
                    Context.SaveChanges();
                    //
                    var _CentroLogisticoViewModel = CentroLogisticoViewModels
                        .Where(o => o.CentroLogisticoId == CentroLogisticoViewModel.CentroLogisticoId)
                        .FirstOrDefault();
                    _CentroLogisticoViewModel.Codigo = CentroLogisticoViewModel.Codigo;
                    _CentroLogisticoViewModel.Nombre = CentroLogisticoViewModel.Nombre;
                    _CentroLogisticoViewModel.Descripcion = CentroLogisticoViewModel.Descripcion;
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
