using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{
    public class Producto
    {
        private string descripcion { get; set; }
        private double precio { get; set;}

        public double asignarPrecio()
        {
            switch (descripcion)
            {
                case "Televisor" :
                    this.precio = 1200;
                    break;
                case "Equipo":
                    this.precio = 500;
                    break;
                case "Refrigeradora":
                    this.precio = 750;
                    break;
                case "Lavadora":
                    this.precio = 350;
                    break;

            }
            return this.precio;
        }
    }
}
