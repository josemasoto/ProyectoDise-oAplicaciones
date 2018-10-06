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
        Cliente GetCliente(int idCliente, string nombreCliente, int telefonoCliente, string direccionCliente);
        Proveedor GetProveedor(int idProveedor, string nombreProveedor, int telefonoProveedor, string direccionProveedor, string tipoProveedor);
        Evento GetEvento(int idEvento, DateTime fechaEvento, List<string> listaProveedoresEvento, double duracionEvento, decimal precioEvento, List<decimal> pagosEvento);
    }
    
}
