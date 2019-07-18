using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Data;
using AdmCostoProduccion.Common.ViewModels.Maestro;
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

namespace AdmCostoProduccion.Windows.Maestro.CentroLogistico
{
    public partial class LstCentroLogisticoForm : Form
    {
        private ObservableListSource<CentroLogisticoViewModel> _CentroLogisticoViewModels = new ObservableListSource<CentroLogisticoViewModel>();

        public LstCentroLogisticoForm()
        {
            InitializeComponent();

            var centroLogisticos = new ApplicationDbContext().CentroLogisticos.ToList();
            _CentroLogisticoViewModels = new ObservableListSource<CentroLogisticoViewModel>();
            foreach (var centroLogistico in centroLogisticos)
            {
                _CentroLogisticoViewModels.Add(new CentroLogisticoViewModel(centroLogistico));
            }

            centroLogisticoViewModelBindingSource.DataSource = _CentroLogisticoViewModels;
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            var frm = new MntCentroLogisticoForm(_CentroLogisticoViewModels);
            frm.ShowDialog();
        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            var _CentroLogistico = (CentroLogisticoViewModel)centroLogisticoViewModelBindingSource.Current;
            var frm = new MntCentroLogisticoForm(_CentroLogistico, _CentroLogisticoViewModels);
            frm.ShowDialog();
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {

        }

        private void ActualizarButton_Click(object sender, EventArgs e)
        {
            var centroLogisticos = new ApplicationDbContext().CentroLogisticos.ToList();
            _CentroLogisticoViewModels.Clear();
            foreach (var centroLogistico in centroLogisticos)
            {
                _CentroLogisticoViewModels.Add(new CentroLogisticoViewModel(centroLogistico));
            }
        }
    }
}
