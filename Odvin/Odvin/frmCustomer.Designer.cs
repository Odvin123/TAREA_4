namespace Odvin
{
    partial class frmCustomer
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
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNombredeCompañia = new System.Windows.Forms.Label();
            this.lblNombreDelCliente = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblRegion = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblCodigoPostal = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtNombreCompañia = new System.Windows.Forms.TextBox();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.txtCodigoPostal = new System.Windows.Forms.TextBox();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.txtTituloContacto = new System.Windows.Forms.TextBox();
            this.lblTItulodelContacto = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblFax = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.AllowUserToDeleteRows = false;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCustomer.Location = new System.Drawing.Point(0, 300);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.RowTemplate.Height = 25;
            this.dgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomer.Size = new System.Drawing.Size(624, 150);
            this.dgvCustomer.TabIndex = 0;
            this.dgvCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellContentClick);
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(22, 54);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(73, 15);
            this.lblCustomerID.TabIndex = 1;
            this.lblCustomerID.Text = "Customer ID";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(127, 46);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(100, 23);
            this.txtCustomerID.TabIndex = 2;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(12, 253);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 3;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(190, 253);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(292, 253);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(175, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tabla de Customer";
            // 
            // lblNombredeCompañia
            // 
            this.lblNombredeCompañia.AutoSize = true;
            this.lblNombredeCompañia.Location = new System.Drawing.Point(12, 84);
            this.lblNombredeCompañia.Name = "lblNombredeCompañia";
            this.lblNombredeCompañia.Size = new System.Drawing.Size(119, 15);
            this.lblNombredeCompañia.TabIndex = 8;
            this.lblNombredeCompañia.Text = "NombredeCompañia";
            // 
            // lblNombreDelCliente
            // 
            this.lblNombreDelCliente.AutoSize = true;
            this.lblNombreDelCliente.Location = new System.Drawing.Point(12, 127);
            this.lblNombreDelCliente.Name = "lblNombreDelCliente";
            this.lblNombreDelCliente.Size = new System.Drawing.Size(110, 15);
            this.lblNombreDelCliente.TabIndex = 9;
            this.lblNombreDelCliente.Text = "Nombre del Cliente";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(272, 57);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(45, 15);
            this.lblCiudad.TabIndex = 10;
            this.lblCiudad.Text = "Ciudad";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(22, 206);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(57, 15);
            this.lblDireccion.TabIndex = 11;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(272, 93);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(44, 15);
            this.lblRegion.TabIndex = 12;
            this.lblRegion.Text = "Region";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(288, 178);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(28, 15);
            this.lblPais.TabIndex = 13;
            this.lblPais.Text = "País";
            // 
            // lblCodigoPostal
            // 
            this.lblCodigoPostal.AutoSize = true;
            this.lblCodigoPostal.Location = new System.Drawing.Point(245, 135);
            this.lblCodigoPostal.Name = "lblCodigoPostal";
            this.lblCodigoPostal.Size = new System.Drawing.Size(81, 15);
            this.lblCodigoPostal.TabIndex = 14;
            this.lblCodigoPostal.Text = "Codigo Postal";
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(332, 54);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(100, 23);
            this.txtCiudad.TabIndex = 15;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(127, 198);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 23);
            this.txtDireccion.TabIndex = 16;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(127, 124);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(100, 23);
            this.txtNombreCliente.TabIndex = 17;
            // 
            // txtNombreCompañia
            // 
            this.txtNombreCompañia.Location = new System.Drawing.Point(127, 76);
            this.txtNombreCompañia.Name = "txtNombreCompañia";
            this.txtNombreCompañia.Size = new System.Drawing.Size(100, 23);
            this.txtNombreCompañia.TabIndex = 18;
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(332, 170);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(100, 23);
            this.txtPais.TabIndex = 19;
            // 
            // txtCodigoPostal
            // 
            this.txtCodigoPostal.Location = new System.Drawing.Point(332, 127);
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.Size = new System.Drawing.Size(100, 23);
            this.txtCodigoPostal.TabIndex = 20;
            // 
            // txtRegion
            // 
            this.txtRegion.Location = new System.Drawing.Point(332, 85);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(100, 23);
            this.txtRegion.TabIndex = 21;
            // 
            // txtTituloContacto
            // 
            this.txtTituloContacto.Location = new System.Drawing.Point(127, 160);
            this.txtTituloContacto.Name = "txtTituloContacto";
            this.txtTituloContacto.Size = new System.Drawing.Size(100, 23);
            this.txtTituloContacto.TabIndex = 22;
            // 
            // lblTItulodelContacto
            // 
            this.lblTItulodelContacto.AutoSize = true;
            this.lblTItulodelContacto.Location = new System.Drawing.Point(34, 163);
            this.lblTItulodelContacto.Name = "lblTItulodelContacto";
            this.lblTItulodelContacto.Size = new System.Drawing.Size(87, 15);
            this.lblTItulodelContacto.TabIndex = 23;
            this.lblTItulodelContacto.Text = "Titulo contacto";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(278, 206);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(44, 15);
            this.lblCelular.TabIndex = 24;
            this.lblCelular.Text = "Celular";
            // 
            // lblFax
            // 
            this.lblFax.AutoSize = true;
            this.lblFax.Location = new System.Drawing.Point(486, 84);
            this.lblFax.Name = "lblFax";
            this.lblFax.Size = new System.Drawing.Size(25, 15);
            this.lblFax.TabIndex = 25;
            this.lblFax.Text = "Fax";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(332, 199);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(100, 23);
            this.txtCelular.TabIndex = 26;
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(524, 81);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(100, 23);
            this.txtFax.TabIndex = 27;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(93, 253);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 450);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.lblFax);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.lblTItulodelContacto);
            this.Controls.Add(this.txtTituloContacto);
            this.Controls.Add(this.txtRegion);
            this.Controls.Add(this.txtCodigoPostal);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.txtNombreCompañia);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.lblCodigoPostal);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.lblRegion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblCiudad);
            this.Controls.Add(this.lblNombreDelCliente);
            this.Controls.Add(this.lblNombredeCompañia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.dgvCustomer);
            this.Name = "frmCustomer";
            this.Text = "frmCustomer";
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label2;
        private DataGridView dgvCustomer;
        private Label lblCustomerID;
        private TextBox txtCustomerID;
        private Button btnRegistrar;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Label lblNombredeCompañia;
        private Label lblNombreDelCliente;
        private Label label5;
        private Label lblDireccion;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label lblCiudad;
        private Label lblRegion;
        private TextBox txtCiudad;
        private TextBox txtDireccion;
        private TextBox txtNombreCliente;
        private TextBox txtNombreCompañia;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox txtRegion;
        private Label lblPais;
        private Label lblCodigoPostal;
        private TextBox txtPais;
        private TextBox txtCodigoPostal;
        private TextBox txtTituloContacto;
        private Label lblTItulodelContacto;
        private Label lblCelular;
        private Label lblFax;
        private TextBox txtCelular;
        private TextBox txtFax;
        private Button btnActualizar;
    }
}