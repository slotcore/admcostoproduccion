using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Data;
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
    public partial class MercaderiaPromptForm : KryptonForm
    {
        private ObservableListSource<MercaderiaViewModel> ViewModelList = new ObservableListSource<MercaderiaViewModel>();
        private MercaderiaViewModel _MercaderiaViewModel = new MercaderiaViewModel();
        private List<MercaderiaViewModel> _MercaderiaViewModelList = new List<MercaderiaViewModel>();

        public MercaderiaViewModel MercaderiaViewModel
        {
            get { return _MercaderiaViewModel; }
        }        

        public List<MercaderiaViewModel> MercaderiaViewModelList
        {
            get { return _MercaderiaViewModelList; }
        }

        #region Constructor
        public MercaderiaPromptForm()
        {
            InitializeComponent();

            ViewModelList = new ObservableListSource<MercaderiaViewModel>();
            mercaderiaViewModelBindingSource.DataSource = ViewModelList;
        }

        public MercaderiaPromptForm(string filtro)
        {
            InitializeComponent();

            ViewModelList = new ObservableListSource<MercaderiaViewModel>();
            mercaderiaViewModelBindingSource.DataSource = ViewModelList;
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
                if (mercaderiaViewModelBindingSource.Current == null)
                {
                    throw new Exception("Debe de seleccionar al menos un registro");
                }
                _MercaderiaViewModel = (MercaderiaViewModel)mercaderiaViewModelBindingSource.Current;
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
                var list = new ApplicationDbContext().Mercaderias.Where(o =>
                                o.Codigo.ToUpper().Contains(cadenaBusqueda) ||
                                o.Nombre.ToUpper().Contains(cadenaBusqueda) ||
                                o.Descripcion.ToUpper().Contains(cadenaBusqueda)).ToList();

                ViewModelList.Clear();
                foreach (var model in list)
                {
                    ViewModelList.Add(new MercaderiaViewModel(model));
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
