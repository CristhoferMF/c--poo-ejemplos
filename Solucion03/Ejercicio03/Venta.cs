using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    public class Venta
    {
        public string producto {get;set;}
        public double precio { get; set; }
        public int cantidad { get; set; }
        public double descuento { get; set; }
        public double total { get; set; }

        public Venta()
        {

        }
        public Venta(double precio, int cantidad)
        {
            this.precio = precio;
            this.cantidad = cantidad;
        }
        public double CalcularMonto()
        {
            double monto = 0;
            monto = this.precio * this.cantidad;
            return monto;
        }
        public double CalcularDescuento()
        {
            double descuento = 0;
            if (this.CalcularMonto() > 100 && this.CalcularMonto() <= 500) {
                descuento = (5 * CalcularMonto())/100;
            } else if (this.CalcularMonto()>500) {
                descuento = (10 * CalcularMonto()) / 100;
            }
            else
            {
                descuento = 0;
            }
            return descuento;
        }
        public double CalcularTotal()
        {
            double total = 0;
            total = CalcularMonto() - CalcularDescuento();
            return total;
        }
    }
}
