using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Data;
using AdmCostoProduccion.Common.ViewModels.Aplicacion;
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

namespace AdmCostoProduccion.Windows.Mantenimiento.Aplicacion.AplicacionConfiguracion
{
    public partial class MntAplicacionConfiguracionForm : KryptonForm
    {
        #region Propiedades
        private AplicacionConfiguracionViewModel ViewModel = new AplicacionConfiguracionViewModel();
        #endregion

        #region Constructor
        public MntAplicacionConfiguracionForm()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            InitializeComponent();
            var aplicacionConfiguracion = context.AplicacionConfiguracions.FirstOrDefault();
            if (aplicacionConfiguracion == null)
            {
                ViewModel = new AplicacionConfiguracionViewModel();
            }
            else
            {
                ViewModel = new AplicacionConfiguracionViewModel(aplicacionConfiguracion);
            }
            aplicacionConfiguracionViewModelBindingSource.DataSource = ViewModel;
        }
        #endregion

        #region Eventos de Formulario
        private void GrabarButton_Click(object sender, EventArgs e)
        {
            Grabar();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            aplicacionConfiguracionViewModelBindingSource.CancelEdit();
            this.Close();
        }
        #endregion

        #region Eventos Privados

        private void Grabar()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                aplicacionConfiguracionViewModelBindingSource.EndEdit();
                ViewModel.Grabar();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Ocurrió un error al grabar, mensaje de error: {0}", ex.Message)
                    , "Grabar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
        #endregion
    }
}
