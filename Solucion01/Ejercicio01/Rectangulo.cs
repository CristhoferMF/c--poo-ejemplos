using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    public class Rectangulo
    {
        //Definir Estructura
        public double largo;
        public double ancho;

        //Definir Compotamientos

        public double CalcularPerimetro()
        {
            double perimetro = 0;
            perimetro = 2 * (this.largo + this.ancho);
            return perimetro;
        }
        public double CalcularArea()
        {
            double area=0;
            area = this.ancho * this.largo;
            return area;
        }
        public double CalcularDiagonal()
        {
            double diagonal = 0;
            diagonal = Math.Sqrt(Math.Pow(this.ancho, 2)+ Math.Pow(this.largo,2));
            return diagonal;
        }

    }
}
