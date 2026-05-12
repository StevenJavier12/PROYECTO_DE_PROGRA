namespace PROSERA.WinFormsUI.UsersControl
{
    partial class UserControlCompras
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
            btnEliminar = new Button();
            btnAgregar = new Button();
            dgvVenta = new DataGridView();
            txbPrecio = new TextBox();
            numCantidad = new NumericUpDown();
            label10 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            cbProducto = new ComboBox();
            txbSubtotal = new TextBox();
            label9 = new Label();
            cbTipoComprobante = new ComboBox();
            label7 = new Label();
            cbDescuento = new ComboBox();
            label6 = new Label();
            label4 = new Label();
            comboBox2 = new ComboBox();
            label3 = new Label();
            dtimeFechaCompra = new DateTimePicker();
            label2 = new Label();
            cbProveedor = new ComboBox();
            button2 = new Button();
            button1 = new Button();
            dgvDetalleProducto = new DataGridView();
            label5 = new Label();
            txtTotal = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvVenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleProducto).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(340, 10);
            label1.Name = "label1";
            label1.Size = new Size(98, 25);
            label1.TabIndex = 5;
            label1.Text = "Compras";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(657, 476);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(90, 27);
            btnEliminar.TabIndex = 80;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(657, 451);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(90, 27);
            btnAgregar.TabIndex = 79;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // dgvVenta
            // 
            dgvVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVenta.Location = new Point(20, 254);
            dgvVenta.Name = "dgvVenta";
            dgvVenta.Size = new Size(727, 151);
            dgvVenta.TabIndex = 78;
            dgvVenta.CellContentClick += dgvVenta_CellContentClick;
            // 
            // txbPrecio
            // 
            txbPrecio.Location = new Point(361, 480);
            txbPrecio.Name = "txbPrecio";
            txbPrecio.Size = new Size(62, 23);
            txbPrecio.TabIndex = 77;
            txbPrecio.TextChanged += txbPrecio_TextChanged;
            // 
            // numCantidad
            // 
            numCantidad.Location = new Point(284, 481);
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new Size(55, 23);
            numCantidad.TabIndex = 76;
            numCantidad.ValueChanged += numCantidad_ValueChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label10.Location = new Point(22, 436);
            label10.Name = "label10";
            label10.Size = new Size(140, 19);
            label10.TabIndex = 75;
            label10.Text = "Detalle de producto";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(284, 462);
            label13.Name = "label13";
            label13.Size = new Size(55, 15);
            label13.TabIndex = 74;
            label13.Text = "Cantidad";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(483, 462);
            label14.Name = "label14";
            label14.Size = new Size(52, 15);
            label14.TabIndex = 73;
            label14.Text = "SubTotal";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(361, 462);
            label15.Name = "label15";
            label15.Size = new Size(40, 15);
            label15.TabIndex = 72;
            label15.Text = "Precio";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(21, 463);
            label16.Name = "label16";
            label16.Size = new Size(56, 15);
            label16.TabIndex = 71;
            label16.Text = "Producto";
            // 
            // cbProducto
            // 
            cbProducto.FormattingEnabled = true;
            cbProducto.Location = new Point(22, 481);
            cbProducto.Name = "cbProducto";
            cbProducto.Size = new Size(240, 23);
            cbProducto.TabIndex = 70;
            // 
            // txbSubtotal
            // 
            txbSubtotal.Location = new Point(483, 480);
            txbSubtotal.Name = "txbSubtotal";
            txbSubtotal.Size = new Size(70, 23);
            txbSubtotal.TabIndex = 69;
            txbSubtotal.TextChanged += txbSubtotal_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label9.Location = new Point(20, 62);
            label9.Name = "label9";
            label9.Size = new Size(135, 19);
            label9.TabIndex = 68;
            label9.Text = "Detalle de Compra";
            // 
            // cbTipoComprobante
            // 
            cbTipoComprobante.FormattingEnabled = true;
            cbTipoComprobante.Items.AddRange(new object[] { "Efectivo", "Tarjeta", "Tranferencia" });
            cbTipoComprobante.Location = new Point(317, 105);
            cbTipoComprobante.Name = "cbTipoComprobante";
            cbTipoComprobante.Size = new Size(121, 23);
            cbTipoComprobante.TabIndex = 65;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(317, 87);
            label7.Name = "label7";
            label7.Size = new Size(104, 15);
            label7.TabIndex = 64;
            label7.Text = "TipoComprobante";
            // 
            // cbDescuento
            // 
            cbDescuento.FormattingEnabled = true;
            cbDescuento.Items.AddRange(new object[] { "10", "20", "30" });
            cbDescuento.Location = new Point(20, 159);
            cbDescuento.Name = "cbDescuento";
            cbDescuento.Size = new Size(242, 23);
            cbDescuento.TabIndex = 63;
            cbDescuento.SelectedIndexChanged += cbDescuento_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 141);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 62;
            label6.Text = "Descuento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(607, 11);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 61;
            label4.Text = "Usuario";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(607, 31);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(140, 23);
            comboBox2.TabIndex = 60;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 87);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 59;
            label3.Text = "Proveedor";
            // 
            // dtimeFechaCompra
            // 
            dtimeFechaCompra.Location = new Point(22, 212);
            dtimeFechaCompra.Name = "dtimeFechaCompra";
            dtimeFechaCompra.Size = new Size(240, 23);
            dtimeFechaCompra.TabIndex = 58;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 194);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 57;
            label2.Text = "Fecha";
            // 
            // cbProveedor
            // 
            cbProveedor.FormattingEnabled = true;
            cbProveedor.Location = new Point(20, 105);
            cbProveedor.Name = "cbProveedor";
            cbProveedor.Size = new Size(242, 23);
            cbProveedor.TabIndex = 56;
            cbProveedor.SelectedIndexChanged += cbProveedor_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(657, 159);
            button2.Name = "button2";
            button2.Size = new Size(90, 39);
            button2.TabIndex = 55;
            button2.Text = "Modificar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(657, 105);
            button1.Name = "button1";
            button1.Size = new Size(90, 39);
            button1.TabIndex = 54;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            // 
            // dgvDetalleProducto
            // 
            dgvDetalleProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalleProducto.Location = new Point(20, 534);
            dgvDetalleProducto.Name = "dgvDetalleProducto";
            dgvDetalleProducto.Size = new Size(727, 151);
            dgvDetalleProducto.TabIndex = 53;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(317, 194);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 82;
            label5.Text = "Total";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(317, 212);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(70, 23);
            txtTotal.TabIndex = 81;
            // 
            // UserControlCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label5);
            Controls.Add(txtTotal);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvVenta);
            Controls.Add(txbPrecio);
            Controls.Add(numCantidad);
            Controls.Add(label10);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(label16);
            Controls.Add(cbProducto);
            Controls.Add(txbSubtotal);
            Controls.Add(label9);
            Controls.Add(cbTipoComprobante);
            Controls.Add(label7);
            Controls.Add(cbDescuento);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(comboBox2);
            Controls.Add(label3);
            Controls.Add(dtimeFechaCompra);
            Controls.Add(label2);
            Controls.Add(cbProveedor);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dgvDetalleProducto);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UserControlCompras";
            Size = new Size(767, 728);
            Load += UserControlCompras_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleProducto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnEliminar;
        private Button btnAgregar;
        private DataGridView dgvVenta;
        private TextBox txbPrecio;
        private NumericUpDown numCantidad;
        private Label label10;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private ComboBox cbProducto;
        private TextBox txbSubtotal;
        private Label label9;
        private ComboBox cbTipoComprobante;
        private Label label7;
        private ComboBox cbDescuento;
        private Label label6;
        private Label label4;
        private ComboBox comboBox2;
        private Label label3;
        private DateTimePicker dtimeFechaCompra;
        private Label label2;
        private ComboBox cbProveedor;
        private Button button2;
        private Button button1;
        private DataGridView dgvDetalleProducto;
        private Label label5;
        private TextBox txtTotal;
    }
}
