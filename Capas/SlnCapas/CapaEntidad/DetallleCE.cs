using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class DetallleCE
    {
        public int id { get; set; }
        public int idVenta { get; set; }
        public int idProducto { get; set; }
        public int cantidad { get; set; }
        public DetallleCE()
        {

        }
        public DetallleCE(int miId, int miIdVenta, int miIdProducto, int miCantidad)
        {
            this.id = miId;
            this.idVenta = miIdVenta;
            this.idProducto = miIdProducto;
            this.cantidad = miCantidad;
        }
    }
}
