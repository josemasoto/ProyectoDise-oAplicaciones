using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDiseñoAplicaciones
{
    public class Proveedor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Telefono { get; set; }
        public string Direccion { get; set; }
        public List<TipoProveduria> Tipo { get; set; }


        public void Agregar() { }

        public void Modificar() { }
        

    }
}
