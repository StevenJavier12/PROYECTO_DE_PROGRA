using PROSERA.Entidades;
using PROSERA.Datos;
using System.Data;

namespace PROSERA.Negocios
{
    public class UsuarioBL : IUsuarioBL
    {
        private readonly IUsuarioDAL _usuarioDAL;

        public UsuarioBL(IUsuarioDAL usuarioDAL)
        {
            _usuarioDAL = usuarioDAL;
        }

        public void Guardar(Usuario usuario)
        {
            if (string.IsNullOrWhiteSpace(usuario.Username))
                throw new Exception("El nombre de usuario es obligatorio.");

            if (string.IsNullOrWhiteSpace(usuario.Contraseña))
                throw new Exception("La contraseña es obligatoria.");

            if (string.IsNullOrWhiteSpace(usuario.Rol))
                throw new Exception("El rol es obligatorio.");

            if (string.IsNullOrWhiteSpace(usuario.EstadoUser))
                throw new Exception("El estado es obligatorio.");

            if (_usuarioDAL.ExistePorUsername(usuario.Username))
                throw new Exception("Ya existe un usuario con ese nombre de usuario.");

            _usuarioDAL.Guardar(usuario);
        }

        public void Editar(Usuario usuario)
        {
            if (usuario.IdUsuario <= 0)
                throw new Exception("Usuario no válido.");

            if (string.IsNullOrWhiteSpace(usuario.Username))
                throw new Exception("El nombre de usuario es obligatorio.");

            if (string.IsNullOrWhiteSpace(usuario.Contraseña))
                throw new Exception("La contraseña es obligatoria.");

            if (string.IsNullOrWhiteSpace(usuario.Rol))
                throw new Exception("El rol es obligatorio.");

            if (string.IsNullOrWhiteSpace(usuario.EstadoUser))
                throw new Exception("El estado es obligatorio.");

            if (_usuarioDAL.ExistePorUsername(usuario.Username, usuario.IdUsuario))
                throw new Exception("Ya existe un usuario con ese nombre de usuario.");

            _usuarioDAL.Editar(usuario);
        }

        public void Eliminar(int id)
        {
            _usuarioDAL.Eliminar(id);
        }

        public DataTable Listar()
        {
            return _usuarioDAL.ListarConEmpleado();
        }

        public Usuario? ObtenerPorId(int id)
        {
            return _usuarioDAL.ObtenerPorId(id);
        }
    }
}