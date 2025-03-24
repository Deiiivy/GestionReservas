namespace HabitacionReservas
{
    partial class FormReserva
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtNumeroHabitacion = new System.Windows.Forms.TextBox();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.txtTarifa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dptFechaReserva = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Cliente";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(149, 44);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(200, 20);
            this.txtNombreCliente.TabIndex = 1;
            // 
            // txtNumeroHabitacion
            // 
            this.txtNumeroHabitacion.Location = new System.Drawing.Point(149, 108);
            this.txtNumeroHabitacion.Name = "txtNumeroHabitacion";
            this.txtNumeroHabitacion.Size = new System.Drawing.Size(200, 20);
            this.txtNumeroHabitacion.TabIndex = 2;
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(149, 184);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(200, 20);
            this.txtDuracion.TabIndex = 3;
            // 
            // txtTarifa
            // 
            this.txtTarifa.Location = new System.Drawing.Point(149, 258);
            this.txtTarifa.Name = "txtTarifa";
            this.txtTarifa.Size = new System.Drawing.Size(200, 20);
            this.txtTarifa.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Numero Habitacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tiempo habitacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tarifa por noche";
            // 
            // dptFechaReserva
            // 
            this.dptFechaReserva.Location = new System.Drawing.Point(149, 320);
            this.dptFechaReserva.Name = "dptFechaReserva";
            this.dptFechaReserva.Size = new System.Drawing.Size(200, 20);
            this.dptFechaReserva.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fecha reserva";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(131, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Fecha Reserva";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dptFechaReserva);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTarifa);
            this.Controls.Add(this.txtDuracion);
            this.Controls.Add(this.txtNumeroHabitacion);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.label1);
            this.Name = "FormReserva";
            this.Text = "FormReserva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtNumeroHabitacion;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.TextBox txtTarifa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dptFechaReserva;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}