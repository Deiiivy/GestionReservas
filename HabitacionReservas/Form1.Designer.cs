namespace HabitacionReservas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnEstandar = new System.Windows.Forms.Button();
            this.btnVIP = new System.Windows.Forms.Button();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.NombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroHabitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaReserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DuracionEstadia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escoja el tipo de habitacion";
            // 
            // btnEstandar
            // 
            this.btnEstandar.Location = new System.Drawing.Point(243, 28);
            this.btnEstandar.Name = "btnEstandar";
            this.btnEstandar.Size = new System.Drawing.Size(134, 37);
            this.btnEstandar.TabIndex = 1;
            this.btnEstandar.Text = "Habitacion estandar";
            this.btnEstandar.UseVisualStyleBackColor = true;
            this.btnEstandar.Click += new System.EventHandler(this.btnEstandar_Click);
            // 
            // btnVIP
            // 
            this.btnVIP.Location = new System.Drawing.Point(432, 29);
            this.btnVIP.Name = "btnVIP";
            this.btnVIP.Size = new System.Drawing.Size(134, 37);
            this.btnVIP.TabIndex = 2;
            this.btnVIP.Text = "Habitacion VIP";
            this.btnVIP.UseVisualStyleBackColor = true;
            this.btnVIP.Click += new System.EventHandler(this.btnVIP_Click);
            // 
            // dgvReservas
            // 
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreCliente,
            this.NumeroHabitacion,
            this.FechaReserva,
            this.DuracionEstadia,
            this.CostoTotal});
            this.dgvReservas.Location = new System.Drawing.Point(12, 85);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.Size = new System.Drawing.Size(743, 266);
            this.dgvReservas.TabIndex = 3;
            // 
            // NombreCliente
            // 
            this.NombreCliente.HeaderText = "Nombre del cliente";
            this.NombreCliente.Name = "NombreCliente";
            // 
            // NumeroHabitacion
            // 
            this.NumeroHabitacion.HeaderText = "Numero de habitacion";
            this.NumeroHabitacion.Name = "NumeroHabitacion";
            // 
            // FechaReserva
            // 
            this.FechaReserva.HeaderText = "Fecha de reserva";
            this.FechaReserva.Name = "FechaReserva";
            // 
            // DuracionEstadia
            // 
            this.DuracionEstadia.HeaderText = "Duracion de Estandia";
            this.DuracionEstadia.Name = "DuracionEstadia";
            // 
            // CostoTotal
            // 
            this.CostoTotal.HeaderText = "Costo Total";
            this.CostoTotal.Name = "CostoTotal";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(243, 365);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(420, 365);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dgvReservas);
            this.Controls.Add(this.btnVIP);
            this.Controls.Add(this.btnEstandar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEstandar;
        private System.Windows.Forms.Button btnVIP;
        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroHabitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaReserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn DuracionEstadia;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoTotal;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
    }
}

