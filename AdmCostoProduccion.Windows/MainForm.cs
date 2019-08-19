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
using AdmCostoProduccion.Windows.Procesos.Inventario.Recepcion;
using AdmCostoProduccion.Windows.Procesos.Inventario.Despacho;
using AdmCostoProduccion.Windows.Procesos.CompraVenta.Venta;
using AdmCostoProduccion.Windows.Procesos.CompraVenta.Compra;
using AdmCostoProduccion.Windows.Procesos.Produccion.OrdenProduccion;
using AdmCostoProduccion.Windows.Procesos.Contabilidad.CostoProduccion;
using AdmCostoProduccion.Windows.Mantenimiento.Aplicacion.AplicacionConfiguracion;
using AdmCostoProduccion.Windows.Mantenimiento.Aplicacion.AplicacionCorrelativo;

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

        private void MainFormKryptonDockableNavigator_CloseAction(object sender, CloseActionEventArgs e)
        {
            (e.Item.Tag as Form).Close();
            if (MainFormKryptonDockableNavigator.Pages.Count == 1)
            {
                MainFormKryptonDockableNavigator.Visible = false;
            }
        }

        private void AplicacionConfiguracionMenuItem_Click(object sender, EventArgs e)
        {
            var form = new MntAplicacionConfiguracionForm();
            form.ShowDialog();
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

        private void RecepcionMenuItem_Click(object sender, EventArgs e)
        {
            var form = new LstRecepcionForm
            {
                MdiParent = this
            };
            form.Show();
        }

        private void DespachoMenuItem_Click(object sender, EventArgs e)
        {
            var form = new LstDespachoForm
            {
                MdiParent = this
            };
            form.Show();
        }

        private void VentaMenuItem_Click(object sender, EventArgs e)
        {
            var form = new LstVentaForm
            {
                MdiParent = this
            };
            form.Show();
        }

        private void CompraMenuItem_Click(object sender, EventArgs e)
        {
            var form = new LstCompraForm
            {
                MdiParent = this
            };
            form.Show();
        }

        private void OrdenProduccionMenuItem_Click(object sender, EventArgs e)
        {
            var form = new LstOrdenProduccionForm
            {
                MdiParent = this
            };
            form.Show();
        }

        private void CostoProduccionMenuItem_Click(object sender, EventArgs e)
        {
            var form = new LstCostoProduccionForm
            {
                MdiParent = this
            };
            form.Show();
        }

        private void CorrelativoMenuItem_Click(object sender, EventArgs e)
        {
            var form = new LstAplicacionCorrelativoForm
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
    }
}
