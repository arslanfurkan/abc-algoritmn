namespace ABCalgoritmn
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.numKoloniBuyuklugu = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.numIterasyon = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numDenemeLimit = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numOlasilik = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.numKoloniBuyuklugu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIterasyon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDenemeLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOlasilik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // numKoloniBuyuklugu
            // 
            this.numKoloniBuyuklugu.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numKoloniBuyuklugu.Location = new System.Drawing.Point(164, 22);
            this.numKoloniBuyuklugu.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numKoloniBuyuklugu.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numKoloniBuyuklugu.Name = "numKoloniBuyuklugu";
            this.numKoloniBuyuklugu.Size = new System.Drawing.Size(106, 22);
            this.numKoloniBuyuklugu.TabIndex = 0;
            this.numKoloniBuyuklugu.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Koloni büyüklüğü :";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(26, 230);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(244, 69);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // numIterasyon
            // 
            this.numIterasyon.Location = new System.Drawing.Point(164, 50);
            this.numIterasyon.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numIterasyon.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numIterasyon.Name = "numIterasyon";
            this.numIterasyon.Size = new System.Drawing.Size(106, 22);
            this.numIterasyon.TabIndex = 0;
            this.numIterasyon.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "İterasyon sayısı :";
            // 
            // numDenemeLimit
            // 
            this.numDenemeLimit.Location = new System.Drawing.Point(164, 78);
            this.numDenemeLimit.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numDenemeLimit.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numDenemeLimit.Name = "numDenemeLimit";
            this.numDenemeLimit.Size = new System.Drawing.Size(106, 22);
            this.numDenemeLimit.TabIndex = 0;
            this.numDenemeLimit.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Deneme limiti :";
            // 
            // numOlasilik
            // 
            this.numOlasilik.DecimalPlaces = 1;
            this.numOlasilik.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numOlasilik.Location = new System.Drawing.Point(164, 106);
            this.numOlasilik.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numOlasilik.Name = "numOlasilik";
            this.numOlasilik.Size = new System.Drawing.Size(106, 22);
            this.numOlasilik.TabIndex = 0;
            this.numOlasilik.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Olasılık :";
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(295, 22);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(580, 277);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 318);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numOlasilik);
            this.Controls.Add(this.numDenemeLimit);
            this.Controls.Add(this.numIterasyon);
            this.Controls.Add(this.numKoloniBuyuklugu);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numKoloniBuyuklugu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIterasyon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDenemeLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOlasilik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numKoloniBuyuklugu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown numIterasyon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numDenemeLimit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numOlasilik;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

