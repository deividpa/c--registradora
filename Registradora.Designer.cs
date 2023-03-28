
namespace HolaMundo
{
    partial class Registradora
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registradora));
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbFacturacion = new System.Windows.Forms.GroupBox();
            this.gbFactura = new System.Windows.Forms.GroupBox();
            this.txtPagar = new System.Windows.Forms.TextBox();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnFacturaFin = new System.Windows.Forms.Button();
            this.cbIVA = new System.Windows.Forms.CheckBox();
            this.radDesc10 = new System.Windows.Forms.RadioButton();
            this.radDesc5 = new System.Windows.Forms.RadioButton();
            this.radDesc0 = new System.Windows.Forms.RadioButton();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.txtSalida = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFacturaValor = new System.Windows.Forms.TextBox();
            this.cbProductos = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.btnFactCerrar = new System.Windows.Forms.Button();
            this.btnFactNew = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtNomCliente = new System.Windows.Forms.TextBox();
            this.lbSucursal = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbFacturacion.SuspendLayout();
            this.gbFactura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            this.gbCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLogin
            // 
            this.gbLogin.Controls.Add(this.pictureBox1);
            this.gbLogin.Controls.Add(this.btnSalir);
            this.gbLogin.Controls.Add(this.btnBorrar);
            this.gbLogin.Controls.Add(this.btnEnviar);
            this.gbLogin.Controls.Add(this.label4);
            this.gbLogin.Controls.Add(this.txtContra);
            this.gbLogin.Controls.Add(this.txtUsuario);
            this.gbLogin.Controls.Add(this.label2);
            this.gbLogin.Location = new System.Drawing.Point(48, 81);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(725, 160);
            this.gbLogin.TabIndex = 0;
            this.gbLogin.TabStop = false;
            this.gbLogin.Text = "Iniciar Sesión";
            this.gbLogin.Enter += new System.EventHandler(this.gbLogin_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HolaMundo.Properties.Resources.caja;
            this.pictureBox1.Location = new System.Drawing.Point(558, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(593, 126);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(473, 80);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(51, 26);
            this.btnBorrar.TabIndex = 6;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(473, 34);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(51, 26);
            this.btnEnviar.TabIndex = 5;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Contraseña:";
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(139, 84);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(294, 20);
            this.txtContra.TabIndex = 3;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(139, 38);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(294, 20);
            this.txtUsuario.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "PROGRAMA CAJA REGISTRADORA";
            // 
            // gbFacturacion
            // 
            this.gbFacturacion.Controls.Add(this.gbFactura);
            this.gbFacturacion.Controls.Add(this.gbCliente);
            this.gbFacturacion.Location = new System.Drawing.Point(48, 247);
            this.gbFacturacion.Name = "gbFacturacion";
            this.gbFacturacion.Size = new System.Drawing.Size(725, 388);
            this.gbFacturacion.TabIndex = 2;
            this.gbFacturacion.TabStop = false;
            this.gbFacturacion.Text = "Facturación";
            this.gbFacturacion.Visible = false;
            // 
            // gbFactura
            // 
            this.gbFactura.Controls.Add(this.txtPagar);
            this.gbFactura.Controls.Add(this.btnPagar);
            this.gbFactura.Controls.Add(this.btnFacturaFin);
            this.gbFactura.Controls.Add(this.cbIVA);
            this.gbFactura.Controls.Add(this.radDesc10);
            this.gbFactura.Controls.Add(this.radDesc5);
            this.gbFactura.Controls.Add(this.radDesc0);
            this.gbFactura.Controls.Add(this.btnAgregar);
            this.gbFactura.Controls.Add(this.numCantidad);
            this.gbFactura.Controls.Add(this.txtSalida);
            this.gbFactura.Controls.Add(this.label11);
            this.gbFactura.Controls.Add(this.label10);
            this.gbFactura.Controls.Add(this.txtFacturaValor);
            this.gbFactura.Controls.Add(this.cbProductos);
            this.gbFactura.Controls.Add(this.label9);
            this.gbFactura.Controls.Add(this.label8);
            this.gbFactura.Controls.Add(this.label7);
            this.gbFactura.Location = new System.Drawing.Point(12, 150);
            this.gbFactura.Name = "gbFactura";
            this.gbFactura.Size = new System.Drawing.Size(702, 229);
            this.gbFactura.TabIndex = 1;
            this.gbFactura.TabStop = false;
            this.gbFactura.Text = "Factura";
            this.gbFactura.Visible = false;
            // 
            // txtPagar
            // 
            this.txtPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagar.Location = new System.Drawing.Point(581, 165);
            this.txtPagar.Name = "txtPagar";
            this.txtPagar.Size = new System.Drawing.Size(109, 21);
            this.txtPagar.TabIndex = 19;
            this.txtPagar.Visible = false;
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(581, 191);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(109, 26);
            this.btnPagar.TabIndex = 18;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Visible = false;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // btnFacturaFin
            // 
            this.btnFacturaFin.Location = new System.Drawing.Point(581, 78);
            this.btnFacturaFin.Name = "btnFacturaFin";
            this.btnFacturaFin.Size = new System.Drawing.Size(109, 26);
            this.btnFacturaFin.TabIndex = 17;
            this.btnFacturaFin.Text = "Fin Factura";
            this.btnFacturaFin.UseVisualStyleBackColor = true;
            this.btnFacturaFin.Click += new System.EventHandler(this.btnFacturaFin_Click);
            // 
            // cbIVA
            // 
            this.cbIVA.AutoSize = true;
            this.cbIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIVA.Location = new System.Drawing.Point(319, 82);
            this.cbIVA.Name = "cbIVA";
            this.cbIVA.Size = new System.Drawing.Size(43, 19);
            this.cbIVA.TabIndex = 16;
            this.cbIVA.Text = "IVA";
            this.cbIVA.UseVisualStyleBackColor = true;
            // 
            // radDesc10
            // 
            this.radDesc10.AutoSize = true;
            this.radDesc10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDesc10.Location = new System.Drawing.Point(213, 81);
            this.radDesc10.Name = "radDesc10";
            this.radDesc10.Size = new System.Drawing.Size(50, 19);
            this.radDesc10.TabIndex = 15;
            this.radDesc10.Text = "10%";
            this.radDesc10.UseVisualStyleBackColor = true;
            // 
            // radDesc5
            // 
            this.radDesc5.AutoSize = true;
            this.radDesc5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDesc5.Location = new System.Drawing.Point(168, 81);
            this.radDesc5.Name = "radDesc5";
            this.radDesc5.Size = new System.Drawing.Size(43, 19);
            this.radDesc5.TabIndex = 14;
            this.radDesc5.Text = "5%";
            this.radDesc5.UseVisualStyleBackColor = true;
            // 
            // radDesc0
            // 
            this.radDesc0.AutoSize = true;
            this.radDesc0.Checked = true;
            this.radDesc0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDesc0.Location = new System.Drawing.Point(123, 81);
            this.radDesc0.Name = "radDesc0";
            this.radDesc0.Size = new System.Drawing.Size(43, 19);
            this.radDesc0.TabIndex = 13;
            this.radDesc0.TabStop = true;
            this.radDesc0.Text = "0%";
            this.radDesc0.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(581, 32);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(109, 26);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // numCantidad
            // 
            this.numCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCantidad.Location = new System.Drawing.Point(504, 31);
            this.numCantidad.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(36, 21);
            this.numCantidad.TabIndex = 11;
            this.numCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtSalida
            // 
            this.txtSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalida.Location = new System.Drawing.Point(28, 148);
            this.txtSalida.Multiline = true;
            this.txtSalida.Name = "txtSalida";
            this.txtSalida.ReadOnly = true;
            this.txtSalida.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSalida.Size = new System.Drawing.Size(512, 69);
            this.txtSalida.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(24, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 20);
            this.label11.TabIndex = 9;
            this.label11.Text = "Salida:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(24, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "Descuento:";
            // 
            // txtFacturaValor
            // 
            this.txtFacturaValor.Location = new System.Drawing.Point(319, 32);
            this.txtFacturaValor.Name = "txtFacturaValor";
            this.txtFacturaValor.ReadOnly = true;
            this.txtFacturaValor.Size = new System.Drawing.Size(105, 20);
            this.txtFacturaValor.TabIndex = 5;
            // 
            // cbProductos
            // 
            this.cbProductos.FormattingEnabled = true;
            this.cbProductos.Items.AddRange(new object[] {
            "Papaya",
            "Manzana",
            "Pera",
            "Uva"});
            this.cbProductos.Location = new System.Drawing.Point(127, 30);
            this.cbProductos.Name = "cbProductos";
            this.cbProductos.Size = new System.Drawing.Size(121, 21);
            this.cbProductos.TabIndex = 4;
            this.cbProductos.SelectedIndexChanged += new System.EventHandler(this.cbProductos_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(430, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Cantidad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(263, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Valor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Productos:";
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.btnFactCerrar);
            this.gbCliente.Controls.Add(this.btnFactNew);
            this.gbCliente.Controls.Add(this.dtpFecha);
            this.gbCliente.Controls.Add(this.txtNomCliente);
            this.gbCliente.Controls.Add(this.lbSucursal);
            this.gbCliente.Controls.Add(this.label6);
            this.gbCliente.Controls.Add(this.label5);
            this.gbCliente.Controls.Add(this.label3);
            this.gbCliente.Enabled = false;
            this.gbCliente.Location = new System.Drawing.Point(12, 33);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(696, 111);
            this.gbCliente.TabIndex = 0;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Cliente";
            // 
            // btnFactCerrar
            // 
            this.btnFactCerrar.Location = new System.Drawing.Point(581, 64);
            this.btnFactCerrar.Name = "btnFactCerrar";
            this.btnFactCerrar.Size = new System.Drawing.Size(109, 26);
            this.btnFactCerrar.TabIndex = 10;
            this.btnFactCerrar.Text = "Cerrar Facturación";
            this.btnFactCerrar.UseVisualStyleBackColor = true;
            this.btnFactCerrar.Click += new System.EventHandler(this.btnFactCerrar_Click);
            // 
            // btnFactNew
            // 
            this.btnFactNew.Location = new System.Drawing.Point(581, 26);
            this.btnFactNew.Name = "btnFactNew";
            this.btnFactNew.Size = new System.Drawing.Size(109, 26);
            this.btnFactNew.TabIndex = 9;
            this.btnFactNew.Text = "Nueva Factura";
            this.btnFactNew.UseVisualStyleBackColor = true;
            this.btnFactNew.Click += new System.EventHandler(this.btnFactNew_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(100, 64);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(272, 20);
            this.dtpFecha.TabIndex = 5;
            // 
            // txtNomCliente
            // 
            this.txtNomCliente.Location = new System.Drawing.Point(100, 25);
            this.txtNomCliente.Name = "txtNomCliente";
            this.txtNomCliente.Size = new System.Drawing.Size(272, 20);
            this.txtNomCliente.TabIndex = 4;
            // 
            // lbSucursal
            // 
            this.lbSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSucursal.FormattingEnabled = true;
            this.lbSucursal.ItemHeight = 15;
            this.lbSucursal.Items.AddRange(new object[] {
            "Medellín",
            "Bello",
            "Envigado",
            "Itagüí"});
            this.lbSucursal.Location = new System.Drawing.Point(480, 26);
            this.lbSucursal.Name = "lbSucursal";
            this.lbSucursal.Size = new System.Drawing.Size(74, 64);
            this.lbSucursal.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(399, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Sucursal:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre:";
            // 
            // Registradora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(819, 648);
            this.Controls.Add(this.gbFacturacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registradora";
            this.Text = "Caja Registradora";
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbFacturacion.ResumeLayout(false);
            this.gbFactura.ResumeLayout(false);
            this.gbFactura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox gbFacturacion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbFactura;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.Button btnFactCerrar;
        private System.Windows.Forms.Button btnFactNew;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtNomCliente;
        private System.Windows.Forms.ListBox lbSucursal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSalida;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFacturaValor;
        private System.Windows.Forms.ComboBox cbProductos;
        private System.Windows.Forms.TextBox txtPagar;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnFacturaFin;
        private System.Windows.Forms.CheckBox cbIVA;
        private System.Windows.Forms.RadioButton radDesc10;
        private System.Windows.Forms.RadioButton radDesc5;
        private System.Windows.Forms.RadioButton radDesc0;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.NumericUpDown numCantidad;
    }
}