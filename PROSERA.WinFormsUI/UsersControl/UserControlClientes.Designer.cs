namespace PROSERA.WinFormsUI.UsersControl
{
    partial class UserControlClientes
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
            btnRegresar = new Button();
            btnGuardar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            label2 = new Label();
            txtNombre = new TextBox();
            dgvClientes = new DataGridView();
            label4 = new Label();
            txtApeliido = new TextBox();
            txtTelefono = new TextBox();
            label3 = new Label();
            txtDireccion = new TextBox();
            label5 = new Label();
            txtCorreo = new TextBox();
            label6 = new Label();
            txtDui = new TextBox();
            lblDui = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(345, 10);
            label1.Name = "label1";
            label1.Size = new Size(88, 25);
            label1.TabIndex = 5;
            label1.Text = "Clientes";
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(491, 341);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(98, 24);
            btnRegresar.TabIndex = 13;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(387, 341);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(98, 24);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(273, 341);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(98, 24);
            btnModificar.TabIndex = 15;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(155, 341);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(98, 24);
            btnEliminar.TabIndex = 16;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 73);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 12;
            label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(35, 91);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(161, 23);
            txtNombre.TabIndex = 10;
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(59, 194);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(669, 125);
            dgvClientes.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(257, 73);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 12;
            label4.Text = "Apellido";
            // 
            // txtApeliido
            // 
            txtApeliido.Location = new Point(210, 91);
            txtApeliido.Name = "txtApeliido";
            txtApeliido.Size = new Size(161, 23);
            txtApeliido.TabIndex = 10;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(387, 91);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(161, 23);
            txtTelefono.TabIndex = 10;
            txtTelefono.TextChanged += txtTelefono_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(434, 73);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 12;
            label3.Text = "Telefono";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(35, 147);
            txtDireccion.Multiline = true;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(336, 23);
            txtDireccion.TabIndex = 10;
            txtDireccion.TextChanged += txtTelefono_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(166, 129);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 12;
            label5.Text = "Direccion";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(567, 91);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(161, 23);
            txtCorreo.TabIndex = 10;
            txtCorreo.TextChanged += txtTelefono_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(614, 73);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 12;
            label6.Text = "Correo";
            // 
            // txtDui
            // 
            txtDui.Location = new Point(414, 147);
            txtDui.Name = "txtDui";
            txtDui.Size = new Size(161, 23);
            txtDui.TabIndex = 10;
            txtDui.TextChanged += txtTelefono_TextChanged;
            // 
            // lblDui
            // 
            lblDui.AutoSize = true;
            lblDui.Location = new Point(461, 129);
            lblDui.Name = "lblDui";
            lblDui.Size = new Size(26, 15);
            lblDui.TabIndex = 12;
            lblDui.Text = "DUI";
            // 
            // UserControlClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(btnRegresar);
            Controls.Add(btnGuardar);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(label5);
            Controls.Add(lblDui);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(txtDireccion);
            Controls.Add(txtDui);
            Controls.Add(txtCorreo);
            Controls.Add(txtTelefono);
            Controls.Add(txtApeliido);
            Controls.Add(txtNombre);
            Controls.Add(dgvClientes);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UserControlClientes";
            Size = new Size(786, 490);
            Load += UserControlClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnRegresar;
        private Button btnGuardar;
        private Button btnModificar;
        private Button btnEliminar;
        private Label label2;
        private TextBox txtNombre;
        private DataGridView dgvClientes;
        private Label label4;
        private TextBox txtApeliido;
        private TextBox txtTelefono;
        private Label label3;
        private TextBox txtDireccion;
        private Label label5;
        private TextBox txtCorreo;
        private Label label6;
        private TextBox txtDui;
        private Label lblDui;
    }
}
