namespace WindowsFormsApp1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.SineWaveType = new System.Windows.Forms.RadioButton();
            this.SquareWaveType = new System.Windows.Forms.RadioButton();
            this.x8bit = new System.Windows.Forms.RadioButton();
            this.x16bit = new System.Windows.Forms.RadioButton();
            this.x24bit = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Sawtooth = new System.Windows.Forms.RadioButton();
            this.Triangle = new System.Windows.Forms.RadioButton();
            this.Format = new System.Windows.Forms.GroupBox();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.Format.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 56);
            this.button2.TabIndex = 1;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 59);
            this.button3.TabIndex = 2;
            this.button3.Text = "Play Sample";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(365, 42);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(44, 20);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Duration";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(284, 42);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(64, 20);
            this.numericUpDown2.TabIndex = 6;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Frequency";
            // 
            // SineWaveType
            // 
            this.SineWaveType.AutoSize = true;
            this.SineWaveType.Location = new System.Drawing.Point(6, 13);
            this.SineWaveType.Name = "SineWaveType";
            this.SineWaveType.Size = new System.Drawing.Size(46, 17);
            this.SineWaveType.TabIndex = 11;
            this.SineWaveType.Text = "Sine";
            this.SineWaveType.UseVisualStyleBackColor = true;
            this.SineWaveType.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // SquareWaveType
            // 
            this.SquareWaveType.AutoSize = true;
            this.SquareWaveType.Location = new System.Drawing.Point(6, 36);
            this.SquareWaveType.Name = "SquareWaveType";
            this.SquareWaveType.Size = new System.Drawing.Size(59, 17);
            this.SquareWaveType.TabIndex = 12;
            this.SquareWaveType.Text = "Square";
            this.SquareWaveType.UseVisualStyleBackColor = true;
            this.SquareWaveType.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // x8bit
            // 
            this.x8bit.AutoSize = true;
            this.x8bit.Location = new System.Drawing.Point(6, 19);
            this.x8bit.Name = "x8bit";
            this.x8bit.Size = new System.Drawing.Size(45, 17);
            this.x8bit.TabIndex = 15;
            this.x8bit.Text = "8-bit";
            this.x8bit.UseVisualStyleBackColor = true;
            this.x8bit.CheckedChanged += new System.EventHandler(this.x8bit_CheckedChanged);
            // 
            // x16bit
            // 
            this.x16bit.AutoSize = true;
            this.x16bit.Location = new System.Drawing.Point(6, 42);
            this.x16bit.Name = "x16bit";
            this.x16bit.Size = new System.Drawing.Size(51, 17);
            this.x16bit.TabIndex = 16;
            this.x16bit.Text = "16-bit";
            this.x16bit.UseVisualStyleBackColor = true;
            this.x16bit.CheckedChanged += new System.EventHandler(this.x16bit_CheckedChanged);
            // 
            // x24bit
            // 
            this.x24bit.AutoSize = true;
            this.x24bit.Location = new System.Drawing.Point(6, 65);
            this.x24bit.Name = "x24bit";
            this.x24bit.Size = new System.Drawing.Size(51, 17);
            this.x24bit.TabIndex = 17;
            this.x24bit.Text = "24-bit";
            this.x24bit.UseVisualStyleBackColor = true;
            this.x24bit.CheckedChanged += new System.EventHandler(this.x24bit_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 108);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(71, 17);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.Text = "My Wave";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Sawtooth);
            this.groupBox1.Controls.Add(this.Triangle);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.SquareWaveType);
            this.groupBox1.Controls.Add(this.SineWaveType);
            this.groupBox1.Location = new System.Drawing.Point(270, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 144);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wave Type";
            // 
            // Sawtooth
            // 
            this.Sawtooth.AutoSize = true;
            this.Sawtooth.Location = new System.Drawing.Point(7, 83);
            this.Sawtooth.Name = "Sawtooth";
            this.Sawtooth.Size = new System.Drawing.Size(70, 17);
            this.Sawtooth.TabIndex = 15;
            this.Sawtooth.Text = "Sawtooth";
            this.Sawtooth.UseVisualStyleBackColor = true;
            this.Sawtooth.CheckedChanged += new System.EventHandler(this.Sawtooth_CheckedChanged);
            // 
            // Triangle
            // 
            this.Triangle.AutoSize = true;
            this.Triangle.Location = new System.Drawing.Point(6, 59);
            this.Triangle.Name = "Triangle";
            this.Triangle.Size = new System.Drawing.Size(63, 17);
            this.Triangle.TabIndex = 14;
            this.Triangle.Text = "Triangle";
            this.Triangle.UseVisualStyleBackColor = true;
            this.Triangle.CheckedChanged += new System.EventHandler(this.Triangle_CheckedChanged);
            // 
            // Format
            // 
            this.Format.Controls.Add(this.x24bit);
            this.Format.Controls.Add(this.x16bit);
            this.Format.Controls.Add(this.x8bit);
            this.Format.Location = new System.Drawing.Point(415, 80);
            this.Format.Name = "Format";
            this.Format.Size = new System.Drawing.Size(110, 100);
            this.Format.TabIndex = 20;
            this.Format.TabStop = false;
            this.Format.Text = "Format";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(433, 42);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(65, 20);
            this.numericUpDown3.TabIndex = 21;
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(433, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Volume";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(29, 230);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(759, 195);
            this.chart1.TabIndex = 23;
            this.chart1.Text = "chart1";

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.Format);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Format.ResumeLayout(false);
            this.Format.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton SineWaveType;
        private System.Windows.Forms.RadioButton SquareWaveType;
        private System.Windows.Forms.RadioButton x8bit;
        private System.Windows.Forms.RadioButton x16bit;
        private System.Windows.Forms.RadioButton x24bit;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox Format;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton Sawtooth;
        private System.Windows.Forms.RadioButton Triangle;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

