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
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOps.SelectedIndex == 0)
            {
                panel0.Visible = true;
                //panel0.Enabled = true;
            }
            else if (cmbOps.SelectedIndex == 1)
            {
                panel1.Visible = true;
                //panel1.Enabled = true;
            }
            else if (cmbOps.SelectedIndex == 2)
            {
                panel2.Visible = true;
                //panel2.Enabled = true;
            }
        }

        private void panel0_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel0.Visible = false;
            panel1.Visible = false;
            panel2.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
