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
            label1 = new Label();
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
            // UserControlCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UserControlCategoria";
            Size = new Size(786, 490);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}
