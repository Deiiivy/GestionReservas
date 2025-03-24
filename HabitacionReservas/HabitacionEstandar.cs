using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabitacionReservas
{
   public class HabitacionEstandar : Reserva
    {
        public double TarifaFija { get; set; }

        public HabitacionEstandar(string nombreCliente, int numeroHabitacion, DateTime fechaReserva, 
            int duracionEstandia, double tarifaFija)
            : base(nombreCliente, numeroHabitacion, fechaReserva, duracionEstandia)
        {

            if (tarifaFija <= 0)
            {
                throw new ArgumentException("La tarifa fija no puede ser menor o igual a 0");
            }
            TarifaFija = tarifaFija;
        }

        public override double CalcularCosto()
        {
            return DuracionEstandia * TarifaFija;
        }
    }
}
