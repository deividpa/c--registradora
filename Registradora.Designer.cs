
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbFacturacion = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.gbFactura = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbSucursal = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnFactNew = new System.Windows.Forms.Button();
            this.btnFactCerrar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gbLogin.SuspendLayout();
            this.gbFacturacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbCliente.SuspendLayout();
            this.gbFactura.SuspendLayout();
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
            this.gbLogin.Size = new System.Drawing.Size(714, 160);
            this.gbLogin.TabIndex = 0;
            this.gbLogin.TabStop = false;
            this.gbLogin.Text = "Iniciar Sesión";
            this.gbLogin.Enter += new System.EventHandler(this.gbLogin_Enter);
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
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(139, 38);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(294, 20);
            this.txtUsuario.TabIndex = 2;
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(139, 84);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(294, 20);
            this.txtContra.TabIndex = 3;
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
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(473, 80);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(51, 26);
            this.btnBorrar.TabIndex = 6;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(593, 126);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // gbFacturacion
            // 
            this.gbFacturacion.Controls.Add(this.gbFactura);
            this.gbFacturacion.Controls.Add(this.gbCliente);
            this.gbFacturacion.Location = new System.Drawing.Point(48, 247);
            this.gbFacturacion.Name = "gbFacturacion";
            this.gbFacturacion.Size = new System.Drawing.Size(714, 271);
            this.gbFacturacion.TabIndex = 2;
            this.gbFacturacion.TabStop = false;
            this.gbFacturacion.Text = "Facturación";
            this.gbFacturacion.Visible = false;
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
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.btnFactCerrar);
            this.gbCliente.Controls.Add(this.btnFactNew);
            this.gbCliente.Controls.Add(this.dtpFecha);
            this.gbCliente.Controls.Add(this.textBox1);
            this.gbCliente.Controls.Add(this.lbSucursal);
            this.gbCliente.Controls.Add(this.label6);
            this.gbCliente.Controls.Add(this.label5);
            this.gbCliente.Controls.Add(this.label3);
            this.gbCliente.Location = new System.Drawing.Point(12, 33);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(696, 111);
            this.gbCliente.TabIndex = 0;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Cliente";
            // 
            // gbFactura
            // 
            this.gbFactura.Controls.Add(this.label9);
            this.gbFactura.Controls.Add(this.label8);
            this.gbFactura.Controls.Add(this.label7);
            this.gbFactura.Location = new System.Drawing.Point(12, 150);
            this.gbFactura.Name = "gbFactura";
            this.gbFactura.Size = new System.Drawing.Size(696, 111);
            this.gbFactura.TabIndex = 1;
            this.gbFactura.TabStop = false;
            this.gbFactura.Text = "Factura";
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(272, 20);
            this.textBox1.TabIndex = 4;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(100, 64);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(272, 20);
            this.dtpFecha.TabIndex = 5;
            // 
            // btnFactNew
            // 
            this.btnFactNew.Location = new System.Drawing.Point(581, 26);
            this.btnFactNew.Name = "btnFactNew";
            this.btnFactNew.Size = new System.Drawing.Size(109, 26);
            this.btnFactNew.TabIndex = 9;
            this.btnFactNew.Text = "Nueva Factura";
            this.btnFactNew.UseVisualStyleBackColor = true;
            // 
            // btnFactCerrar
            // 
            this.btnFactCerrar.Location = new System.Drawing.Point(581, 64);
            this.btnFactCerrar.Name = "btnFactCerrar";
            this.btnFactCerrar.Size = new System.Drawing.Size(109, 26);
            this.btnFactCerrar.TabIndex = 10;
            this.btnFactCerrar.Text = "Cerrar Factura";
            this.btnFactCerrar.UseVisualStyleBackColor = true;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(272, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Valor:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(529, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Cantidad:";
            // 
            // Registradora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(806, 539);
            this.Controls.Add(this.gbFacturacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registradora";
            this.Text = "Caja Registradora";
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            this.gbFacturacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.gbFactura.ResumeLayout(false);
            this.gbFactura.PerformLayout();
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox lbSucursal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
    }
}