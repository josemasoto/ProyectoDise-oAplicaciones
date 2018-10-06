using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDiseñoAplicaciones
{
    public class Evento
    {
        public int IdEvento { get; set; }
        public DateTime FechaEvento { get; set; }
        public List<string> ListaProveedoresEvento { get; set; }
        public double DuracionEvento { get; set; }
        public decimal PrecioEvento { get; set; }
        public List<decimal> PagosEvento { get; set; }

    }
}
