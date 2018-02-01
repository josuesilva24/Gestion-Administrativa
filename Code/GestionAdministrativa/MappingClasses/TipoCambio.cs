using System.Linq;
using EFF;
using System.Collections.Generic;

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

        }


    }
}
