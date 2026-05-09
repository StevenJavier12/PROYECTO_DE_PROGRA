using PROSERA.WinFormsUI.UsersControl;

namespace PROSERA.WinFormsUI
{
    public partial class ControlEmpleado : Form
    {
        public ControlEmpleado()
        {
            InitializeComponent();
        }

        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            UserControlProducto uc = new UserControlProducto();
            addUserControl(uc);
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            UserControlCategoria uc = new UserControlCategoria();
            addUserControl(uc);
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            UserControlInventario uc = new UserControlInventario();
            addUserControl(uc);
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            UserControlVentas uc = new UserControlVentas();
            addUserControl(uc);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            UserControlClientes uc = new UserControlClientes();
            addUserControl(uc);
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            UserControlCompras uc = new UserControlCompras();
            addUserControl(uc);
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            UserControlProveedores uc = new UserControlProveedores();
            addUserControl(uc);
        }

        private void btnRecepcion_Click(object sender, EventArgs e)
        {
            UserControlRecepcion uc = new UserControlRecepcion();
            addUserControl(uc);
        }

        private void btnDispositivos_Click(object sender, EventArgs e)
        {
            UserControlDispositivos uc = new UserControlDispositivos();
            addUserControl(uc);
        }

        private void btnInicioProcera_Click(object sender, EventArgs e)
        {
        }
    }
}
