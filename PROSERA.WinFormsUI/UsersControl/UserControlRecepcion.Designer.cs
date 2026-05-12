namespace PROSERA.WinFormsUI.UsersControl
{
    partial class UserControlRecepcion
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
            dtimeFecha = new DateTimePicker();
            cbCliente = new ComboBox();
            cbUsuario = new ComboBox();
            txtObservaciones = new TextBox();
            txtIdRecepcion = new TextBox();
            label6 = new Label();
            label7 = new Label();
            cbDispositivo = new ComboBox();
            txtCantidad = new TextBox();
            txtIdDetalle = new TextBox();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            dgvRecepcion = new DataGridView();
            dgvDetalle = new DataGridView();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRecepcion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(333, 11);
            label1.Name = "label1";
            label1.Size = new Size(108, 25);
            label1.TabIndex = 5;
            label1.Text = "Recepcion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 59);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 6;
            label2.Text = "Fecha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 86);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 7;
            label3.Text = "Cliente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 119);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 8;
            label4.Text = "Usuario";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 146);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 9;
            label5.Text = "Observaciones";
            // 
            // dtimeFecha
            // 
            dtimeFecha.Location = new Point(111, 56);
            dtimeFecha.Margin = new Padding(2);
            dtimeFecha.Name = "dtimeFecha";
            dtimeFecha.Size = new Size(211, 23);
            dtimeFecha.TabIndex = 10;
            // 
            // cbCliente
            // 
            cbCliente.FormattingEnabled = true;
            cbCliente.Location = new Point(111, 85);
            cbCliente.Margin = new Padding(2);
            cbCliente.Name = "cbCliente";
            cbCliente.Size = new Size(129, 23);
            cbCliente.TabIndex = 11;
            // 
            // cbUsuario
            // 
            cbUsuario.FormattingEnabled = true;
            cbUsuario.Location = new Point(111, 116);
            cbUsuario.Margin = new Padding(2);
            cbUsuario.Name = "cbUsuario";
            cbUsuario.Size = new Size(129, 23);
            cbUsuario.TabIndex = 12;
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(111, 143);
            txtObservaciones.Margin = new Padding(2);
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(106, 23);
            txtObservaciones.TabIndex = 13;
            // 
            // txtIdRecepcion
            // 
            txtIdRecepcion.Location = new Point(111, 173);
            txtIdRecepcion.Margin = new Padding(2);
            txtIdRecepcion.Name = "txtIdRecepcion";
            txtIdRecepcion.Size = new Size(106, 23);
            txtIdRecepcion.TabIndex = 14;
            txtIdRecepcion.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(370, 88);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(65, 15);
            label6.TabIndex = 15;
            label6.Text = "Dispositivo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(370, 122);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 16;
            label7.Text = "Cantidad";
            // 
            // cbDispositivo
            // 
            cbDispositivo.FormattingEnabled = true;
            cbDispositivo.Location = new Point(444, 83);
            cbDispositivo.Margin = new Padding(2);
            cbDispositivo.Name = "cbDispositivo";
            cbDispositivo.Size = new Size(129, 23);
            cbDispositivo.TabIndex = 17;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(444, 119);
            txtCantidad.Margin = new Padding(2);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(106, 23);
            txtCantidad.TabIndex = 18;
            // 
            // txtIdDetalle
            // 
            txtIdDetalle.Location = new Point(444, 148);
            txtIdDetalle.Margin = new Padding(2);
            txtIdDetalle.Name = "txtIdDetalle";
            txtIdDetalle.Size = new Size(106, 23);
            txtIdDetalle.TabIndex = 19;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(673, 70);
            btnGuardar.Margin = new Padding(2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(78, 20);
            btnGuardar.TabIndex = 20;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(673, 104);
            btnEditar.Margin = new Padding(2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(78, 20);
            btnEditar.TabIndex = 21;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(673, 139);
            btnEliminar.Margin = new Padding(2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(78, 20);
            btnEliminar.TabIndex = 22;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(673, 173);
            btnLimpiar.Margin = new Padding(2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(78, 20);
            btnLimpiar.TabIndex = 23;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dgvRecepcion
            // 
            dgvRecepcion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecepcion.Location = new Point(17, 209);
            dgvRecepcion.Margin = new Padding(2);
            dgvRecepcion.Name = "dgvRecepcion";
            dgvRecepcion.RowHeadersWidth = 62;
            dgvRecepcion.Size = new Size(322, 248);
            dgvRecepcion.TabIndex = 24;
<<<<<<< HEAD
            dgvRecepcion.CellClick += dgvRecepcion_CellContentClick;
=======
            dgvRecepcion.CellContentClick += dgvRecepcion_CellContentClick;
>>>>>>> 8fab699fa5c3adbb4463fca748e4e82fe2d2b6cb
            // 
            // dgvDetalle
            // 
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle.Location = new Point(370, 209);
            dgvDetalle.Margin = new Padding(2);
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.RowHeadersWidth = 62;
            dgvDetalle.Size = new Size(323, 248);
            dgvDetalle.TabIndex = 25;
            dgvDetalle.CellContentClick += dgvDetalle_CellContentClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(101, 28);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(84, 17);
            label8.TabIndex = 26;
            label8.Text = "Recepcion";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(547, 41);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(59, 17);
            label9.TabIndex = 27;
            label9.Text = "Detalle";
            // 
            // UserControlRecepcion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(dgvDetalle);
            Controls.Add(dgvRecepcion);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(txtIdDetalle);
            Controls.Add(txtCantidad);
            Controls.Add(cbDispositivo);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtIdRecepcion);
            Controls.Add(txtObservaciones);
            Controls.Add(cbUsuario);
            Controls.Add(cbCliente);
            Controls.Add(dtimeFecha);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UserControlRecepcion";
            Size = new Size(785, 490);
            Load += UserControlRecepcion_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvRecepcion).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dtimeFecha;
        private ComboBox cbCliente;
        private ComboBox cbUsuario;
        private TextBox txtObservaciones;
        private TextBox txtIdRecepcion;
        private Label label6;
        private Label label7;
        private ComboBox cbDispositivo;
        private TextBox txtCantidad;
        private TextBox txtIdDetalle;
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private DataGridView dgvRecepcion;
        private DataGridView dgvDetalle;
        private Label label8;
        private Label label9;
    }
}
