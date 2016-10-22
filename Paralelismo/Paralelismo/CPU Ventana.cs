using System;
using System.Threading;
using System.Windows.Forms;
using Paralelismo.Utilities;
using System.Windows.Forms.DataVisualization.Charting;

namespace Paralelismo
{
    public partial class CPU_Ventana : Form
    {
        bool iscontinue = true;
        private static CpuUsage cpu;
        public CPU_Ventana()
        {
            InitializeComponent();            
        }

        private void CPU_Ventana_Load(object sender, EventArgs e)
        {
            //Chart Settings 

            // Populating the data arrays.
            this.cpuUsageChart.Series.Clear();
            this.cpuUsageChart.Palette = ChartColorPalette.SeaGreen;

            // Set chart title.
            this.cpuUsageChart.Titles.Add("Uso de CPU");

            // Add chart series
            Series series = this.cpuUsageChart.Series.Add("Uso de CPU");
            cpuUsageChart.Series[0].ChartType = SeriesChartType.Area; // Area

            // Add Initial Point as Zero.
            series.Points.Add(0);

            //Populating X Y Axis  Information 
            cpuUsageChart.Series[0].YAxisType = AxisType.Primary;
            cpuUsageChart.Series[0].YValueType = ChartValueType.Int32;
            cpuUsageChart.Series[0].IsXValueIndexed = false;

            cpuUsageChart.ResetAutoValues();
            cpuUsageChart.ChartAreas[0].AxisY.Maximum = 100;//Max Y 
            cpuUsageChart.ChartAreas[0].AxisY.Minimum = 0;
            cpuUsageChart.ChartAreas[0].AxisX.Enabled = AxisEnabled.False;
            cpuUsageChart.ChartAreas[0].AxisY.Title = "Uso de CPU %";
            cpuUsageChart.ChartAreas[0].AxisY.IntervalAutoMode = IntervalAutoMode.VariableCount;

            populateCPUInfo();
        }
        private void populateCPUInfo()
        {
            try
            {
                // Crea y devuelve una instancia de uso de la CPU que se pueden utilizar para consultar el tiempo de CPU en este sistema operativo.
                cpu = CpuUsage.Create();

                /// creando un nuevo hilo
                Thread thread = new Thread(new ThreadStart(delegate ()
                {
                    try
                    {
                        while (iscontinue)
                        {
                            //Para actualizar la interfaz de usuario hay que invocarlo
                            this.Invoke(new System.Windows.Forms.MethodInvoker(delegate ()
                            {
                                int process = cpu.Query(); //Determina la carga de la CPU 
                                proVal.Text = process.ToString() + "%";
                                cpuUsageChart.Series[0].Points.AddY(process);//Agrega proceso al chart 

                                if (cpuUsageChart.Series[0].Points.Count > 40)//limpiar los datos viejos despues de esperar el hilo  * 40
                                    cpuUsageChart.Series[0].Points.RemoveAt(0);

                            }));

                            Thread.Sleep(400);//parar el hilo por 450 millisegundos
                        }
                    }
                    catch (Exception ex)
                    {

                    }

                }));

                thread.Priority = ThreadPriority.Highest;
                thread.IsBackground = true;
                thread.Start();//iniciar el hijo
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private void CPU_Ventana_FormClosed(object sender, FormClosedEventArgs e)
        {
            iscontinue = false;
        }

        private void cpuUsageChart_Click(object sender, EventArgs e)
        {

        }
    }
}
