namespace Paralelismo
{
    partial class CPU_Ventana
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CPU_Ventana));
            this.proVal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cpuUsageChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.core0 = new System.Windows.Forms.ProgressBar();
            this.core1 = new System.Windows.Forms.ProgressBar();
            this.core2 = new System.Windows.Forms.ProgressBar();
            this.lbl0 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.perfCount0 = new System.Diagnostics.PerformanceCounter();
            this.perfCount1 = new System.Diagnostics.PerformanceCounter();
            this.perfCount2 = new System.Diagnostics.PerformanceCounter();
            this.perfCount3 = new System.Diagnostics.PerformanceCounter();
            this.perfCount4 = new System.Diagnostics.PerformanceCounter();
            this.perfCount5 = new System.Diagnostics.PerformanceCounter();
            this.perfCount6 = new System.Diagnostics.PerformanceCounter();
            this.perfCount7 = new System.Diagnostics.PerformanceCounter();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.core5 = new System.Windows.Forms.ProgressBar();
            this.core4 = new System.Windows.Forms.ProgressBar();
            this.core3 = new System.Windows.Forms.ProgressBar();
            this.nucleo3 = new System.Windows.Forms.Label();
            this.nucleo2 = new System.Windows.Forms.Label();
            this.nucleo1 = new System.Windows.Forms.Label();
            this.nucleo6 = new System.Windows.Forms.Label();
            this.nucleo5 = new System.Windows.Forms.Label();
            this.nucleo4 = new System.Windows.Forms.Label();
            this.nucleo8 = new System.Windows.Forms.Label();
            this.nucleo7 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.core7 = new System.Windows.Forms.ProgressBar();
            this.core6 = new System.Windows.Forms.ProgressBar();
            this.cbEnable3D = new System.Windows.Forms.CheckBox();
            this.perfCount8 = new System.Diagnostics.PerformanceCounter();
            ((System.ComponentModel.ISupportInitialize)(this.cpuUsageChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfCount0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfCount1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfCount2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfCount3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfCount4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfCount5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfCount6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfCount7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfCount8)).BeginInit();
            this.SuspendLayout();
            // 
            // proVal
            // 
            this.proVal.AutoSize = true;
            this.proVal.BackColor = System.Drawing.Color.Transparent;
            this.proVal.Font = new System.Drawing.Font("Imprint MT Shadow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proVal.Location = new System.Drawing.Point(317, 400);
            this.proVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.proVal.Name = "proVal";
            this.proVal.Size = new System.Drawing.Size(56, 33);
            this.proVal.TabIndex = 4;
            this.proVal.Text = "0%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 400);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Uso total del CPU";
            // 
            // cpuUsageChart
            // 
            this.cpuUsageChart.BackColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisX2.TitleFont = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY.TitleFont = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY2.TitleFont = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.Name = "ChartArea1";
            this.cpuUsageChart.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.cpuUsageChart.Legends.Add(legend2);
            this.cpuUsageChart.Location = new System.Drawing.Point(-3, 50);
            this.cpuUsageChart.Name = "cpuUsageChart";
            this.cpuUsageChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.cpuUsageChart.Series.Add(series2);
            this.cpuUsageChart.Size = new System.Drawing.Size(768, 347);
            this.cpuUsageChart.TabIndex = 5;
            this.cpuUsageChart.Text = "cpuChart";
            title2.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Title1";
            this.cpuUsageChart.Titles.Add(title2);
            this.cpuUsageChart.Click += new System.EventHandler(this.cpuUsageChart_Click);
            // 
            // core0
            // 
            this.core0.Location = new System.Drawing.Point(885, 50);
            this.core0.Name = "core0";
            this.core0.Size = new System.Drawing.Size(209, 32);
            this.core0.TabIndex = 6;
            // 
            // core1
            // 
            this.core1.Location = new System.Drawing.Point(885, 88);
            this.core1.Name = "core1";
            this.core1.Size = new System.Drawing.Size(209, 32);
            this.core1.TabIndex = 7;
            // 
            // core2
            // 
            this.core2.Location = new System.Drawing.Point(885, 126);
            this.core2.Name = "core2";
            this.core2.Size = new System.Drawing.Size(209, 32);
            this.core2.TabIndex = 8;
            // 
            // lbl0
            // 
            this.lbl0.AutoSize = true;
            this.lbl0.BackColor = System.Drawing.Color.Transparent;
            this.lbl0.Font = new System.Drawing.Font("Imprint MT Shadow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0.Location = new System.Drawing.Point(1121, 49);
            this.lbl0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl0.Name = "lbl0";
            this.lbl0.Size = new System.Drawing.Size(56, 33);
            this.lbl0.TabIndex = 9;
            this.lbl0.Text = "0%";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Imprint MT Shadow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(1121, 88);
            this.lbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(56, 33);
            this.lbl1.TabIndex = 10;
            this.lbl1.Text = "0%";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.Transparent;
            this.lbl2.Font = new System.Drawing.Font("Imprint MT Shadow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(1121, 125);
            this.lbl2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(56, 33);
            this.lbl2.TabIndex = 11;
            this.lbl2.Text = "0%";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // perfCount0
            // 
            this.perfCount0.CategoryName = "Processor";
            this.perfCount0.CounterName = "% Processor Time";
            this.perfCount0.InstanceName = "0";
            // 
            // perfCount1
            // 
            this.perfCount1.CategoryName = "Processor";
            this.perfCount1.CounterName = "% Processor Time";
            this.perfCount1.InstanceName = "1";
            // 
            // perfCount2
            // 
            this.perfCount2.CategoryName = "Processor";
            this.perfCount2.CounterName = "% Processor Time";
            this.perfCount2.InstanceName = "2";
            // 
            // perfCount3
            // 
            this.perfCount3.CategoryName = "Processor";
            this.perfCount3.CounterName = "% Processor Time";
            this.perfCount3.InstanceName = "3";
            // 
            // perfCount4
            // 
            this.perfCount4.CategoryName = "Processor";
            this.perfCount4.CounterName = "% Processor Time";
            this.perfCount4.InstanceName = "4";
            // 
            // perfCount5
            // 
            this.perfCount5.CategoryName = "Processor";
            this.perfCount5.CounterName = "% Processor Time";
            this.perfCount5.InstanceName = "5";
            // 
            // perfCount6
            // 
            this.perfCount6.CategoryName = "Processor";
            this.perfCount6.CounterName = "% Processor Time";
            this.perfCount6.InstanceName = "6";
            // 
            // perfCount7
            // 
            this.perfCount7.CategoryName = "Processor";
            this.perfCount7.CounterName = "% Processor Time";
            this.perfCount7.InstanceName = "7";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.BackColor = System.Drawing.Color.Transparent;
            this.lbl5.Font = new System.Drawing.Font("Imprint MT Shadow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.Location = new System.Drawing.Point(1121, 239);
            this.lbl5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(56, 33);
            this.lbl5.TabIndex = 21;
            this.lbl5.Text = "0%";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.BackColor = System.Drawing.Color.Transparent;
            this.lbl4.Font = new System.Drawing.Font("Imprint MT Shadow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(1121, 202);
            this.lbl4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(56, 33);
            this.lbl4.TabIndex = 20;
            this.lbl4.Text = "0%";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.BackColor = System.Drawing.Color.Transparent;
            this.lbl3.Font = new System.Drawing.Font("Imprint MT Shadow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(1121, 163);
            this.lbl3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(56, 33);
            this.lbl3.TabIndex = 19;
            this.lbl3.Text = "0%";
            // 
            // core5
            // 
            this.core5.Location = new System.Drawing.Point(885, 240);
            this.core5.Name = "core5";
            this.core5.Size = new System.Drawing.Size(209, 32);
            this.core5.TabIndex = 18;
            // 
            // core4
            // 
            this.core4.Location = new System.Drawing.Point(885, 202);
            this.core4.Name = "core4";
            this.core4.Size = new System.Drawing.Size(209, 32);
            this.core4.TabIndex = 17;
            // 
            // core3
            // 
            this.core3.Location = new System.Drawing.Point(885, 164);
            this.core3.Name = "core3";
            this.core3.Size = new System.Drawing.Size(209, 32);
            this.core3.TabIndex = 16;
            // 
            // nucleo3
            // 
            this.nucleo3.AutoSize = true;
            this.nucleo3.BackColor = System.Drawing.Color.Transparent;
            this.nucleo3.Font = new System.Drawing.Font("Imprint MT Shadow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nucleo3.Location = new System.Drawing.Point(756, 126);
            this.nucleo3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nucleo3.Name = "nucleo3";
            this.nucleo3.Size = new System.Drawing.Size(122, 33);
            this.nucleo3.TabIndex = 24;
            this.nucleo3.Text = "Nucleo 3";
            // 
            // nucleo2
            // 
            this.nucleo2.AutoSize = true;
            this.nucleo2.BackColor = System.Drawing.Color.Transparent;
            this.nucleo2.Font = new System.Drawing.Font("Imprint MT Shadow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nucleo2.Location = new System.Drawing.Point(756, 88);
            this.nucleo2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nucleo2.Name = "nucleo2";
            this.nucleo2.Size = new System.Drawing.Size(122, 33);
            this.nucleo2.TabIndex = 23;
            this.nucleo2.Text = "Nucleo 2";
            // 
            // nucleo1
            // 
            this.nucleo1.AutoSize = true;
            this.nucleo1.BackColor = System.Drawing.Color.Transparent;
            this.nucleo1.Font = new System.Drawing.Font("Imprint MT Shadow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nucleo1.Location = new System.Drawing.Point(756, 50);
            this.nucleo1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nucleo1.Name = "nucleo1";
            this.nucleo1.Size = new System.Drawing.Size(120, 33);
            this.nucleo1.TabIndex = 22;
            this.nucleo1.Text = "Nucleo 1";
            // 
            // nucleo6
            // 
            this.nucleo6.AutoSize = true;
            this.nucleo6.BackColor = System.Drawing.Color.Transparent;
            this.nucleo6.Font = new System.Drawing.Font("Imprint MT Shadow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nucleo6.Location = new System.Drawing.Point(756, 239);
            this.nucleo6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nucleo6.Name = "nucleo6";
            this.nucleo6.Size = new System.Drawing.Size(122, 33);
            this.nucleo6.TabIndex = 27;
            this.nucleo6.Text = "Nucleo 6";
            // 
            // nucleo5
            // 
            this.nucleo5.AutoSize = true;
            this.nucleo5.BackColor = System.Drawing.Color.Transparent;
            this.nucleo5.Font = new System.Drawing.Font("Imprint MT Shadow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nucleo5.Location = new System.Drawing.Point(756, 201);
            this.nucleo5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nucleo5.Name = "nucleo5";
            this.nucleo5.Size = new System.Drawing.Size(122, 33);
            this.nucleo5.TabIndex = 26;
            this.nucleo5.Text = "Nucleo 5";
            // 
            // nucleo4
            // 
            this.nucleo4.AutoSize = true;
            this.nucleo4.BackColor = System.Drawing.Color.Transparent;
            this.nucleo4.Font = new System.Drawing.Font("Imprint MT Shadow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nucleo4.Location = new System.Drawing.Point(756, 164);
            this.nucleo4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nucleo4.Name = "nucleo4";
            this.nucleo4.Size = new System.Drawing.Size(122, 33);
            this.nucleo4.TabIndex = 25;
            this.nucleo4.Text = "Nucleo 4";
            // 
            // nucleo8
            // 
            this.nucleo8.AutoSize = true;
            this.nucleo8.BackColor = System.Drawing.Color.Transparent;
            this.nucleo8.Font = new System.Drawing.Font("Imprint MT Shadow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nucleo8.Location = new System.Drawing.Point(756, 315);
            this.nucleo8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nucleo8.Name = "nucleo8";
            this.nucleo8.Size = new System.Drawing.Size(122, 33);
            this.nucleo8.TabIndex = 33;
            this.nucleo8.Text = "Nucleo 8";
            // 
            // nucleo7
            // 
            this.nucleo7.AutoSize = true;
            this.nucleo7.BackColor = System.Drawing.Color.Transparent;
            this.nucleo7.Font = new System.Drawing.Font("Imprint MT Shadow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nucleo7.Location = new System.Drawing.Point(756, 277);
            this.nucleo7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nucleo7.Name = "nucleo7";
            this.nucleo7.Size = new System.Drawing.Size(122, 33);
            this.nucleo7.TabIndex = 32;
            this.nucleo7.Text = "Nucleo 7";
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.BackColor = System.Drawing.Color.Transparent;
            this.lbl7.Font = new System.Drawing.Font("Imprint MT Shadow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl7.Location = new System.Drawing.Point(1121, 315);
            this.lbl7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(56, 33);
            this.lbl7.TabIndex = 31;
            this.lbl7.Text = "0%";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.BackColor = System.Drawing.Color.Transparent;
            this.lbl6.Font = new System.Drawing.Font("Imprint MT Shadow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl6.Location = new System.Drawing.Point(1121, 278);
            this.lbl6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(56, 33);
            this.lbl6.TabIndex = 30;
            this.lbl6.Text = "0%";
            // 
            // core7
            // 
            this.core7.Location = new System.Drawing.Point(885, 316);
            this.core7.Name = "core7";
            this.core7.Size = new System.Drawing.Size(209, 32);
            this.core7.TabIndex = 29;
            // 
            // core6
            // 
            this.core6.Location = new System.Drawing.Point(885, 278);
            this.core6.Name = "core6";
            this.core6.Size = new System.Drawing.Size(209, 32);
            this.core6.TabIndex = 28;
            // 
            // cbEnable3D
            // 
            this.cbEnable3D.AutoSize = true;
            this.cbEnable3D.BackColor = System.Drawing.Color.Transparent;
            this.cbEnable3D.Font = new System.Drawing.Font("Imprint MT Shadow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEnable3D.Location = new System.Drawing.Point(12, 12);
            this.cbEnable3D.Name = "cbEnable3D";
            this.cbEnable3D.Size = new System.Drawing.Size(236, 37);
            this.cbEnable3D.TabIndex = 35;
            this.cbEnable3D.Text = "Activar vista 3D";
            this.cbEnable3D.UseVisualStyleBackColor = false;
            this.cbEnable3D.CheckedChanged += new System.EventHandler(this.cbEnable3D_CheckedChanged);
            // 
            // perfCount8
            // 
            this.perfCount8.CategoryName = "Processor";
            this.perfCount8.CounterName = "% Processor Time";
            this.perfCount8.InstanceName = "8";
            // 
            // CPU_Ventana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1206, 476);
            this.Controls.Add(this.cbEnable3D);
            this.Controls.Add(this.nucleo8);
            this.Controls.Add(this.nucleo7);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.core7);
            this.Controls.Add(this.core6);
            this.Controls.Add(this.nucleo6);
            this.Controls.Add(this.nucleo5);
            this.Controls.Add(this.nucleo4);
            this.Controls.Add(this.nucleo3);
            this.Controls.Add(this.nucleo2);
            this.Controls.Add(this.nucleo1);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.core5);
            this.Controls.Add(this.core4);
            this.Controls.Add(this.core3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lbl0);
            this.Controls.Add(this.core2);
            this.Controls.Add(this.core1);
            this.Controls.Add(this.core0);
            this.Controls.Add(this.cpuUsageChart);
            this.Controls.Add(this.proVal);
            this.Controls.Add(this.label1);
            this.Name = "CPU_Ventana";
            this.Text = "Monitoreo de CPU";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CPU_Ventana_FormClosed);
            this.Load += new System.EventHandler(this.CPU_Ventana_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cpuUsageChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfCount0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfCount1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfCount2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfCount3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfCount4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfCount5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfCount6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfCount7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfCount8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label proVal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart cpuUsageChart;
        private System.Windows.Forms.ProgressBar core0;
        private System.Windows.Forms.ProgressBar core1;
        private System.Windows.Forms.ProgressBar core2;
        private System.Windows.Forms.Label lbl0;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Timer timer1;
        private System.Diagnostics.PerformanceCounter perfCount0;
        private System.Diagnostics.PerformanceCounter perfCount1;
        private System.Diagnostics.PerformanceCounter perfCount2;
        private System.Diagnostics.PerformanceCounter perfCount3;
        private System.Diagnostics.PerformanceCounter perfCount4;
        private System.Diagnostics.PerformanceCounter perfCount5;
        private System.Diagnostics.PerformanceCounter perfCount6;
        private System.Diagnostics.PerformanceCounter perfCount7;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.ProgressBar core5;
        private System.Windows.Forms.ProgressBar core4;
        private System.Windows.Forms.ProgressBar core3;
        private System.Windows.Forms.Label nucleo3;
        private System.Windows.Forms.Label nucleo2;
        private System.Windows.Forms.Label nucleo1;
        private System.Windows.Forms.Label nucleo6;
        private System.Windows.Forms.Label nucleo5;
        private System.Windows.Forms.Label nucleo4;
        private System.Windows.Forms.Label nucleo8;
        private System.Windows.Forms.Label nucleo7;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.ProgressBar core7;
        private System.Windows.Forms.ProgressBar core6;
        private System.Windows.Forms.CheckBox cbEnable3D;
        private System.Diagnostics.PerformanceCounter perfCount8;
    }
}