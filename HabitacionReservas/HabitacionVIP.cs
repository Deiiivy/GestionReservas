using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabitacionReservas
{
   public class HabitacionVIP : Reserva
    {
        public double TarifaFija { get; set; }
        public const double Descuesto = 0.2;

        public HabitacionVIP(string nombreCliente, int numeroHabitacion, DateTime fechaReserva,
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
           double costoTotal = DuracionEstandia * TarifaFija;
         
            if(DuracionEstandia > 5)
            {
                costoTotal -= costoTotal * Descuesto;
            }
            return costoTotal;
        }
    }
}
