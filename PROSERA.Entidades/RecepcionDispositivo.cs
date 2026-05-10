using System;
using System.Collections.Generic;
using System.Text;

namespace PROSERA.Entidades
{
    public class RecepcionDispositivo
    {
        public int IdRecepcion { get; set; }
        public DateTime Fecha { get; set; }
        public int IdCliente { get; set; }
        public int IdUsuario { get; set; }
        public string Observaciones { get; set; }

        public Cliente Cliente { get; set; }
        public Usuario Usuario { get; set; }

        public List<DetalleRecepcion> DetalleRecepciones { get; set; }
    }
}
