namespace PROSERA.WinFormsUI.UsersControl
{
    partial class UserControlProveedores
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnEliminar = new Button();
            dataGridProveedores = new DataGridView();
            txtDireccion = new TextBox();
            btnModificar = new Button();
            btnGuardar = new Button();
            txtNombreEmpresa = new TextBox();
            txtTelefono = new TextBox();
            txtRespaldo = new TextBox();
            txtCorreo = new TextBox();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridProveedores).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(370, 14);
            label1.Name = "label1";
            label1.Size = new Size(159, 32);
            label1.TabIndex = 5;
            label1.Text = "Proveedores";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 97);
            label2.Name = "label2";
            label2.Size = new Size(125, 20);
            label2.TabIndex = 6;
            label2.Text = "Nombre Empresa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(370, 97);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 7;
            label3.Text = "Telefono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(650, 97);
            label4.Name = "label4";
            label4.Size = new Size(133, 20);
            label4.TabIndex = 8;
            label4.Text = "Telefono Respaldo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(77, 205);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 9;
            label5.Text = "Correo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(580, 205);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 10;
            label6.Text = "Direccion";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(505, 334);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dataGridProveedores
            // 
            dataGridProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridProveedores.Location = new Point(77, 400);
            dataGridProveedores.Name = "dataGridProveedores";
            dataGridProveedores.RowHeadersWidth = 51;
            dataGridProveedores.Size = new Size(706, 250);
            dataGridProveedores.TabIndex = 14;
            dataGridProveedores.CellContentClick += dataGridProveedores_CellContentClick;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(580, 228);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(287, 27);
            txtDireccion.TabIndex = 19;
            txtDireccion.TextChanged += txtDireccion_TextChanged;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(310, 334);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 20;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click_1;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(152, 334);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 21;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // txtNombreEmpresa
            // 
            txtNombreEmpresa.Location = new Point(84, 128);
            txtNombreEmpresa.Name = "txtNombreEmpresa";
            txtNombreEmpresa.Size = new Size(211, 27);
            txtNombreEmpresa.TabIndex = 22;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(370, 131);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(195, 27);
            txtTelefono.TabIndex = 23;
            txtTelefono.TextChanged += txtTelefono_TextChanged_1;
            // 
            // txtRespaldo
            // 
            txtRespaldo.Location = new Point(650, 131);
            txtRespaldo.Name = "txtRespaldo";
            txtRespaldo.Size = new Size(213, 27);
            txtRespaldo.TabIndex = 24;
            txtRespaldo.TextChanged += txtRespaldo_TextChanged;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(77, 228);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(272, 27);
            txtCorreo.TabIndex = 25;
            txtCorreo.TextChanged += txtCorreo_TextChanged_1;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(674, 334);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(109, 29);
            btnLimpiar.TabIndex = 26;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // UserControlProveedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnLimpiar);
            Controls.Add(txtCorreo);
            Controls.Add(txtRespaldo);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombreEmpresa);
            Controls.Add(btnGuardar);
            Controls.Add(btnModificar);
            Controls.Add(txtDireccion);
            Controls.Add(dataGridProveedores);
            Controls.Add(btnEliminar);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UserControlProveedores";
            Size = new Size(898, 653);
            ((System.ComponentModel.ISupportInitialize)dataGridProveedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnEliminar;

        private Button button1;
        private Button button2;
        private DataGridView dataGridProveedores;
        private TextBox txtNombreEmpresa;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox txtDireccion;
        private Button btnModificar;
        private Button btnGuardar;
        private TextBox txtTelefono;
        private TextBox txtRespaldo;
        private TextBox txtCorreo;
        private Button btnLimpiar;
    }
}
