﻿using System;
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
        double totalCajero = 0;
        double ivaCajero = 0;
        double descuentoCajero = 0;
        double totalFactura = 0;
        double ivaFactura = 0;
        double descuentoFactura = 0;

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
                        gbCliente.Enabled = true;
                        MessageBox.Show("Bienvenido al sistema de facturación." + 
                            txtUsuario.Text);
                    } else
                    {
                        MessageBox.Show("Clave inválida!");
                    }
                }
            }
                
        }

        private void btnFactNew_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtNomCliente.Text))
            {
                MessageBox.Show("Debe de ingresar un nombre de cliente!");
            } else
            {
                gbFactura.Visible = true;
                // Se reinician variables de factura
                totalFactura = 0;
                ivaFactura = 0;
                descuentoFactura = 0;
                DateTime objFecha = dtpFecha.Value;
                txtSalida.Text = "Factura de Compra:\r\n" +
                    "Cliente: " + txtNomCliente.Text + "  Fecha: " + objFecha.Year +
                        "/" + objFecha.Month + "/" + objFecha.Day + "  Sucursal: " +
                            "\r\n" + lbSucursal.Text;
                txtSalida.AppendText("\r\nProducto\tValor\t+" +
                    "Cant\tDesc\tIVA\tSubtotal");
            }
        }

        private void cbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbProductos.Text)
            {
                case "Papaya":
                    txtFacturaValor.Text = "3000";
                    break;
                case "Manzana":
                    txtFacturaValor.Text = "1500";
                    break;
                case "Pera":
                    txtFacturaValor.Text = "2000";
                    break;
                case "Uva":
                    txtFacturaValor.Text = "4000";
                    break;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            double subTotal = 0, descuento = 0, IVA = 0;
            subTotal = Double.Parse(txtFacturaValor.Text)*(double)numCantidad.Value;
            if(radDesc10.Checked == true)
            {
                descuento = subTotal * 10 / 100;
            } else if(radDesc5.Checked == true)
            {
                descuento = subTotal * 5 / 100;
            } else
            {
                descuento = subTotal;
            }

            if(cbIVA.Checked == true)
            {
                IVA = (subTotal - descuento) * 19 / 100; 
            }

            subTotal = subTotal - descuento + IVA;
            txtSalida.Text = txtSalida.Text + "\r\n" + cbProductos.Text +
                    "\t" + txtFacturaValor.Text + "\t" + numCantidad.Value + "\t" +
                        descuento + "\t" + IVA + "\t" + subTotal;
            totalFactura = totalFactura + subTotal;
            descuentoFactura = descuentoFactura + descuento;
            ivaFactura = ivaFactura + IVA;

        }

        private void btnFacturaFin_Click(object sender, EventArgs e)
        {
            txtPagar.Visible = true;
            btnPagar.Visible = true;
            txtSalida.AppendText("\r\n\r\nEl total a pagar es de: " + totalFactura+"$"
                + "\r\nEl descuento total es de: " + descuentoFactura + "$"
                   + "\r\nEl total de IVA es de: " + ivaFactura + "$");
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if(totalFactura <= Double.Parse(txtPagar.Text))
            {
                double devuelta = Double.Parse(txtPagar.Text) - totalFactura;
                MessageBox.Show("Su devuelta es de: " + devuelta + "$");
                totalCajero = totalCajero + totalFactura;
                ivaCajero = ivaCajero + ivaFactura;
                descuentoCajero = descuentoCajero + descuentoFactura;
                gbFactura.Visible = false;
                gbCliente.Visible = true;
                txtSalida.Clear();

                // Se invisiblizan botones y caja de texto de pago, al momento de
                // finalizar una compra
                btnPagar.Visible = false;
                txtPagar.Visible = false;
            } else
            {
                MessageBox.Show("El valor de pago es insuficiente.");
            }

        }

        private void btnFactCerrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total producido caja: " + totalCajero + "$"
                + "\r\nTotal descuento caja: " + descuentoCajero + "$"
                    +"\r\nTotal iva caja: " + ivaCajero + "$");
            totalCajero = 0;
            descuentoCajero = 0;
            ivaCajero = 0;
            gbFactura.Visible = false;
            gbLogin.Enabled = true;
            txtSalida.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
