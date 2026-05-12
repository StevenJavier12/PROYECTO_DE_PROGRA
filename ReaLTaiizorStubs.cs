using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ReaLTaiizor.Controls
{
    // Stub para compilar sin la librería externa. Hereda DataGridView para mantener compatibilidad.
    public class PoisonDataGridView : DataGridView
    {
        // Mantener constructor por si el diseñador lo instancia.
        public PoisonDataGridView()
        {
        }
    }
}

namespace ReaLTaiizor.Forms
{
    using System.ComponentModel;

    // Stub mínimo de ParrotForm para satisfacer referencias del diseñador.
    [DesignerCategory("Code")]
    public class ParrotForm : UserControl
    {
        public ParrotForm()
        {
            // Crear y añadir WorkingArea para que el diseñador manipule sus propiedades.
            WorkingArea = new Panel();
            WorkingArea.BackColor = Color.FromArgb(236, 236, 236);
            WorkingArea.Dock = DockStyle.Fill;
            Controls.Add(WorkingArea);
        }

        // Propiedades usadas en el diseñador
        public bool ExitApplication { get; set; }

        public enum Style
        {
            MacOS,
            Material,
            Ubuntu
        }

        public Style FormStyle { get; set; }

        public Color MacOSForeColor { get; set; }
        public Color MacOSLeftBackColor { get; set; }
        public Color MacOSRightBackColor { get; set; }
        public Color MacOSSeparatorColor { get; set; }

        public Color MaterialBackColor { get; set; }
        public Color MaterialForeColor { get; set; }

        public bool ShowMaximize { get; set; }
        public bool ShowMinimize { get; set; }

        public SmoothingMode SmoothingType { get; set; }

        public string TitleText { get; set; }

        public Color UbuntuForeColor { get; set; }
        public Color UbuntuLeftBackColor { get; set; }
        public Color UbuntuRightBackColor { get; set; }

        // Control expuesto en el diseñador
        public Panel WorkingArea { get; private set; }
    }
}