using AdmCostoProduccion.Common.Data;
using AdmCostoProduccion.Common.Helpers;
using AdmCostoProduccion.Common.ViewModels.Maestro;
using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmCostoProduccion.Common.Commands
{
    public static class MaestroCommand
    {
        public static void CargarMasivoAlmacen(string pRutaArchivo)
        {
            List<AlmacenViewModel> almacenViewModels = new List<AlmacenViewModel>();

            if (System.IO.File.Exists(pRutaArchivo))
            {
                using (FileStream FS = new FileStream(pRutaArchivo, FileMode.Open, FileAccess.Read))
                {
                    IWorkbook workbook = WorkbookFactory.Create(FS);
                    ISheet worksheet = workbook.GetSheetAt(0);

                    using (var context = new ApplicationDbContext())
                    {
                        for (int rowIndex = 1; rowIndex <= worksheet.LastRowNum; rowIndex++)
                        {
                            IRow row = worksheet.GetRow(rowIndex);
                            if (row != null)
                            {
                                var codigoCentroLogistico = row.GetCell(0).ToString();
                                var centroLogistico = context.CentroLogisticos
                                    .Where(o => o.Codigo == codigoCentroLogistico)
                                    .FirstOrDefault();
                                if (centroLogistico == null)
                                    throw new Exception(string.Format("Código de centrologistico {0} no encontrado", codigoCentroLogistico));

                                AlmacenViewModel almacenViewModel = new AlmacenViewModel
                                {
                                    CentroLogisticoId = centroLogistico.CentroLogisticoId,
                                    Codigo = row.GetCell(1).ToString(),
                                    Nombre = row.GetCell(2).ToString(),
                                    Descripcion = row.GetCell(3).ToString()
                                };
                                almacenViewModels.Add(almacenViewModel);
                            }
                        }

                        using (var dbContextTransaction = context.Database.BeginTransaction())
                        {
                            try
                            {
                                foreach (var almacenViewModel in almacenViewModels)
                                {
                                    almacenViewModel.Grabar(context);
                                }
                                dbContextTransaction.Commit();
                            }
                            catch (Exception ex)
                            {
                                dbContextTransaction.Rollback();
                                throw ex;
                            }
                        }
                    }
                }
            }
            else
            {
                throw new Exception("El archivo especificado no existe.");
            }

        }
    }
}
