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

        public void UpdateProveedpr(EFF.Proveedor provedor)
        {
            EFF.Proveedor prove= GetProveedor(provedor.Id);

            prove.Nombre = provedor.Nombre;
            prove.TipoIdentificacion = provedor.TipoIdentificacion;
            prove.Identificacion = provedor.Identificacion;
            prove.Telefono = provedor.Telefono;
            prove.Telefono2 = provedor.Telefono2;
            prove.Direccion = provedor.Direccion;
            prove.Notas = provedor.Notas;
            context.SaveChanges();
        }
    }
}
