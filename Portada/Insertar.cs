using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portada
{
    class Insertar
    {
        public string action { get; set; }
        public string idUbicasion { get; set; }
        public string Ciudad { get; set; }
        public string Proveedor { get; set; }
        public string Fecha_llegada { get; set; }
        public string idPedido { get; set; }

        public Insertar(string idUbicaciones, string Ciudades, string Proveedores, string Fechas_llegada, string idPedidos)
        {
            action = "agregar_ubicasion";
            idUbicasion = idUbicaciones;
            Ciudad = Ciudades;
            Proveedor = Proveedores;
            Fecha_llegada = Fechas_llegada;
            idPedido = idPedidos;
        }
    }
}
