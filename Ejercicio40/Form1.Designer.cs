namespace Ejercicio40
{
    partial class Form1
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
            this.gvSimulacion = new System.Windows.Forms.DataGridView();
            this.Reloj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_diffLlegadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_proxLlegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Atencion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.I_Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.I_tiempoAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.I_finAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.I_inicioOcio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.I_cola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.T_Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.T_proxima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.T_fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_tiempoAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_finAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_inicioOcio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_cola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S_Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S_tiempoAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S_finAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S_inicioOcio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S_cola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvSimulacion)).BeginInit();
            this.SuspendLayout();
            // 
            // gvSimulacion
            // 
            this.gvSimulacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSimulacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Reloj,
            this.Evento,
            this.C_diffLlegadas,
            this.C_proxLlegada,
            this.Atencion,
            this.I_Estado,
            this.I_tiempoAt,
            this.I_finAt,
            this.I_inicioOcio,
            this.I_cola,
            this.T_Estado,
            this.T_proxima,
            this.T_fin,
            this.P_Estado,
            this.P_tiempoAt,
            this.P_finAt,
            this.P_inicioOcio,
            this.P_cola,
            this.S_Estado,
            this.S_tiempoAt,
            this.S_finAt,
            this.S_inicioOcio,
            this.S_cola});
            this.gvSimulacion.Location = new System.Drawing.Point(3, 51);
            this.gvSimulacion.Name = "gvSimulacion";
            this.gvSimulacion.Size = new System.Drawing.Size(1300, 600);
            this.gvSimulacion.TabIndex = 0;
            this.gvSimulacion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Reloj
            // 
            this.Reloj.HeaderText = "Reloj";
            this.Reloj.Name = "Reloj";
            this.Reloj.Width = 70;
            // 
            // Evento
            // 
            this.Evento.HeaderText = "Evento";
            this.Evento.Name = "Evento";
            this.Evento.Width = 70;
            // 
            // C_diffLlegadas
            // 
            this.C_diffLlegadas.HeaderText = "C_diffLlegadas";
            this.C_diffLlegadas.Name = "C_diffLlegadas";
            this.C_diffLlegadas.Width = 70;
            // 
            // C_proxLlegada
            // 
            this.C_proxLlegada.HeaderText = "C_proxLlegada";
            this.C_proxLlegada.Name = "C_proxLlegada";
            this.C_proxLlegada.Width = 70;
            // 
            // Atencion
            // 
            this.Atencion.HeaderText = "Atencion";
            this.Atencion.Name = "Atencion";
            this.Atencion.Width = 70;
            // 
            // I_Estado
            // 
            this.I_Estado.HeaderText = "I_Estado";
            this.I_Estado.Name = "I_Estado";
            this.I_Estado.Width = 70;
            // 
            // I_tiempoAt
            // 
            this.I_tiempoAt.HeaderText = "I_tiempoAt";
            this.I_tiempoAt.Name = "I_tiempoAt";
            this.I_tiempoAt.Width = 70;
            // 
            // I_finAt
            // 
            this.I_finAt.HeaderText = "I_finAt";
            this.I_finAt.Name = "I_finAt";
            this.I_finAt.Width = 70;
            // 
            // I_inicioOcio
            // 
            this.I_inicioOcio.HeaderText = "I_inicioOcio";
            this.I_inicioOcio.Name = "I_inicioOcio";
            // 
            // I_cola
            // 
            this.I_cola.HeaderText = "I_cola";
            this.I_cola.Name = "I_cola";
            // 
            // T_Estado
            // 
            this.T_Estado.HeaderText = "T_Estado";
            this.T_Estado.Name = "T_Estado";
            // 
            // T_proxima
            // 
            this.T_proxima.HeaderText = "T_proxima";
            this.T_proxima.Name = "T_proxima";
            // 
            // T_fin
            // 
            this.T_fin.HeaderText = "T_fin";
            this.T_fin.Name = "T_fin";
            // 
            // P_Estado
            // 
            this.P_Estado.HeaderText = "P_Estado";
            this.P_Estado.Name = "P_Estado";
            // 
            // P_tiempoAt
            // 
            this.P_tiempoAt.HeaderText = "P_tiempoAt";
            this.P_tiempoAt.Name = "P_tiempoAt";
            // 
            // P_finAt
            // 
            this.P_finAt.HeaderText = "P_finAt";
            this.P_finAt.Name = "P_finAt";
            // 
            // P_inicioOcio
            // 
            this.P_inicioOcio.HeaderText = "P_inicioOcio";
            this.P_inicioOcio.Name = "P_inicioOcio";
            // 
            // P_cola
            // 
            this.P_cola.HeaderText = "P_cola";
            this.P_cola.Name = "P_cola";
            // 
            // S_Estado
            // 
            this.S_Estado.HeaderText = "S_Estado";
            this.S_Estado.Name = "S_Estado";
            // 
            // S_tiempoAt
            // 
            this.S_tiempoAt.HeaderText = "S_tiempoAt";
            this.S_tiempoAt.Name = "S_tiempoAt";
            // 
            // S_finAt
            // 
            this.S_finAt.HeaderText = "S_finAt";
            this.S_finAt.Name = "S_finAt";
            // 
            // S_inicioOcio
            // 
            this.S_inicioOcio.HeaderText = "S_inicioOcio";
            this.S_inicioOcio.Name = "S_inicioOcio";
            // 
            // S_cola
            // 
            this.S_cola.HeaderText = "S_cola";
            this.S_cola.Name = "S_cola";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 383);
            this.Controls.Add(this.gvSimulacion);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gvSimulacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvSimulacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reloj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Evento;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_diffLlegadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_proxLlegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Atencion;
        private System.Windows.Forms.DataGridViewTextBoxColumn I_Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn I_tiempoAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn I_finAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn I_inicioOcio;
        private System.Windows.Forms.DataGridViewTextBoxColumn I_cola;
        private System.Windows.Forms.DataGridViewTextBoxColumn T_Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn T_proxima;
        private System.Windows.Forms.DataGridViewTextBoxColumn T_fin;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_tiempoAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_finAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_inicioOcio;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_cola;
        private System.Windows.Forms.DataGridViewTextBoxColumn S_Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn S_tiempoAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn S_finAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn S_inicioOcio;
        private System.Windows.Forms.DataGridViewTextBoxColumn S_cola;
    }
}

