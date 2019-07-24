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

        #region Constructor
        public LstCentroLogisticoForm()
        {
            InitializeComponent();

            _CentroLogisticoViewModels = new ObservableListSource<CentroLogisticoViewModel>();
            centroLogisticoViewModelBindingSource.DataSource = _CentroLogisticoViewModels;
        }
        #endregion

        #region Eventos de Formulario
        private void AgregarButton_Click(object sender, EventArgs e)
        {
            Agregar();
        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            Modificar();
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void ActualizarButton_Click(object sender, EventArgs e)
        {
            Actualizar();
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
        #endregion

        #region Eventos Privados
        private void Agregar()
        {
            try
            {
                var frm = new MntCentroLogisticoForm(_CentroLogisticoViewModels);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Ocurrió un error al agregar, mensaje de error: {0}", ex.Message)
                    , "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Modificar()
        {
            try
            {
                var _CentroLogistico = (CentroLogisticoViewModel)centroLogisticoViewModelBindingSource.Current;
                var frm = new MntCentroLogisticoForm(_CentroLogistico, _CentroLogisticoViewModels);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Ocurrió un error al modificar, mensaje de error: {0}", ex.Message)
                    , "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Eliminar()
        {
            try
            {
                if (MessageBox.Show("¿Esta seguro de eliminar el registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Cursor = Cursors.WaitCursor;
                    var _context = new ApplicationDbContext();
                    var _CentroLogisticoViewModel = (CentroLogisticoViewModel)centroLogisticoViewModelBindingSource.Current;
                    var _CentroLogistico = _context.CentroLogisticos
                        .Where(o => o.CentroLogisticoId == _CentroLogisticoViewModel.CentroLogisticoId)
                        .FirstOrDefault();
                    _context.CentroLogisticos.Remove(_CentroLogistico);
                    _context.SaveChanges();
                    _CentroLogisticoViewModels.Remove(_CentroLogisticoViewModel);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Ocurrió un error al eliminar, mensaje de error: {0}", ex.Message)
                    , "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void Actualizar()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                var centroLogisticos = new ApplicationDbContext().CentroLogisticos.ToList();
                _CentroLogisticoViewModels.Clear();
                foreach (var centroLogistico in centroLogisticos)
                {
                    _CentroLogisticoViewModels.Add(new CentroLogisticoViewModel(centroLogistico));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Ocurrió un error al actualizar, mensaje de error: {0}", ex.Message)
                    , "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
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
        #endregion
    }
}
