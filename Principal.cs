using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HolaMundo
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void jueguitoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void cajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registradora objR = new Registradora();
            objR.MdiParent = this;
            objR.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
