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
        string direccionPer, direccionComp, direccionClie;

        public Form1()
        {
            InitializeComponent();
            AvisoTiempoPrimer.Visible = false;
            TiempoPrimero.Visible = false;
            label19.Visible = false;
            label18.Visible = false;
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
            Prueba.inicio = dateTimePicker1.Value.Date;
            Prueba.final = fechFinal.Value.Date;
            compras = new System.IO.StreamReader(direccionComp);
            clientes = new System.IO.StreamReader(direccionClie);
            perfiles = new System.IO.StreamReader(direccionPer);
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
            if (CedulaGrupal.Text != null)
            {
                Prueba.cedulas[Prueba.ind] = CedulaGrupal.Text;
                Prueba.comprasTot[Prueba.ind] = 0;
                Prueba.ind++;
            }
        }

        private void BuscarGrup_Click(object sender, EventArgs e)
        {
            Prueba.inicio = Calendario1.Value.Date;
            Prueba.final = Calendario2.Value.Date;
            compras = new System.IO.StreamReader(direccionComp);
            clientes = new System.IO.StreamReader(direccionClie);
            perfiles = new System.IO.StreamReader(direccionPer);
            Prueba.BuscarCompras();
            label19.Visible = true;
            label18.Text = Prueba.tiempoTot;
            label18.Visible = true;
            int cont = 0;
            for (int v = 0; v < Prueba.cedulas.Length; v++)
            {
                TablaDatos.Rows.Insert(cont, Prueba.cedulas[v], Prueba.cliente, Prueba.comprasTot[v]);
                /*TablaDatos.Rows[v].Cells[0].Value = Prueba.cedulas[v];
                TablaDatos.Rows[v].Cells[1].Value = Prueba.cliente;
                TablaDatos.Rows[v].Cells[2].Value = Prueba.comprasTot[v];*/
                cont++;
            }

            /*
                        //TablaDatos.Rows(1).Cells(1).Text = Prueba.cliente;
                        txtNombre.Visible = true;
                        txtCedula.Text = Prueba.ced;
                        txtCedula.Visible = true;
                        txtMonto.Text = Prueba.mayorC.ToString();
                        txtMonto.Visible = true;*/
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

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void btnCPU_Click(object sender, EventArgs e)
        {
            Rendimiento rend = new Rendimiento();
            rend.Show();
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

