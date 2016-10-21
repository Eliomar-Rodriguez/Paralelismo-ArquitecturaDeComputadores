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
        }
    }
}
