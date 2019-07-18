using AdmCostoProduccion.Common.Forms;
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
    public partial class LstCentroLogisticoForm : LstBaseForm
    {
        public LstCentroLogisticoForm()
        {
            InitializeComponent();
        }

        private void LstCentroLogisticoForm_Agregar(object sender, EventArgs e)
        {
            var frm = new MntCentroLogisticoForm();
            frm.ShowDialog();
        }
    }
}
