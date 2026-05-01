using PROSERA.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace PROSERA.Datos
{
    internal interface IClienteDAL
    {
        void Guardar(Cliente cliente);
        void Editar(Cliente cliente);
        void Eliminar(int id);
        DataTable Listar();

        // Métodos de consulta
        Cliente? ObtenerPorId(int id);
        bool ExistePorDui(string dui, int? excluirId = null);
        bool TieneFacturasRelacionadas(int clienteId);
        bool TieneRecepcionesRelacionadas(int clienteId);
    }
}
