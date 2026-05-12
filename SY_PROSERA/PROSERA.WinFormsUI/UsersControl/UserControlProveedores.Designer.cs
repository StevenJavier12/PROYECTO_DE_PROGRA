namespace PROSERA.WinFormsUI.UsersControl
{
    partial class UserControlProveedores
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
            TxbTelefonoEmpresa = new TextBox();
            btnGuardar = new Button();
            btnEliminar = new Button();
            TxbNombreEmpresa = new TextBox();
            TxbTelefonoRespaldo = new TextBox();
            TxbCorreo = new TextBox();
            dataGridProveedores = new DataGridView();
            btnModificar = new Button();
            txbDireccion = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridProveedores).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(370, 14);
            label1.Name = "label1";
            label1.Size = new Size(159, 32);
            label1.TabIndex = 5;
            label1.Text = "Proveedores";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 87);
            label2.Name = "label2";
            label2.Size = new Size(125, 20);
            label2.TabIndex = 7;
            label2.Text = "Nombre Empresa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(620, 87);
            label3.Name = "label3";
            label3.Size = new Size(154, 20);
            label3.TabIndex = 8;
            label3.Text = "Telefono de Respaldo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(350, 87);
            label4.Name = "label4";
            label4.Size = new Size(128, 20);
            label4.TabIndex = 9;
            label4.Text = "Telefono Empresa";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(563, 191);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 10;
            label5.Text = "Dirección";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(64, 191);
            label6.Name = "label6";
            label6.Size = new Size(54, 20);
            label6.TabIndex = 11;
            label6.Text = "Correo";
            // 
            // TxbTelefonoEmpresa
            // 
            TxbTelefonoEmpresa.Location = new Point(350, 110);
            TxbTelefonoEmpresa.Name = "TxbTelefonoEmpresa";
            TxbTelefonoEmpresa.Size = new Size(190, 27);
            TxbTelefonoEmpresa.TabIndex = 16;
            TxbTelefonoEmpresa.TextChanged += TxbTelefonoEmpresa_TextChanged;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(152, 317);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(105, 29);
            btnGuardar.TabIndex = 20;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += BtnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(609, 317);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(113, 29);
            btnEliminar.TabIndex = 23;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // TxbNombreEmpresa
            // 
            TxbNombreEmpresa.Location = new Point(47, 110);
            TxbNombreEmpresa.Name = "TxbNombreEmpresa";
            TxbNombreEmpresa.Size = new Size(249, 27);
            TxbNombreEmpresa.TabIndex = 24;
            TxbNombreEmpresa.TextChanged += TxbNombreEmpresa_TextChanged;
            // 
            // TxbTelefonoRespaldo
            // 
            TxbTelefonoRespaldo.Location = new Point(620, 120);
            TxbTelefonoRespaldo.Name = "TxbTelefonoRespaldo";
            TxbTelefonoRespaldo.Size = new Size(222, 27);
            TxbTelefonoRespaldo.TabIndex = 25;
            TxbTelefonoRespaldo.TextChanged += TxbTelefonoRespaldo_TextChanged;
            // 
            // TxbCorreo
            // 
            TxbCorreo.Location = new Point(64, 225);
            TxbCorreo.Name = "TxbCorreo";
            TxbCorreo.Size = new Size(259, 27);
            TxbCorreo.TabIndex = 27;
            TxbCorreo.TextChanged += TxbCorreo_TextChanged;
            // 
            // dataGridProveedores
            // 
            dataGridProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridProveedores.Location = new Point(61, 363);
            dataGridProveedores.Name = "dataGridProveedores";
            dataGridProveedores.RowHeadersWidth = 51;
            dataGridProveedores.Size = new Size(781, 287);
            dataGridProveedores.TabIndex = 28;
            dataGridProveedores.CellContentClick += dataGridProveedores_CellContentClick;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(387, 315);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 29;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // txbDireccion
            // 
            txbDireccion.Location = new Point(563, 214);
            txbDireccion.Name = "txbDireccion";
            txbDireccion.Size = new Size(201, 27);
            txbDireccion.TabIndex = 30;
            txbDireccion.TextChanged += txbDireccion_TextChanged;
            // 
            // UserControlProveedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txbDireccion);
            Controls.Add(btnModificar);
            Controls.Add(dataGridProveedores);
            Controls.Add(TxbCorreo);
            Controls.Add(TxbTelefonoRespaldo);
            Controls.Add(TxbNombreEmpresa);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(TxbTelefonoEmpresa);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UserControlProveedores";
            Size = new Size(898, 653);
            ((System.ComponentModel.ISupportInitialize)dataGridProveedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label LbIdProveedor;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox TxbTelefonoEmpresa;
        private TextBox textBox4;
        private TextBox textBox5;
        private DataGridView dataGridProveedores;
        private Button btnGuardar;
        private Button button2;
        private Button btnEliminar;
        private TextBox TxbNombreEmpresa;
        private TextBox TxbTelefonoRespaldo;
        private TextBox textBox6;
        private TextBox TxbCorreo;
        private Button btnModificar;
        private TextBox txbDireccion;
    }
}
