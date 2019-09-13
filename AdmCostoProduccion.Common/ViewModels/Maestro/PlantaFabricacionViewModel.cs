using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Data;
using AdmCostoProduccion.Common.Models.Maestro;
using System;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace AdmCostoProduccion.Common.ViewModels.Maestro
{
    public class PlantaFabricacionViewModel : ObjectBase
    {
        #region Constructor

        public PlantaFabricacionViewModel()
        {
            _IsNew = true;
            _PlantaFabricacionId = Guid.NewGuid().ToString();
        }

        public PlantaFabricacionViewModel(PlantaFabricacion model)
        {
            _PlantaFabricacionId = model.PlantaFabricacionId;
            _CentroLogisticoId = model.CentroLogisticoId;
            _Codigo = model.Codigo;
            _Nombre = model.Nombre;
            _Descripcion = model.Descripcion;
            _CentroLogistico = model.CentroLogistico.Nombre;
        }

        #endregion

        #region Propiedades privadas

        private string _PlantaFabricacionId;

        private string _CentroLogisticoId;

        private string _Codigo;

        private string _Nombre;

        private string _Descripcion;

        private string _CentroLogistico;

        #endregion

        #region Propiedades publicas

        public string PlantaFabricacionId
        {
            get
            {
                return _PlantaFabricacionId;
            }

            set
            {
                if (value != _PlantaFabricacionId)
                {
                    _PlantaFabricacionId = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string CentroLogisticoId
        {
            get
            {
                return _CentroLogisticoId;
            }

            set
            {
                if (value != _CentroLogisticoId)
                {
                    _CentroLogisticoId = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Codigo
        {
            get
            {
                return _Codigo;
            }

            set
            {
                if (value != _Codigo)
                {
                    _Codigo = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Nombre
        {
            get
            {
                return _Nombre;
            }

            set
            {
                if (value != _Nombre)
                {
                    _Nombre = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Descripcion
        {
            get
            {
                return _Descripcion;
            }

            set
            {
                if (value != _Descripcion)
                {
                    _Descripcion = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string CentroLogistico
        {
            get
            {
                return _CentroLogistico;
            }

            set
            {
                if (value != _CentroLogistico)
                {
                    _CentroLogistico = value;
                    NotifyPropertyChanged();
                }
            }
        }

        #endregion

        #region Metodos Publicos

        public void CopyOf(PlantaFabricacionViewModel viewModel)
        {
            _IsNew = viewModel.IsNew;
            _IsOld = viewModel.IsOld;
            _PlantaFabricacionId = viewModel.PlantaFabricacionId;
            _CentroLogisticoId = viewModel.CentroLogisticoId;
            _Codigo = viewModel.Codigo;
            _Nombre = viewModel.Nombre;
            _Descripcion = viewModel.Descripcion;
            _CentroLogistico = viewModel.CentroLogistico;
        }

        public PlantaFabricacion ToModel()
        {
            PlantaFabricacion model = new PlantaFabricacion
            {
                PlantaFabricacionId = _PlantaFabricacionId,
                CentroLogisticoId = _CentroLogisticoId,
                Codigo = _Codigo,
                Nombre = _Nombre,
                Descripcion = _Descripcion
            };

            return model;
        }

        public void Grabar()
        {
            using (var context = new ApplicationDbContext())
            {
                PlantaFabricacion model = this.ToModel();

                if (IsNew)
                {
                    context.PlantaFabricacions.Add(model);
                }
                else
                {
                    if (IsOld)
                    {
                        context.Entry(model).State = EntityState.Modified;
                    }
                }
                context.SaveChanges();
                _IsNew = false;
                _IsOld = false;
                _PlantaFabricacionId = model.PlantaFabricacionId;
            }
        }

        public void Eliminar()
        {
            using (var context = new ApplicationDbContext())
            {
                PlantaFabricacion model = this.ToModel();
                context.Entry(model).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        #endregion
    }
}
