namespace PROSERA.WinFormsUI.UsersControl
{
    partial class UserControlDispositivos
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
            txtDescripcion = new TextBox();
            txtDui = new TextBox();
            txtEstado = new TextBox();
            txtModelo = new TextBox();
            txtMarca = new TextBox();
            txtDispositivo = new TextBox();
            dgvDispositivos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDispositivos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(324, 10);
            label1.Name = "label1";
            label1.Size = new Size(126, 25);
            label1.TabIndex = 5;
            label1.Text = "Dispositivos";
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(503, 399);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(98, 24);
            btnRegresar.TabIndex = 31;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(399, 399);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(98, 24);
            btnGuardar.TabIndex = 32;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(285, 399);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(98, 24);
            btnModificar.TabIndex = 33;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(167, 399);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(98, 24);
            btnEliminar.TabIndex = 34;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(178, 187);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 29;
            label5.Text = "Descripcion";
            // 
            // DUI
            // 
            DUI.AutoSize = true;
            DUI.Location = new Point(489, 187);
            DUI.Name = "DUI";
            DUI.Size = new Size(112, 15);
            DUI.TabIndex = 28;
            DUI.Text = "Peso del Dispositivo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(626, 131);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 27;
            label6.Text = "Estado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(446, 131);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 30;
            label3.Text = "Modelo ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(269, 131);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 26;
            label4.Text = "Marca";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 131);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 25;
            label2.Text = "Dispositivo";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(47, 205);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(336, 23);
            txtDescripcion.TabIndex = 24;
            // 
            // txtDui
            // 
            txtDui.Location = new Point(446, 205);
            txtDui.Name = "txtDui";
            txtDui.Size = new Size(210, 23);
            txtDui.TabIndex = 23;
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(579, 149);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(161, 23);
            txtEstado.TabIndex = 22;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(399, 149);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(161, 23);
            txtModelo.TabIndex = 21;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(222, 149);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(161, 23);
            txtMarca.TabIndex = 20;
            // 
            // txtDispositivo
            // 
            txtDispositivo.Location = new Point(47, 149);
            txtDispositivo.Name = "txtDispositivo";
            txtDispositivo.Size = new Size(161, 23);
            txtDispositivo.TabIndex = 19;
            // 
            // dgvDispositivos
            // 
            dgvDispositivos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDispositivos.Location = new Point(71, 252);
            dgvDispositivos.Name = "dgvDispositivos";
            dgvDispositivos.Size = new Size(669, 125);
            dgvDispositivos.TabIndex = 18;
            // 
            // UserControlDispositivos
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
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(txtDescripcion);
            Controls.Add(txtDui);
            Controls.Add(txtEstado);
            Controls.Add(txtModelo);
            Controls.Add(txtMarca);
            Controls.Add(txtDispositivo);
            Controls.Add(dgvDispositivos);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UserControlDispositivos";
            Size = new Size(786, 490);
            Load += UserControlDispositivos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDispositivos).EndInit();
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
        private TextBox txtDescripcion;
        private TextBox txtDui;
        private TextBox txtEstado;
        private TextBox txtModelo;
        private TextBox txtMarca;
        private TextBox txtDispositivo;
        private DataGridView dgvDispositivos;
    }
}
