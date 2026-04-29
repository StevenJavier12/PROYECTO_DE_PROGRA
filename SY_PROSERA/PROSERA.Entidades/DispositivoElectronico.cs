using System;
using System.Collections.Generic;
using System.Text;

namespace PROSERA.Entidades
{
    public class DispositivoElectronico
    {
        public int IdDispositivo { get; set; }
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Estado { get; set; }
        public int UnidadDeMedida { get; set; }
        public string Descripcion { get; set; }

        public List<DetalleRecepcion> DetalleRecepciones { get; set; }
    }
}
