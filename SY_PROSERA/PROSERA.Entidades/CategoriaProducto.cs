using System;
using System.Collections.Generic;
using System.Text;

namespace PROSERA.Entidades
{
    public class CategoriaProducto
    {
        public int IdCategoria { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public List<Producto> Productos { get; set; }
    }
}
