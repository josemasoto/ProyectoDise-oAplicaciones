using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ProyectoDiseñoAplicaciones
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        Cliente GetCliente(int id, string nombre, int telefono, string direccion);
        /*Proveedor GetProveedor(int id, string nombre, int telefono, string direccion, string tipo);
        Evento GetEvento(int id, DateTime fecha, List<Proveedor> listaproveedores, double duracion, decimal precio, List<Pago> pagos);
    */
    }
    
}
