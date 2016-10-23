using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paralelismo
{
    public partial class Form1 : Form
    {
        public static System.IO.StreamReader perfiles = null, compras = null, clientes = null;
        public static string direccionPer, direccionComp, direccionClie;
        public static bool chorizo = false;

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
            ToolTip toolType = new ToolTip();
            toolType.AutoPopDelay = 5000;
            toolType.InitialDelay = 1000;
            toolType.ReshowDelay = 500;
            toolType.ShowAlways = true;
            toolType.SetToolTip(this.btnClientes, "Cargar Archivo Clientes");
            toolType.SetToolTip(this.btnCompras, "Cargar Archivo Compras");
            toolType.SetToolTip(this.btnPerfiles, "Cargar Archivo Perfiles");

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

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void btnCPU_Click(object sender, EventArgs e)
        {
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

