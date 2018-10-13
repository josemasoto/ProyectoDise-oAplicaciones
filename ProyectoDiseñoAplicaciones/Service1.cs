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
            cliente1.Id = idCliente;
            cliente1.Nombre = nombreCliente;
            cliente1.Telefono = telefonoCliente;
            cliente1.Direccion = direccionCliente;
            return cliente1;
        }

        public Evento GetEvento(int idEvento, DateTime fechaEvento, List<string> listaProveedoresEvento, double duracionEvento, decimal precioEvento, List<decimal> pagosEvento)
        {
            Evento evento1 = new Evento();
            evento1.Id = idEvento;
            evento1.Fecha = fechaEvento;
            evento1.ListaProveedores = listaProveedoresEvento;
            evento1.Duracion = duracionEvento;
            evento1.Precio = precioEvento;
            evento1.Pagos = pagosEvento;
            return evento1;

        }

        public Proveedor GetProveedor(int idProveedor, string nombreProveedor, int telefonoProveedor, string direccionProveedor, string tipoProveedor)
        {
            Proveedor proveedor1 = new Proveedor();
            proveedor1.Id = idProveedor;
            proveedor1.Nombre = nombreProveedor;
            proveedor1.Telefono = telefonoProveedor;
            proveedor1.Direccion = direccionProveedor;
            proveedor1.Tipo = tipoProveedor;
            return proveedor1;
        }
    }
}
