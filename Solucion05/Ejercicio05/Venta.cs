using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{
    public class Venta:Producto
    {
        public string fecha { get; set; }
        public int cantidad { get; set; }
        public double calcularSubTotal()
        {
            return this.asignarPrecio() * this.cantidad;
        }
        public double calcularDescuento()
        {

        }
    }
}
