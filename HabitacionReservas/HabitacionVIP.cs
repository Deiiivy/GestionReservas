using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HabitacionReservas
{
    public class HabitacionVIP : Reserva
    {
        private const double Descuento = 0.2;
        public double TarifaFija { get; set; }
        public override double Tarifa => TarifaFija;

        public override double CostoTotal => CalcularCosto(); 

        public HabitacionVIP(string nombreCliente, int numeroHabitacion, DateTime fechaReserva, int duracionEstandia, double tarifa)
            : base(nombreCliente, numeroHabitacion, fechaReserva, duracionEstandia)
        {
            if (tarifa <= 0)
            {
                throw new ArgumentException("La tarifa no puede ser menor o igual a 0");
            }

            TarifaFija = tarifa;
        }

        public override double CalcularCosto()
        {
            double costoTotal = DuracionEstandia * Tarifa;
            if (DuracionEstandia > 5)
            {
                costoTotal -= costoTotal * Descuento;
            }
            return costoTotal;
        }
    }
}
