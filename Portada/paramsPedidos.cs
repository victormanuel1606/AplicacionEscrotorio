using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portada
{
    class paramsPedidos
    {
        public string action { get; set; }

        public paramsPedidos()
        {
            action = "mostrar_pedidos";
        }
    }

    class resultsPedidos
    {
        public int idPedido { get; set; }
        public string Destino { get; set; }
        public string referencias { get; set; }
        public string Origen { get; set; }
        public int Precio { get; set; }
        public string Nombre_Cliente { get; set; }
        public string estado_pedido { get; set; }
    }
}
