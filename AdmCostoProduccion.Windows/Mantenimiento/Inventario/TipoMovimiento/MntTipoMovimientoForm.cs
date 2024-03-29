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

namespace AdmCostoProduccion.Windows.Mantenimiento.Inventario.TipoMovimiento
{
    public partial class MntTipoMovimientoForm : KryptonForm
    {
        private readonly ApplicationDbContext Context = new ApplicationDbContext();
        private TipoMovimientoViewModel ViewModel = new TipoMovimientoViewModel();

        #region Propiedades
        public bool IsNew { get; set; }
        public ObservableListSource<TipoMovimientoViewModel> ViewModelList { get; set; }
        #endregion

        #region Constructor
        public MntTipoMovimientoForm(TipoMovimientoViewModel viewModel
            , ObservableListSource<TipoMovimientoViewModel> viewModelList)
        {
            InitializeComponent();
            IsNew = false;
            viewModel.CopyTo(ref ViewModel);
            ViewModelList = viewModelList;
            tipoMovimientoViewModelBindingSource.DataSource = ViewModel;
        }

        public MntTipoMovimientoForm(ObservableListSource<TipoMovimientoViewModel> viewModelList)
        {
            InitializeComponent();
            IsNew = true;
            ViewModelList = viewModelList;
            tipoMovimientoViewModelBindingSource.DataSource = ViewModel;
        }
        #endregion

        #region Eventos de Formulario
        private void GrabarButton_Click(object sender, EventArgs e)
        {
            Grabar();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            tipoMovimientoViewModelBindingSource.CancelEdit();
            this.Close();
        }
        #endregion

        #region Eventos Privados

        private void Grabar()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                tipoMovimientoViewModelBindingSource.EndEdit();

                var model = ViewModel.ToModel();
                if (IsNew)
                {
                    Context.TipoMovimientos.Add(model);
                    Context.SaveChanges();
                    //
                    ViewModel.TipoMovimientoId = model.TipoMovimientoId;
                    ViewModelList.Add(ViewModel);
                }
                else
                {
                    Context.Entry(model).State = EntityState.Modified;
                    Context.SaveChanges();
                    //
                    var viewModel = ViewModelList
                        .Where(o => o.TipoMovimientoId == ViewModel.TipoMovimientoId)
                        .FirstOrDefault();
                    ViewModel.CopyTo(ref viewModel);
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
