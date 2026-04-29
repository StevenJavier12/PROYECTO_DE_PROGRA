using System;
using System.Collections.Generic;
using System.Text;

namespace PROSERA.Entidades
{
    public class DetalleRecepcion
    {
        public int IdDetalle { get; set; }
        public int IdRecepcion { get; set; }
        public int IdDispositivo { get; set; }
        public int Cantidad { get; set; }

        public RecepcionDispositivo RecepcionDispositivo { get; set; }
        public DispositivoElectronico DispositivoElectronico { get; set; }
    }
}
