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
            label1.Location = new Point(476, 18);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(163, 37);
            label1.TabIndex = 5;
            label1.Text = "Recepcion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 99);
            label2.Name = "label2";
            label2.Size = new Size(57, 25);
            label2.TabIndex = 6;
            label2.Text = "Fecha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 144);
            label3.Name = "label3";
            label3.Size = new Size(65, 25);
            label3.TabIndex = 7;
            label3.Text = "Cliente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 198);
            label4.Name = "label4";
            label4.Size = new Size(72, 25);
            label4.TabIndex = 8;
            label4.Text = "Usuario";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 244);
            label5.Name = "label5";
            label5.Size = new Size(128, 25);
            label5.TabIndex = 9;
            label5.Text = "Observaciones";
            // 
            // dtimeFecha
            // 
            dtimeFecha.Location = new Point(158, 93);
            dtimeFecha.Name = "dtimeFecha";
            dtimeFecha.Size = new Size(300, 31);
            dtimeFecha.TabIndex = 10;
            // 
            // cbCliente
            // 
            cbCliente.FormattingEnabled = true;
            cbCliente.Location = new Point(158, 141);
            cbCliente.Name = "cbCliente";
            cbCliente.Size = new Size(182, 33);
            cbCliente.TabIndex = 11;
            // 
            // cbUsuario
            // 
            cbUsuario.FormattingEnabled = true;
            cbUsuario.Location = new Point(158, 193);
            cbUsuario.Name = "cbUsuario";
            cbUsuario.Size = new Size(182, 33);
            cbUsuario.TabIndex = 12;
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(158, 238);
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(150, 31);
            txtObservaciones.TabIndex = 13;
            // 
            // txtIdRecepcion
            // 
            txtIdRecepcion.Location = new Point(158, 289);
            txtIdRecepcion.Name = "txtIdRecepcion";
            txtIdRecepcion.Size = new Size(150, 31);
            txtIdRecepcion.TabIndex = 14;
            txtIdRecepcion.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(528, 147);
            label6.Name = "label6";
            label6.Size = new Size(101, 25);
            label6.TabIndex = 15;
            label6.Text = "Dispositivo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(528, 204);
            label7.Name = "label7";
            label7.Size = new Size(83, 25);
            label7.TabIndex = 16;
            label7.Text = "Cantidad";
            // 
            // cbDispositivo
            // 
            cbDispositivo.FormattingEnabled = true;
            cbDispositivo.Location = new Point(634, 139);
            cbDispositivo.Name = "cbDispositivo";
            cbDispositivo.Size = new Size(182, 33);
            cbDispositivo.TabIndex = 17;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(634, 198);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(150, 31);
            txtCantidad.TabIndex = 18;
            // 
            // txtIdDetalle
            // 
            txtIdDetalle.Location = new Point(634, 247);
            txtIdDetalle.Name = "txtIdDetalle";
            txtIdDetalle.Size = new Size(150, 31);
            txtIdDetalle.TabIndex = 19;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(962, 117);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 34);
            btnGuardar.TabIndex = 20;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(962, 173);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(112, 34);
            btnEditar.TabIndex = 21;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(962, 232);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 34);
            btnEliminar.TabIndex = 22;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(962, 289);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(112, 34);
            btnLimpiar.TabIndex = 23;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // dgvRecepcion
            // 
            dgvRecepcion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecepcion.Location = new Point(24, 349);
            dgvRecepcion.Name = "dgvRecepcion";
            dgvRecepcion.RowHeadersWidth = 62;
            dgvRecepcion.Size = new Size(460, 413);
            dgvRecepcion.TabIndex = 24;
            // 
            // dgvDetalle
            // 
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle.Location = new Point(528, 349);
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.RowHeadersWidth = 62;
            dgvDetalle.Size = new Size(461, 413);
            dgvDetalle.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sitka Banner Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(144, 46);
            label8.Name = "label8";
            label8.Size = new Size(94, 29);
            label8.TabIndex = 26;
            label8.Text = "Recepcion";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Sitka Banner Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(782, 68);
            label9.Name = "label9";
            label9.Size = new Size(68, 29);
            label9.TabIndex = 27;
            label9.Text = "Detalle";
            // 
            // UserControlRecepcion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
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
            Margin = new Padding(4);
            Name = "UserControlRecepcion";
            Size = new Size(1122, 816);
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
