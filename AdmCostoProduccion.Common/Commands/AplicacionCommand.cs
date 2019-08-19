using AdmCostoProduccion.Common.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmCostoProduccion.Common.Commands
{
    public static class AplicacionCommand
    {
        public static string GetCorrelativo(string codigo)
        {
            string correlativo = string.Empty;

            using (var context = new ApplicationDbContext())
            {
                var aplicacionCorrelativo = context.AplicacionCorrelativos
                    .Where(o => o.Codigo == codigo)
                    .FirstOrDefault();

                if (aplicacionCorrelativo == null)
                {
                    throw new Exception(string.Format("No existe correlativo asociado al codigo: {0}", codigo));
                }

                int _IndiceDigito = 0;
                string _NumeroDigitosCadena = string.Empty;
                while (_IndiceDigito < aplicacionCorrelativo.NumeroDigitos)
                {
                    _NumeroDigitosCadena = string.Format("{0}0", _NumeroDigitosCadena);
                    _IndiceDigito++;
                }
                correlativo = string.Format("{0}{1}", aplicacionCorrelativo.Prefijo, string.Format("{0:" + _NumeroDigitosCadena + "}", aplicacionCorrelativo.Correlativo));

                aplicacionCorrelativo.Correlativo += 1;
                context.Entry(aplicacionCorrelativo).State = EntityState.Modified;
                context.SaveChanges();
            }

            return correlativo;
        }
    }
}
