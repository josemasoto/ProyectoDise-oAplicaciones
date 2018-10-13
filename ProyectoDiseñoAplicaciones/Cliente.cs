using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDiseñoAplicaciones
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Telefono { get; set; }
        public string Direccion { get; set; }

        public void Agregar(int id, string nombre, int telefono, string direccion) {
            Cliente cliente = new Cliente
            {
                Id = id,
                Nombre = nombre,
                Telefono = telefono,
                Direccion = direccion
            };
        }
            
        public void Modificar()
        {
           
        }

        public void Buscar()
        {

        }

    }
}
