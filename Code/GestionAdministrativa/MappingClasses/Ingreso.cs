using System.Linq;
using System.Collections.Generic;

namespace MappingClasses
{
    public class Ingreso:BaseData
    {

        public List<EFF.IngresoModel> GetAllIngresos()
        {
          return (from ingres in context.Ingresoes
                   join Proyect in context.Proyectoes on ingres.IdProyecto equals Proyect.Id
                   join tipoC in context.TipoCambios on ingres.IdTipoCambio equals tipoC.Id orderby ingres.Fecha descending
                   select new EFF.IngresoModel {
                       Id= ingres.Id,
                      Nombre= ingres.Nombre,
                     Fecha=  ingres.Fecha,
                     MontoColones=  ingres.MontoColones,
                    MontoDolares=   ingres.MontoDolares,
                      TipoCambio= tipoC.Valor,
                      IdProyecto= Proyect.Descripcion,
                   }).ToList();
        }

        public EFF.Ingreso GetIngreso(int idIngreso)
        {
            return context.Ingresoes.Where(e => e.Id == idIngreso).FirstOrDefault();
        }


        public void AddIngreso(EFF.Ingreso Ingreso)
        {
            context.Ingresoes.Add(Ingreso);
            context.SaveChanges();

        }

        public void UpdateIngreso(EFF.Ingreso Ingreso)
        {
            EFF.Ingreso ingresoBD= context.Ingresoes.Where(e => e.Id == Ingreso.Id).FirstOrDefault();
            ingresoBD.Nombre = Ingreso.Nombre;
            ingresoBD.Descripcion = Ingreso.Descripcion;
            ingresoBD.TipoCambio = Ingreso.TipoCambio;
            ingresoBD.MontoColones = Ingreso.MontoColones;
            ingresoBD.MontoDolares = Ingreso.MontoDolares;
            ingresoBD.IdProyecto= Ingreso.IdProyecto;
            context.SaveChanges();

        }
        public void deleteIngreso(int idIngreso) {

            EFF.Ingreso ingresoBD = context.Ingresoes.Where(e => e.Id == idIngreso).FirstOrDefault();

            context.Ingresoes.Remove(ingresoBD);
            context.SaveChanges();
        }
    }
}
