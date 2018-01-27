using System.Collections.Generic;
using System.Linq;

namespace MappingClasses
{
    public class Proveedor:BaseData
    {

        public List<EFF.Proveedor> GetAllProveedores()
        {
            return context.Proveedors.ToList();
        }

        public EFF.Proveedor GetProveedor(int IdEmpleado)
        {
            return context.Proveedors.Where(e => e.Id == IdEmpleado).FirstOrDefault();
        }


        public void AddProveedor(EFF.Proveedor provedor)
        {
            context.Proveedors.Add(provedor);
            context.SaveChanges();

        }
    }
}
