
using Microsoft.Data.SqlClient;
using PROSERA.Datos;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PROSERA.WinFormsUI
{
    public partial class InicioDeSesion : Form
    {
        public InicioDeSesion()
        {
            InitializeComponent();
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            const string SQL = @"SELECT id_usuario, username 
                         FROM Usuarios
                         WHERE estadoUser = 'Activo'";

            using SqlDataAdapter da = new(SQL, cn);

            DataTable dt = new();
            da.Fill(dt);

            cbUsuario.DataSource = dt;
            cbUsuario.DisplayMember = "username";
            cbUsuario.ValueMember = "id_usuario";

            cbUsuario.SelectedIndex = -1;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.TryParse(cbUsuario.SelectedValue?.ToString(), out int idUsuario))
            {
                string usuario = cbUsuario.Text;
            }
        }






        private void InicioDeSesion_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(cbUsuario.SelectedValue?.ToString(), out int idUsuario))
            {
                MessageBox.Show("Seleccione un usuario");
                return;
            }

            string contraseña = txbContraseña.Text;

            using SqlConnection cn = new(ConexionDB.Cadena);
            cn.Open();

            const string SQL = @"SELECT rol
                         FROM Usuarios
                         WHERE id_usuario = @id
                         AND contraseña = @contraseña
                         AND estadoUser = 'Activo'";

            using SqlCommand cmd = new(SQL, cn);

            cmd.Parameters.AddWithValue("@id", idUsuario);
            cmd.Parameters.AddWithValue("@contraseña", contraseña);

            object resultado = cmd.ExecuteScalar();

            if (resultado != null)
            {
                string? rol = resultado.ToString();

                MessageBox.Show("Inicio de sesión correcto");

                if (rol == "Admin")
                {
                    ControlAdmin frm = new ControlAdmin();
                    frm.Show();
                    this.Hide();
                }
                else if (rol == "Empleado")
                {
                    ControlEmpleado frm = new ControlEmpleado();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Rol no reconocido");
                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }
        }
    }
}
