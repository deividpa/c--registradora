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
    public partial class Registradora : Form
    {
        public Registradora()
        {
            InitializeComponent();
        }

        private void gbLogin_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("Debe de ingresar el usuario.");
            } else
            {
                if (string.IsNullOrEmpty(txtContra.Text))
                {
                    MessageBox.Show("Debe de ingresar la contraseña.");
                } else
                {
                    if(txtContra.Text=="1234")
                    {
                        gbLogin.Enabled = false;
                        gbFacturacion.Visible = true;
                        MessageBox.Show("Bienvenido al sistema de facturación." + 
                            txtUsuario.Text);
                    } else
                    {
                        MessageBox.Show("Clave inválida!");
                    }
                }
            }
                
        }
    }
}
