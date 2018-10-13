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
        public Cliente GetCliente(int id, string nombre, int telefono, string direccion)
        {
            Cliente cliente1 = new Cliente
            {
                Id = id,
                Nombre = nombre,
                Telefono = telefono,
                Direccion = direccion
            };
            return cliente1;
        }
        /*
        public Evento GetEvento(int id, DateTime fecha, List<Proveedor> listaProveedores, double duracion, decimal precio, List<Pago> pagos)
        {
            Evento evento1 = new Evento();
            evento1.Id = id;
            evento1.Fecha = fecha;
            evento1.ListaProveedores = listaProveedores;
            evento1.Duracion = duracion;
            evento1.Precio = precio;
            evento1.Pagos = pagos;
            return evento1;

        }

        public Proveedor GetProveedor(int id, string nombre, int telefono, string direccion, string tipo)
        {
            Proveedor proveedor1 = new Proveedor();
            proveedor1.Id = id;
            proveedor1.Nombre = nombre;
            proveedor1.Telefono = telefono;
            proveedor1.Direccion = direccion;
            proveedor1.Tipo = tipo;
            return proveedor1;
        }*/
    }
}
