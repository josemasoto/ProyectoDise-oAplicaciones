using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDiseñoAplicaciones
{
    public class TipoProveduria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public void Agregar (int id, string nombre)
        {
            TipoProveduria tipoProveduria = new TipoProveduria
            {
                Id = id,
                Nombre = nombre
            };
        }

        public void Buscar() { }

        public void Modificar () { }

    }
}
