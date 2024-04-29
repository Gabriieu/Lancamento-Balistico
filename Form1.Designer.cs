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
            this.lblAlcance = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblTt = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblHmax = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cartesianChart2 = new LiveCharts.WinForms.CartesianChart();
            this.lblY0 = new System.Windows.Forms.Label();
            this.numericV0 = new System.Windows.Forms.NumericUpDown();
            this.numericTeta = new System.Windows.Forms.NumericUpDown();
            this.numericG = new System.Windows.Forms.NumericUpDown();
            this.numericH = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericAlvoH = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numericAlvoD = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericV0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTeta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAlvoH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAlvoD)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAlcance
            // 
            this.lblAlcance.AutoSize = true;
            this.lblAlcance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlcance.ForeColor = System.Drawing.Color.White;
            this.lblAlcance.Location = new System.Drawing.Point(293, 520);
            this.lblAlcance.Name = "lblAlcance";
            this.lblAlcance.Size = new System.Drawing.Size(0, 22);
            this.lblAlcance.TabIndex = 18;
            this.lblAlcance.Visible = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label4.Location = new System.Drawing.Point(32, 522);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "DISTÂNCIA TOTAL DE VOO: ";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnCalcular.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.Black;
            this.btnCalcular.Location = new System.Drawing.Point(36, 447);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(257, 37);
            this.btnCalcular.TabIndex = 16;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label3.Location = new System.Drawing.Point(32, 160);
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
            this.label2.Location = new System.Drawing.Point(32, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 27);
            this.label2.TabIndex = 11;
            this.label2.Text = "θ°";
            // 
            // lbl1
            // 
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lbl1.Location = new System.Drawing.Point(32, 53);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(31, 19);
            this.lbl1.TabIndex = 9;
            this.lbl1.Text = "v0";
            // 
            // lblTt
            // 
            this.lblTt.AutoSize = true;
            this.lblTt.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTt.ForeColor = System.Drawing.Color.White;
            this.lblTt.Location = new System.Drawing.Point(249, 560);
            this.lblTt.Name = "lblTt";
            this.lblTt.Size = new System.Drawing.Size(0, 22);
            this.lblTt.TabIndex = 20;
            this.lblTt.Visible = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label5.Location = new System.Drawing.Point(32, 560);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "TEMPO TOTAL DE VOO: ";
            // 
            // lblHmax
            // 
            this.lblHmax.AutoSize = true;
            this.lblHmax.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHmax.ForeColor = System.Drawing.Color.White;
            this.lblHmax.Location = new System.Drawing.Point(293, 594);
            this.lblHmax.Name = "lblHmax";
            this.lblHmax.Size = new System.Drawing.Size(0, 22);
            this.lblHmax.TabIndex = 22;
            this.lblHmax.Visible = false;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label6.Location = new System.Drawing.Point(32, 596);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(255, 19);
            this.label6.TabIndex = 21;
            this.label6.Text = "ALTURA MÁXIMA ATINGIDA: ";
            // 
            // cartesianChart2
            // 
            this.cartesianChart2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartesianChart2.Location = new System.Drawing.Point(337, 20);
            this.cartesianChart2.Name = "cartesianChart2";
            this.cartesianChart2.Size = new System.Drawing.Size(569, 312);
            this.cartesianChart2.TabIndex = 23;
            this.cartesianChart2.Text = "cartesianChart2";
            // 
            // lblY0
            // 
            this.lblY0.BackColor = System.Drawing.Color.Transparent;
            this.lblY0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblY0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblY0.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblY0.Location = new System.Drawing.Point(32, 213);
            this.lblY0.Name = "lblY0";
            this.lblY0.Size = new System.Drawing.Size(31, 30);
            this.lblY0.TabIndex = 24;
            this.lblY0.Text = "h";
            // 
            // numericV0
            // 
            this.numericV0.DecimalPlaces = 2;
            this.numericV0.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numericV0.Location = new System.Drawing.Point(69, 52);
            this.numericV0.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericV0.Name = "numericV0";
            this.numericV0.Size = new System.Drawing.Size(120, 20);
            this.numericV0.TabIndex = 35;
            this.numericV0.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericTeta
            // 
            this.numericTeta.DecimalPlaces = 2;
            this.numericTeta.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericTeta.Location = new System.Drawing.Point(69, 109);
            this.numericTeta.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.numericTeta.Name = "numericTeta";
            this.numericTeta.Size = new System.Drawing.Size(120, 20);
            this.numericTeta.TabIndex = 36;
            this.numericTeta.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // numericG
            // 
            this.numericG.DecimalPlaces = 2;
            this.numericG.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericG.Location = new System.Drawing.Point(69, 163);
            this.numericG.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericG.Name = "numericG";
            this.numericG.Size = new System.Drawing.Size(120, 20);
            this.numericG.TabIndex = 37;
            this.numericG.Value = new decimal(new int[] {
            981,
            0,
            0,
            131072});
            // 
            // numericH
            // 
            this.numericH.DecimalPlaces = 2;
            this.numericH.Location = new System.Drawing.Point(69, 213);
            this.numericH.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericH.Name = "numericH";
            this.numericH.Size = new System.Drawing.Size(120, 20);
            this.numericH.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label1.Location = new System.Drawing.Point(38, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 19);
            this.label1.TabIndex = 39;
            this.label1.Text = "POSIÇÃO DO ALVO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericAlvoH
            // 
            this.numericAlvoH.DecimalPlaces = 2;
            this.numericAlvoH.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numericAlvoH.Location = new System.Drawing.Point(119, 310);
            this.numericAlvoH.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericAlvoH.Name = "numericAlvoH";
            this.numericAlvoH.Size = new System.Drawing.Size(70, 20);
            this.numericAlvoH.TabIndex = 40;
            this.numericAlvoH.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label7.Location = new System.Drawing.Point(32, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 30);
            this.label7.TabIndex = 41;
            this.label7.Text = "altura";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label8.Location = new System.Drawing.Point(32, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 30);
            this.label8.TabIndex = 43;
            this.label8.Text = "distância";
            // 
            // numericAlvoD
            // 
            this.numericAlvoD.DecimalPlaces = 2;
            this.numericAlvoD.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numericAlvoD.Location = new System.Drawing.Point(119, 340);
            this.numericAlvoD.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericAlvoD.Name = "numericAlvoD";
            this.numericAlvoD.Size = new System.Drawing.Size(70, 20);
            this.numericAlvoD.TabIndex = 42;
            this.numericAlvoD.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label9.Location = new System.Drawing.Point(32, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(255, 19);
            this.label9.TabIndex = 44;
            this.label9.Text = "CANHÃO";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(44, 372);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 45;
            this.label10.Text = "label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(44, 398);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 46;
            this.label11.Text = "label11";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(933, 626);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numericAlvoD);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericAlvoH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericH);
            this.Controls.Add(this.numericG);
            this.Controls.Add(this.numericTeta);
            this.Controls.Add(this.numericV0);
            this.Controls.Add(this.lblY0);
            this.Controls.Add(this.cartesianChart2);
            this.Controls.Add(this.lblHmax);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblAlcance);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Lançamento Obliquo";
            ((System.ComponentModel.ISupportInitialize)(this.numericV0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTeta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAlvoH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAlvoD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.Label lblAlcance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblTt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblHmax;
        private System.Windows.Forms.Label label6;
        private LiveCharts.WinForms.CartesianChart cartesianChart2;
        private System.Windows.Forms.Label lblY0;
        private System.Windows.Forms.NumericUpDown numericV0;
        private System.Windows.Forms.NumericUpDown numericTeta;
        private System.Windows.Forms.NumericUpDown numericG;
        private System.Windows.Forms.NumericUpDown numericH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericAlvoH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericAlvoD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

