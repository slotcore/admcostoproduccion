using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Data;
using AdmCostoProduccion.Common.ViewModels.Inventario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdmCostoProduccion.Windows.Mantenimiento.Inventario.UnidadMedida
{
    public partial class LstUnidadMedidaForm : Form
    {
        private ObservableListSource<UnidadMedidaViewModel> _UnidadMedidaViewModels = new ObservableListSource<UnidadMedidaViewModel>();

        #region Constructor
        public LstUnidadMedidaForm()
        {
            InitializeComponent();

            _UnidadMedidaViewModels = new ObservableListSource<UnidadMedidaViewModel>();
            unidadMedidaViewModelBindingSource.DataSource = _UnidadMedidaViewModels;
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
                var frm = new MntUnidadMedidaForm(_UnidadMedidaViewModels);
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
                var _UnidadMedida = (UnidadMedidaViewModel)unidadMedidaViewModelBindingSource.Current;
                var frm = new MntUnidadMedidaForm(_UnidadMedida, _UnidadMedidaViewModels);
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
                    var _UnidadMedidaViewModel = (UnidadMedidaViewModel)unidadMedidaViewModelBindingSource.Current;
                    var _UnidadMedida = _context.UnidadMedidas
                        .Where(o => o.UnidadMedidaId == _UnidadMedidaViewModel.UnidadMedidaId)
                        .FirstOrDefault();
                    _context.UnidadMedidas.Remove(_UnidadMedida);
                    _context.SaveChanges();
                    _UnidadMedidaViewModels.Remove(_UnidadMedidaViewModel);
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
                var unidadMedidas = new ApplicationDbContext().UnidadMedidas.ToList();
                _UnidadMedidaViewModels.Clear();
                foreach (var unidadMedida in unidadMedidas)
                {
                    _UnidadMedidaViewModels.Add(new UnidadMedidaViewModel(unidadMedida));
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
                var unidadMedidas = new ApplicationDbContext().UnidadMedidas.Where(o =>
                                o.Codigo.ToUpper().Contains(cadenaBusqueda) ||
                                o.Nombre.ToUpper().Contains(cadenaBusqueda) ||
                                o.Descripcion.ToUpper().Contains(cadenaBusqueda)).ToList();

                _UnidadMedidaViewModels.Clear();
                foreach (var unidadMedida in unidadMedidas)
                {
                    _UnidadMedidaViewModels.Add(new UnidadMedidaViewModel(unidadMedida));
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
