using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portada
{
    class ParamsUbicaciones
    {
        public string action { get; set; }

        public ParamsUbicaciones()
        {
            action = "mostrar_ubicasiones";
        }
    }

    class ResultsUbicaciones
    {
        public int idUbicasion { get; set; }

        public string Ciudad { get; set; }

        public string Proveedor { get; set; }

        public string Fecha_llegada { get; set; }

        public int idPedido { get; set; }
    }
}
