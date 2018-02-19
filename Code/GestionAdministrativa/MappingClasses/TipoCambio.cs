using System.Linq;
using EFF;
using System.Collections.Generic;
using System.Data;
using System;

namespace MappingClasses
{
    public class TipoCambio:BaseData
    {
        public int Id { get; set; }
        public decimal Valor { get; set; }
        public System.DateTime Fecha { get; set; }
        public bool Activo { get; set; }


        public ICollection<EFF.TipoCambio> GetAllTiposCambios()
        {
            return context.TipoCambios.ToList();
        }

        public EFF.TipoCambio GetTipoCambio(int idTipoCambio)
        {
            return context.TipoCambios.Where(e => e.Id == idTipoCambio).FirstOrDefault();
        }


        public void AddTipoCambio(EFF.TipoCambio tipoCambio)
        {
            context.TipoCambios.Add(tipoCambio);
            context.SaveChanges();

            EFF.TipoCambio tipoCambioActivo = GetAllTiposCambios().Where(e => e.Id != tipoCambio.Id && e.Activo).SingleOrDefault();
            if (tipoCambio != null) {
                tipoCambioActivo.Activo = false;
                UpdateTipoCambio(tipoCambioActivo);
            }
        }

        public void UpdateTipoCambio(EFF.TipoCambio tipoCambio)
        {
            EFF.TipoCambio tipoCambioBD = context.TipoCambios.Where(e => e.Id == tipoCambio.Id).FirstOrDefault();
            tipoCambioBD.Valor = tipoCambio.Valor;
            tipoCambioBD.Activo = tipoCambio.Activo;
            context.SaveChanges();

        }

        public List<string> deleteTipoCambio(int tipoCambio)
        {
            try

            {
                EFF.TipoCambio TipoCambioBD = context.TipoCambios.Where(e => e.Id == tipoCambio).FirstOrDefault();
                context.TipoCambios.Remove(TipoCambioBD);
                context.SaveChanges();

            }
            catch (Exception cnExp)

            {
                //var sqlError = cnExp.InnerException as System.Data.SqlClient.SqlException;
                //if (sqlError.Number == 2601 || sqlError.Number == 2627)
                //{
                LoggerService.WriteEntryError(cnExp.InnerException.Message);
                    return new List<string> { cnExp.Message };
                //}
            }
            return new List<string>();
        }


    }
}
