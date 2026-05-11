using PROSERA.Datos;
using PROSERA.Negocios;
using PROSERA.Entidades;

namespace PROSERA.WinFormsUI.UsersControl
{
    public partial class UserControlCompras : UserControl
    {
        private readonly IProveedorBL _proveedoreBL;
        public UserControlCompras()
        {
            InitializeComponent();
            _proveedoreBL = new ProveedorBL(new ProveedorDAL());
        }

        private void cbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.TryParse(cbProveedor.SelectedValue?.ToString(), out int idProveedor))
            {
                string proveedor = cbProveedor.Text;

                MessageBox.Show($"ID: {idProveedor}\nProveedor: {proveedor}");
            }
        }

        private void UserControlCompras_Load(object sender, EventArgs e)
        {

        }
    }
}
