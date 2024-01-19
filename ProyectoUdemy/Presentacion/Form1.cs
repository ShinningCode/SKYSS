using Microsoft.Win32;
using ProyectoUdemy.Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoUdemy
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlMarcaAgua.Dock = DockStyle.Fill;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            ucRegistro registro = new ucRegistro();
            pnlFondo.Controls.Clear();
            registro.Dock = DockStyle.Fill;
            pnlFondo.Controls.Add(registro);
        }
    }
}
