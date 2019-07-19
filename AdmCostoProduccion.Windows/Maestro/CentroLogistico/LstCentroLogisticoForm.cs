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

            //var centroLogisticos = new ApplicationDbContext().CentroLogisticos.ToList();
            _CentroLogisticoViewModels = new ObservableListSource<CentroLogisticoViewModel>();
            //foreach (var centroLogistico in centroLogisticos)
            //{
            //    _CentroLogisticoViewModels.Add(new CentroLogisticoViewModel(centroLogistico));
            //}

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

        private void Buscar()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                var cadenaBusqueda = BusquedaTextBox.Text.Trim().ToUpper();
                var centroLogisticos = new ApplicationDbContext().CentroLogisticos.Where(o =>
                                o.Codigo.ToUpper().Contains(cadenaBusqueda) ||
                                o.Nombre.ToUpper().Contains(cadenaBusqueda) ||
                                o.Descripcion.ToUpper().Contains(cadenaBusqueda)).ToList();

                _CentroLogisticoViewModels.Clear();
                foreach (var centroLogistico in centroLogisticos)
                {
                    _CentroLogisticoViewModels.Add(new CentroLogisticoViewModel(centroLogistico));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Ocurrió un error al buscar, mensaje de error: {0}", ex.Message)
                    , "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            BusquedaTextBox.Clear();
        }

        private void BusquedaTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Buscar();
            }
        }
    }
}
