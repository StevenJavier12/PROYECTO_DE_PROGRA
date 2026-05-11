using System;
using System.Collections.Generic;
using System.Text;

namespace PROSERA.Entidades
{
    public class Proveedor
    {
        public int IdProveedor { get; set; }
        public string NombreEmpresa { get; set; }
        public string Contacto { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }

        public List<FacturaCompra> FacturaCompras { get; set; }
    }
}
