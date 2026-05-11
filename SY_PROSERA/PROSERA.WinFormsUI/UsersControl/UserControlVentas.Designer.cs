namespace PROSERA.WinFormsUI.UsersControl
{
    partial class UserControlVentas
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            cbCliente = new ComboBox();
            label2 = new Label();
            dtimeFecha = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            comboBox2 = new ComboBox();
            label6 = new Label();
            cbDescuento = new ComboBox();
            label7 = new Label();
            cbMetodoPago = new ComboBox();
            cbEstadoFac = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            cbProducto = new ComboBox();
            txbSubTotal = new TextBox();
            numCantidad = new NumericUpDown();
            txbPrecio = new TextBox();
            dgvVenta = new DataGridView();
            btnAgregar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvVenta).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(336, 10);
            label1.Name = "label1";
            label1.Size = new Size(74, 25);
            label1.TabIndex = 5;
            label1.Text = "Ventas";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(19, 533);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(727, 151);
            dataGridView1.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(656, 104);
            button1.Name = "button1";
            button1.Size = new Size(90, 39);
            button1.TabIndex = 7;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(656, 158);
            button2.Name = "button2";
            button2.Size = new Size(90, 39);
            button2.TabIndex = 8;
            button2.Text = "Modificar";
            button2.UseVisualStyleBackColor = true;
            // 
            // cbCliente
            // 
            cbCliente.FormattingEnabled = true;
            cbCliente.Location = new Point(19, 104);
            cbCliente.Name = "cbCliente";
            cbCliente.Size = new Size(242, 23);
            cbCliente.TabIndex = 12;
            cbCliente.SelectedIndexChanged += cbCliente_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 193);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 13;
            label2.Text = "Fecha";
            // 
            // dtimeFecha
            // 
            dtimeFecha.Location = new Point(21, 211);
            dtimeFecha.Name = "dtimeFecha";
            dtimeFecha.Size = new Size(240, 23);
            dtimeFecha.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 86);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 15;
            label3.Text = "Cliente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(606, 10);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 17;
            label4.Text = "Usuario";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(606, 30);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(140, 23);
            comboBox2.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 140);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 20;
            label6.Text = "Descuento";
            // 
            // cbDescuento
            // 
            cbDescuento.FormattingEnabled = true;
            cbDescuento.Location = new Point(19, 158);
            cbDescuento.Name = "cbDescuento";
            cbDescuento.Size = new Size(242, 23);
            cbDescuento.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(316, 86);
            label7.Name = "label7";
            label7.Size = new Size(95, 15);
            label7.TabIndex = 22;
            label7.Text = "Metodo de pago";
            // 
            // cbMetodoPago
            // 
            cbMetodoPago.FormattingEnabled = true;
            cbMetodoPago.Items.AddRange(new object[] { "Efectivo", "Tarjeta", "Tranferencia" });
            cbMetodoPago.Location = new Point(316, 104);
            cbMetodoPago.Name = "cbMetodoPago";
            cbMetodoPago.Size = new Size(121, 23);
            cbMetodoPago.TabIndex = 23;
            // 
            // cbEstadoFac
            // 
            cbEstadoFac.FormattingEnabled = true;
            cbEstadoFac.Location = new Point(316, 158);
            cbEstadoFac.Name = "cbEstadoFac";
            cbEstadoFac.Size = new Size(121, 23);
            cbEstadoFac.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(316, 140);
            label8.Name = "label8";
            label8.Size = new Size(100, 15);
            label8.TabIndex = 24;
            label8.Text = "Estado de Factura";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label9.Location = new Point(19, 61);
            label9.Name = "label9";
            label9.Size = new Size(121, 19);
            label9.TabIndex = 26;
            label9.Text = "Detalle de Venta";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label10.Location = new Point(21, 435);
            label10.Name = "label10";
            label10.Size = new Size(140, 19);
            label10.TabIndex = 45;
            label10.Text = "Detalle de producto";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(283, 461);
            label13.Name = "label13";
            label13.Size = new Size(55, 15);
            label13.TabIndex = 39;
            label13.Text = "Cantidad";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(482, 461);
            label14.Name = "label14";
            label14.Size = new Size(52, 15);
            label14.TabIndex = 38;
            label14.Text = "SubTotal";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(360, 461);
            label15.Name = "label15";
            label15.Size = new Size(40, 15);
            label15.TabIndex = 37;
            label15.Text = "Precio";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(20, 462);
            label16.Name = "label16";
            label16.Size = new Size(56, 15);
            label16.TabIndex = 35;
            label16.Text = "Producto";
            // 
            // cbProducto
            // 
            cbProducto.FormattingEnabled = true;
            cbProducto.Location = new Point(21, 480);
            cbProducto.Name = "cbProducto";
            cbProducto.Size = new Size(240, 23);
            cbProducto.TabIndex = 32;
            // 
            // txbSubTotal
            // 
            txbSubTotal.Location = new Point(482, 479);
            txbSubTotal.Name = "txbSubTotal";
            txbSubTotal.Size = new Size(70, 23);
            txbSubTotal.TabIndex = 31;
            // 
            // numCantidad
            // 
            numCantidad.Location = new Point(283, 480);
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new Size(55, 23);
            numCantidad.TabIndex = 47;
            // 
            // txbPrecio
            // 
            txbPrecio.Location = new Point(360, 479);
            txbPrecio.Name = "txbPrecio";
            txbPrecio.Size = new Size(62, 23);
            txbPrecio.TabIndex = 48;
            // 
            // dgvVenta
            // 
            dgvVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVenta.Location = new Point(19, 253);
            dgvVenta.Name = "dgvVenta";
            dgvVenta.Size = new Size(727, 151);
            dgvVenta.TabIndex = 49;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(656, 450);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(90, 27);
            btnAgregar.TabIndex = 50;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(656, 475);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(90, 27);
            btnEliminar.TabIndex = 51;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // UserControlVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
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
            Controls.Add(txbSubTotal);
            Controls.Add(label9);
            Controls.Add(cbEstadoFac);
            Controls.Add(label8);
            Controls.Add(cbMetodoPago);
            Controls.Add(label7);
            Controls.Add(cbDescuento);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(comboBox2);
            Controls.Add(label3);
            Controls.Add(dtimeFecha);
            Controls.Add(label2);
            Controls.Add(cbCliente);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UserControlVentas";
            Size = new Size(767, 728);
            Load += UserControlVentas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvVenta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private ComboBox cbCliente;
        private Label label2;
        private DateTimePicker dtimeFecha;
        private Label label3;
        private Label label4;
        private ComboBox comboBox2;
        private Label label6;
        private ComboBox cbDescuento;
        private Label label7;
        private ComboBox cbMetodoPago;
        private ComboBox cbEstadoFac;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private ComboBox cbProducto;
        private TextBox txbSubTotal;
        private NumericUpDown numCantidad;
        private TextBox txbPrecio;
        private DataGridView dgvVenta;
        private Button btnAgregar;
        private Button btnEliminar;
    }
}
