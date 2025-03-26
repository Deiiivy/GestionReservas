using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HabitacionReservas
{
    public partial class FormReserva: Form
    {
        private string _tipoHabitacion;
        public FormReserva(string tipoHabitacion)
        {
            InitializeComponent();
            _tipoHabitacion = tipoHabitacion;
            this.Text = $"Reserva de Habitación {_tipoHabitacion}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreCliente = txtNombreCliente.Text;
                int numeroHabitacion = int.Parse(txtNumeroHabitacion.Text);
                int duracion = int.Parse(txtDuracion.Text);
                double tarifa = double.Parse(txtTarifa.Text);
                DateTime fechaReserva = dptFechaReserva.Value;

                GestorReservas.Instancia.AgregarReserva(_tipoHabitacion, nombreCliente, numeroHabitacion, fechaReserva, duracion, tarifa);

             
                MessageBox.Show($"Reserva de habitación {_tipoHabitacion} realizada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (ArgumentException ex)
            {
            
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Verifique que los datos ingresados sean correctos.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la reserva: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
