﻿using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Data;
using AdmCostoProduccion.Common.ViewModels.Produccion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdmCostoProduccion.Windows.Procesos.Produccion.OrdenProduccion
{
    public partial class LstOrdenProduccionForm : Form
    {
        private ObservableListSource<OrdenProduccionViewModel> ViewModelList = new ObservableListSource<OrdenProduccionViewModel>();

        #region Constructor
        public LstOrdenProduccionForm()
        {
            InitializeComponent();

            ViewModelList = new ObservableListSource<OrdenProduccionViewModel>();
            ordenProduccionViewModelBindingSource.DataSource = ViewModelList;
        }
        #endregion

        #region Eventos de Formulario
        private void AgregarButton_Click(object sender, EventArgs e)
        {
            Agregar();
        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            Modificar();
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void ActualizarButton_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            BusquedaTextBox.Clear();
        }

        private void BusquedaTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Buscar();
            }
        }
        #endregion

        #region Eventos Privados
        private void Agregar()
        {
            try
            {
                var frm = new MntOrdenProduccionForm(ViewModelList);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Ocurrió un error al agregar, mensaje de error: {0}", ex.Message)
                    , "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Modificar()
        {
            try
            {
                var viewModel = (OrdenProduccionViewModel)ordenProduccionViewModelBindingSource.Current;
                var frm = new MntOrdenProduccionForm(viewModel, ViewModelList);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Ocurrió un error al modificar, mensaje de error: {0}", ex.Message)
                    , "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Eliminar()
        {
            try
            {
                if (MessageBox.Show("¿Esta seguro de eliminar el registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Cursor = Cursors.WaitCursor;
                    var viewModel = (OrdenProduccionViewModel)ordenProduccionViewModelBindingSource.Current;
                    viewModel.Eliminar();
                    ViewModelList.RemoveItem(viewModel);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Ocurrió un error al eliminar, mensaje de error: {0}", ex.Message)
                    , "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void Actualizar()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                var list = new ApplicationDbContext().OrdenProduccions.ToList();
                ViewModelList.Clear();
                foreach (var model in list)
                {
                    ViewModelList.Add(new OrdenProduccionViewModel(model));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Ocurrió un error al actualizar, mensaje de error: {0}", ex.Message)
                    , "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void Buscar()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                var cadenaBusqueda = BusquedaTextBox.Text.Trim().ToUpper();
                var list = new ApplicationDbContext().OrdenProduccions.Where(o =>
                                o.Codigo.ToUpper().Contains(cadenaBusqueda) ||
                                o.Lote.ToUpper().Contains(cadenaBusqueda) ||
                                o.Mercaderia.Codigo.ToUpper().Contains(cadenaBusqueda)).ToList();

                ViewModelList.Clear();
                foreach (var model in list)
                {
                    ViewModelList.Add(new OrdenProduccionViewModel(model));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Ocurrió un error al buscar, mensaje de error: {0}", ex.Message)
                    , "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
        #endregion
    }
}
