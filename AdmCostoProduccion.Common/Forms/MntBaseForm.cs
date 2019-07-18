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
    public partial class MntBaseForm : KryptonForm
    {
        public event EventHandler Grabar;
        public event EventHandler Cancelar;

        public MntBaseForm()
        {
            InitializeComponent();
        }

        private void GrabarButton_Click(object sender, EventArgs e)
        {
            Grabar?.Invoke(sender, e);
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            Cancelar?.Invoke(sender, e);
        }
    }
}
