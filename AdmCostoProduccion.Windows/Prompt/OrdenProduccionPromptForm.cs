using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Data;
using AdmCostoProduccion.Common.ViewModels.Inventario;
using AdmCostoProduccion.Common.ViewModels.Produccion;
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
    public partial class OrdenProduccionPromptForm : KryptonForm
    {
        private ObservableListSource<OrdenProduccionViewModel> ViewModelList = new ObservableListSource<OrdenProduccionViewModel>();
        private OrdenProduccionViewModel _OrdenProduccionViewModel = new OrdenProduccionViewModel();
        private List<OrdenProduccionViewModel> _OrdenProduccionViewModelList = new List<OrdenProduccionViewModel>();

        public OrdenProduccionViewModel OrdenProduccionViewModel
        {
            get { return _OrdenProduccionViewModel; }
        }

        public List<OrdenProduccionViewModel> OrdenProduccionViewModelList
        {
            get { return _OrdenProduccionViewModelList; }
        }

        #region Constructor
        public OrdenProduccionPromptForm()
        {
            InitializeComponent();

            ViewModelList = new ObservableListSource<OrdenProduccionViewModel>();
            ordenProduccionViewModelBindingSource.DataSource = ViewModelList;
            DesdeDateTimePicker.Value = DateTime.Today.AddDays(-15);
            HastaDateTimePicker.Value = DateTime.Today.AddDays(15);
        }

        public OrdenProduccionPromptForm(string filtro)
        {
            InitializeComponent();

            ViewModelList = new ObservableListSource<OrdenProduccionViewModel>();
            ordenProduccionViewModelBindingSource.DataSource = ViewModelList;
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
                if (ordenProduccionViewModelBindingSource.Current == null)
                {
                    throw new Exception("Debe de seleccionar al menos un registro");
                }
                _OrdenProduccionViewModel = (OrdenProduccionViewModel)ordenProduccionViewModelBindingSource.Current;
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
                var list = new ApplicationDbContext().OrdenProduccions.Where(o =>
                                (o.Codigo.ToUpper().Contains(cadenaBusqueda) ||
                                o.Descripcion.ToUpper().Contains(cadenaBusqueda) ||
                                o.Mercaderia.Codigo.ToUpper().Contains(cadenaBusqueda) ||
                                o.Mercaderia.Nombre.ToUpper().Contains(cadenaBusqueda)) && 
                                o.Fecha >= DesdeDateTimePicker.Value &&
                                o.Fecha <= HastaDateTimePicker.Value).ToList();

                ViewModelList.Clear();
                foreach (var model in list)
                {
                    ViewModelList.Add(new OrdenProduccionViewModel(model));
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
