namespace PROSERA.WinFormsUI.UsersControl
{
    partial class UserControlCompras
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        private void InitializeComponent()
        {
            label1 = new Label();
            lblBuscar = new Label();
            txtBuscarCompra = new TextBox();
            btnBuscar = new Button();
            gbEncabezado = new GroupBox();
            txtIdCompra = new TextBox();
            lblIdCompra = new Label();
            lblTotal = new Label();
            txtTotal = new TextBox();
            lblTipoComprobante = new Label();
            cboTipoComprobante = new ComboBox();
            lblProveedor = new Label();
            cboProveedor = new ComboBox();
            dtpFecha = new DateTimePicker();
            lblFecha = new Label();
            gbDetalle = new GroupBox();
            btnQuitarLinea = new Button();
            btnAgregarLinea = new Button();
            dgvDetalle = new DataGridView();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnCancelar = new Button();
            btnEliminar = new Button();
            gbEncabezado.SuspendLayout();
            gbDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(340, 10);
            label1.Name = "label1";
            label1.Size = new Size(98, 25);
            label1.TabIndex = 0;
            label1.Text = "Compras";
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(531, 23);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(88, 15);
            lblBuscar.TabIndex = 1;
            lblBuscar.Text = "Buscar Compra";
            // 
            // txtBuscarCompra
            // 
            txtBuscarCompra.Location = new Point(472, 41);
            txtBuscarCompra.Name = "txtBuscarCompra";
            txtBuscarCompra.Size = new Size(147, 23);
            txtBuscarCompra.TabIndex = 2;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(625, 40);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 25);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // gbEncabezado
            // 
            gbEncabezado.Controls.Add(txtIdCompra);
            gbEncabezado.Controls.Add(lblIdCompra);
            gbEncabezado.Controls.Add(lblTotal);
            gbEncabezado.Controls.Add(txtTotal);
            gbEncabezado.Controls.Add(lblTipoComprobante);
            gbEncabezado.Controls.Add(cboTipoComprobante);
            gbEncabezado.Controls.Add(lblProveedor);
            gbEncabezado.Controls.Add(cboProveedor);
            gbEncabezado.Controls.Add(dtpFecha);
            gbEncabezado.Controls.Add(lblFecha);
            gbEncabezado.Location = new Point(32, 70);
            gbEncabezado.Name = "gbEncabezado";
            gbEncabezado.Size = new Size(665, 100);
            gbEncabezado.TabIndex = 4;
            gbEncabezado.TabStop = false;
            gbEncabezado.Text = "Encabezado";
            // 
            // txtIdCompra
            // 
            txtIdCompra.Enabled = false;
            txtIdCompra.Location = new Point(80, 22);
            txtIdCompra.Name = "txtIdCompra";
            txtIdCompra.ReadOnly = true;
            txtIdCompra.Size = new Size(80, 23);
            txtIdCompra.TabIndex = 0;
            txtIdCompra.Visible = false;
            // 
            // lblIdCompra
            // 
            lblIdCompra.AutoSize = true;
            lblIdCompra.Location = new Point(10, 25);
            lblIdCompra.Name = "lblIdCompra";
            lblIdCompra.Size = new Size(64, 15);
            lblIdCompra.TabIndex = 1;
            lblIdCompra.Text = "ID Compra";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(407, 20);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(33, 15);
            lblTotal.TabIndex = 7;
            lblTotal.Text = "Total";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(447, 17);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(120, 23);
            txtTotal.TabIndex = 8;
            txtTotal.Text = "0.00";
            txtTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // lblTipoComprobante
            // 
            lblTipoComprobante.AutoSize = true;
            lblTipoComprobante.Location = new Point(300, 65);
            lblTipoComprobante.Name = "lblTipoComprobante";
            lblTipoComprobante.Size = new Size(108, 15);
            lblTipoComprobante.TabIndex = 5;
            lblTipoComprobante.Text = "Tipo Comprobante";
            // 
            // cboTipoComprobante
            // 
            cboTipoComprobante.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoComprobante.FormattingEnabled = true;
            cboTipoComprobante.Location = new Point(420, 62);
            cboTipoComprobante.Name = "cboTipoComprobante";
            cboTipoComprobante.Size = new Size(150, 23);
            cboTipoComprobante.TabIndex = 6;
            // 
            // lblProveedor
            // 
            lblProveedor.AutoSize = true;
            lblProveedor.Location = new Point(10, 65);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new Size(61, 15);
            lblProveedor.TabIndex = 3;
            lblProveedor.Text = "Proveedor";
            // 
            // cboProveedor
            // 
            cboProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProveedor.FormattingEnabled = true;
            cboProveedor.Location = new Point(80, 62);
            cboProveedor.Name = "cboProveedor";
            cboProveedor.Size = new Size(200, 23);
            cboProveedor.TabIndex = 4;
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(250, 22);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(120, 23);
            dtpFecha.TabIndex = 2;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(200, 25);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "Fecha";
            // 
            // gbDetalle
            // 
            gbDetalle.Controls.Add(btnQuitarLinea);
            gbDetalle.Controls.Add(btnAgregarLinea);
            gbDetalle.Controls.Add(dgvDetalle);
            gbDetalle.Location = new Point(32, 180);
            gbDetalle.Name = "gbDetalle";
            gbDetalle.Size = new Size(653, 250);
            gbDetalle.TabIndex = 5;
            gbDetalle.TabStop = false;
            gbDetalle.Text = "Detalle";
            // 
            // btnQuitarLinea
            // 
            btnQuitarLinea.Location = new Point(130, 215);
            btnQuitarLinea.Name = "btnQuitarLinea";
            btnQuitarLinea.Size = new Size(110, 25);
            btnQuitarLinea.TabIndex = 2;
            btnQuitarLinea.Text = "Quitar Línea";
            btnQuitarLinea.UseVisualStyleBackColor = true;
            btnQuitarLinea.Click += btnQuitarLinea_Click;
            // 
            // btnAgregarLinea
            // 
            btnAgregarLinea.Location = new Point(10, 215);
            btnAgregarLinea.Name = "btnAgregarLinea";
            btnAgregarLinea.Size = new Size(110, 25);
            btnAgregarLinea.TabIndex = 1;
            btnAgregarLinea.Text = "Agregar Línea";
            btnAgregarLinea.UseVisualStyleBackColor = true;
            btnAgregarLinea.Click += btnAgregarLinea_Click;
            // 
            // dgvDetalle
            // 
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle.Location = new Point(10, 22);
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.Size = new Size(577, 185);
            dgvDetalle.TabIndex = 0;
            dgvDetalle.CellEndEdit += dgvDetalle_CellEndEdit;
            dgvDetalle.RowsRemoved += dgvDetalle_RowsRemoved;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(250, 450);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(109, 34);
            btnNuevo.TabIndex = 6;
            btnNuevo.Text = "NUEVO";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(370, 450);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(109, 34);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(490, 450);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(109, 34);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(610, 450);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(109, 34);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // UserControlCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            Controls.Add(btnEliminar);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(gbDetalle);
            Controls.Add(gbEncabezado);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscarCompra);
            Controls.Add(lblBuscar);
            Controls.Add(label1);
            Name = "UserControlCompras";
            Size = new Size(870, 510);
            Load += UserControlCompras_Load;
            gbEncabezado.ResumeLayout(false);
            gbEncabezado.PerformLayout();
            gbDetalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblBuscar;
        private TextBox txtBuscarCompra;
        private Button btnBuscar;
        private GroupBox gbEncabezado;
        private TextBox txtIdCompra;
        private Label lblIdCompra;
        private Label lblFecha;
        private DateTimePicker dtpFecha;
        private Label lblProveedor;
        private ComboBox cboProveedor;
        private Label lblTipoComprobante;
        private ComboBox cboTipoComprobante;
        private Label lblTotal;
        private TextBox txtTotal;
        private GroupBox gbDetalle;
        private Button btnAgregarLinea;
        private Button btnQuitarLinea;
        private DataGridView dgvDetalle;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnCancelar;
        private Button btnEliminar;
    }
}