namespace PROSERA.WinFormsUI.UsersControl
{
    partial class UserControlEmpleados
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
            label5 = new Label();
            DUI = new Label();
            label6 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            txtDireccion = new TextBox();
            txtDui = new TextBox();
            txtCorreo = new TextBox();
            txtCargo = new TextBox();
            txtApeliido = new TextBox();
            txtNombre = new TextBox();
            dgvClientes = new DataGridView();
            txtTelefono = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(329, 10);
            label1.Name = "label1";
            label1.Size = new Size(116, 25);
            label1.TabIndex = 5;
            label1.Text = "Empleados";
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(503, 367);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(98, 24);
            btnRegresar.TabIndex = 30;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(399, 367);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(98, 24);
            btnGuardar.TabIndex = 31;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(285, 367);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(98, 24);
            btnModificar.TabIndex = 32;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(167, 367);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(98, 24);
            btnEliminar.TabIndex = 33;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(178, 155);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 28;
            label5.Text = "Direccion";
            // 
            // DUI
            // 
            DUI.AutoSize = true;
            DUI.Location = new Point(446, 155);
            DUI.Name = "DUI";
            DUI.Size = new Size(43, 15);
            DUI.TabIndex = 27;
            DUI.Text = "Correo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(626, 99);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 26;
            label6.Text = "Correo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(446, 99);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 29;
            label3.Text = "Cargo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(269, 99);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 25;
            label4.Text = "Apellido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 99);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 24;
            label2.Text = "Nombre";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(47, 173);
            txtDireccion.Multiline = true;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(336, 23);
            txtDireccion.TabIndex = 22;
            // 
            // txtDui
            // 
            txtDui.Location = new Point(399, 173);
            txtDui.Name = "txtDui";
            txtDui.Size = new Size(161, 23);
            txtDui.TabIndex = 21;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(579, 117);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(161, 23);
            txtCorreo.TabIndex = 20;
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(399, 117);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(161, 23);
            txtCargo.TabIndex = 19;
            // 
            // txtApeliido
            // 
            txtApeliido.Location = new Point(222, 117);
            txtApeliido.Name = "txtApeliido";
            txtApeliido.Size = new Size(161, 23);
            txtApeliido.TabIndex = 18;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(47, 117);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(161, 23);
            txtNombre.TabIndex = 23;
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(71, 220);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(669, 125);
            dgvClientes.TabIndex = 17;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(579, 173);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(161, 23);
            txtTelefono.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(626, 155);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 29;
            label7.Text = "Telefono";
            // 
            // UserControlEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnRegresar);
            Controls.Add(btnGuardar);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(label5);
            Controls.Add(DUI);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(txtDireccion);
            Controls.Add(txtDui);
            Controls.Add(txtCorreo);
            Controls.Add(txtTelefono);
            Controls.Add(txtCargo);
            Controls.Add(txtApeliido);
            Controls.Add(txtNombre);
            Controls.Add(dgvClientes);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UserControlEmpleados";
            Size = new Size(786, 490);
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
        private Label label5;
        private Label DUI;
        private Label label6;
        private Label label3;
        private Label label4;
        private Label label2;
        private TextBox txtDireccion;
        private TextBox txtDui;
        private TextBox txtCorreo;
        private TextBox txtCargo;
        private TextBox txtApeliido;
        private TextBox txtNombre;
        private DataGridView dgvClientes;
        private TextBox txtTelefono;
        private Label label7;
    }
}
