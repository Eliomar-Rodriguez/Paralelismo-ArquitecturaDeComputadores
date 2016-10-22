using Microsoft.Win32;
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
    public partial class Rendimiento : Form
    {
        public Rendimiento()
        {
            InitializeComponent();
        }

        private void Rendimiento_Load(object sender, EventArgs e)
        {
            RegistryKey rk = Registry.LocalMachine;
            String[] subKeys = rk.OpenSubKey("HARDWARE").OpenSubKey("DESCRIPTION").OpenSubKey("System").OpenSubKey("CentralProcessor").GetSubKeyNames();

            txtCantNuc.Text = subKeys.Length.ToString();

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = (int) performanceCounter1.NextValue();
            progressBar2.Value = (int)performanceCounter2.NextValue();
            label6.Text = progressBar1.Value.ToString()+"%";
            label5.Text = progressBar2.Value.ToString() + "%";
        }
    }
}
