using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Data;
using AdmCostoProduccion.Common.ViewModels.CompraVenta;
using AdmCostoProduccion.Common.ViewModels.Inventario;
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

namespace AdmCostoProduccion.Windows.Prompt
{
    public partial class CompraPromptForm : KryptonForm
    {
        private ObservableListSource<CompraViewModel> ViewModelList = new ObservableListSource<CompraViewModel>();
        private CompraViewModel _CompraViewModel = new CompraViewModel();
        private List<CompraViewModel> _CompraViewModelList = new List<CompraViewModel>();

        public CompraViewModel CompraViewModel
        {
            get { return _CompraViewModel; }
        }

        public List<CompraViewModel> CompraViewModelList
        {
            get { return _CompraViewModelList; }
        }

        #region Constructor
        public CompraPromptForm()
        {
            InitializeComponent();

            ViewModelList = new ObservableListSource<CompraViewModel>();
            compraViewModelBindingSource.DataSource = ViewModelList;
        }

        public CompraPromptForm(string filtro)
        {
            InitializeComponent();

            ViewModelList = new ObservableListSource<CompraViewModel>();
            compraViewModelBindingSource.DataSource = ViewModelList;
            if (!string.IsNullOrEmpty(filtro))
            {
                BusquedaTextBox.Text = filtro;
                Buscar();
            }
        }
        #endregion

        #region Eventos de Formulario

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            Aceptar();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            Cancelar();
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

        private void DetalleDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Aceptar();
        }
        #endregion

        #region Eventos Privados
        private void Aceptar()
        {
            try
            {
                if (compraViewModelBindingSource.Current == null)
                {
                    throw new Exception("Debe de seleccionar al menos un registro");
                }
                _CompraViewModel = (CompraViewModel)compraViewModelBindingSource.Current;
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Ocurrió un error al agregar, mensaje de error: {0}", ex.Message)
                    , "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cancelar()
        {
            try
            {
                DialogResult = DialogResult.Cancel;
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Ocurrió un error al modificar, mensaje de error: {0}", ex.Message)
                    , "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Buscar()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                var cadenaBusqueda = BusquedaTextBox.Text.Trim().ToUpper();
                var list = new ApplicationDbContext().Compras.Where(o =>
                                o.NumeroDocumento.ToUpper().Contains(cadenaBusqueda) ||
                                o.CentroLogistico.Nombre.ToUpper().Contains(cadenaBusqueda) ||
                                o.Descripcion.ToUpper().Contains(cadenaBusqueda)).ToList();

                ViewModelList.Clear();
                foreach (var model in list)
                {
                    ViewModelList.Add(new CompraViewModel(model));
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
