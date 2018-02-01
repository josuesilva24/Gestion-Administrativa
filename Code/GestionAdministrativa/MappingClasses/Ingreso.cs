using System;
using System.Collections.Generic;

namespace MappingClasses
{
    public class Ingreso:BaseData
    {

        public ICollection<EFF.Ingreso> GetAllIngresos()
        {
            return context.Ingresoes.ToList();
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

    }
}
