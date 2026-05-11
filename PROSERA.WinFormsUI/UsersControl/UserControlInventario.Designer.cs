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
            label1.Location = new Point(475, 18);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(166, 37);
            label1.TabIndex = 5;
            label1.Text = "Inventario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 116);
            label2.Name = "label2";
            label2.Size = new Size(85, 25);
            label2.TabIndex = 6;
            label2.Text = "Producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(272, 116);
            label3.Name = "label3";
            label3.Size = new Size(55, 25);
            label3.TabIndex = 7;
            label3.Text = "Stock";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(432, 116);
            label4.Name = "label4";
            label4.Size = new Size(116, 25);
            label4.TabIndex = 8;
            label4.Text = "StockMinimo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(796, 116);
            label5.Name = "label5";
            label5.Size = new Size(57, 25);
            label5.TabIndex = 9;
            label5.Text = "Fecha";
            // 
            // cbProducto
            // 
            cbProducto.FormattingEnabled = true;
            cbProducto.Location = new Point(24, 144);
            cbProducto.Name = "cbProducto";
            cbProducto.Size = new Size(182, 33);
            cbProducto.TabIndex = 10;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(228, 144);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(150, 31);
            txtStock.TabIndex = 11;
            // 
            // txtStockMinimo
            // 
            txtStockMinimo.Location = new Point(413, 144);
            txtStockMinimo.Name = "txtStockMinimo";
            txtStockMinimo.Size = new Size(150, 31);
            txtStockMinimo.TabIndex = 12;
            // 
            // dtimeFechaActualizacion
            // 
            dtimeFechaActualizacion.Location = new Point(678, 142);
            dtimeFechaActualizacion.Name = "dtimeFechaActualizacion";
            dtimeFechaActualizacion.Size = new Size(300, 31);
            dtimeFechaActualizacion.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 237);
            label6.Name = "label6";
            label6.Size = new Size(148, 25);
            label6.TabIndex = 14;
            label6.Text = "Tipo Movimiento";
            // 
            // cbTipoMovimiento
            // 
            cbTipoMovimiento.FormattingEnabled = true;
            cbTipoMovimiento.Location = new Point(24, 265);
            cbTipoMovimiento.Name = "cbTipoMovimiento";
            cbTipoMovimiento.Size = new Size(182, 33);
            cbTipoMovimiento.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(228, 237);
            label7.Name = "label7";
            label7.Size = new Size(205, 25);
            label7.TabIndex = 16;
            label7.Text = "Descripcion Movimiento";
            // 
            // txtDescripcionMovimiento
            // 
            txtDescripcionMovimiento.Location = new Point(228, 265);
            txtDescripcionMovimiento.Name = "txtDescripcionMovimiento";
            txtDescripcionMovimiento.Size = new Size(205, 31);
            txtDescripcionMovimiento.TabIndex = 17;
            // 
            // txtInventario
            // 
            txtInventario.Location = new Point(758, 221);
            txtInventario.Name = "txtInventario";
            txtInventario.Size = new Size(150, 31);
            txtInventario.TabIndex = 18;
            txtInventario.Visible = false;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(53, 358);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 34);
            btnGuardar.TabIndex = 19;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(228, 358);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(112, 34);
            btnEditar.TabIndex = 20;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(395, 358);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 34);
            btnEliminar.TabIndex = 21;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(588, 358);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(112, 34);
            btnLimpiar.TabIndex = 22;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // dgvInventario
            // 
            dgvInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventario.Location = new Point(53, 423);
            dgvInventario.Name = "dgvInventario";
            dgvInventario.RowHeadersWidth = 62;
            dgvInventario.Size = new Size(653, 330);
            dgvInventario.TabIndex = 23;
            // 
            // UserControlInventario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
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
            Margin = new Padding(4);
            Name = "UserControlInventario";
            Size = new Size(1122, 816);
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
