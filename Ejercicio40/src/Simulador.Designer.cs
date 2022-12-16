namespace Attention_Simulator
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
            this.components = new System.ComponentModel.Container();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sim));
            this.gvSimulacion = new MetroFramework.Controls.MetroGrid();
            this.Reloj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_diffLlegadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_proxLlegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Atencion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.I_Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.I_tiempoAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.I_finAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.I_personalLibre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.I_inicioOcio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.I_cola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.T_Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.T_proxima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.T_fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_tiempoAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_finAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P2_tiempoAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P2_finAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P3_tiempoAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P3_finAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_personalLibre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_inicioOcio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_cola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S_Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S_tiempoAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S_finAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S2_tiempoAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S2_finAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S_personalLibre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S_inicioOcio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S_cola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grTS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grTP = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grTI = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_simular = new MetroFramework.Controls.MetroButton();
            this.txMinutosSim = new MetroFramework.Controls.MetroTextBox();
            this.lbMinutosSim = new MetroFramework.Controls.MetroLabel();
            this.lbcM1 = new MetroFramework.Controls.MetroLabel();
            this.lbColaMI = new MetroFramework.Controls.MetroLabel();
            this.lbColaMP = new MetroFramework.Controls.MetroLabel();
            this.lbcM2 = new MetroFramework.Controls.MetroLabel();
            this.lbColaMS = new MetroFramework.Controls.MetroLabel();
            this.lbcM3 = new MetroFramework.Controls.MetroLabel();
            this.txMc = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.txMi = new MetroFramework.Controls.MetroTextBox();
            this.txMs = new MetroFramework.Controls.MetroTextBox();
            this.txDs = new MetroFramework.Controls.MetroTextBox();
            this.txDi = new MetroFramework.Controls.MetroTextBox();
            this.txDc = new MetroFramework.Controls.MetroTextBox();
            this.txDl = new MetroFramework.Controls.MetroTextBox();
            this.txDp = new MetroFramework.Controls.MetroTextBox();
            this.txL = new MetroFramework.Controls.MetroTextBox();
            this.txMl = new MetroFramework.Controls.MetroTextBox();
            this.txMp = new MetroFramework.Controls.MetroTextBox();
            this.rbDefault = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.logoUtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize) (this.gvSimulacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.grTS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.grTP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.grTI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.logoUtn)).BeginInit();
            this.SuspendLayout();
            // 
            // gvSimulacion
            // 
            this.gvSimulacion.AllowUserToResizeRows = false;
            this.gvSimulacion.BackgroundColor = System.Drawing.Color.FromArgb(((int) (((byte) (17)))), ((int) (((byte) (17)))), ((int) (((byte) (17)))));
            this.gvSimulacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvSimulacion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gvSimulacion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (174)))), ((int) (((byte) (219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (17)))), ((int) (((byte) (17)))), ((int) (((byte) (17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (198)))), ((int) (((byte) (247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (17)))), ((int) (((byte) (17)))), ((int) (((byte) (17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvSimulacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvSimulacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSimulacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.Reloj, this.Evento, this.C_diffLlegadas, this.C_proxLlegada, this.Atencion, this.I_Estado, this.I_tiempoAt, this.I_finAt, this.I_personalLibre, this.I_inicioOcio, this.I_cola, this.T_Estado, this.T_proxima, this.T_fin, this.P_Estado, this.P_tiempoAt, this.P_finAt, this.P2_tiempoAt, this.P2_finAt, this.P3_tiempoAt, this.P3_finAt, this.P_personalLibre, this.P_inicioOcio, this.P_cola, this.S_Estado, this.S_tiempoAt, this.S_finAt, this.S2_tiempoAt, this.S2_finAt, this.S_personalLibre, this.S_inicioOcio, this.S_cola});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (17)))), ((int) (((byte) (17)))), ((int) (((byte) (17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (109)))), ((int) (((byte) (109)))), ((int) (((byte) (109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (198)))), ((int) (((byte) (247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (17)))), ((int) (((byte) (17)))), ((int) (((byte) (17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvSimulacion.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvSimulacion.EnableHeadersVisualStyles = false;
            this.gvSimulacion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gvSimulacion.GridColor = System.Drawing.Color.FromArgb(((int) (((byte) (17)))), ((int) (((byte) (17)))), ((int) (((byte) (17)))));
            this.gvSimulacion.Location = new System.Drawing.Point(23, 170);
            this.gvSimulacion.Name = "gvSimulacion";
            this.gvSimulacion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (174)))), ((int) (((byte) (219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (17)))), ((int) (((byte) (17)))), ((int) (((byte) (17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (198)))), ((int) (((byte) (247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (17)))), ((int) (((byte) (17)))), ((int) (((byte) (17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvSimulacion.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gvSimulacion.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (179)))), ((int) (((byte) (229)))), ((int) (((byte) (252)))));
            this.gvSimulacion.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gvSimulacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvSimulacion.Size = new System.Drawing.Size(1300, 530);
            this.gvSimulacion.Style = MetroFramework.MetroColorStyle.Blue;
            this.gvSimulacion.TabIndex = 0;
            this.gvSimulacion.TabStop = false;
            this.gvSimulacion.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.gvSimulacion.UseCustomBackColor = true;
            this.gvSimulacion.UseCustomForeColor = true;
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
            this.Atencion.Width = 75;
            // 
            // I_Estado
            // 
            this.I_Estado.HeaderText = "I_Estado";
            this.I_Estado.Name = "I_Estado";
            this.I_Estado.Width = 65;
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
            // I_personalLibre
            // 
            this.I_personalLibre.HeaderText = "I_personalLibre";
            this.I_personalLibre.Name = "I_personalLibre";
            this.I_personalLibre.Width = 55;
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
            this.T_Estado.Width = 65;
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
            this.P_Estado.Width = 65;
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
            // P2_tiempoAt
            // 
            this.P2_tiempoAt.HeaderText = "P2_tiempoAt";
            this.P2_tiempoAt.Name = "P2_tiempoAt";
            this.P2_tiempoAt.Width = 75;
            // 
            // P2_finAt
            // 
            this.P2_finAt.HeaderText = "P2_finAt";
            this.P2_finAt.Name = "P2_finAt";
            this.P2_finAt.Width = 75;
            // 
            // P3_tiempoAt
            // 
            this.P3_tiempoAt.HeaderText = "P3_tiempoAt";
            this.P3_tiempoAt.Name = "P3_tiempoAt";
            this.P3_tiempoAt.Width = 75;
            // 
            // P3_finAt
            // 
            this.P3_finAt.HeaderText = "P3_finAt";
            this.P3_finAt.Name = "P3_finAt";
            this.P3_finAt.Width = 75;
            // 
            // P_personalLibre
            // 
            this.P_personalLibre.HeaderText = "P_personalLibre";
            this.P_personalLibre.Name = "P_personalLibre";
            this.P_personalLibre.Width = 55;
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
            this.S_Estado.Width = 65;
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
            // S2_tiempoAt
            // 
            this.S2_tiempoAt.HeaderText = "S2_tiempoAt";
            this.S2_tiempoAt.Name = "S2_tiempoAt";
            this.S2_tiempoAt.Width = 75;
            // 
            // S2_finAt
            // 
            this.S2_finAt.HeaderText = "S2_finAt";
            this.S2_finAt.Name = "S2_finAt";
            this.S2_finAt.Width = 75;
            // 
            // S_personalLibre
            // 
            this.S_personalLibre.HeaderText = "S_personalLibre";
            this.S_personalLibre.Name = "S_personalLibre";
            this.S_personalLibre.Width = 55;
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
            legend1.TitleForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (3)))), ((int) (((byte) (169)))), ((int) (((byte) (244)))));
            this.grTS.Legends.Add(legend1);
            this.grTS.Location = new System.Drawing.Point(1017, 17);
            this.grTS.Name = "grTS";
            this.grTS.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.grTS.PaletteCustomColors = new System.Drawing.Color[] {System.Drawing.Color.FromArgb(((int) (((byte) (3)))), ((int) (((byte) (169)))), ((int) (((byte) (244))))), System.Drawing.Color.FromArgb(((int) (((byte) (75)))), ((int) (((byte) (75)))), ((int) (((byte) (75)))))};
            this.grTS.Size = new System.Drawing.Size(242, 147);
            this.grTS.TabIndex = 16;
            this.grTS.TabStop = false;
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
            legend2.TitleForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (3)))), ((int) (((byte) (169)))), ((int) (((byte) (244)))));
            this.grTP.Legends.Add(legend2);
            this.grTP.Location = new System.Drawing.Point(777, 17);
            this.grTP.Name = "grTP";
            this.grTP.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.grTP.PaletteCustomColors = new System.Drawing.Color[] {System.Drawing.Color.FromArgb(((int) (((byte) (3)))), ((int) (((byte) (169)))), ((int) (((byte) (244))))), System.Drawing.Color.FromArgb(((int) (((byte) (75)))), ((int) (((byte) (75)))), ((int) (((byte) (75)))))};
            this.grTP.Size = new System.Drawing.Size(242, 147);
            this.grTP.TabIndex = 0;
            this.grTP.TabStop = false;
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
            legend3.TitleForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (3)))), ((int) (((byte) (169)))), ((int) (((byte) (244)))));
            this.grTI.Legends.Add(legend3);
            this.grTI.Location = new System.Drawing.Point(529, 17);
            this.grTI.Name = "grTI";
            this.grTI.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.grTI.PaletteCustomColors = new System.Drawing.Color[] {System.Drawing.Color.FromArgb(((int) (((byte) (3)))), ((int) (((byte) (169)))), ((int) (((byte) (244))))), System.Drawing.Color.FromArgb(((int) (((byte) (75)))), ((int) (((byte) (75)))), ((int) (((byte) (75)))))};
            this.grTI.Size = new System.Drawing.Size(242, 147);
            this.grTI.TabIndex = 0;
            this.grTI.TabStop = false;
            this.grTI.Text = "grTI";
            // 
            // btn_simular
            // 
            this.btn_simular.Location = new System.Drawing.Point(401, 132);
            this.btn_simular.Name = "btn_simular";
            this.btn_simular.Size = new System.Drawing.Size(119, 34);
            this.btn_simular.Style = MetroFramework.MetroColorStyle.White;
            this.btn_simular.TabIndex = 13;
            this.btn_simular.Text = "Simular";
            this.btn_simular.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_simular.UseSelectable = true;
            this.btn_simular.Click += new System.EventHandler(this.btn_simular_Click);
            // 
            // txMinutosSim
            // 
            // 
            // 
            // 
            this.txMinutosSim.CustomButton.Image = null;
            this.txMinutosSim.CustomButton.Location = new System.Drawing.Point(68, 2);
            this.txMinutosSim.CustomButton.Name = "";
            this.txMinutosSim.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txMinutosSim.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txMinutosSim.CustomButton.TabIndex = 1;
            this.txMinutosSim.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txMinutosSim.CustomButton.UseSelectable = true;
            this.txMinutosSim.CustomButton.Visible = false;
            this.txMinutosSim.Lines = new string[0];
            this.txMinutosSim.Location = new System.Drawing.Point(142, 68);
            this.txMinutosSim.MaxLength = 5;
            this.txMinutosSim.Name = "txMinutosSim";
            this.txMinutosSim.PasswordChar = '\0';
            this.txMinutosSim.PromptText = "En minutos";
            this.txMinutosSim.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txMinutosSim.SelectedText = "";
            this.txMinutosSim.SelectionLength = 0;
            this.txMinutosSim.SelectionStart = 0;
            this.txMinutosSim.ShortcutsEnabled = true;
            this.txMinutosSim.Size = new System.Drawing.Size(86, 20);
            this.txMinutosSim.TabIndex = 1;
            this.txMinutosSim.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txMinutosSim.UseSelectable = true;
            this.txMinutosSim.WaterMark = "En minutos";
            this.txMinutosSim.WaterMarkColor = System.Drawing.Color.FromArgb(((int) (((byte) (109)))), ((int) (((byte) (109)))), ((int) (((byte) (109)))));
            this.txMinutosSim.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txMinutosSim.Validating += new System.ComponentModel.CancelEventHandler(this.txMinutosSim_Validating);
            // 
            // lbMinutosSim
            // 
            this.lbMinutosSim.AutoSize = true;
            this.lbMinutosSim.Location = new System.Drawing.Point(24, 69);
            this.lbMinutosSim.Name = "lbMinutosSim";
            this.lbMinutosSim.Size = new System.Drawing.Size(112, 19);
            this.lbMinutosSim.TabIndex = 8;
            this.lbMinutosSim.Text = "Minutos a simular";
            this.lbMinutosSim.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lbcM1
            // 
            this.lbcM1.AutoSize = true;
            this.lbcM1.Location = new System.Drawing.Point(645, 145);
            this.lbcM1.Name = "lbcM1";
            this.lbcM1.Size = new System.Drawing.Size(94, 19);
            this.lbcM1.TabIndex = 0;
            this.lbcM1.Text = "Cola máxima: ";
            this.lbcM1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbcM1.Visible = false;
            // 
            // lbColaMI
            // 
            this.lbColaMI.AutoSize = true;
            this.lbColaMI.Location = new System.Drawing.Point(732, 145);
            this.lbColaMI.Name = "lbColaMI";
            this.lbColaMI.Size = new System.Drawing.Size(17, 19);
            this.lbColaMI.TabIndex = 0;
            this.lbColaMI.Text = "X";
            this.lbColaMI.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbColaMI.Visible = false;
            // 
            // lbColaMP
            // 
            this.lbColaMP.AutoSize = true;
            this.lbColaMP.Location = new System.Drawing.Point(985, 145);
            this.lbColaMP.Name = "lbColaMP";
            this.lbColaMP.Size = new System.Drawing.Size(17, 19);
            this.lbColaMP.TabIndex = 12;
            this.lbColaMP.Text = "X";
            this.lbColaMP.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbColaMP.Visible = false;
            // 
            // lbcM2
            // 
            this.lbcM2.AutoSize = true;
            this.lbcM2.Location = new System.Drawing.Point(898, 145);
            this.lbcM2.Name = "lbcM2";
            this.lbcM2.Size = new System.Drawing.Size(94, 19);
            this.lbcM2.TabIndex = 0;
            this.lbcM2.Text = "Cola máxima: ";
            this.lbcM2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbcM2.Visible = false;
            // 
            // lbColaMS
            // 
            this.lbColaMS.AutoSize = true;
            this.lbColaMS.Location = new System.Drawing.Point(1225, 145);
            this.lbColaMS.Name = "lbColaMS";
            this.lbColaMS.Size = new System.Drawing.Size(17, 19);
            this.lbColaMS.TabIndex = 0;
            this.lbColaMS.Text = "X";
            this.lbColaMS.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbColaMS.Visible = false;
            // 
            // lbcM3
            // 
            this.lbcM3.AutoSize = true;
            this.lbcM3.Location = new System.Drawing.Point(1138, 145);
            this.lbcM3.Name = "lbcM3";
            this.lbcM3.Size = new System.Drawing.Size(94, 19);
            this.lbcM3.TabIndex = 0;
            this.lbcM3.Text = "Cola máxima: ";
            this.lbcM3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbcM3.Visible = false;
            // 
            // txMc
            // 
            // 
            // 
            // 
            this.txMc.CustomButton.Image = null;
            this.txMc.CustomButton.Location = new System.Drawing.Point(17, 2);
            this.txMc.CustomButton.Name = "";
            this.txMc.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txMc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txMc.CustomButton.TabIndex = 1;
            this.txMc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txMc.CustomButton.UseSelectable = true;
            this.txMc.CustomButton.Visible = false;
            this.txMc.Enabled = false;
            this.txMc.Lines = new string[0];
            this.txMc.Location = new System.Drawing.Point(142, 94);
            this.txMc.MaxLength = 32767;
            this.txMc.Name = "txMc";
            this.txMc.PasswordChar = '\0';
            this.txMc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txMc.SelectedText = "";
            this.txMc.SelectionLength = 0;
            this.txMc.SelectionStart = 0;
            this.txMc.ShortcutsEnabled = true;
            this.txMc.Size = new System.Drawing.Size(35, 20);
            this.txMc.TabIndex = 2;
            this.txMc.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txMc.UseSelectable = true;
            this.txMc.WaterMarkColor = System.Drawing.Color.FromArgb(((int) (((byte) (109)))), ((int) (((byte) (109)))), ((int) (((byte) (109)))));
            this.txMc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txMc.Validating += new System.ComponentModel.CancelEventHandler(this.txMc_Validating);
            // 
            // metroTextBox2
            // 
            // 
            // 
            // 
            this.metroTextBox2.CustomButton.Image = null;
            this.metroTextBox2.CustomButton.Location = new System.Drawing.Point(-3, 2);
            this.metroTextBox2.CustomButton.Name = "";
            this.metroTextBox2.CustomButton.Size = new System.Drawing.Size(0, 0);
            this.metroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.CustomButton.TabIndex = 1;
            this.metroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.CustomButton.UseSelectable = true;
            this.metroTextBox2.CustomButton.Visible = false;
            this.metroTextBox2.Lines = new string[0];
            this.metroTextBox2.Location = new System.Drawing.Point(142, 120);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.PromptText = "En minutos";
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.SelectionLength = 0;
            this.metroTextBox2.SelectionStart = 0;
            this.metroTextBox2.ShortcutsEnabled = true;
            this.metroTextBox2.Size = new System.Drawing.Size(0, 0);
            this.metroTextBox2.TabIndex = 16;
            this.metroTextBox2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBox2.UseSelectable = true;
            this.metroTextBox2.WaterMark = "En minutos";
            this.metroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int) (((byte) (109)))), ((int) (((byte) (109)))), ((int) (((byte) (109)))));
            this.metroTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox3
            // 
            // 
            // 
            // 
            this.metroTextBox3.CustomButton.Image = null;
            this.metroTextBox3.CustomButton.Location = new System.Drawing.Point(-3, 2);
            this.metroTextBox3.CustomButton.Name = "";
            this.metroTextBox3.CustomButton.Size = new System.Drawing.Size(0, 0);
            this.metroTextBox3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox3.CustomButton.TabIndex = 1;
            this.metroTextBox3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox3.CustomButton.UseSelectable = true;
            this.metroTextBox3.CustomButton.Visible = false;
            this.metroTextBox3.Lines = new string[0];
            this.metroTextBox3.Location = new System.Drawing.Point(142, 146);
            this.metroTextBox3.MaxLength = 32767;
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.PasswordChar = '\0';
            this.metroTextBox3.PromptText = "En minutos";
            this.metroTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox3.SelectedText = "";
            this.metroTextBox3.SelectionLength = 0;
            this.metroTextBox3.SelectionStart = 0;
            this.metroTextBox3.ShortcutsEnabled = true;
            this.metroTextBox3.Size = new System.Drawing.Size(0, 0);
            this.metroTextBox3.TabIndex = 17;
            this.metroTextBox3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBox3.UseSelectable = true;
            this.metroTextBox3.WaterMark = "En minutos";
            this.metroTextBox3.WaterMarkColor = System.Drawing.Color.FromArgb(((int) (((byte) (109)))), ((int) (((byte) (109)))), ((int) (((byte) (109)))));
            this.metroTextBox3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txMi
            // 
            // 
            // 
            // 
            this.txMi.CustomButton.Image = null;
            this.txMi.CustomButton.Location = new System.Drawing.Point(17, 2);
            this.txMi.CustomButton.Name = "";
            this.txMi.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txMi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txMi.CustomButton.TabIndex = 1;
            this.txMi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txMi.CustomButton.UseSelectable = true;
            this.txMi.CustomButton.Visible = false;
            this.txMi.Enabled = false;
            this.txMi.Lines = new string[0];
            this.txMi.Location = new System.Drawing.Point(142, 120);
            this.txMi.MaxLength = 32767;
            this.txMi.Name = "txMi";
            this.txMi.PasswordChar = '\0';
            this.txMi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txMi.SelectedText = "";
            this.txMi.SelectionLength = 0;
            this.txMi.SelectionStart = 0;
            this.txMi.ShortcutsEnabled = true;
            this.txMi.Size = new System.Drawing.Size(35, 20);
            this.txMi.TabIndex = 4;
            this.txMi.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txMi.UseSelectable = true;
            this.txMi.WaterMarkColor = System.Drawing.Color.FromArgb(((int) (((byte) (109)))), ((int) (((byte) (109)))), ((int) (((byte) (109)))));
            this.txMi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txMi.Validating += new System.ComponentModel.CancelEventHandler(this.txMi_Validating);
            // 
            // txMs
            // 
            // 
            // 
            // 
            this.txMs.CustomButton.Image = null;
            this.txMs.CustomButton.Location = new System.Drawing.Point(17, 2);
            this.txMs.CustomButton.Name = "";
            this.txMs.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txMs.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txMs.CustomButton.TabIndex = 1;
            this.txMs.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txMs.CustomButton.UseSelectable = true;
            this.txMs.CustomButton.Visible = false;
            this.txMs.Enabled = false;
            this.txMs.Lines = new string[0];
            this.txMs.Location = new System.Drawing.Point(142, 146);
            this.txMs.MaxLength = 32767;
            this.txMs.Name = "txMs";
            this.txMs.PasswordChar = '\0';
            this.txMs.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txMs.SelectedText = "";
            this.txMs.SelectionLength = 0;
            this.txMs.SelectionStart = 0;
            this.txMs.ShortcutsEnabled = true;
            this.txMs.Size = new System.Drawing.Size(35, 20);
            this.txMs.TabIndex = 6;
            this.txMs.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txMs.UseSelectable = true;
            this.txMs.WaterMarkColor = System.Drawing.Color.FromArgb(((int) (((byte) (109)))), ((int) (((byte) (109)))), ((int) (((byte) (109)))));
            this.txMs.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txMs.Validating += new System.ComponentModel.CancelEventHandler(this.txMs_Validating);
            // 
            // txDs
            // 
            // 
            // 
            // 
            this.txDs.CustomButton.Image = null;
            this.txDs.CustomButton.Location = new System.Drawing.Point(17, 2);
            this.txDs.CustomButton.Name = "";
            this.txDs.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txDs.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txDs.CustomButton.TabIndex = 1;
            this.txDs.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txDs.CustomButton.UseSelectable = true;
            this.txDs.CustomButton.Visible = false;
            this.txDs.Enabled = false;
            this.txDs.Lines = new string[0];
            this.txDs.Location = new System.Drawing.Point(193, 146);
            this.txDs.MaxLength = 32767;
            this.txDs.Name = "txDs";
            this.txDs.PasswordChar = '\0';
            this.txDs.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txDs.SelectedText = "";
            this.txDs.SelectionLength = 0;
            this.txDs.SelectionStart = 0;
            this.txDs.ShortcutsEnabled = true;
            this.txDs.Size = new System.Drawing.Size(35, 20);
            this.txDs.TabIndex = 7;
            this.txDs.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txDs.UseSelectable = true;
            this.txDs.WaterMarkColor = System.Drawing.Color.FromArgb(((int) (((byte) (109)))), ((int) (((byte) (109)))), ((int) (((byte) (109)))));
            this.txDs.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txDs.Validating += new System.ComponentModel.CancelEventHandler(this.txDs_Validating);
            // 
            // txDi
            // 
            // 
            // 
            // 
            this.txDi.CustomButton.Image = null;
            this.txDi.CustomButton.Location = new System.Drawing.Point(17, 2);
            this.txDi.CustomButton.Name = "";
            this.txDi.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txDi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txDi.CustomButton.TabIndex = 1;
            this.txDi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txDi.CustomButton.UseSelectable = true;
            this.txDi.CustomButton.Visible = false;
            this.txDi.Enabled = false;
            this.txDi.Lines = new string[0];
            this.txDi.Location = new System.Drawing.Point(193, 120);
            this.txDi.MaxLength = 32767;
            this.txDi.Name = "txDi";
            this.txDi.PasswordChar = '\0';
            this.txDi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txDi.SelectedText = "";
            this.txDi.SelectionLength = 0;
            this.txDi.SelectionStart = 0;
            this.txDi.ShortcutsEnabled = true;
            this.txDi.Size = new System.Drawing.Size(35, 20);
            this.txDi.TabIndex = 5;
            this.txDi.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txDi.UseSelectable = true;
            this.txDi.WaterMarkColor = System.Drawing.Color.FromArgb(((int) (((byte) (109)))), ((int) (((byte) (109)))), ((int) (((byte) (109)))));
            this.txDi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txDi.Validating += new System.ComponentModel.CancelEventHandler(this.txDi_Validating);
            // 
            // txDc
            // 
            // 
            // 
            // 
            this.txDc.CustomButton.Image = null;
            this.txDc.CustomButton.Location = new System.Drawing.Point(17, 2);
            this.txDc.CustomButton.Name = "";
            this.txDc.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txDc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txDc.CustomButton.TabIndex = 1;
            this.txDc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txDc.CustomButton.UseSelectable = true;
            this.txDc.CustomButton.Visible = false;
            this.txDc.Enabled = false;
            this.txDc.Lines = new string[0];
            this.txDc.Location = new System.Drawing.Point(193, 94);
            this.txDc.MaxLength = 32767;
            this.txDc.Name = "txDc";
            this.txDc.PasswordChar = '\0';
            this.txDc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txDc.SelectedText = "";
            this.txDc.SelectionLength = 0;
            this.txDc.SelectionStart = 0;
            this.txDc.ShortcutsEnabled = true;
            this.txDc.Size = new System.Drawing.Size(35, 20);
            this.txDc.TabIndex = 3;
            this.txDc.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txDc.UseSelectable = true;
            this.txDc.WaterMarkColor = System.Drawing.Color.FromArgb(((int) (((byte) (109)))), ((int) (((byte) (109)))), ((int) (((byte) (109)))));
            this.txDc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txDc.Validating += new System.ComponentModel.CancelEventHandler(this.txDc_Validating);
            // 
            // txDl
            // 
            // 
            // 
            // 
            this.txDl.CustomButton.Image = null;
            this.txDl.CustomButton.Location = new System.Drawing.Point(17, 2);
            this.txDl.CustomButton.Name = "";
            this.txDl.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txDl.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txDl.CustomButton.TabIndex = 1;
            this.txDl.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txDl.CustomButton.UseSelectable = true;
            this.txDl.CustomButton.Visible = false;
            this.txDl.Enabled = false;
            this.txDl.Lines = new string[0];
            this.txDl.Location = new System.Drawing.Point(355, 120);
            this.txDl.MaxLength = 32767;
            this.txDl.Name = "txDl";
            this.txDl.PasswordChar = '\0';
            this.txDl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txDl.SelectedText = "";
            this.txDl.SelectionLength = 0;
            this.txDl.SelectionStart = 0;
            this.txDl.ShortcutsEnabled = true;
            this.txDl.Size = new System.Drawing.Size(35, 20);
            this.txDl.TabIndex = 11;
            this.txDl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txDl.UseSelectable = true;
            this.txDl.WaterMarkColor = System.Drawing.Color.FromArgb(((int) (((byte) (109)))), ((int) (((byte) (109)))), ((int) (((byte) (109)))));
            this.txDl.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txDl.Validating += new System.ComponentModel.CancelEventHandler(this.txDl_Validating);
            // 
            // txDp
            // 
            // 
            // 
            // 
            this.txDp.CustomButton.Image = null;
            this.txDp.CustomButton.Location = new System.Drawing.Point(17, 2);
            this.txDp.CustomButton.Name = "";
            this.txDp.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txDp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txDp.CustomButton.TabIndex = 1;
            this.txDp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txDp.CustomButton.UseSelectable = true;
            this.txDp.CustomButton.Visible = false;
            this.txDp.Enabled = false;
            this.txDp.Lines = new string[0];
            this.txDp.Location = new System.Drawing.Point(432, 94);
            this.txDp.MaxLength = 32767;
            this.txDp.Name = "txDp";
            this.txDp.PasswordChar = '\0';
            this.txDp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txDp.SelectedText = "";
            this.txDp.SelectionLength = 0;
            this.txDp.SelectionStart = 0;
            this.txDp.ShortcutsEnabled = true;
            this.txDp.Size = new System.Drawing.Size(35, 20);
            this.txDp.TabIndex = 9;
            this.txDp.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txDp.UseSelectable = true;
            this.txDp.WaterMarkColor = System.Drawing.Color.FromArgb(((int) (((byte) (109)))), ((int) (((byte) (109)))), ((int) (((byte) (109)))));
            this.txDp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txDp.Validating += new System.ComponentModel.CancelEventHandler(this.txDp_Validating);
            // 
            // txL
            // 
            // 
            // 
            // 
            this.txL.CustomButton.Image = null;
            this.txL.CustomButton.Location = new System.Drawing.Point(17, 2);
            this.txL.CustomButton.Name = "";
            this.txL.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txL.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txL.CustomButton.TabIndex = 1;
            this.txL.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txL.CustomButton.UseSelectable = true;
            this.txL.CustomButton.Visible = false;
            this.txL.Enabled = false;
            this.txL.Lines = new string[0];
            this.txL.Location = new System.Drawing.Point(355, 146);
            this.txL.MaxLength = 32767;
            this.txL.Name = "txL";
            this.txL.PasswordChar = '\0';
            this.txL.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txL.SelectedText = "";
            this.txL.SelectionLength = 0;
            this.txL.SelectionStart = 0;
            this.txL.ShortcutsEnabled = true;
            this.txL.Size = new System.Drawing.Size(35, 20);
            this.txL.TabIndex = 12;
            this.txL.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txL.UseSelectable = true;
            this.txL.WaterMarkColor = System.Drawing.Color.FromArgb(((int) (((byte) (109)))), ((int) (((byte) (109)))), ((int) (((byte) (109)))));
            this.txL.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txL.Validating += new System.ComponentModel.CancelEventHandler(this.txL_Validating);
            // 
            // txMl
            // 
            // 
            // 
            // 
            this.txMl.CustomButton.Image = null;
            this.txMl.CustomButton.Location = new System.Drawing.Point(17, 2);
            this.txMl.CustomButton.Name = "";
            this.txMl.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txMl.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txMl.CustomButton.TabIndex = 1;
            this.txMl.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txMl.CustomButton.UseSelectable = true;
            this.txMl.CustomButton.Visible = false;
            this.txMl.Enabled = false;
            this.txMl.Lines = new string[0];
            this.txMl.Location = new System.Drawing.Point(304, 120);
            this.txMl.MaxLength = 32767;
            this.txMl.Name = "txMl";
            this.txMl.PasswordChar = '\0';
            this.txMl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txMl.SelectedText = "";
            this.txMl.SelectionLength = 0;
            this.txMl.SelectionStart = 0;
            this.txMl.ShortcutsEnabled = true;
            this.txMl.Size = new System.Drawing.Size(35, 20);
            this.txMl.TabIndex = 10;
            this.txMl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txMl.UseSelectable = true;
            this.txMl.WaterMarkColor = System.Drawing.Color.FromArgb(((int) (((byte) (109)))), ((int) (((byte) (109)))), ((int) (((byte) (109)))));
            this.txMl.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txMl.Validating += new System.ComponentModel.CancelEventHandler(this.txMl_Validating);
            // 
            // txMp
            // 
            // 
            // 
            // 
            this.txMp.CustomButton.Image = null;
            this.txMp.CustomButton.Location = new System.Drawing.Point(17, 2);
            this.txMp.CustomButton.Name = "";
            this.txMp.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txMp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txMp.CustomButton.TabIndex = 1;
            this.txMp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txMp.CustomButton.UseSelectable = true;
            this.txMp.CustomButton.Visible = false;
            this.txMp.Enabled = false;
            this.txMp.Lines = new string[0];
            this.txMp.Location = new System.Drawing.Point(381, 94);
            this.txMp.MaxLength = 32767;
            this.txMp.Name = "txMp";
            this.txMp.PasswordChar = '\0';
            this.txMp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txMp.SelectedText = "";
            this.txMp.SelectionLength = 0;
            this.txMp.SelectionStart = 0;
            this.txMp.ShortcutsEnabled = true;
            this.txMp.Size = new System.Drawing.Size(35, 20);
            this.txMp.TabIndex = 8;
            this.txMp.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txMp.UseSelectable = true;
            this.txMp.WaterMarkColor = System.Drawing.Color.FromArgb(((int) (((byte) (109)))), ((int) (((byte) (109)))), ((int) (((byte) (109)))));
            this.txMp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txMp.Validating += new System.ComponentModel.CancelEventHandler(this.txMp_Validating);
            // 
            // rbDefault
            // 
            this.rbDefault.AutoSize = true;
            this.rbDefault.Checked = true;
            this.rbDefault.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rbDefault.Location = new System.Drawing.Point(304, 68);
            this.rbDefault.Name = "rbDefault";
            this.rbDefault.Size = new System.Drawing.Size(150, 15);
            this.rbDefault.TabIndex = 29;
            this.rbDefault.Text = "Usar valores por defecto";
            this.rbDefault.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.rbDefault.UseSelectable = true;
            this.rbDefault.CheckedChanged += new System.EventHandler(this.rbDefault_CheckedChanged);
            this.rbDefault.Click += new System.EventHandler(this.rbDefault_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.Location = new System.Drawing.Point(41, 95);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(101, 15);
            this.metroLabel1.TabIndex = 30;
            this.metroLabel1.Text = "Llegada clientes: μ ";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.Location = new System.Drawing.Point(31, 121);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(111, 15);
            this.metroLabel2.TabIndex = 31;
            this.metroLabel2.Text = "Atencion insumos: μ ";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel3.Location = new System.Drawing.Point(247, 95);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(133, 15);
            this.metroLabel3.TabIndex = 32;
            this.metroLabel3.Text = "Atencion presupuesto: μ ";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel4.Location = new System.Drawing.Point(178, 96);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(14, 15);
            this.metroLabel4.TabIndex = 33;
            this.metroLabel4.Text = "σ";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel5.Location = new System.Drawing.Point(178, 122);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(14, 15);
            this.metroLabel5.TabIndex = 34;
            this.metroLabel5.Text = "σ";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel6.Location = new System.Drawing.Point(178, 147);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(14, 15);
            this.metroLabel6.TabIndex = 35;
            this.metroLabel6.Text = "σ";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel7.Location = new System.Drawing.Point(417, 95);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(14, 15);
            this.metroLabel7.TabIndex = 36;
            this.metroLabel7.Text = "σ";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel8.Location = new System.Drawing.Point(340, 122);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(14, 15);
            this.metroLabel8.TabIndex = 37;
            this.metroLabel8.Text = "σ";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel10.Location = new System.Drawing.Point(11, 146);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(131, 15);
            this.metroLabel10.TabIndex = 39;
            this.metroLabel10.Text = "Atencion serv. Tecnico: μ ";
            this.metroLabel10.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel9.Location = new System.Drawing.Point(237, 121);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(67, 15);
            this.metroLabel9.TabIndex = 40;
            this.metroLabel9.Text = "Lllamada: μ ";
            this.metroLabel9.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel11.Location = new System.Drawing.Point(268, 146);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(87, 15);
            this.metroLabel11.TabIndex = 41;
            this.metroLabel11.Text = "Llamadas cada: ";
            this.metroLabel11.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // logoUtn
            // 
            this.logoUtn.Image = ((System.Drawing.Image) (resources.GetObject("logoUtn.Image")));
            this.logoUtn.Location = new System.Drawing.Point(283, 21);
            this.logoUtn.Name = "logoUtn";
            this.logoUtn.Size = new System.Drawing.Size(30, 36);
            this.logoUtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoUtn.TabIndex = 42;
            this.logoUtn.TabStop = false;
            // 
            // Sim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1346, 728);
            this.Controls.Add(this.logoUtn);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.rbDefault);
            this.Controls.Add(this.txDl);
            this.Controls.Add(this.txDp);
            this.Controls.Add(this.txL);
            this.Controls.Add(this.txMl);
            this.Controls.Add(this.txMp);
            this.Controls.Add(this.txDs);
            this.Controls.Add(this.txDi);
            this.Controls.Add(this.txDc);
            this.Controls.Add(this.txMs);
            this.Controls.Add(this.txMi);
            this.Controls.Add(this.metroTextBox3);
            this.Controls.Add(this.metroTextBox2);
            this.Controls.Add(this.txMc);
            this.Controls.Add(this.lbColaMS);
            this.Controls.Add(this.lbcM3);
            this.Controls.Add(this.lbColaMP);
            this.Controls.Add(this.lbcM2);
            this.Controls.Add(this.lbColaMI);
            this.Controls.Add(this.lbcM1);
            this.Controls.Add(this.lbMinutosSim);
            this.Controls.Add(this.txMinutosSim);
            this.Controls.Add(this.btn_simular);
            this.Controls.Add(this.grTI);
            this.Controls.Add(this.grTP);
            this.Controls.Add(this.grTS);
            this.Controls.Add(this.gvSimulacion);
            this.Name = "Sim";
            this.Resizable = false;
            this.Text = "Simulador de atenciones";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Sim_FormClosing);
            ((System.ComponentModel.ISupportInitialize) (this.gvSimulacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.grTS)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.grTP)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.grTI)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.logoUtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn I_personalLibre;
        private System.Windows.Forms.DataGridViewTextBoxColumn I_inicioOcio;
        private System.Windows.Forms.DataGridViewTextBoxColumn I_cola;
        private System.Windows.Forms.DataGridViewTextBoxColumn T_Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn T_proxima;
        private System.Windows.Forms.DataGridViewTextBoxColumn T_fin;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_tiempoAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_finAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn P2_tiempoAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn P2_finAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn P3_tiempoAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn P3_finAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_personalLibre;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_inicioOcio;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_cola;
        private System.Windows.Forms.DataGridViewTextBoxColumn S_Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn S_tiempoAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn S_finAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn S2_tiempoAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn S2_finAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn S_personalLibre;
        private System.Windows.Forms.DataGridViewTextBoxColumn S_inicioOcio;
        private System.Windows.Forms.DataGridViewTextBoxColumn S_cola;
        private MetroFramework.Controls.MetroGrid gvSimulacion;
        private System.Windows.Forms.DataVisualization.Charting.Chart grTS;
        private System.Windows.Forms.DataVisualization.Charting.Chart grTP;
        private System.Windows.Forms.DataVisualization.Charting.Chart grTI;
        private MetroFramework.Controls.MetroButton btn_simular;
        private MetroFramework.Controls.MetroTextBox txMinutosSim;
        private MetroFramework.Controls.MetroLabel lbMinutosSim;
        private MetroFramework.Controls.MetroLabel lbcM1;
        private MetroFramework.Controls.MetroLabel lbColaMI;
        private MetroFramework.Controls.MetroLabel lbColaMP;
        private MetroFramework.Controls.MetroLabel lbcM2;
        private MetroFramework.Controls.MetroLabel lbColaMS;
        private MetroFramework.Controls.MetroLabel lbcM3;
        private MetroFramework.Controls.MetroTextBox txMc;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        private MetroFramework.Controls.MetroTextBox txMi;
        private MetroFramework.Controls.MetroTextBox txMs;
        private MetroFramework.Controls.MetroTextBox txDs;
        private MetroFramework.Controls.MetroTextBox txDi;
        private MetroFramework.Controls.MetroTextBox txDc;
        private MetroFramework.Controls.MetroTextBox txDl;
        private MetroFramework.Controls.MetroTextBox txDp;
        private MetroFramework.Controls.MetroTextBox txL;
        private MetroFramework.Controls.MetroTextBox txMl;
        private MetroFramework.Controls.MetroTextBox txMp;
        private MetroFramework.Controls.MetroCheckBox rbDefault;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.PictureBox logoUtn;
    }
}

