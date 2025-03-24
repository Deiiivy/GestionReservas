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
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            ConfigurarDataGridView();
        }

        private void btnEstandar_Click(object sender, EventArgs e)
        {
            FormReserva formReserva = new FormReserva("Estandar");
            formReserva.ShowDialog();
            CargarReservas();
        }

        private void btnVIP_Click(object sender, EventArgs e)
        {
            FormReserva formVIP = new FormReserva("VIP");
            formVIP.ShowDialog();
            CargarReservas();
        }

        private void ConfigurarDataGridView()
        {
            dgvReservas.AutoGenerateColumns = false;
            dgvReservas.Columns.Clear();

            dgvReservas.Columns.Add("NombreCliente", "Cliente");
            dgvReservas.Columns["NombreCliente"].DataPropertyName = "NombreCliente";

            dgvReservas.Columns.Add("NumeroHabitacion", "N° Habitación");
            dgvReservas.Columns["NumeroHabitacion"].DataPropertyName = "NumeroHabitacion";

            dgvReservas.Columns.Add("FechaReserva", "Fecha Reserva");
            dgvReservas.Columns["FechaReserva"].DataPropertyName = "FechaReserva";

            dgvReservas.Columns.Add("DuracionEstandia", "Duración (Noches)");
            dgvReservas.Columns["DuracionEstandia"].DataPropertyName = "DuracionEstandia";

            dgvReservas.Columns.Add("Tarifa", "Tarifa por Noche");
            dgvReservas.Columns["Tarifa"].DataPropertyName = "Tarifa";

            dgvReservas.Columns.Add("CostoTotal", "Costo Total");
            dgvReservas.Columns["CostoTotal"].DataPropertyName = "CostoTotal";

            dgvReservas.Columns.Add("TipoHabitacion", "Tipo");
            dgvReservas.Columns["TipoHabitacion"].DataPropertyName = "TipoHabitacion";
        }

        private void CargarReservas()
        {
            dgvReservas.DataSource = null;
            dgvReservas.DataSource = GestorReservas.Instancia.ObtenerReservas();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvReservas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una reserva para editar.");
                return;
            }

            int numeroHabitacion = Convert.ToInt32(dgvReservas.SelectedRows[0].Cells["NumeroHabitacion"].Value);
            DateTime fechaReserva = Convert.ToDateTime(dgvReservas.SelectedRows[0].Cells["FechaReserva"].Value);
            string nombreActual = dgvReservas.SelectedRows[0].Cells["NombreCliente"].Value.ToString();
            int duracionActual = Convert.ToInt32(dgvReservas.SelectedRows[0].Cells["DuracionEstandia"].Value);

          
            string nuevoNombre = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nuevo nombre del cliente:", "Editar Reserva", nombreActual);
            string nuevaDuracionStr = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la nueva duración de la estadía (número de noches):", "Editar Reserva", duracionActual.ToString());
            string nuevoNumeroHabitacionStr = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nuevo número de habitación:", "Editar Reserva", numeroHabitacion.ToString());
            string nuevaFechaStr = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la nueva fecha de la reserva (yyyy-MM-dd):", "Editar Reserva", fechaReserva.ToString("yyyy-MM-dd"));

            if (string.IsNullOrWhiteSpace(nuevoNombre) ||
                !int.TryParse(nuevaDuracionStr, out int nuevaDuracion) ||
                !int.TryParse(nuevoNumeroHabitacionStr, out int nuevoNumeroHabitacion) ||
                !DateTime.TryParse(nuevaFechaStr, out DateTime nuevaFechaReserva))
            {
                MessageBox.Show("Datos inválidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                GestorReservas.Instancia.EditarReserva(numeroHabitacion, fechaReserva, nuevoNumeroHabitacion, nuevaFechaReserva, nuevoNombre, nuevaDuracion);
                MessageBox.Show("Reserva editada correctamente.");
                CargarReservas();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvReservas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una reserva para eliminar.");
                return;
            }

            DialogResult confirmacion = MessageBox.Show(
                "¿Estás seguro de que deseas eliminar esta reserva?",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmacion == DialogResult.Yes)
            {
      
                int numeroHabitacion = Convert.ToInt32(dgvReservas.SelectedRows[0].Cells["NumeroHabitacion"].Value);
                DateTime fechaReserva = Convert.ToDateTime(dgvReservas.SelectedRows[0].Cells["FechaReserva"].Value);

                try
                {
                    GestorReservas.Instancia.EliminarReserva(numeroHabitacion, fechaReserva);
                    MessageBox.Show("Reserva eliminada correctamente.");
                    CargarReservas(); 
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        }
    }

