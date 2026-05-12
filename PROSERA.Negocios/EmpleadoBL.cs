using PROSERA.Entidades;
using PROSERA.Datos;
using System.Data;

namespace PROSERA.Negocios
{
    public class EmpleadoBL : IEmpleadoBL
    {
        private readonly IEmpleadoDAL _empleadoDAL;

        public EmpleadoBL(IEmpleadoDAL empleadoDAL)
        {
            _empleadoDAL = empleadoDAL;
        }

        public void Guardar(Empleado empleado)
        {
            if (string.IsNullOrWhiteSpace(empleado.Nombre))
                throw new Exception("El nombre es obligatorio.");

            if (string.IsNullOrWhiteSpace(empleado.Apellido))
                throw new Exception("El apellido es obligatorio.");

            if (string.IsNullOrWhiteSpace(empleado.Cargo))
                throw new Exception("El cargo es obligatorio.");

            if (string.IsNullOrWhiteSpace(empleado.Telefono))
                throw new Exception("El teléfono es obligatorio.");

            if (string.IsNullOrWhiteSpace(empleado.Correo))
                throw new Exception("El correo es obligatorio.");

            if (string.IsNullOrWhiteSpace(empleado.Direccion))
                throw new Exception("La dirección es obligatoria.");

            if (string.IsNullOrWhiteSpace(empleado.Dui))
                throw new Exception("El DUI es obligatorio.");

            if (_empleadoDAL.ExistePorDui(empleado.Dui))
                throw new Exception("Ya existe un empleado con ese DUI.");

            _empleadoDAL.Guardar(empleado);
        }

        public void Editar(Empleado empleado)
        {
            if (empleado.IdEmpleado <= 0)
                throw new Exception("Empleado no válido.");

            if (string.IsNullOrWhiteSpace(empleado.Nombre))
                throw new Exception("El nombre es obligatorio.");

            if (string.IsNullOrWhiteSpace(empleado.Apellido))
                throw new Exception("El apellido es obligatorio.");

            if (string.IsNullOrWhiteSpace(empleado.Cargo))
                throw new Exception("El cargo es obligatorio.");

            if (string.IsNullOrWhiteSpace(empleado.Telefono))
                throw new Exception("El teléfono es obligatorio.");

            if (string.IsNullOrWhiteSpace(empleado.Correo))
                throw new Exception("El correo es obligatorio.");

            if (string.IsNullOrWhiteSpace(empleado.Direccion))
                throw new Exception("La dirección es obligatoria.");

            if (string.IsNullOrWhiteSpace(empleado.Dui))
                throw new Exception("El DUI es obligatorio.");

            if (_empleadoDAL.ExistePorDui(empleado.Dui, empleado.IdEmpleado))
                throw new Exception("Ya existe un empleado con ese DUI.");

            _empleadoDAL.Editar(empleado);
        }

        public void Eliminar(int id)
        {
            _empleadoDAL.Eliminar(id);
        }

        public DataTable Listar()
        {
            return _empleadoDAL.Listar();
        }

        public Empleado? ObtenerPorId(int id)
        {
            return _empleadoDAL.ObtenerPorId(id);
        }
    }
}