namespace PROSERA.WinFormsUI.UsersControl
{
    partial class UserControlUsuarios
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
            btnGuardarUser = new Button();
            btnModificarUser = new Button();
            btnEliminarUser = new Button();
            btnLimpiarUser = new Button();
            dataGridUsuario = new DataGridView();
            txtNombreUsuario = new TextBox();
            txtContraseña = new TextBox();
            cbxRolUsuario = new ComboBox();
            cbxEstadoUsuario = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridUsuario).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(389, 13);
            label1.Name = "label1";
            label1.Size = new Size(120, 32);
            label1.TabIndex = 5;
            label1.Text = "Usuarios";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 98);
            label2.Name = "label2";
            label2.Size = new Size(118, 20);
            label2.TabIndex = 6;
            label2.Text = "Nombre Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(389, 98);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 7;
            label3.Text = "Contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(683, 98);
            label4.Name = "label4";
            label4.Size = new Size(31, 20);
            label4.TabIndex = 8;
            label4.Text = "Rol";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(84, 193);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 9;
            label5.Text = "Estado";
            // 
            // btnGuardarUser
            // 
            btnGuardarUser.Location = new Point(96, 290);
            btnGuardarUser.Name = "btnGuardarUser";
            btnGuardarUser.Size = new Size(94, 29);
            btnGuardarUser.TabIndex = 10;
            btnGuardarUser.Text = "Guardar";
            btnGuardarUser.UseVisualStyleBackColor = true;
            btnGuardarUser.Click += btnGuardarUser_Click;
            // 
            // btnModificarUser
            // 
            btnModificarUser.Location = new Point(282, 290);
            btnModificarUser.Name = "btnModificarUser";
            btnModificarUser.Size = new Size(94, 29);
            btnModificarUser.TabIndex = 11;
            btnModificarUser.Text = "Modificar";
            btnModificarUser.UseVisualStyleBackColor = true;
            btnModificarUser.Click += btnModificarUser_Click;
            // 
            // btnEliminarUser
            // 
            btnEliminarUser.Location = new Point(491, 290);
            btnEliminarUser.Name = "btnEliminarUser";
            btnEliminarUser.Size = new Size(94, 29);
            btnEliminarUser.TabIndex = 12;
            btnEliminarUser.Text = "Eliminar";
            btnEliminarUser.UseVisualStyleBackColor = true;
            btnEliminarUser.Click += btnEliminarUser_Click;
            // 
            // btnLimpiarUser
            // 
            btnLimpiarUser.Location = new Point(683, 290);
            btnLimpiarUser.Name = "btnLimpiarUser";
            btnLimpiarUser.Size = new Size(94, 29);
            btnLimpiarUser.TabIndex = 13;
            btnLimpiarUser.Text = "Limpiar";
            btnLimpiarUser.UseVisualStyleBackColor = true;
            btnLimpiarUser.Click += btnLimpiarUser_Click;
            // 
            // dataGridUsuario
            // 
            dataGridUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridUsuario.Location = new Point(96, 351);
            dataGridUsuario.Name = "dataGridUsuario";
            dataGridUsuario.RowHeadersWidth = 51;
            dataGridUsuario.Size = new Size(681, 277);
            dataGridUsuario.TabIndex = 14;
            dataGridUsuario.CellContentClick += dataGridUsuario_CellContentClick;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(86, 125);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(245, 27);
            txtNombreUsuario.TabIndex = 15;
            txtNombreUsuario.TextChanged += txtNombreUsuario_TextChanged;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(391, 130);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(178, 27);
            txtContraseña.TabIndex = 16;
            txtContraseña.TextChanged += txtContraseña_TextChanged;
            // 
            // cbxRolUsuario
            // 
            cbxRolUsuario.FormattingEnabled = true;
            cbxRolUsuario.Location = new Point(681, 125);
            cbxRolUsuario.Name = "cbxRolUsuario";
            cbxRolUsuario.Size = new Size(151, 28);
            cbxRolUsuario.TabIndex = 17;
            cbxRolUsuario.SelectedIndexChanged += cbxRolUsuario_SelectedIndexChanged;
            // 
            // cbxEstadoUsuario
            // 
            cbxEstadoUsuario.FormattingEnabled = true;
            cbxEstadoUsuario.Location = new Point(82, 216);
            cbxEstadoUsuario.Name = "cbxEstadoUsuario";
            cbxEstadoUsuario.Size = new Size(151, 28);
            cbxEstadoUsuario.TabIndex = 18;
            cbxEstadoUsuario.SelectedIndexChanged += cbxEstadoUsuario_SelectedIndexChanged;
            // 
            // UserControlUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cbxEstadoUsuario);
            Controls.Add(cbxRolUsuario);
            Controls.Add(txtContraseña);
            Controls.Add(txtNombreUsuario);
            Controls.Add(dataGridUsuario);
            Controls.Add(btnLimpiarUser);
            Controls.Add(btnEliminarUser);
            Controls.Add(btnModificarUser);
            Controls.Add(btnGuardarUser);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UserControlUsuarios";
            Size = new Size(898, 653);
            ((System.ComponentModel.ISupportInitialize)dataGridUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnGuardarUser;
        private Button btnModificarUser;
        private Button btnEliminarUser;
        private Button btnLimpiarUser;
        private DataGridView dataGridUsuario;
        private TextBox txtNombreUsuario;
        private TextBox txtContraseña;
        private ComboBox cbxRolUsuario;
        private ComboBox cbxEstadoUsuario;
    }
}
