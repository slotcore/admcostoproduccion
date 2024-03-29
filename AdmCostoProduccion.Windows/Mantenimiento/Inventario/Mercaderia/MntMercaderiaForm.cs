﻿using AdmCostoProduccion.Common.Classes;
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

namespace AdmCostoProduccion.Windows.Mantenimiento.Inventario.Mercaderia
{
    public partial class MntMercaderiaForm : KryptonForm
    {
        #region Propiedades
        private MercaderiaViewModel ViewModel = new MercaderiaViewModel();
        private ObservableListSource<MercaderiaViewModel> ViewModelList;
        private List<TipoMercaderiaViewModel> tipoMercaderiaViewModels;
        private List<FamiliaMercaderiaViewModel> familiaMercaderiaViewModels;
        #endregion

        #region Constructor
        public MntMercaderiaForm(MercaderiaViewModel viewModel
            , ObservableListSource<MercaderiaViewModel> viewModelList)
        {
            InitializeComponent();
            ViewModel.CopyOf(viewModel);
            ViewModelList = viewModelList;
            CargarCombos();
            mercaderiaViewModelBindingSource.DataSource = ViewModel;
        }

        public MntMercaderiaForm(ObservableListSource<MercaderiaViewModel> viewModelList)
        {
            InitializeComponent();
            ViewModel = new MercaderiaViewModel();
            ViewModelList = viewModelList;
            CargarCombos();
            mercaderiaViewModelBindingSource.DataSource = ViewModel;
        }
        #endregion

        #region Eventos de Formulario
        private void GrabarButton_Click(object sender, EventArgs e)
        {
            Grabar();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            mercaderiaViewModelBindingSource.CancelEdit();
            this.Close();
        }
        #endregion

        #region Eventos Privados

        private void Grabar()
        {
            try
            {
                bool IsNew = ViewModel.IsNew;
                Cursor = Cursors.WaitCursor;
                mercaderiaViewModelBindingSource.EndEdit();
                ViewModel.Grabar();
                if (IsNew) ViewModelList.Add(ViewModel);
                else
                {
                    var viewModel = ViewModelList
                        .Where(o => o.MercaderiaId == ViewModel.MercaderiaId)
                        .FirstOrDefault();
                    viewModel.CopyOf(ViewModel);
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

        private void CargarCombos()
        {
            using (var context = new ApplicationDbContext())
            {
                var TipoMercaderias = context.TipoMercaderias.ToList();
                tipoMercaderiaViewModels = new List<TipoMercaderiaViewModel>();
                foreach (var model in TipoMercaderias)
                {
                    tipoMercaderiaViewModels.Add(new TipoMercaderiaViewModel(model));
                }
                tipoMercaderiaViewModelBindingSource.DataSource = tipoMercaderiaViewModels;

                var familiaMercaderias = context.FamiliaMercaderias.ToList();
                familiaMercaderiaViewModels = new List<FamiliaMercaderiaViewModel>();
                foreach (var familiaMercaderia in familiaMercaderias)
                {
                    familiaMercaderiaViewModels.Add(new FamiliaMercaderiaViewModel(familiaMercaderia));
                }
                familiaMercaderiaViewModelBindingSource.DataSource = familiaMercaderiaViewModels;
            }
        }
        #endregion
    }
}
