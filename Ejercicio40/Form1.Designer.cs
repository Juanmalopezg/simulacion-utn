﻿namespace Ejercicio40
{
    partial class Sim
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.gvSimulacion = new MetroFramework.Controls.MetroGrid();
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
            this.grTS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grTP = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grTI = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_simular = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.gvSimulacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grTS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grTP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grTI)).BeginInit();
            this.SuspendLayout();
            // 
            // gvSimulacion
            // 
            this.gvSimulacion.AllowUserToResizeRows = false;
            this.gvSimulacion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.gvSimulacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvSimulacion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gvSimulacion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvSimulacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvSimulacion.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvSimulacion.EnableHeadersVisualStyles = false;
            this.gvSimulacion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gvSimulacion.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.gvSimulacion.Location = new System.Drawing.Point(17, 184);
            this.gvSimulacion.Name = "gvSimulacion";
            this.gvSimulacion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvSimulacion.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gvSimulacion.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.gvSimulacion.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gvSimulacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvSimulacion.Size = new System.Drawing.Size(1330, 530);
            this.gvSimulacion.Style = MetroFramework.MetroColorStyle.Blue;
            this.gvSimulacion.TabIndex = 0;
            this.gvSimulacion.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.gvSimulacion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Reloj
            // 
            this.Reloj.HeaderText = "Reloj";
            this.Reloj.Name = "Reloj";
            this.Reloj.Width = 75;
            // 
            // Evento
            // 
            this.Evento.HeaderText = "Evento";
            this.Evento.Name = "Evento";
            this.Evento.Width = 110;
            // 
            // C_diffLlegadas
            // 
            this.C_diffLlegadas.HeaderText = "C_diffLlegadas";
            this.C_diffLlegadas.Name = "C_diffLlegadas";
            this.C_diffLlegadas.Width = 75;
            // 
            // C_proxLlegada
            // 
            this.C_proxLlegada.HeaderText = "C_proxLlegada";
            this.C_proxLlegada.Name = "C_proxLlegada";
            this.C_proxLlegada.Width = 75;
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
            this.I_tiempoAt.Width = 75;
            // 
            // I_finAt
            // 
            this.I_finAt.HeaderText = "I_finAt";
            this.I_finAt.Name = "I_finAt";
            this.I_finAt.Width = 75;
            // 
            // I_inicioOcio
            // 
            this.I_inicioOcio.HeaderText = "I_inicioOcio";
            this.I_inicioOcio.Name = "I_inicioOcio";
            this.I_inicioOcio.Width = 75;
            // 
            // I_cola
            // 
            this.I_cola.HeaderText = "I_cola";
            this.I_cola.Name = "I_cola";
            this.I_cola.Width = 40;
            // 
            // T_Estado
            // 
            this.T_Estado.HeaderText = "T_Estado";
            this.T_Estado.Name = "T_Estado";
            this.T_Estado.Width = 70;
            // 
            // T_proxima
            // 
            this.T_proxima.HeaderText = "T_proxima";
            this.T_proxima.Name = "T_proxima";
            this.T_proxima.Width = 75;
            // 
            // T_fin
            // 
            this.T_fin.HeaderText = "T_fin";
            this.T_fin.Name = "T_fin";
            this.T_fin.Width = 75;
            // 
            // P_Estado
            // 
            this.P_Estado.HeaderText = "P_Estado";
            this.P_Estado.Name = "P_Estado";
            this.P_Estado.Width = 70;
            // 
            // P_tiempoAt
            // 
            this.P_tiempoAt.HeaderText = "P_tiempoAt";
            this.P_tiempoAt.Name = "P_tiempoAt";
            this.P_tiempoAt.Width = 75;
            // 
            // P_finAt
            // 
            this.P_finAt.HeaderText = "P_finAt";
            this.P_finAt.Name = "P_finAt";
            this.P_finAt.Width = 75;
            // 
            // P_inicioOcio
            // 
            this.P_inicioOcio.HeaderText = "P_inicioOcio";
            this.P_inicioOcio.Name = "P_inicioOcio";
            this.P_inicioOcio.Width = 75;
            // 
            // P_cola
            // 
            this.P_cola.HeaderText = "P_cola";
            this.P_cola.Name = "P_cola";
            this.P_cola.Width = 40;
            // 
            // S_Estado
            // 
            this.S_Estado.HeaderText = "S_Estado";
            this.S_Estado.Name = "S_Estado";
            this.S_Estado.Width = 70;
            // 
            // S_tiempoAt
            // 
            this.S_tiempoAt.HeaderText = "S_tiempoAt";
            this.S_tiempoAt.Name = "S_tiempoAt";
            this.S_tiempoAt.Width = 75;
            // 
            // S_finAt
            // 
            this.S_finAt.HeaderText = "S_finAt";
            this.S_finAt.Name = "S_finAt";
            this.S_finAt.Width = 75;
            // 
            // S_inicioOcio
            // 
            this.S_inicioOcio.HeaderText = "S_inicioOcio";
            this.S_inicioOcio.Name = "S_inicioOcio";
            this.S_inicioOcio.Width = 75;
            // 
            // S_cola
            // 
            this.S_cola.HeaderText = "S_cola";
            this.S_cola.Name = "S_cola";
            this.S_cola.Width = 40;
            // 
            // grTS
            // 
            this.grTS.BackColor = System.Drawing.Color.Transparent;
            this.grTS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grTS.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.grTS.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.Name = "Legend1";
            legend1.Title = "Servidor Serv. Técnico";
            legend1.TitleBackColor = System.Drawing.Color.Transparent;
            legend1.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            legend1.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.grTS.Legends.Add(legend1);
            this.grTS.Location = new System.Drawing.Point(1052, 28);
            this.grTS.Name = "grTS";
            this.grTS.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.grTS.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))))};
            this.grTS.Size = new System.Drawing.Size(236, 136);
            this.grTS.TabIndex = 3;
            this.grTS.Text = "chart2";
            // 
            // grTP
            // 
            this.grTP.BackColor = System.Drawing.Color.Transparent;
            this.grTP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grTP.BorderlineColor = System.Drawing.Color.Black;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.grTP.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.ForeColor = System.Drawing.Color.White;
            legend2.Name = "Legend1";
            legend2.Title = "Servidor Presupuesto";
            legend2.TitleBackColor = System.Drawing.Color.Transparent;
            legend2.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            legend2.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.grTP.Legends.Add(legend2);
            this.grTP.Location = new System.Drawing.Point(810, 28);
            this.grTP.Name = "grTP";
            this.grTP.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.grTP.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))))};
            this.grTP.Size = new System.Drawing.Size(236, 136);
            this.grTP.TabIndex = 4;
            this.grTP.Text = "grTP";
            // 
            // grTI
            // 
            this.grTI.BackColor = System.Drawing.Color.Transparent;
            this.grTI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grTI.BorderlineColor = System.Drawing.Color.Black;
            chartArea3.BackColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.grTI.ChartAreas.Add(chartArea3);
            legend3.BackColor = System.Drawing.Color.Transparent;
            legend3.ForeColor = System.Drawing.Color.White;
            legend3.Name = "Legend1";
            legend3.Title = "Servidor Insumos";
            legend3.TitleBackColor = System.Drawing.Color.Transparent;
            legend3.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            legend3.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.grTI.Legends.Add(legend3);
            this.grTI.Location = new System.Drawing.Point(579, 28);
            this.grTI.Name = "grTI";
            this.grTI.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.grTI.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))))};
            this.grTI.Size = new System.Drawing.Size(236, 136);
            this.grTI.TabIndex = 5;
            this.grTI.Text = "grTI";
            // 
            // btn_simular
            // 
            this.btn_simular.Location = new System.Drawing.Point(432, 130);
            this.btn_simular.Name = "btn_simular";
            this.btn_simular.Size = new System.Drawing.Size(119, 34);
            this.btn_simular.Style = MetroFramework.MetroColorStyle.Blue;
            this.btn_simular.TabIndex = 6;
            this.btn_simular.Text = "Simular";
            this.btn_simular.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_simular.UseSelectable = true;
            this.btn_simular.Click += new System.EventHandler(this.btn_simular_Click);
            // 
            // Sim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 600);
            this.Controls.Add(this.btn_simular);
            this.Controls.Add(this.grTI);
            this.Controls.Add(this.grTP);
            this.Controls.Add(this.grTS);
            this.Controls.Add(this.gvSimulacion);
            this.Name = "Sim";
            this.Resizable = false;
            this.Text = "Sim";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gvSimulacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grTS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grTP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grTI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
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
        private MetroFramework.Controls.MetroGrid gvSimulacion;
        private System.Windows.Forms.DataVisualization.Charting.Chart grTS;
        private System.Windows.Forms.DataVisualization.Charting.Chart grTP;
        private System.Windows.Forms.DataVisualization.Charting.Chart grTI;
        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroButton btn_simular;
    }
}

