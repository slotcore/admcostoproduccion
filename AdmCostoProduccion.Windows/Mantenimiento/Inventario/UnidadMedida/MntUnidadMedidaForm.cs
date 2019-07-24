using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Data;
using AdmCostoProduccion.Common.ViewModels.Inventario;
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

namespace AdmCostoProduccion.Windows.Mantenimiento.Inventario.UnidadMedida
{
    public partial class MntUnidadMedidaForm : KryptonForm
    {
        private readonly ApplicationDbContext Context = new ApplicationDbContext();
        private UnidadMedidaViewModel UnidadMedidaViewModel = new UnidadMedidaViewModel();

        #region Propiedades
        public bool IsNew { get; set; }
        public ObservableListSource<UnidadMedidaViewModel> UnidadMedidaViewModels { get; set; }
        #endregion

        #region Constructor
        public MntUnidadMedidaForm(UnidadMedidaViewModel UnidadMedidaViewModel
            , ObservableListSource<UnidadMedidaViewModel> UnidadMedidaViewModels)
        {
            InitializeComponent();
            IsNew = false;
            UnidadMedidaViewModel.CopyTo(ref this.UnidadMedidaViewModel);
            this.UnidadMedidaViewModels = UnidadMedidaViewModels;
            unidadMedidaViewModelBindingSource.DataSource = this.UnidadMedidaViewModel;
        }

        public MntUnidadMedidaForm(ObservableListSource<UnidadMedidaViewModel> UnidadMedidaViewModels)
        {
            InitializeComponent();
            IsNew = true;
            this.UnidadMedidaViewModels = UnidadMedidaViewModels;
            unidadMedidaViewModelBindingSource.DataSource = UnidadMedidaViewModel;
        }
        #endregion

        #region Eventos de Formulario
        private void GrabarButton_Click(object sender, EventArgs e)
        {
            Grabar();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            unidadMedidaViewModelBindingSource.CancelEdit();
            this.Close();
        }
        #endregion

        #region Eventos Privados

        private void Grabar()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                unidadMedidaViewModelBindingSource.EndEdit();

                var unidadMedida = UnidadMedidaViewModel.ToModel();
                if (IsNew)
                {
                    Context.UnidadMedidas.Add(unidadMedida);
                    Context.SaveChanges();
                    //
                    UnidadMedidaViewModel.UnidadMedidaId = unidadMedida.UnidadMedidaId;
                    UnidadMedidaViewModels.Add(UnidadMedidaViewModel);
                }
                else
                {
                    Context.Entry(unidadMedida).State = EntityState.Modified;
                    Context.SaveChanges();
                    //
                    var _UnidadMedidaViewModel = UnidadMedidaViewModels
                        .Where(o => o.UnidadMedidaId == UnidadMedidaViewModel.UnidadMedidaId)
                        .FirstOrDefault();
                    UnidadMedidaViewModel.CopyTo(ref _UnidadMedidaViewModel);
                }
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
