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
    public partial class MainBaseForm : KryptonForm
    {
        public MainBaseForm()
        {
            InitializeComponent();
        }

        private void MainBaseForm_MdiChildActivate(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
                MainBaseTabForm.Visible = false;
            else
            {
                this.ActiveMdiChild.WindowState = FormWindowState.Maximized;
                this.ActiveMdiChild.Dock = DockStyle.Fill;
                this.ActiveMdiChild.TopLevel = false;
                this.ActiveMdiChild.FormBorderStyle = FormBorderStyle.None;

                // If child form is new and no has tabPage, create new tabPage
                if (this.ActiveMdiChild.Tag == null)
                {
                    // Add a tabPage to tabControl with child form caption
                    TabPage tp = new TabPage(this.ActiveMdiChild.Text);
                    tp.Tag = this.ActiveMdiChild;
                    tp.Parent = MainBaseTabForm;
                    MainBaseTabForm.SelectedTab = tp;

                    this.ActiveMdiChild.Tag = tp;
                    this.ActiveMdiChild.FormClosed += new FormClosedEventHandler(ActiveMdiChild_FormClosed);
                }

                if (!MainBaseTabForm.Visible) MainBaseTabForm.Visible = true;
            }
        }

        private void ActiveMdiChild_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((sender as Form).Tag as TabPage).Dispose();
        }

        private void MainBaseTabForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((MainBaseTabForm.SelectedTab != null) && (MainBaseTabForm.SelectedTab.Tag != null))
                (MainBaseTabForm.SelectedTab.Tag as Form).Select();
        }
    }
}
