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
        public List<Proveedor> ListaProveedores { get; set; }
        public double Duracion { get; set; }
        public decimal Precio { get; set; }
        public List<Pago> Pagos { get; set; }

        public void Agregar() { }

        public void Modificar() { }

    } 

}
