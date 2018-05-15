using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    public class Venta
    {
        //definir atributos
        public string cliente { get; set; }
        public string producto { get; set; }
        public int cantidad { get; set; }

        //definir comportamientos
        public double asignaPrecio()
        {
            switch (this.producto)
            {
                case "Teclado": return 65;
                case "Impresora": return 150;
                case "Monitor": return 280;
                case "Mouse": return 45;
                case "Parlantes": return 150;
            }
            return 0;
        }
        public double CalcularSubtotal()
        {
          return this.cantidad * this.asignaPrecio();
        }
        public double CalcularDescuento()
        {
            double dscto = 0;
            if (this.CalcularSubtotal() >= 500)
            {
                dscto = 0.10;
            }else if(this.CalcularSubtotal()>=100){
                dscto = 0.05;
            }
            return this.CalcularSubtotal() * dscto;
        }
        public double CalcularTotal()
        {
            return (this.CalcularSubtotal() - this.CalcularDescuento());
        }
    }
}
