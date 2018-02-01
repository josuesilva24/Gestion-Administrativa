using System;
using System.Collections.Generic;
using System.Linq;
namespace MappingClasses
{
    public class Historial_Salario_Empleado: BaseData
    {

        public List<EFF.Historial_Salario_Empleado> GetAllHistoriaSalarioEmp()
        {

            return context.Historial_Salario_Empleado.ToList();

        }

        public EFF.Historial_Salario_Empleado GetHistorialSalarioEmp(int IdHistorialEmp)
        {
            return context.Historial_Salario_Empleado.Where(e => e.Id == IdHistorialEmp).FirstOrDefault();
        }


        public void AddHistorialSalarioEmp(EFF.Historial_Salario_Empleado HistorialEmp)
        {
            context.Historial_Salario_Empleado.Add(HistorialEmp);
            context.SaveChanges();

        }
    }
}
