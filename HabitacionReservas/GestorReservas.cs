using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabitacionReservas
{
   public class GestorReservas
    {
        private static GestorReservas _instancia;
        private List<Reserva> _reserva;

        private GestorReservas()
        {
            _reserva = new List<Reserva>();
        }

        public static GestorReservas Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new GestorReservas();
                }
                return _instancia;
            }
        }

        public void AgregarReserva(
     string tipo, string nombreCliente, int numeroHabitacion,
     DateTime fechaReserva, int duracion, double tarifa)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(nombreCliente))
                {
                    throw new ArgumentException("El nombre del cliente no puede estar vacío.");
                }

                if (tarifa <= 0)
                {
                    throw new ArgumentException("La tarifa debe ser mayor a cero.");
                }

                if (duracion < 1)
                {
                    throw new ArgumentException("La duración de la estancia debe ser mayor a 1 noche.");
                }

                if (_reserva.Any(r => r.NumeroHabitacion == numeroHabitacion && r.FechaReserva.Date == fechaReserva.Date))
                {
                    throw new ArgumentException("La habitación ya está reservada para la fecha seleccionada.");
                }

                Reserva reserva = ReservaFactory.CrearReserva(
                    tipo, nombreCliente, numeroHabitacion, fechaReserva, duracion, tarifa);

                _reserva.Add(reserva);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error al agregar reserva: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inesperado al agregar reserva: {ex.Message}");
            }
        }

        public void EliminarReserva(int numeroHabitacion, DateTime fechaReserva)
        {
            try
            {
                Reserva reserva = _reserva.FirstOrDefault(r => r.NumeroHabitacion == numeroHabitacion && r.FechaReserva == fechaReserva);
                if (reserva == null)
                {
                    throw new ArgumentException("La reserva no existe.");
                }
                _reserva.Remove(reserva);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error al eliminar reserva: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inesperado al eliminar reserva: {ex.Message}");
            }
        }

        public void EditarReserva(int numeroHabitacion, DateTime fechaReserva, int nuevoNumeroHabitacion, DateTime nuevaFechaReserva, string nuevoNombreCliente, int nuevaDuracion)
        {
            try
            {
                var reserva = _reserva.FirstOrDefault(r => r.NumeroHabitacion == numeroHabitacion && r.FechaReserva == fechaReserva);

                if (reserva == null)
                {
                    throw new ArgumentException("La reserva no existe.");
                }

                if (string.IsNullOrWhiteSpace(nuevoNombreCliente))
                {
                    throw new ArgumentException("El nombre del cliente no puede estar vacío.");
                }

                if (nuevaDuracion < 1)
                {
                    throw new ArgumentException("La duración de la estancia no puede ser menor a 1.");
                }

                var reservaExistente = _reserva.FirstOrDefault(r => r.NumeroHabitacion == nuevoNumeroHabitacion && r.FechaReserva == nuevaFechaReserva);
                if (reservaExistente != null && reservaExistente != reserva)
                {
                    throw new ArgumentException("Ya existe una reserva para esa fecha y número de habitación.");
                }

                reserva.NumeroHabitacion = nuevoNumeroHabitacion;
                reserva.FechaReserva = nuevaFechaReserva;
                reserva.NombreCliente = nuevoNombreCliente;
                reserva.DuracionEstandia = nuevaDuracion;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error al editar reserva: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inesperado al editar reserva: {ex.Message}");
            }
        }

        public List<Reserva> ObtenerReservas()
        {
            try
            {
                return _reserva;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener reservas: {ex.Message}");
                return new List<Reserva>();
            }
        }
    }
}
