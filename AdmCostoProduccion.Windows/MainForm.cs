using AdmCostoProduccion.Windows.Maestro.Almacen;
using AdmCostoProduccion.Windows.Maestro.CentroLogistico;
using ComponentFactory.Krypton.Toolkit;
using ComponentFactory.Krypton.Navigator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdmCostoProduccion.Windows.Maestro.PlantaFabricacion;
using AdmCostoProduccion.Windows.Mantenimiento.Inventario.UnidadMedida;
using AdmCostoProduccion.Windows.Mantenimiento.Inventario.TipoMercaderia;
using AdmCostoProduccion.Windows.Mantenimiento.Inventario.Mercaderia;
using AdmCostoProduccion.Windows.Mantenimiento.Inventario.TipoMovimiento;
using AdmCostoProduccion.Windows.Mantenimiento.Inventario.TipoRecepcion;
using AdmCostoProduccion.Windows.Mantenimiento.Inventario.TipoDespacho;
using AdmCostoProduccion.Windows.Mantenimiento.Produccion.ProcedimientoProduccion;

namespace AdmCostoProduccion.Windows
{
    public partial class MainForm : KryptonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_MdiChildActivate(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
                MainFormKryptonDockableNavigator.Visible = false;
            else
            {
                this.ActiveMdiChild.FormBorderStyle = FormBorderStyle.None;
                this.ActiveMdiChild.WindowState = FormWindowState.Maximized;
                this.ActiveMdiChild.Dock = DockStyle.Fill;
                this.ActiveMdiChild.TopLevel = false;

                // If child form is new and no has tabPage, create new tabPage
                if (this.ActiveMdiChild.Tag == null)
                {
                    KryptonPage page = new KryptonPage(this.ActiveMdiChild.Text)
                    {
                        Tag = this.ActiveMdiChild
                    };

                    this.ActiveMdiChild.FormClosed += new FormClosedEventHandler(ActiveMdiChild_FormClosed);
                    this.ActiveMdiChild.Parent = page;

                    MainFormKryptonDockableNavigator.Pages.Add(page);
                    MainFormKryptonDockableNavigator.SelectedPage = page;
                }

                if (!MainFormKryptonDockableNavigator.Visible) MainFormKryptonDockableNavigator.Visible = true;
            }
        }

        private void MainFormKryptonDockableNavigator_SelectedPageChanged(object sender, EventArgs e)
        {
            if ((MainFormKryptonDockableNavigator.SelectedPage != null) && (MainFormKryptonDockableNavigator.SelectedPage.Tag != null))
                (MainFormKryptonDockableNavigator.SelectedPage.Tag as Form).Select();
        }

        private void ActiveMdiChild_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((sender as Form).Tag as KryptonPage).Dispose();
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
            form.Show();
        }

        private void PlantaFabricacionMenuItem_Click(object sender, EventArgs e)
        {
            var form = new LstPlantaFabricacionForm
            {
                MdiParent = this
            };
            form.Show();
        }

        private void TipoMercaderiaMenuItem_Click(object sender, EventArgs e)
        {
            var form = new LstTipoMercaderiaForm
            {
                MdiParent = this
            };
            form.Show();
        }

        private void UnidadMedidaMenuItem_Click(object sender, EventArgs e)
        {
            var form = new LstUnidadMedidaForm
            {
                MdiParent = this
            };
            form.Show();
        }

        private void SalirMenuItem_Click(object sender, EventArgs e)
        {
            Salir();
        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            Salir();
        }

        private void Salir()
        {
            this.Close();
        }

        private void MercaderíaMenuItem_Click(object sender, EventArgs e)
        {
            var form = new LstMercaderiaForm
            {
                MdiParent = this
            };
            form.Show();
        }

        private void TipoMovimientoMenuItem_Click(object sender, EventArgs e)
        {
            var form = new LstTipoMovimientoForm
            {
                MdiParent = this
            };
            form.Show();
        }

        private void TipoRecepcionMenuItem_Click(object sender, EventArgs e)
        {
            var form = new LstTipoRecepcionForm
            {
                MdiParent = this
            };
            form.Show();
        }

        private void TipoDespachoMenuItem_Click(object sender, EventArgs e)
        {
            var form = new LstTipoDespachoForm
            {
                MdiParent = this
            };
            form.Show();
        }

        private void ProcedimientoProduccionMenuItem_Click(object sender, EventArgs e)
        {
            var form = new LstProcedimientoProduccionForm
            {
                MdiParent = this
            };
            form.Show();
        }
    }
}
