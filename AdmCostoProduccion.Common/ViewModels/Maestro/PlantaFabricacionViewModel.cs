﻿using AdmCostoProduccion.Common.Classes;
using AdmCostoProduccion.Common.Models.Maestro;
using System;
using System.Linq;
using System.Text;

namespace AdmCostoProduccion.Common.ViewModels.Maestro
{
    public class PlantaFabricacionViewModel : ObjectBase
    {
        #region Constructor

        public PlantaFabricacionViewModel()
        {
        }

        public PlantaFabricacionViewModel(PlantaFabricacion model)
        {
            _PlantaFabricacionId = model.PlantaFabricacionId;
            _Codigo = model.Codigo;
            _Nombre = model.Nombre;
            _Descripcion = model.Descripcion;
        }

        #endregion

        #region Propiedades privadas

        private int _PlantaFabricacionId;

        private int _CentroLogisticoId;

        private string _Codigo;

        private string _Nombre;

        private string _Descripcion;

        private string _CentroLogistico;

        #endregion

        #region Propiedades publicas

        public int PlantaFabricacionId
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

        public int CentroLogisticoId
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

        public void CopyTo(ref PlantaFabricacionViewModel viewModel)
        {
            viewModel.PlantaFabricacionId = _PlantaFabricacionId;
            viewModel.Codigo = _Codigo;
            viewModel.Nombre = _Nombre;
            viewModel.Descripcion = _Descripcion;
            viewModel.CentroLogistico = _CentroLogistico;
            viewModel.CentroLogisticoId = _CentroLogisticoId;
        }

        public PlantaFabricacion ToModel()
        {
            PlantaFabricacion model = new PlantaFabricacion
            {
                PlantaFabricacionId = _PlantaFabricacionId,
                Codigo = _Codigo,
                Nombre = _Nombre,
                Descripcion = _Descripcion,
                CentroLogisticoId = _CentroLogisticoId
            };

            return model;
        }

        #endregion
    }
}