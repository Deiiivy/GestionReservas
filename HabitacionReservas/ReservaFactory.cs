using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabitacionReservas
{
   public static class ReservaFactory
    {
        public static Reserva CrearReserva(string tipo, string nombreCliente, int numeroHabitacion, DateTime fechaReserva, int duracion, double tarifa)
        {

            if(tipo == "Estandar")
            {
                return new HabitacionEstandar(nombreCliente, numeroHabitacion, fechaReserva, duracion, tarifa);
            }else if(tipo == "VIP")
            {
                return new HabitacionVIP(nombreCliente, numeroHabitacion, fechaReserva, duracion, tarifa);
            }
            else
            {
                throw new ArgumentException("Tipo de reserva no valido");
            }
        }
    }
}
