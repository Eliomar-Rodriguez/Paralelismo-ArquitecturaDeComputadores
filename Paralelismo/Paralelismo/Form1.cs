using Paralelismo.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Paralelismo
{
    public partial class Form1 : Form
    {
        public static System.IO.StreamReader perfiles = null, compras = null, clientes = null;
        public static string direccionPer, direccionComp, direccionClie;
        public static bool chorizo = false;
        public static int cantNucleos;
        private static CpuUsage cpu;
        bool iscontinue = true;

        public Form1()
        {
            
            InitializeComponent();
            AvisoTiempoPrimer.Visible = false;
            TiempoPrimero.Visible = false;
            label19.Visible = false;
            label18.Visible = false;
            AvisoTiempo.Visible = false;
            Tiempo.Visible = false;
            txtChoriso.Visible = false;
            txtNormal.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOps.SelectedIndex == 0)
            {
                panel0.Visible = true;
                panel0.Enabled = true;
                panel1.Visible = false;
                panel2.Visible = false;
            }
            else if (cmbOps.SelectedIndex == 1)
            {
                panel1.Visible = true;
                panel0.Visible = false;
               
                panel2.Visible = false;
                //panel1.Enabled = true;
            }
            else if (cmbOps.SelectedIndex == 2)
            {
                panel0.Visible = false;
                panel1.Visible = false;
               
                panel2.Visible = true;

                //panel2.Enabled = true;
            }
        }

        private void panel0_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel3.Visible = false;
            label24.Visible = false;
            ToolTip toolType = new ToolTip();
            toolType.AutoPopDelay = 5000;
            toolType.InitialDelay = 1000;
            toolType.ReshowDelay = 500;
            toolType.ShowAlways = true;
            toolType.SetToolTip(this.btnClientes, "Cargar Archivo Clientes");
            toolType.SetToolTip(this.btnCompras, "Cargar Archivo Compras");
            toolType.SetToolTip(this.btnPerfiles, "Cargar Archivo Perfiles");

            toolType.SetToolTip(this.button1, "Ver uso del CPU en esta ventana");
            toolType.SetToolTip(this.button2, "Ocultar uso de CPU");
            toolType.SetToolTip(this.btnCPU, "Ver uso del CPU en una ventana externa");

            label9.Visible = false;
            panelMostrar.Visible = false;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ventana = new OpenFileDialog();
            ventana.Title = "Seleccionar el archivo de compras";
            if (ventana.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                System.IO.StreamReader ArchivoCompras = new System.IO.StreamReader(ventana.FileName);
                //MessageBox.Show(sr.ReadToEnd());
                lblCompras.Text = ventana.FileName;
                direccionComp = ventana.FileName;
                compras = ArchivoCompras;
                //comprasTemp = ArchivoCompras;
                //System.Console.WriteLine(ventana.FileName);
                //ArchivoCompras.Close();
            }
        }

        private void btnPerfiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog ventana = new OpenFileDialog();
            ventana.Title = "Seleccionar el archivo de perfiles";
            if (ventana.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader archivoPerfiles = new System.IO.StreamReader(ventana.FileName);
                lblPerfiles.Text = ventana.FileName;
                direccionPer = ventana.FileName;
                perfiles = archivoPerfiles;
                //perfilesTemp = archivoPerfiles;
                //archivoPerfiles.Close();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Text = "Ventana Principal";
            if (lblClientes.Text=="Direccion"||lblCompras.Text=="Direccion"||lblPerfiles.Text=="Direccion")
            {
                label9.Visible = true;
            }
            else
            {
                panel4.Visible = false;
                panelMostrar.Visible = true;
                cmbOps.Visible = true;
                panel0.Visible = false;
                panel1.Visible = false;
                panel2.Visible = false;
            }
            
            
            //panel4.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Text = "Carga de Archivos";
            panelMostrar.Visible = false;
            panel4.Visible = true;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtBuscar_Click(object sender, EventArgs e)
        {
            compras = new System.IO.StreamReader(direccionComp);
            clientes = new System.IO.StreamReader(direccionClie);
            perfiles = new System.IO.StreamReader(direccionPer);
            if (paraleloCompra.Checked)
            {
                Paralelo.inicio = dateTimePicker1.Value.Date;
                Paralelo.final = fechFinal.Value.Date;
                Parallel.Invoke(() => Paralelo.Buscar1());
                AvisoTiempoPrimer.Visible = true;
                TiempoPrimero.Text = Paralelo.tiempoTot;
                TiempoPrimero.Visible = true;
                txtNombre.Text = Paralelo.cliente;
                txtNombre.Visible = true;
                txtCedula.Text = Paralelo.ced;
                txtCedula.Visible = true;
                txtMonto.Text = Paralelo.mayorC.ToString();
                txtMonto.Visible = true;
            }
            else
            {
                Prueba.inicio = dateTimePicker1.Value.Date;
                Prueba.final = fechFinal.Value.Date;
                Prueba.Buscar1();
                AvisoTiempoPrimer.Visible = true;
                TiempoPrimero.Text = Prueba.tiempoTot;
                TiempoPrimero.Visible = true;
                txtNombre.Text = Prueba.cliente;
                txtNombre.Visible = true;
                txtCedula.Text = Prueba.ced;
                txtCedula.Visible = true;
                txtMonto.Text = Prueba.mayorC.ToString();
                txtMonto.Visible = true;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void AnadirCed_Click(object sender, EventArgs e)
        {
            if (CedulaGrupal.Text != "")
            {
                Prueba.cedulas[Prueba.ind] = CedulaGrupal.Text;
                Prueba.comprasTot[Prueba.ind] = 0;
                Prueba.ind++;
                Paralelo.cedulas[Paralelo.ind] = CedulaGrupal.Text;
                Paralelo.comprasTot[Paralelo.ind] = 0;
                Paralelo.ind++;
                CedulaGrupal.Text = "";
            }
            else
                System.Console.WriteLine("Debe ingresar una cedula.");
        }

        private void BuscarGrup_Click(object sender, EventArgs e)
        {
            if (((Prueba.cedulas[0] != "") && (Paralelo.cedulas[0] != "")) && ((paraleloLista.Checked) || (secuencialLista.Checked)))
            {
                
                compras = new System.IO.StreamReader(direccionComp);
                clientes = new System.IO.StreamReader(direccionClie);
                perfiles = new System.IO.StreamReader(direccionPer);
                if (paraleloLista.Checked)
                {
                    Paralelo.inicio = Calendario1.Value.Date;
                    Paralelo.final = Calendario2.Value.Date;
                    Parallel.Invoke(() => Paralelo.BuscarCompras());
                    label19.Visible = true;
                    label18.Text = Paralelo.tiempoTot;
                    label18.Visible = true;
                    for (int v = 0; v < Paralelo.cedulas.Length; v++)
                    {
                        TablaDatos.Rows.Insert(v, Paralelo.cedulas[v], Paralelo.nombres[v], Paralelo.comprasTot[v]);
                    }
                }
                else
                {
                    Prueba.inicio = Calendario1.Value.Date;
                    Prueba.final = Calendario2.Value.Date;
                    Prueba.BuscarCompras();
                    label19.Visible = true;
                    label18.Text = Prueba.tiempoTot;
                    label18.Visible = true;
                    for (int v = 0; v < Prueba.cedulas.Length; v++)
                    {
                        TablaDatos.Rows.Insert(v, Prueba.cedulas[v], Prueba.nombres[v], Prueba.comprasTot[v]);
                    }
                }
            }
            else
                System.Console.WriteLine("Debe ingresar una cedula y/o activar alguna opcion de tipo de búsqueda.");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if ((txtID.Text != "") && ((paraleloMayor.Checked) || (secuencialMayor.Checked)))
            {
                txtChoriso.Visible = false;
                txtNormal.Visible = false;
                Prueba.ced = txtID.Text;
                compras = new System.IO.StreamReader(direccionComp);
                clientes = new System.IO.StreamReader(direccionClie);
                perfiles = new System.IO.StreamReader(direccionPer);
                if (paraleloMayor.Checked)
                {
                    Paralelo.BuscarSospechosos();
                    AvisoTiempo.Visible = true;
                    Tiempo.Text = Paralelo.tiempoTot;
                    Tiempo.Visible = true;
                    txtName.Text = Paralelo.cliente;
                    txtName.Visible = true;
                    txtID.Text = Paralelo.ced;
                    txtID.Visible = true;
                    txtLimite.Text = Paralelo.limitBreak.ToString();
                    txtLimite.Visible = true;
                    txtCompra.Text = Paralelo.mayorC.ToString();
                    txtCompra.Visible = true;
                    if (chorizo == true)
                        txtChoriso.Visible = true;
                    else
                        txtNormal.Visible = true;
                    txtID.Text = "";
                }
                else
                {
                    Prueba.BuscarSospechosos();
                    AvisoTiempo.Visible = true;
                    Tiempo.Text = Prueba.tiempoTot;
                    Tiempo.Visible = true;
                    txtName.Text = Prueba.cliente;
                    txtName.Visible = true;
                    txtID.Text = Prueba.ced;
                    txtID.Visible = true;
                    txtLimite.Text = Prueba.limitBreak.ToString();
                    txtLimite.Visible = true;
                    txtCompra.Text = Prueba.mayorC.ToString();
                    txtCompra.Visible = true;
                    if (chorizo == true)
                        txtChoriso.Visible = true;
                    else
                        txtNormal.Visible = true;
                    txtID.Text = "";
                }
            }
            else
                label24.Visible = true;
                System.Console.WriteLine("Debe ingresar una cedula y/o activar alguna opcion de tipo de búsqueda.");
        }

        private void fechFinal_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void lblClientes_Click(object sender, EventArgs e)
        {

        }

        private void lblCompras_Click(object sender, EventArgs e)
        {

        }

        private void lblPerfiles_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void paraleloLista_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void paraleloMayor_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            panel3.Visible = true;
            button1.Enabled = true;

            //load
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

            lbl4.Visible = false;
            core4.Visible = false;
            nucleo5.Visible = false;

            lbl5.Visible = false;
            core5.Visible = false;
            nucleo6.Visible = false;

            lbl6.Visible = false;
            core6.Visible = false;
            nucleo7.Visible = false;

            lbl7.Visible = false;
            core7.Visible = false;
            nucleo8.Visible = false;

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

        private void button2_Click_1(object sender, EventArgs e)
        {
            button1.Enabled = true;
            panel3.Visible = false;
            
        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {
            
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
            else if (cantNucleos == 8)
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

        private void cpuUsageChart_Click(object sender, EventArgs e)
        {

        }

        private void panel3_VisibleChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            iscontinue = false;
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

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void btnCPU_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            //Rendimiento rend = new Rendimiento();
            //rend.Show();
            CPU_Ventana rendi = new CPU_Ventana();
            rendi.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            cmbOps.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ventana = new OpenFileDialog();
            ventana.Title = "Seleccionar el archivo de clientes";
            if (ventana.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader ArchivoClientes = new System.IO.StreamReader(ventana.FileName);
                //MessageBox.Show(sr.ReadToEnd());
                lblClientes.Text = ventana.FileName;
                direccionClie = ventana.FileName;
                clientes = ArchivoClientes;
                //clientesTemp = ArchivoClientes;
                //System.Console.WriteLine(ventana.FileName);
                //ArchivoClientes.Close();
            }

        }

    }
}

