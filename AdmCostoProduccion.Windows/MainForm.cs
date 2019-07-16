using AdmCostoProduccion.Windows.Maestro.Almacen;
using AdmCostoProduccion.Windows.Maestro.CentroLogistico;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdmCostoProduccion.Windows
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_MdiChildActivate(object sender, EventArgs e)
        {
            //if (this.ActiveMdiChild == null)
            //    MainTabForm.Visible = false; // If no any child form, hide tabControl
            //else
            //{
            //    this.ActiveMdiChild.WindowState = FormWindowState.Maximized; // Child form always maximized
            //    this.ActiveMdiChild.Dock = DockStyle.Fill;
            //    this.ActiveMdiChild.TopLevel = false;
            //    this.ActiveMdiChild.FormBorderStyle = FormBorderStyle.None;

            //    // If child form is new and no has tabPage, create new tabPage
            //    if (this.ActiveMdiChild.Tag == null)
            //    {
            //        // Add a tabPage to tabControl with child form caption
            //        TabPage tp = new TabPage(this.ActiveMdiChild.Text);
            //        tp.Tag = this.ActiveMdiChild;
            //        tp.Parent = MainTabForm;
            //        MainTabForm.SelectedTab = tp;

            //        this.ActiveMdiChild.Tag = tp;
            //        this.ActiveMdiChild.FormClosed += new FormClosedEventHandler(ActiveMdiChild_FormClosed);
            //    }

            //    if (!MainTabForm.Visible) MainTabForm.Visible = true;
            //}
        }

        private void ActiveMdiChild_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((sender as Form).Tag as TabPage).Dispose();
        }

        private void MainTabForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((MainTabForm.SelectedTab != null) && (MainTabForm.SelectedTab.Tag != null))
                (MainTabForm.SelectedTab.Tag as Form).Select();
        }

        private void CentroLogisticoMenuItem_Click(object sender, EventArgs e)
        {
            var form = new LstCentroLogisticoForm
            {
                MdiParent = this
            };
            form.Show();
        }

        private void AlmacenMenuItem_Click(object sender, EventArgs e)
        {
            var form = new LstAlmacenForm
            {
                MdiParent = this
            };
            ToolStripManager.Merge(form.MainMenuStrip, this.MainMenuStrip);
            form.Show();
        }
    }
}
