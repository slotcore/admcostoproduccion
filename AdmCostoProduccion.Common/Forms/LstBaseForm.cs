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

namespace AdmCostoProduccion.Common.Forms
{
    public partial class LstBaseForm : Form
    {
        public event EventHandler Agregar;
        public event EventHandler Modificar;
        public event EventHandler Eliminar;
        public event EventHandler Actualizar;
        public event EventHandler CargarExcel;

        public LstBaseForm()
        {
            InitializeComponent();
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            Agregar?.Invoke(sender, e);
        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            Modificar?.Invoke(sender, e);
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            Eliminar?.Invoke(sender, e);
        }

        private void ActualizarButton_Click(object sender, EventArgs e)
        {
            Actualizar?.Invoke(sender, e);
        }

        private void CargarExcelButton_Click(object sender, EventArgs e)
        {
            CargarExcel?.Invoke(sender, e);
        }
    }
}
