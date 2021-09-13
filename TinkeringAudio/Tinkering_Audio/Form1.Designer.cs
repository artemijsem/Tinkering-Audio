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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.PlayButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Sawtooth = new System.Windows.Forms.RadioButton();
            this.Triangle = new System.Windows.Forms.RadioButton();
            this.Square = new System.Windows.Forms.RadioButton();
            this.Sin = new System.Windows.Forms.RadioButton();
            this.x8bit = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.x24bit = new System.Windows.Forms.RadioButton();
            this.x16bit = new System.Windows.Forms.RadioButton();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Echo_duration = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Attack_Level_Scroller = new System.Windows.Forms.NumericUpDown();
            this.Attack_Time_Scroller = new System.Windows.Forms.NumericUpDown();
            this.Decay_Time_Scroller = new System.Windows.Forms.NumericUpDown();
            this.Sustain_Level_Scroller = new System.Windows.Forms.NumericUpDown();
            this.Sustain_Time_Scroller = new System.Windows.Forms.NumericUpDown();
            this.Release_Time_Scroller = new System.Windows.Forms.NumericUpDown();
            this.Attack_Lvl = new System.Windows.Forms.Label();
            this.Attack_Time = new System.Windows.Forms.Label();
            this.Decay_Time = new System.Windows.Forms.Label();
            this.Susatin_Lvl = new System.Windows.Forms.Label();
            this.Sustain_Time = new System.Windows.Forms.Label();
            this.Release_Time = new System.Windows.Forms.Label();
            this.ADSROn = new System.Windows.Forms.CheckBox();
            this.Normalize_OnOff = new System.Windows.Forms.CheckBox();
            this.Echo_OnOff = new System.Windows.Forms.CheckBox();
            this.PhaseInversion = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Echo_duration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Attack_Level_Scroller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Attack_Time_Scroller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Decay_Time_Scroller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sustain_Level_Scroller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sustain_Time_Scroller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Release_Time_Scroller)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(386, 26);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(63, 20);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.Audio_Duration_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(260, 26);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(83, 20);
            this.numericUpDown2.TabIndex = 1;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.Frequecny_ValueChanged);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.DecimalPlaces = 2;
            this.numericUpDown3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown3.Location = new System.Drawing.Point(483, 26);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown3.TabIndex = 2;
            this.numericUpDown3.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.Volume_ValueChanged_1);
            // 
            // PlayButton
            // 
            this.PlayButton.Location = new System.Drawing.Point(24, 25);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(75, 48);
            this.PlayButton.TabIndex = 3;
            this.PlayButton.Text = "Play Sample";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 42);
            this.button2.TabIndex = 4;
            this.button2.Text = "Save Sample";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Sawtooth);
            this.groupBox1.Controls.Add(this.Triangle);
            this.groupBox1.Controls.Add(this.Square);
            this.groupBox1.Controls.Add(this.Sin);
            this.groupBox1.Location = new System.Drawing.Point(266, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 118);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "WaveType";
            // 
            // Sawtooth
            // 
            this.Sawtooth.AutoSize = true;
            this.Sawtooth.Location = new System.Drawing.Point(7, 89);
            this.Sawtooth.Name = "Sawtooth";
            this.Sawtooth.Size = new System.Drawing.Size(70, 17);
            this.Sawtooth.TabIndex = 3;
            this.Sawtooth.TabStop = true;
            this.Sawtooth.Text = "Sawtooth";
            this.Sawtooth.UseVisualStyleBackColor = true;
            this.Sawtooth.CheckedChanged += new System.EventHandler(this.Sawtooth_CheckedChanged_1);
            // 
            // Triangle
            // 
            this.Triangle.AutoSize = true;
            this.Triangle.Location = new System.Drawing.Point(7, 66);
            this.Triangle.Name = "Triangle";
            this.Triangle.Size = new System.Drawing.Size(63, 17);
            this.Triangle.TabIndex = 2;
            this.Triangle.TabStop = true;
            this.Triangle.Text = "Triangle";
            this.Triangle.UseVisualStyleBackColor = true;
            this.Triangle.CheckedChanged += new System.EventHandler(this.Triangle_CheckedChanged_1);
            // 
            // Square
            // 
            this.Square.AutoSize = true;
            this.Square.Location = new System.Drawing.Point(7, 43);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(59, 17);
            this.Square.TabIndex = 1;
            this.Square.TabStop = true;
            this.Square.Text = "Square";
            this.Square.UseVisualStyleBackColor = true;
            this.Square.CheckedChanged += new System.EventHandler(this.Square_CheckedChanged);
            // 
            // Sin
            // 
            this.Sin.AutoSize = true;
            this.Sin.Location = new System.Drawing.Point(7, 20);
            this.Sin.Name = "Sin";
            this.Sin.Size = new System.Drawing.Size(40, 17);
            this.Sin.TabIndex = 0;
            this.Sin.TabStop = true;
            this.Sin.Text = "Sin";
            this.Sin.UseVisualStyleBackColor = true;
            this.Sin.CheckedChanged += new System.EventHandler(this.Sin_CheckedChanged);
            // 
            // x8bit
            // 
            this.x8bit.AutoSize = true;
            this.x8bit.Location = new System.Drawing.Point(6, 20);
            this.x8bit.Name = "x8bit";
            this.x8bit.Size = new System.Drawing.Size(45, 17);
            this.x8bit.TabIndex = 4;
            this.x8bit.TabStop = true;
            this.x8bit.Text = "8-bit";
            this.x8bit.UseVisualStyleBackColor = true;
            this.x8bit.CheckedChanged += new System.EventHandler(this.x8bit_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.x24bit);
            this.groupBox2.Controls.Add(this.x16bit);
            this.groupBox2.Controls.Add(this.x8bit);
            this.groupBox2.Location = new System.Drawing.Point(517, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Format";
            // 
            // x24bit
            // 
            this.x24bit.AutoSize = true;
            this.x24bit.Location = new System.Drawing.Point(6, 66);
            this.x24bit.Name = "x24bit";
            this.x24bit.Size = new System.Drawing.Size(51, 17);
            this.x24bit.TabIndex = 6;
            this.x24bit.TabStop = true;
            this.x24bit.Text = "24-bit";
            this.x24bit.UseVisualStyleBackColor = true;
            this.x24bit.CheckedChanged += new System.EventHandler(this.x24bit_CheckedChanged);
            // 
            // x16bit
            // 
            this.x16bit.AutoSize = true;
            this.x16bit.Location = new System.Drawing.Point(6, 43);
            this.x16bit.Name = "x16bit";
            this.x16bit.Size = new System.Drawing.Size(51, 17);
            this.x16bit.TabIndex = 5;
            this.x16bit.TabStop = true;
            this.x16bit.Text = "16-bit";
            this.x16bit.UseVisualStyleBackColor = true;
            this.x16bit.CheckedChanged += new System.EventHandler(this.x16bit_CheckedChanged);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(24, 405);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(764, 141);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Frequency";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(393, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Duration";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(490, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Volume";
            // 
            // Echo_duration
            // 
            this.Echo_duration.Location = new System.Drawing.Point(575, 26);
            this.Echo_duration.Name = "Echo_duration";
            this.Echo_duration.Size = new System.Drawing.Size(82, 20);
            this.Echo_duration.TabIndex = 11;
            this.Echo_duration.ValueChanged += new System.EventHandler(this.Echo_duration_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(575, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Echo duration";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "ADSR Controller";
            // 
            // Attack_Level_Scroller
            // 
            this.Attack_Level_Scroller.DecimalPlaces = 2;
            this.Attack_Level_Scroller.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Attack_Level_Scroller.Location = new System.Drawing.Point(24, 299);
            this.Attack_Level_Scroller.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Attack_Level_Scroller.Name = "Attack_Level_Scroller";
            this.Attack_Level_Scroller.Size = new System.Drawing.Size(48, 20);
            this.Attack_Level_Scroller.TabIndex = 14;
            this.Attack_Level_Scroller.ValueChanged += new System.EventHandler(this.Attack_Level_Scroller_ValueChanged);
            // 
            // Attack_Time_Scroller
            // 
            this.Attack_Time_Scroller.DecimalPlaces = 2;
            this.Attack_Time_Scroller.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Attack_Time_Scroller.Location = new System.Drawing.Point(113, 299);
            this.Attack_Time_Scroller.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Attack_Time_Scroller.Name = "Attack_Time_Scroller";
            this.Attack_Time_Scroller.Size = new System.Drawing.Size(48, 20);
            this.Attack_Time_Scroller.TabIndex = 15;
            this.Attack_Time_Scroller.ValueChanged += new System.EventHandler(this.Attack_Time_Scroller_ValueChanged);
            // 
            // Decay_Time_Scroller
            // 
            this.Decay_Time_Scroller.DecimalPlaces = 2;
            this.Decay_Time_Scroller.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Decay_Time_Scroller.Location = new System.Drawing.Point(201, 299);
            this.Decay_Time_Scroller.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Decay_Time_Scroller.Name = "Decay_Time_Scroller";
            this.Decay_Time_Scroller.Size = new System.Drawing.Size(48, 20);
            this.Decay_Time_Scroller.TabIndex = 16;
            this.Decay_Time_Scroller.ValueChanged += new System.EventHandler(this.Decay_Time_Scroller_ValueChanged);
            // 
            // Sustain_Level_Scroller
            // 
            this.Sustain_Level_Scroller.DecimalPlaces = 2;
            this.Sustain_Level_Scroller.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Sustain_Level_Scroller.Location = new System.Drawing.Point(295, 299);
            this.Sustain_Level_Scroller.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Sustain_Level_Scroller.Name = "Sustain_Level_Scroller";
            this.Sustain_Level_Scroller.Size = new System.Drawing.Size(48, 20);
            this.Sustain_Level_Scroller.TabIndex = 17;
            this.Sustain_Level_Scroller.ValueChanged += new System.EventHandler(this.Sustain_Level_Scroller_ValueChanged);
            // 
            // Sustain_Time_Scroller
            // 
            this.Sustain_Time_Scroller.DecimalPlaces = 2;
            this.Sustain_Time_Scroller.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Sustain_Time_Scroller.Location = new System.Drawing.Point(386, 299);
            this.Sustain_Time_Scroller.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Sustain_Time_Scroller.Name = "Sustain_Time_Scroller";
            this.Sustain_Time_Scroller.Size = new System.Drawing.Size(48, 20);
            this.Sustain_Time_Scroller.TabIndex = 18;
            this.Sustain_Time_Scroller.ValueChanged += new System.EventHandler(this.Sustain_Time_Scroller_ValueChanged);
            // 
            // Release_Time_Scroller
            // 
            this.Release_Time_Scroller.DecimalPlaces = 2;
            this.Release_Time_Scroller.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Release_Time_Scroller.Location = new System.Drawing.Point(484, 299);
            this.Release_Time_Scroller.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Release_Time_Scroller.Name = "Release_Time_Scroller";
            this.Release_Time_Scroller.Size = new System.Drawing.Size(48, 20);
            this.Release_Time_Scroller.TabIndex = 19;
            this.Release_Time_Scroller.ValueChanged += new System.EventHandler(this.Release_Time_Scroller_ValueChanged);
            // 
            // Attack_Lvl
            // 
            this.Attack_Lvl.AutoSize = true;
            this.Attack_Lvl.Location = new System.Drawing.Point(24, 280);
            this.Attack_Lvl.Name = "Attack_Lvl";
            this.Attack_Lvl.Size = new System.Drawing.Size(67, 13);
            this.Attack_Lvl.TabIndex = 20;
            this.Attack_Lvl.Text = "Attack Level";
            // 
            // Attack_Time
            // 
            this.Attack_Time.AutoSize = true;
            this.Attack_Time.Location = new System.Drawing.Point(110, 280);
            this.Attack_Time.Name = "Attack_Time";
            this.Attack_Time.Size = new System.Drawing.Size(64, 13);
            this.Attack_Time.TabIndex = 21;
            this.Attack_Time.Text = "Attack Time";
            // 
            // Decay_Time
            // 
            this.Decay_Time.AutoSize = true;
            this.Decay_Time.Location = new System.Drawing.Point(198, 280);
            this.Decay_Time.Name = "Decay_Time";
            this.Decay_Time.Size = new System.Drawing.Size(64, 13);
            this.Decay_Time.TabIndex = 22;
            this.Decay_Time.Text = "Decay Time";
            // 
            // Susatin_Lvl
            // 
            this.Susatin_Lvl.AutoSize = true;
            this.Susatin_Lvl.Location = new System.Drawing.Point(283, 280);
            this.Susatin_Lvl.Name = "Susatin_Lvl";
            this.Susatin_Lvl.Size = new System.Drawing.Size(71, 13);
            this.Susatin_Lvl.TabIndex = 23;
            this.Susatin_Lvl.Text = "Sustain Level";
            // 
            // Sustain_Time
            // 
            this.Sustain_Time.AutoSize = true;
            this.Sustain_Time.Location = new System.Drawing.Point(379, 280);
            this.Sustain_Time.Name = "Sustain_Time";
            this.Sustain_Time.Size = new System.Drawing.Size(68, 13);
            this.Sustain_Time.TabIndex = 24;
            this.Sustain_Time.Text = "Sustain Time";
            // 
            // Release_Time
            // 
            this.Release_Time.AutoSize = true;
            this.Release_Time.Location = new System.Drawing.Point(468, 280);
            this.Release_Time.Name = "Release_Time";
            this.Release_Time.Size = new System.Drawing.Size(72, 13);
            this.Release_Time.TabIndex = 25;
            this.Release_Time.Text = "Release Time";
            // 
            // ADSROn
            // 
            this.ADSROn.AutoSize = true;
            this.ADSROn.Location = new System.Drawing.Point(155, 255);
            this.ADSROn.Name = "ADSROn";
            this.ADSROn.Size = new System.Drawing.Size(40, 17);
            this.ADSROn.TabIndex = 27;
            this.ADSROn.Text = "On";
            this.ADSROn.UseVisualStyleBackColor = true;
            // 
            // Normalize_OnOff
            // 
            this.Normalize_OnOff.AutoSize = true;
            this.Normalize_OnOff.Location = new System.Drawing.Point(681, 252);
            this.Normalize_OnOff.Name = "Normalize_OnOff";
            this.Normalize_OnOff.Size = new System.Drawing.Size(72, 17);
            this.Normalize_OnOff.TabIndex = 28;
            this.Normalize_OnOff.Text = "Normalize";
            this.Normalize_OnOff.UseVisualStyleBackColor = true;
            // 
            // Echo_OnOff
            // 
            this.Echo_OnOff.AutoSize = true;
            this.Echo_OnOff.Location = new System.Drawing.Point(590, 56);
            this.Echo_OnOff.Name = "Echo_OnOff";
            this.Echo_OnOff.Size = new System.Drawing.Size(40, 17);
            this.Echo_OnOff.TabIndex = 29;
            this.Echo_OnOff.Text = "On";
            this.Echo_OnOff.UseVisualStyleBackColor = true;
            // 
            // PhaseInversion
            // 
            this.PhaseInversion.AutoSize = true;
            this.PhaseInversion.Location = new System.Drawing.Point(681, 275);
            this.PhaseInversion.Name = "PhaseInversion";
            this.PhaseInversion.Size = new System.Drawing.Size(102, 17);
            this.PhaseInversion.TabIndex = 30;
            this.PhaseInversion.Text = "Phase Inversion";
            this.PhaseInversion.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 558);
            this.Controls.Add(this.PhaseInversion);
            this.Controls.Add(this.Echo_OnOff);
            this.Controls.Add(this.Normalize_OnOff);
            this.Controls.Add(this.ADSROn);
            this.Controls.Add(this.Release_Time);
            this.Controls.Add(this.Sustain_Time);
            this.Controls.Add(this.Susatin_Lvl);
            this.Controls.Add(this.Decay_Time);
            this.Controls.Add(this.Attack_Time);
            this.Controls.Add(this.Attack_Lvl);
            this.Controls.Add(this.Release_Time_Scroller);
            this.Controls.Add(this.Sustain_Time_Scroller);
            this.Controls.Add(this.Sustain_Level_Scroller);
            this.Controls.Add(this.Decay_Time_Scroller);
            this.Controls.Add(this.Attack_Time_Scroller);
            this.Controls.Add(this.Attack_Level_Scroller);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Echo_duration);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Echo_duration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Attack_Level_Scroller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Attack_Time_Scroller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Decay_Time_Scroller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sustain_Level_Scroller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sustain_Time_Scroller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Release_Time_Scroller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton x8bit;
        private System.Windows.Forms.RadioButton Sawtooth;
        private System.Windows.Forms.RadioButton Triangle;
        private System.Windows.Forms.RadioButton Square;
        private System.Windows.Forms.RadioButton Sin;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton x24bit;
        private System.Windows.Forms.RadioButton x16bit;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Echo_duration;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown Attack_Level_Scroller;
        private System.Windows.Forms.NumericUpDown Attack_Time_Scroller;
        private System.Windows.Forms.NumericUpDown Decay_Time_Scroller;
        private System.Windows.Forms.NumericUpDown Sustain_Level_Scroller;
        private System.Windows.Forms.NumericUpDown Sustain_Time_Scroller;
        private System.Windows.Forms.NumericUpDown Release_Time_Scroller;
        private System.Windows.Forms.Label Attack_Lvl;
        private System.Windows.Forms.Label Attack_Time;
        private System.Windows.Forms.Label Decay_Time;
        private System.Windows.Forms.Label Susatin_Lvl;
        private System.Windows.Forms.Label Sustain_Time;
        private System.Windows.Forms.Label Release_Time;
        private System.Windows.Forms.CheckBox ADSROn;
        private System.Windows.Forms.CheckBox Normalize_OnOff;
        private System.Windows.Forms.CheckBox Echo_OnOff;
        private System.Windows.Forms.CheckBox PhaseInversion;
    }
}

