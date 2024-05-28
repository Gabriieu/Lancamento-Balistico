namespace Lançamento_Obliquo_Gráfico
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelDistanciaVoo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.labelTempoVoo = new System.Windows.Forms.Label();
            this.labelAlturaMaxima = new System.Windows.Forms.Label();
            this.cartesianChart2 = new LiveCharts.WinForms.CartesianChart();
            this.numericV0 = new System.Windows.Forms.NumericUpDown();
            this.numericTeta = new System.Windows.Forms.NumericUpDown();
            this.numericG = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericAlvoY = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numericAlvoX = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.labelAtingido = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.labelTempoAtingir = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericV0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTeta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAlvoY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAlvoX)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDistanciaVoo
            // 
            this.labelDistanciaVoo.BackColor = System.Drawing.Color.Gainsboro;
            this.labelDistanciaVoo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDistanciaVoo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelDistanciaVoo.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.labelDistanciaVoo.Location = new System.Drawing.Point(334, 375);
            this.labelDistanciaVoo.Name = "labelDistanciaVoo";
            this.labelDistanciaVoo.Padding = new System.Windows.Forms.Padding(3);
            this.labelDistanciaVoo.Size = new System.Drawing.Size(155, 25);
            this.labelDistanciaVoo.TabIndex = 17;
            this.labelDistanciaVoo.Text = "0,00 m";
            this.labelDistanciaVoo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label3.Location = new System.Drawing.Point(266, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 30);
            this.label3.TabIndex = 12;
            this.label3.Text = "g";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label2.Location = new System.Drawing.Point(266, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 27);
            this.label2.TabIndex = 11;
            this.label2.Text = "θ";
            // 
            // lbl1
            // 
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lbl1.Location = new System.Drawing.Point(266, 157);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(31, 19);
            this.lbl1.TabIndex = 9;
            this.lbl1.Text = "v0";
            // 
            // labelTempoVoo
            // 
            this.labelTempoVoo.BackColor = System.Drawing.Color.Gainsboro;
            this.labelTempoVoo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTempoVoo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTempoVoo.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.labelTempoVoo.Location = new System.Drawing.Point(334, 457);
            this.labelTempoVoo.Name = "labelTempoVoo";
            this.labelTempoVoo.Padding = new System.Windows.Forms.Padding(3);
            this.labelTempoVoo.Size = new System.Drawing.Size(155, 25);
            this.labelTempoVoo.TabIndex = 19;
            this.labelTempoVoo.Text = "0,00 s";
            this.labelTempoVoo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAlturaMaxima
            // 
            this.labelAlturaMaxima.BackColor = System.Drawing.Color.Gainsboro;
            this.labelAlturaMaxima.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlturaMaxima.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelAlturaMaxima.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.labelAlturaMaxima.Location = new System.Drawing.Point(334, 402);
            this.labelAlturaMaxima.Name = "labelAlturaMaxima";
            this.labelAlturaMaxima.Padding = new System.Windows.Forms.Padding(3);
            this.labelAlturaMaxima.Size = new System.Drawing.Size(155, 25);
            this.labelAlturaMaxima.TabIndex = 21;
            this.labelAlturaMaxima.Text = "0,00 m";
            this.labelAlturaMaxima.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cartesianChart2
            // 
            this.cartesianChart2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartesianChart2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cartesianChart2.Location = new System.Drawing.Point(520, 18);
            this.cartesianChart2.Name = "cartesianChart2";
            this.cartesianChart2.Size = new System.Drawing.Size(822, 469);
            this.cartesianChart2.TabIndex = 23;
            this.cartesianChart2.Text = "cartesianChart2";
            // 
            // numericV0
            // 
            this.numericV0.DecimalPlaces = 2;
            this.numericV0.ForeColor = System.Drawing.Color.Black;
            this.numericV0.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericV0.Location = new System.Drawing.Point(303, 156);
            this.numericV0.Maximum = new decimal(new int[] {
            -1744830464,
            1364693707,
            -12368715,
            0});
            this.numericV0.Minimum = new decimal(new int[] {
            -1744830464,
            1364693707,
            -12368715,
            -2147483648});
            this.numericV0.Name = "numericV0";
            this.numericV0.ReadOnly = true;
            this.numericV0.Size = new System.Drawing.Size(120, 20);
            this.numericV0.TabIndex = 35;
            this.numericV0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericTeta
            // 
            this.numericTeta.DecimalPlaces = 2;
            this.numericTeta.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericTeta.Location = new System.Drawing.Point(303, 192);
            this.numericTeta.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.numericTeta.Name = "numericTeta";
            this.numericTeta.Size = new System.Drawing.Size(120, 20);
            this.numericTeta.TabIndex = 2;
            this.numericTeta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericTeta.ValueChanged += new System.EventHandler(this.numericTeta_ValueChanged);
            // 
            // numericG
            // 
            this.numericG.DecimalPlaces = 2;
            this.numericG.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericG.Location = new System.Drawing.Point(303, 225);
            this.numericG.Maximum = new decimal(new int[] {
            -1744830464,
            1364693707,
            -12368715,
            0});
            this.numericG.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericG.Name = "numericG";
            this.numericG.Size = new System.Drawing.Size(120, 20);
            this.numericG.TabIndex = 3;
            this.numericG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericG.Value = new decimal(new int[] {
            981,
            0,
            0,
            131072});
            this.numericG.ValueChanged += new System.EventHandler(this.numericG_ValueChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label1.Location = new System.Drawing.Point(16, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 19);
            this.label1.TabIndex = 39;
            this.label1.Text = "POSIÇÃO DO ALVO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericAlvoY
            // 
            this.numericAlvoY.DecimalPlaces = 2;
            this.numericAlvoY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericAlvoY.Location = new System.Drawing.Point(126, 157);
            this.numericAlvoY.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericAlvoY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericAlvoY.Name = "numericAlvoY";
            this.numericAlvoY.Size = new System.Drawing.Size(85, 20);
            this.numericAlvoY.TabIndex = 0;
            this.numericAlvoY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericAlvoY.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericAlvoY.ValueChanged += new System.EventHandler(this.numericAlvoH_ValueChanged);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label7.Location = new System.Drawing.Point(16, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 41;
            this.label7.Text = "Altura:";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label8.Location = new System.Drawing.Point(15, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 23);
            this.label8.TabIndex = 43;
            this.label8.Text = "Distância:";
            // 
            // numericAlvoX
            // 
            this.numericAlvoX.DecimalPlaces = 2;
            this.numericAlvoX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericAlvoX.Location = new System.Drawing.Point(126, 193);
            this.numericAlvoX.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericAlvoX.Name = "numericAlvoX";
            this.numericAlvoX.Size = new System.Drawing.Size(85, 20);
            this.numericAlvoX.TabIndex = 1;
            this.numericAlvoX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericAlvoX.ValueChanged += new System.EventHandler(this.numericAlvoD_ValueChanged);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label9.Location = new System.Drawing.Point(299, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 19);
            this.label9.TabIndex = 44;
            this.label9.Text = "CANHÃO";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAtingido
            // 
            this.labelAtingido.BackColor = System.Drawing.Color.Gainsboro;
            this.labelAtingido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAtingido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelAtingido.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.labelAtingido.Location = new System.Drawing.Point(334, 348);
            this.labelAtingido.Name = "labelAtingido";
            this.labelAtingido.Padding = new System.Windows.Forms.Padding(3);
            this.labelAtingido.Size = new System.Drawing.Size(155, 25);
            this.labelAtingido.TabIndex = 50;
            this.labelAtingido.Text = "-";
            this.labelAtingido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label4.Location = new System.Drawing.Point(20, 348);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(3);
            this.label4.Size = new System.Drawing.Size(308, 25);
            this.label4.TabIndex = 51;
            this.label4.Text = "ALVO ATINGIDO EM MOVIMENTO: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label5.Location = new System.Drawing.Point(20, 375);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(3);
            this.label5.Size = new System.Drawing.Size(308, 25);
            this.label5.TabIndex = 52;
            this.label5.Text = "DISTÂNCIA TOTAL DE VOO: ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label6.Location = new System.Drawing.Point(20, 457);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(3);
            this.label6.Size = new System.Drawing.Size(308, 25);
            this.label6.TabIndex = 53;
            this.label6.Text = "TEMPO TOTAL DE VOO: ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label11.Location = new System.Drawing.Point(20, 402);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(3);
            this.label11.Size = new System.Drawing.Size(308, 25);
            this.label11.TabIndex = 54;
            this.label11.Text = "ALTURA MÁXIMA ATINGIDA: ";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label12.Location = new System.Drawing.Point(73, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(328, 44);
            this.label12.TabIndex = 57;
            this.label12.Text = "LANÇAMENTO BALÍSTICO";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label13.Location = new System.Drawing.Point(429, 156);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 19);
            this.label13.TabIndex = 58;
            this.label13.Text = "m/s";
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label14.Location = new System.Drawing.Point(429, 193);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 19);
            this.label14.TabIndex = 59;
            this.label14.Text = "°";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label15.Location = new System.Drawing.Point(429, 226);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 19);
            this.label15.TabIndex = 60;
            this.label15.Text = "m/s²";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(1, 489);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(49, 13);
            this.linkLabel1.TabIndex = 61;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "@alunos";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label16.Location = new System.Drawing.Point(217, 158);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(21, 19);
            this.label16.TabIndex = 62;
            this.label16.Text = "m";
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label17.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label17.Location = new System.Drawing.Point(217, 194);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(21, 19);
            this.label17.TabIndex = 63;
            this.label17.Text = "m";
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label18.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label18.Location = new System.Drawing.Point(20, 429);
            this.label18.Name = "label18";
            this.label18.Padding = new System.Windows.Forms.Padding(3);
            this.label18.Size = new System.Drawing.Size(308, 25);
            this.label18.TabIndex = 65;
            this.label18.Text = "TEMPO ATÉ ATINGIR O ALVO:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTempoAtingir
            // 
            this.labelTempoAtingir.BackColor = System.Drawing.Color.Gainsboro;
            this.labelTempoAtingir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTempoAtingir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTempoAtingir.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.labelTempoAtingir.Location = new System.Drawing.Point(334, 429);
            this.labelTempoAtingir.Name = "labelTempoAtingir";
            this.labelTempoAtingir.Padding = new System.Windows.Forms.Padding(3);
            this.labelTempoAtingir.Size = new System.Drawing.Size(155, 25);
            this.labelTempoAtingir.TabIndex = 64;
            this.labelTempoAtingir.Text = "0,00 s";
            this.labelTempoAtingir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label19.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label19.Location = new System.Drawing.Point(85, 291);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(328, 44);
            this.label19.TabIndex = 66;
            this.label19.Text = "INFORMAÇÕES";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1354, 506);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.labelTempoAtingir);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelAtingido);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numericAlvoX);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericAlvoY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericG);
            this.Controls.Add(this.numericTeta);
            this.Controls.Add(this.numericV0);
            this.Controls.Add(this.cartesianChart2);
            this.Controls.Add(this.labelAlturaMaxima);
            this.Controls.Add(this.labelTempoVoo);
            this.Controls.Add(this.labelDistanciaVoo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1370, 545);
            this.MinimumSize = new System.Drawing.Size(1370, 545);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lançamento Obliquo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericV0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTeta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAlvoY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAlvoX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelDistanciaVoo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label labelTempoVoo;
        private System.Windows.Forms.Label labelAlturaMaxima;
        private LiveCharts.WinForms.CartesianChart cartesianChart2;
        private System.Windows.Forms.NumericUpDown numericV0;
        private System.Windows.Forms.NumericUpDown numericTeta;
        private System.Windows.Forms.NumericUpDown numericG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericAlvoY;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericAlvoX;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelAtingido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label labelTempoAtingir;
        private System.Windows.Forms.Label label19;
    }
}

