namespace PROSERA.WinFormsUI.UsersControl
{
    partial class UserControlProducto
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
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            txtPrecioUnitario = new TextBox();
            cbMarca = new ComboBox();
            cbCategoria = new ComboBox();
            cbEstadoProducto = new ComboBox();
            label7 = new Label();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            dgvProducto = new DataGridView();
            txtIdProducto = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvProducto).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(478, 18);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(160, 37);
            label1.TabIndex = 5;
            label1.Text = "Productos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 89);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 6;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(245, 89);
            label3.Name = "label3";
            label3.Size = new Size(104, 25);
            label3.TabIndex = 7;
            label3.Text = "Descripcion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(447, 87);
            label4.Name = "label4";
            label4.Size = new Size(60, 25);
            label4.TabIndex = 8;
            label4.Text = "Precio";
            // 
            // label5
            // 
            label5.AccessibleDescription = "v";
            label5.AutoSize = true;
            label5.Location = new Point(661, 87);
            label5.Name = "label5";
            label5.Size = new Size(60, 25);
            label5.TabIndex = 9;
            label5.Text = "Marca";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(903, 89);
            label6.Name = "label6";
            label6.Size = new Size(88, 25);
            label6.TabIndex = 10;
            label6.Text = "Categoria";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(44, 117);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 31);
            txtNombre.TabIndex = 11;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(224, 117);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(150, 31);
            txtDescripcion.TabIndex = 12;
            // 
            // txtPrecioUnitario
            // 
            txtPrecioUnitario.Location = new Point(403, 117);
            txtPrecioUnitario.Name = "txtPrecioUnitario";
            txtPrecioUnitario.Size = new Size(150, 31);
            txtPrecioUnitario.TabIndex = 13;
            // 
            // cbMarca
            // 
            cbMarca.FormattingEnabled = true;
            cbMarca.Location = new Point(604, 115);
            cbMarca.Name = "cbMarca";
            cbMarca.Size = new Size(182, 33);
            cbMarca.TabIndex = 14;
            // 
            // cbCategoria
            // 
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new Point(847, 117);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(182, 33);
            cbCategoria.TabIndex = 15;
            // 
            // cbEstadoProducto
            // 
            cbEstadoProducto.FormattingEnabled = true;
            cbEstadoProducto.Location = new Point(44, 222);
            cbEstadoProducto.Name = "cbEstadoProducto";
            cbEstadoProducto.Size = new Size(182, 33);
            cbEstadoProducto.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(84, 194);
            label7.Name = "label7";
            label7.Size = new Size(66, 25);
            label7.TabIndex = 17;
            label7.Text = "Estado";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(44, 306);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 34);
            btnGuardar.TabIndex = 18;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(224, 306);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(112, 34);
            btnEditar.TabIndex = 19;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(394, 306);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 34);
            btnEliminar.TabIndex = 20;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(585, 306);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(112, 34);
            btnLimpiar.TabIndex = 21;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // dgvProducto
            // 
            dgvProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducto.Location = new Point(44, 361);
            dgvProducto.Name = "dgvProducto";
            dgvProducto.RowHeadersWidth = 62;
            dgvProducto.Size = new Size(653, 389);
            dgvProducto.TabIndex = 22;
            // 
            // txtIdProducto
            // 
            txtIdProducto.Location = new Point(836, 292);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(150, 31);
            txtIdProducto.TabIndex = 23;
            // 
            // UserControlProducto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtIdProducto);
            Controls.Add(dgvProducto);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(label7);
            Controls.Add(cbEstadoProducto);
            Controls.Add(cbCategoria);
            Controls.Add(cbMarca);
            Controls.Add(txtPrecioUnitario);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4);
            Name = "UserControlProducto";
            Size = new Size(1122, 816);
            ((System.ComponentModel.ISupportInitialize)dgvProducto).EndInit();
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
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private TextBox txtPrecioUnitario;
        private ComboBox cbMarca;
        private ComboBox cbCategoria;
        private ComboBox cbEstadoProducto;
        private Label label7;
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private DataGridView dgvProducto;
        private TextBox txtIdProducto;
    }
}
