using System;
using System.Threading;
using System.Windows.Forms;
using Paralelismo.Utilities;
using System.Windows.Forms.DataVisualization.Charting;
using System.Diagnostics;

namespace Paralelismo
{
    public partial class CPU_Ventana : Form
    {
        bool iscontinue = true;
        /// <summary>
		/// Variable que almacena la cantidad de nucleos
		/// </summary>
        public static int cantNucleos;
        private static CpuUsage cpu;



        public CPU_Ventana()
        {
            InitializeComponent();            
        }

        private void CPU_Ventana_Load(object sender, EventArgs e)
        {
            lbl0.Visible = false;
            core0.Visible = false;
            nucleo1.Visible = false;

            lbl1.Visible = false;
            core1.Visible = false;
            nucleo2.Visible = false;

            lbl2.Visible = false;
            core2.Visible = false;
            nucleo3.Visible = false;

            lbl3.Visible = false;
            core3.Visible = false;
            nucleo4.Visible = false;

            lbl5.Visible = false;
            core5.Visible = false;
            nucleo6.Visible = false;

            lbl6.Visible = false;
            core6.Visible = false;
            nucleo7.Visible = false;

            lbl7.Visible = false;
            core7.Visible = false;
            nucleo8.Visible = false;

            //RegistryKey rk = Registry.LocalMachine;
            //String[] subKeys = rk.OpenSubKey("HARDWARE").OpenSubKey("DESCRIPTION").OpenSubKey("System").OpenSubKey("CentralProcessor").GetSubKeyNames();
            //txtCantNuc.Text = subKeys.Length.ToString();
            cantNucleos = Environment.ProcessorCount;  // obtengo la cantidad de nucleos
            timer1.Start();
            
            
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
            mostrar();
            populateCPUInfo();
        }
        public void mostrar()
        {
            if (cantNucleos == 2)
            {
                lbl0.Visible = true;
                core0.Visible = true;
                nucleo1.Visible = true;

                lbl1.Visible = true;
                core1.Visible = true;
                nucleo2.Visible = true;
            }
            else if (cantNucleos == 4)
            {
                lbl0.Visible = true;
                core0.Visible = true;
                nucleo1.Visible = true;

                lbl1.Visible = true;
                core1.Visible = true;
                nucleo2.Visible = true;

                lbl2.Visible = true;
                core2.Visible = true;
                nucleo3.Visible = true;

                lbl3.Visible = true;
                core3.Visible = true;
                nucleo4.Visible = true;
            }
            else if (cantNucleos == 6)
            {
                lbl0.Visible = true;
                core0.Visible = true;
                nucleo1.Visible = true;

                lbl1.Visible = true;
                core1.Visible = true;
                nucleo2.Visible = true;

                lbl2.Visible = true;
                core2.Visible = true;
                nucleo3.Visible = true;

                lbl3.Visible = true;
                core3.Visible = true;
                nucleo4.Visible = true;

                lbl4.Visible = true;
                core4.Visible = true;
                nucleo5.Visible = true;

                lbl5.Visible = true;
                core5.Visible = true;
                nucleo6.Visible = true;
            }
            else if (cantNucleos==8)
            {
                lbl0.Visible = true;
                core0.Visible = true;
                nucleo1.Visible = true;

                lbl1.Visible = true;
                core1.Visible = true;
                nucleo2.Visible = true;

                lbl2.Visible = true;
                core2.Visible = true;
                nucleo3.Visible = true;

                lbl3.Visible = true;
                core3.Visible = true;
                nucleo4.Visible = true;

                lbl4.Visible = true;
                core4.Visible = true;
                nucleo5.Visible = true;

                lbl5.Visible = true;
                core5.Visible = true;
                nucleo6.Visible = true;

                lbl6.Visible = true;
                core6.Visible = true;
                nucleo7.Visible = true;

                lbl7.Visible = true;
                core7.Visible = true;
                nucleo8.Visible = true;
            }

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cantNucleos == 2)
            {
                core0.Value = (int)(perfCount0.NextValue());
                lbl0.Text = core0.Value.ToString() + "%";

                core1.Value = (int)(perfCount1.NextValue());
                lbl1.Text = core1.Value.ToString() + "%";
            }
            else if (cantNucleos == 4)
            {
                core0.Value = (int)(perfCount0.NextValue());
                lbl0.Text = core0.Value.ToString() + "%";

                core1.Value = (int)(perfCount1.NextValue());
                lbl1.Text = core1.Value.ToString() + "%";

                core2.Value = (int)(perfCount2.NextValue());
                lbl2.Text = core2.Value.ToString() + "%";

                core3.Value = (int)(perfCount3.NextValue());
                lbl3.Text = core3.Value.ToString() + "%";
            }
            else if (cantNucleos == 6)
            {
                core0.Value = (int)(perfCount0.NextValue());
                lbl0.Text = core0.Value.ToString() + "%";

                core1.Value = (int)(perfCount1.NextValue());
                lbl1.Text = core1.Value.ToString() + "%";

                core2.Value = (int)(perfCount2.NextValue());
                lbl2.Text = core2.Value.ToString() + "%";

                core3.Value = (int)(perfCount3.NextValue());
                lbl3.Text = core3.Value.ToString() + "%";

                core4.Value = (int)(perfCount4.NextValue());
                lbl4.Text = core4.Value.ToString() + "%";

                core5.Value = (int)(perfCount5.NextValue());
                lbl5.Text = core5.Value.ToString() + "%";
            }
            else if (cantNucleos == 8)
            {
                core0.Value = (int)(perfCount0.NextValue());
                lbl0.Text = core0.Value.ToString() + "% ";

                core1.Value = (int)(perfCount1.NextValue());
                lbl1.Text = core1.Value.ToString() + "%";

                core2.Value = (int)(perfCount2.NextValue());
                lbl2.Text = core2.Value.ToString() + "%";

                core3.Value = (int)(perfCount3.NextValue());
                lbl3.Text = core3.Value.ToString() + "%";

                core4.Value = (int)(perfCount4.NextValue());
                lbl4.Text = core4.Value.ToString() + "%";

                core5.Value = (int)(perfCount5.NextValue());
                lbl5.Text = core5.Value.ToString() + "%";

                core6.Value = (int)(perfCount6.NextValue());
                lbl6.Text = core6.Value.ToString() + "%";

                core7.Value = (int)(perfCount7.NextValue());
                lbl7.Text = core7.Value.ToString() + "%";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PerformanceCounter cpuCounter = new PerformanceCounter();
            cpuCounter.CategoryName = "Processor";
            cpuCounter.CounterName = "% Processor Time";
            cpuCounter.InstanceName = "0";

            PerformanceCounter cpuCounter1 = new PerformanceCounter();
            cpuCounter1.CategoryName = "Processor";
            cpuCounter1.CounterName = "% Processor Time";
            cpuCounter1.InstanceName = "1";

            PerformanceCounter cpuCounter2 = new PerformanceCounter();
            cpuCounter2.CategoryName = "Processor";
            cpuCounter2.CounterName = "% Processor Time";
            cpuCounter2.InstanceName = "2";

            PerformanceCounter cpuCounter3 = new PerformanceCounter();
            cpuCounter3.CategoryName = "Processor";
            cpuCounter3.CounterName = "% Processor Time";
            cpuCounter3.InstanceName = "3";

            while (true)
            {            //Console.Clear();
                lbl0.Text = cpuCounter.NextValue().ToString() + "%";
                //Console.WriteLine("Nucleo 0: " + cpuCounter.NextValue() + "%");
                Console.WriteLine(cpuCounter1.NextValue() + "%");
                Console.WriteLine("Nucleo 2: " + cpuCounter2.NextValue() + "%");
                Console.WriteLine("Nucleo 3: " + cpuCounter3.NextValue() + "%");
                Thread.Sleep(1000);
            }
            
        }

        private void cbEnable3D_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEnable3D.Checked)
            {
                cpuUsageChart.ChartAreas[0].Area3DStyle.Enable3D = true;
            }
            else
            {
                cpuUsageChart.ChartAreas[0].Area3DStyle.Enable3D = false;
            }
        }
    }
}
