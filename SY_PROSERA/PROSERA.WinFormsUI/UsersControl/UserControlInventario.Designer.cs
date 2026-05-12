namespace PROSERA.WinFormsUI.UsersControl
{
    partial class UserControlInventario
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
            cbProducto = new ComboBox();
            txtStock = new TextBox();
            txtStockMinimo = new TextBox();
            dtimeFechaActualizacion = new DateTimePicker();
            label6 = new Label();
            cbTipoMovimiento = new ComboBox();
            label7 = new Label();
            txtDescripcionMovimiento = new TextBox();
            txtInventario = new TextBox();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            dgvInventario = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(332, 11);
            label1.Name = "label1";
            label1.Size = new Size(111, 25);
            label1.TabIndex = 5;
            label1.Text = "Inventario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 70);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 6;
            label2.Text = "Producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(190, 70);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 7;
            label3.Text = "Stock";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(302, 70);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 8;
            label4.Text = "StockMinimo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(557, 70);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 9;
            label5.Text = "Fecha";
            // 
            // cbProducto
            // 
            cbProducto.FormattingEnabled = true;
            cbProducto.Location = new Point(17, 86);
            cbProducto.Margin = new Padding(2);
            cbProducto.Name = "cbProducto";
            cbProducto.Size = new Size(129, 23);
            cbProducto.TabIndex = 10;
            cbProducto.SelectedIndexChanged += cbProducto_SelectedIndexChanged;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(160, 86);
            txtStock.Margin = new Padding(2);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(106, 23);
            txtStock.TabIndex = 11;
            // 
            // txtStockMinimo
            // 
            txtStockMinimo.Location = new Point(289, 86);
            txtStockMinimo.Margin = new Padding(2);
            txtStockMinimo.Name = "txtStockMinimo";
            txtStockMinimo.Size = new Size(106, 23);
            txtStockMinimo.TabIndex = 12;
            // 
            // dtimeFechaActualizacion
            // 
            dtimeFechaActualizacion.Location = new Point(475, 85);
            dtimeFechaActualizacion.Margin = new Padding(2);
            dtimeFechaActualizacion.Name = "dtimeFechaActualizacion";
            dtimeFechaActualizacion.Size = new Size(211, 23);
            dtimeFechaActualizacion.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 142);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(98, 15);
            label6.TabIndex = 14;
            label6.Text = "Tipo Movimiento";
            // 
            // cbTipoMovimiento
            // 
            cbTipoMovimiento.FormattingEnabled = true;
            cbTipoMovimiento.Location = new Point(17, 159);
            cbTipoMovimiento.Margin = new Padding(2);
            cbTipoMovimiento.Name = "cbTipoMovimiento";
            cbTipoMovimiento.Size = new Size(129, 23);
            cbTipoMovimiento.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(160, 142);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(137, 15);
            label7.TabIndex = 16;
            label7.Text = "Descripcion Movimiento";
            // 
            // txtDescripcionMovimiento
            // 
            txtDescripcionMovimiento.Location = new Point(160, 159);
            txtDescripcionMovimiento.Margin = new Padding(2);
            txtDescripcionMovimiento.Name = "txtDescripcionMovimiento";
            txtDescripcionMovimiento.Size = new Size(145, 23);
            txtDescripcionMovimiento.TabIndex = 17;
            // 
            // txtInventario
            // 
            txtInventario.Location = new Point(531, 133);
            txtInventario.Margin = new Padding(2);
            txtInventario.Name = "txtInventario";
            txtInventario.Size = new Size(106, 23);
            txtInventario.TabIndex = 18;
            txtInventario.Visible = false;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(37, 215);
            btnGuardar.Margin = new Padding(2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(78, 20);
            btnGuardar.TabIndex = 19;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(160, 215);
            btnEditar.Margin = new Padding(2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(78, 20);
            btnEditar.TabIndex = 20;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click_1;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(276, 215);
            btnEliminar.Margin = new Padding(2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(78, 20);
            btnEliminar.TabIndex = 21;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(412, 215);
            btnLimpiar.Margin = new Padding(2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(78, 20);
            btnLimpiar.TabIndex = 22;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click_1;
            // 
            // dgvInventario
            // 
            dgvInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventario.Location = new Point(37, 254);
            dgvInventario.Margin = new Padding(2);
            dgvInventario.Name = "dgvInventario";
            dgvInventario.RowHeadersWidth = 62;
            dgvInventario.Size = new Size(457, 198);
            dgvInventario.TabIndex = 23;
            // 
            // UserControlInventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvInventario);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(txtInventario);
            Controls.Add(txtDescripcionMovimiento);
            Controls.Add(label7);
            Controls.Add(cbTipoMovimiento);
            Controls.Add(label6);
            Controls.Add(dtimeFechaActualizacion);
            Controls.Add(txtStockMinimo);
            Controls.Add(txtStock);
            Controls.Add(cbProducto);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UserControlInventario";
            Size = new Size(785, 490);
            ((System.ComponentModel.ISupportInitialize)dgvInventario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cbProducto;
        private TextBox txtStock;
        private TextBox txtStockMinimo;
        private DateTimePicker dtimeFechaActualizacion;
        private Label label6;
        private ComboBox cbTipoMovimiento;
        private Label label7;
        private TextBox txtDescripcionMovimiento;
        private TextBox txtInventario;
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private DataGridView dgvInventario;
    }
}
