using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabitacionReservas
{
   public abstract class Reserva
    {
        public string NombreCliente { get; set; }
        public int NumeroHabitacion { get; set; }

        public DateTime FechaReserva { get; set; }
        public int DuracionEstandia { get; set; }

        public Reserva(string nombreCliente, int numeroHabitacion, DateTime fechaReserva, int duracionEstandia)
        {
            if(!string.IsNullOrEmpty(nombreCliente))
            {
                throw new ArgumentException("El nombre del cliente no puede estar vacio");
            }
            if (numeroHabitacion <= 0)
            {
                throw new ArgumentException("El numero de habitacion no puede ser menor o igual a 0");
            }

            NombreCliente = nombreCliente;
            NumeroHabitacion = numeroHabitacion;
            FechaReserva = fechaReserva;
            DuracionEstandia = duracionEstandia;
        }

        public abstract double CalcularCosto();

    }
}
