using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDiseñoAplicaciones
{
    public class Evento
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public List<string> ListaProveedores { get; set; }
        public double Duracion { get; set; }
        public decimal Precio { get; set; }
        public List<decimal> Pagos { get; set; }

    } 

}
