using System;
using System.Collections.Generic;
using System.Text;

namespace PROSERA.Entidades
{
    public class Marca
    {
        public int IdMarca { get; set; }
        public string? MarcaNombre { get; set; }

        public List<Producto>? Productos { get; set; }
    }
}
