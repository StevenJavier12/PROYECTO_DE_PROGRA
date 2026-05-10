using PROSERA.Datos;
using PROSERA.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace PROSERA.Negocios
{
    public class MarcaBL : IMarcaBL
    {
        private readonly IMarcaDAL _marcaDAL;

        public MarcaBL(IMarcaDAL marcaDAL)
        {
            _marcaDAL = marcaDAL;
        }

        public void Agregar(Marca marca)
        {
            if (marca == null)
                throw new Exception("La marca no puede ser nula");

            if (string.IsNullOrWhiteSpace(marca.MarcaNombre))
                throw new Exception("El nombre de la marca es obligatorio");

            _marcaDAL.Agregar(marca);
        }

        public void Editar(Marca marca)
        {
            if (marca == null)
                throw new Exception("La marca no puede ser nula");

            if (marca.IdMarca <= 0)
                throw new Exception("ID inválido");

            if (string.IsNullOrWhiteSpace(marca.MarcaNombre))
                throw new Exception("El nombre de la marca es obligatorio");

            _marcaDAL.Editar(marca);
        }

        public void Eliminar(int id)
        {
            if (id <= 0)
                throw new Exception("ID inválido");

            _marcaDAL.Eliminar(id);
        }

        public Marca ObtenerPorId(int id)
        {
            if (id <= 0)
                throw new Exception("ID inválido");

            return _marcaDAL.ObtenerPorId(id);
        }

        public List<Marca> Listar()
        {
            return _marcaDAL.Listar();
        }

        public List<Marca> BuscarMarcas(string marca)
        {
            if (string.IsNullOrWhiteSpace(marca))
                throw new Exception("Debe ingresar un nombre para buscar");

            return _marcaDAL.BuscarMarcas(marca);
        }
    }
}
