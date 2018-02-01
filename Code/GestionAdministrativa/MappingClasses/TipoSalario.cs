using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingClasses
{
    public class TipoSalario:BaseData
    {

        public List<EFF.Tipo_Salario> GetAllTiposSalarios()
        {

            return context.Tipo_Salario.ToList();

        }

        public EFF.Tipo_Salario GetTipoSalario(int idTipoSalario)
        {
            return context.Tipo_Salario.Where(e => e.Id ==idTipoSalario).FirstOrDefault();
        }


        public void AddTipoSalario(EFF.Tipo_Salario tipoSalario)
        {
            context.Tipo_Salario.Add(tipoSalario);
            context.SaveChanges();

        }
    }
}
