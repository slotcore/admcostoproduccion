﻿using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Data;
using AdmCostoProduccion.Common.ViewModels.Maestro;
using AdmCostoProduccion.Windows.Mantenimiento.Maestro.PlantaFabricacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdmCostoProduccion.Windows.Maestro.PlantaFabricacion
{
    public partial class LstPlantaFabricacionForm : Form
    {
        private ObservableListSource<PlantaFabricacionViewModel> _PlantaFabricacionViewModels = new ObservableListSource<PlantaFabricacionViewModel>();

        #region Constructor
        public LstPlantaFabricacionForm()
        {
            InitializeComponent();

            _PlantaFabricacionViewModels = new ObservableListSource<PlantaFabricacionViewModel>();
            plantaFabricacionViewModelBindingSource.DataSource = _PlantaFabricacionViewModels;
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
                var frm = new MntPlantaFabricacionForm(_PlantaFabricacionViewModels);
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
                var _PlantaFabricacion = (PlantaFabricacionViewModel)plantaFabricacionViewModelBindingSource.Current;
                var frm = new MntPlantaFabricacionForm(_PlantaFabricacion, _PlantaFabricacionViewModels);
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
                    var _context = new ApplicationDbContext();
                    var _PlantaFabricacionViewModel = (PlantaFabricacionViewModel)plantaFabricacionViewModelBindingSource.Current;
                    var _PlantaFabricacion = _context.PlantaFabricacions
                        .Where(o => o.PlantaFabricacionId == _PlantaFabricacionViewModel.PlantaFabricacionId)
                        .FirstOrDefault();
                    _context.PlantaFabricacions.Remove(_PlantaFabricacion);
                    _context.SaveChanges();
                    _PlantaFabricacionViewModels.Remove(_PlantaFabricacionViewModel);
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
                var plantaFabricacions = new ApplicationDbContext().PlantaFabricacions.ToList();
                _PlantaFabricacionViewModels.Clear();
                foreach (var plantaFabricacion in plantaFabricacions)
                {
                    _PlantaFabricacionViewModels.Add(new PlantaFabricacionViewModel(plantaFabricacion));
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
                var plantaFabricacions = new ApplicationDbContext().PlantaFabricacions.Where(o =>
                                o.Codigo.ToUpper().Contains(cadenaBusqueda) ||
                                o.Nombre.ToUpper().Contains(cadenaBusqueda) ||
                                o.Descripcion.ToUpper().Contains(cadenaBusqueda)).ToList();

                _PlantaFabricacionViewModels.Clear();
                foreach (var plantaFabricacion in plantaFabricacions)
                {
                    _PlantaFabricacionViewModels.Add(new PlantaFabricacionViewModel(plantaFabricacion));
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

        private void CargarExcelButton_Click(object sender, EventArgs e)
        {
            try
            {
                string m_ExcelFileName;
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Filter = "Archivos Excel|*.xls",
                    Title = "Seleccionar Archivo"
                };
                if ((openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK))
                {
                    m_ExcelFileName = openFileDialog.FileName;
                    if (string.IsNullOrEmpty(m_ExcelFileName))
                    {
                        throw new Exception("Se debe de seleccionar el archivo para comenzar el proceso.");
                    }

                    if ((MessageBox.Show("Se procesará el archivo seleccionado. ¿Seguro desea continuar?", "Procesar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes))
                    {
                        Cursor = Cursors.WaitCursor;
                        
                        MessageBox.Show("Se procesó correctamente al archivo seleccionado", "Cargar Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message
                    , "Cargar Excel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
    }
}
