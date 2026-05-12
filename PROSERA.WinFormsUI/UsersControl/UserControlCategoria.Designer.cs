namespace PROSERA.WinFormsUI.UsersControl
{
    partial class UserControlCategoria
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnGuardar = new Button();
            btnRegresar = new Button();
            dgvCategorias = new ReaLTaiizor.Controls.PoisonDataGridView();
            parrotForm1 = new ReaLTaiizor.Forms.ParrotForm();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(336, 10);
            label1.Name = "label1";
            label1.Size = new Size(104, 25);
            label1.TabIndex = 3;
            label1.Text = "Categoria";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(52, 148);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(212, 23);
            txtNombre.TabIndex = 5;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(270, 148);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(451, 23);
            txtDescripcion.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(143, 125);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 6;
            label2.Text = "NOMBRE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(440, 125);
            label3.Name = "label3";
            label3.Size = new Size(181, 15);
            label3.TabIndex = 6;
            label3.Text = "DESCRIPCION DE LA CATEGORIA";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(148, 340);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(98, 24);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(266, 340);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(98, 24);
            btnModificar.TabIndex = 7;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(380, 340);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(98, 24);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(484, 340);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(98, 24);
            btnRegresar.TabIndex = 7;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // dgvCategorias
            // 
            dgvCategorias.AllowUserToResizeRows = false;
            dgvCategorias.BackgroundColor = Color.FromArgb(255, 255, 255);
            dgvCategorias.BorderStyle = BorderStyle.None;
            dgvCategorias.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvCategorias.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCategorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCategorias.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCategorias.EnableHeadersVisualStyles = false;
            dgvCategorias.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgvCategorias.GridColor = Color.FromArgb(255, 255, 255);
            dgvCategorias.Location = new Point(52, 184);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvCategorias.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvCategorias.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategorias.Size = new Size(669, 150);
            dgvCategorias.TabIndex = 8;
            // 
            // parrotForm1
            // 
            parrotForm1.BackColor = Color.FromArgb(236, 236, 236);
            parrotForm1.Dock = DockStyle.Fill;
            parrotForm1.ExitApplication = true;
            parrotForm1.FormStyle = ReaLTaiizor.Forms.ParrotForm.Style.MacOS;
            parrotForm1.Location = new Point(0, 0);
            parrotForm1.MacOSForeColor = Color.FromArgb(40, 40, 40);
            parrotForm1.MacOSLeftBackColor = Color.FromArgb(230, 230, 230);
            parrotForm1.MacOSRightBackColor = Color.FromArgb(210, 210, 210);
            parrotForm1.MacOSSeparatorColor = Color.FromArgb(173, 173, 173);
            parrotForm1.MaterialBackColor = Color.DodgerBlue;
            parrotForm1.MaterialForeColor = Color.White;
            parrotForm1.Name = "parrotForm1";
            parrotForm1.ShowMaximize = true;
            parrotForm1.ShowMinimize = true;
            parrotForm1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotForm1.TabIndex = 0;
            parrotForm1.TitleText = "Parrot Form";
            parrotForm1.UbuntuForeColor = Color.FromArgb(220, 220, 210);
            parrotForm1.UbuntuLeftBackColor = Color.FromArgb(90, 85, 80);
            parrotForm1.UbuntuRightBackColor = Color.FromArgb(65, 65, 60);
            // 
            // 
            // 
            parrotForm1.WorkingArea.BackColor = Color.FromArgb(236, 236, 236);
            parrotForm1.WorkingArea.Dock = DockStyle.Fill;
            parrotForm1.WorkingArea.Location = new Point(0, 39);
            parrotForm1.WorkingArea.Name = "";
            parrotForm1.WorkingArea.Size = new Size(200, 61);
            parrotForm1.WorkingArea.TabIndex = 0;
            // 
            // UserControlCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvCategorias);
            Controls.Add(btnRegresar);
            Controls.Add(btnGuardar);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UserControlCategoria";
            Size = new Size(786, 490);
            Load += UserControlCategoria_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label label1;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private Label label2;
        private Label label3;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnGuardar;
        private Button btnRegresar;
        private ReaLTaiizor.Controls.PoisonDataGridView dgvCategorias;
        private ReaLTaiizor.Forms.ParrotForm parrotForm1;
    }
}
