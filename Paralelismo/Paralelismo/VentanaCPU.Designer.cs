namespace Paralelismo
{
    partial class VentanaCPU
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
            this.cpuUsageChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.proVal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cpuUsageChart)).BeginInit();
            this.SuspendLayout();
            // 
            // cpuUsageChart
            // 
            this.cpuUsageChart.BorderlineColor = System.Drawing.Color.YellowGreen;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX2.TitleFont = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY2.TitleFont = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.Name = "ChartArea1";
            this.cpuUsageChart.ChartAreas.Add(chartArea1);
            legend1.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.cpuUsageChart.Legends.Add(legend1);
            this.cpuUsageChart.Location = new System.Drawing.Point(3, 42);
            this.cpuUsageChart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cpuUsageChart.Name = "cpuUsageChart";
            this.cpuUsageChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.cpuUsageChart.Series.Add(series1);
            this.cpuUsageChart.Size = new System.Drawing.Size(1101, 391);
            this.cpuUsageChart.TabIndex = 0;
            this.cpuUsageChart.Text = "cpuChart";
            this.cpuUsageChart.Click += new System.EventHandler(this.cpuUsageChart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 472);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Uso de CPU";
            // 
            // proVal
            // 
            this.proVal.AutoSize = true;
            this.proVal.Font = new System.Drawing.Font("Imprint MT Shadow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proVal.Location = new System.Drawing.Point(414, 472);
            this.proVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.proVal.Name = "proVal";
            this.proVal.Size = new System.Drawing.Size(56, 33);
            this.proVal.TabIndex = 2;
            this.proVal.Text = "0%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 557);
            this.Controls.Add(this.proVal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cpuUsageChart);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "CPU usage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cpuUsageChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart cpuUsageChart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label proVal;
    }
}

