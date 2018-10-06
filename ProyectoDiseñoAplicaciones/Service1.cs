using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ProyectoDiseñoAplicaciones
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public Cliente GetCliente(int idCliente, string nombreCliente, int telefonoCliente, string direccionCliente)
        {
            Cliente cliente1 = new Cliente();
            cliente1.IdCliente = idCliente;
            cliente1.NombreCliente = nombreCliente;
            cliente1.TelefonoCliente = telefonoCliente;
            cliente1.DireccionCliente = direccionCliente;
            return cliente1;
        }

        public Evento GetEvento(int idEvento, DateTime fechaEvento, List<string> listaProveedoresEvento, double duracionEvento, decimal precioEvento, List<decimal> pagosEvento)
        {
            Evento evento1 = new Evento();
            evento1.IdEvento = idEvento;
            evento1.FechaEvento = fechaEvento;
            evento1.ListaProveedoresEvento = listaProveedoresEvento;
            evento1.DuracionEvento = duracionEvento;
            evento1.PrecioEvento = precioEvento;
            evento1.PagosEvento = pagosEvento;
            return evento1;

        }

        public Proveedor GetProveedor(int idProveedor, string nombreProveedor, int telefonoProveedor, string direccionProveedor, string tipoProveedor)
        {
            Proveedor proveedor1 = new Proveedor();
            proveedor1.IdProveedor = idProveedor;
            proveedor1.NombreProveedor = nombreProveedor;
            proveedor1.TelefonoProveedor = telefonoProveedor;
            proveedor1.DireccionProveedor = direccionProveedor;
            proveedor1.TipoProveedor = tipoProveedor;
            return proveedor1;
        }
    }
}
