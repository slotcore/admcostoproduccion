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

namespace AdmCostoProduccion.Windows.Maestro.PlantaFabricacion
{
    public partial class MntPlantaFabricacionForm : KryptonForm
    {
        private readonly ApplicationDbContext Context = new ApplicationDbContext();
        private PlantaFabricacionViewModel PlantaFabricacionViewModel = new PlantaFabricacionViewModel();

        #region Propiedades
        public bool IsNew { get; set; }
        public ObservableListSource<PlantaFabricacionViewModel> PlantaFabricacionViewModels { get; set; }
        public List<Common.Models.Maestro.CentroLogistico> CentroLogisticos { get; set; }
        #endregion

        #region Constructor
        public MntPlantaFabricacionForm(PlantaFabricacionViewModel PlantaFabricacionViewModel
            , ObservableListSource<PlantaFabricacionViewModel> PlantaFabricacionViewModels)
        {
            InitializeComponent();
            IsNew = false;
            PlantaFabricacionViewModel.CopyTo(ref this.PlantaFabricacionViewModel);
            this.PlantaFabricacionViewModels = PlantaFabricacionViewModels;
            plantaFabricacionViewModelBindingSource.DataSource = this.PlantaFabricacionViewModel;
            //
            CargarCombos();
        }

        public MntPlantaFabricacionForm(ObservableListSource<PlantaFabricacionViewModel> PlantaFabricacionViewModels)
        {
            InitializeComponent();
            IsNew = true;
            this.PlantaFabricacionViewModels = PlantaFabricacionViewModels;
            plantaFabricacionViewModelBindingSource.DataSource = PlantaFabricacionViewModel;
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
            plantaFabricacionViewModelBindingSource.CancelEdit();
            this.Close();
        }
        #endregion

        #region Eventos Privados

        private void CargarCombos()
        {
            CentroLogisticos = new ApplicationDbContext().CentroLogisticos.ToList();
            centroLogisticoBindingSource.DataSource = CentroLogisticos;
        }

        private void Grabar()
        {
            try
            {
                plantaFabricacionViewModelBindingSource.EndEdit();
                var centroLogistico = (Common.Models.Maestro.CentroLogistico)centroLogisticoBindingSource.Current;

                PlantaFabricacionViewModel.CentroLogisticoId = centroLogistico.CentroLogisticoId;
                PlantaFabricacionViewModel.CentroLogistico = centroLogistico.Nombre;

                Common.Models.Maestro.PlantaFabricacion plantaFabricacion = PlantaFabricacionViewModel.ToModel();
                if (IsNew)
                {
                    Context.PlantaFabricacions.Add(plantaFabricacion);
                    Context.SaveChanges();
                    //
                    PlantaFabricacionViewModel.PlantaFabricacionId = plantaFabricacion.PlantaFabricacionId;
                    PlantaFabricacionViewModels.Add(PlantaFabricacionViewModel);
                }
                else
                {
                    Context.Entry(plantaFabricacion).State = EntityState.Modified;
                    Context.SaveChanges();
                    //
                    var _PlantaFabricacionViewModel = PlantaFabricacionViewModels
                        .Where(o => o.PlantaFabricacionId == PlantaFabricacionViewModel.PlantaFabricacionId)
                        .FirstOrDefault();
                    PlantaFabricacionViewModel.CopyTo(ref _PlantaFabricacionViewModel);
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
