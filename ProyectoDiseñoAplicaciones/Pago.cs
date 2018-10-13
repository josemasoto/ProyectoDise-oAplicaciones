using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDiseñoAplicaciones
{
    public class Pago
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }

        public void Agregar(int id, DateTime fecha, decimal monto)
        {
            Pago pago = new Pago
            {
                Id = id,
                Fecha = fecha,
                Monto = monto
            };
        }

        public void Buscar()
        {

        }

        public void Modificar()
        {

        }

    }
}
