using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    public class Registro
    {
        public string nombre { get; set; }
        public double[] notasArray{ get; set; }
        public string condicion { get; set; }

        //Definir un Destructor
        public Registro()
        {

        }
        public Registro(double n1,double n2,double n3,double n4)
        {
            this.notasArray = new double[4];
            this.notasArray[0] = n1;
            this.notasArray[1] = n2;
            this.notasArray[2] = n3;
            this.notasArray[3] = n4;
        }
        public double CalcularPromedio()
        {
            double promedio = 0;
            for (int i = 0; i < notasArray.Length; i++)
            {
                promedio = promedio + this.notasArray[i];
            }
            promedio = (promedio - this.CalcularMenorNota()) / this.notasArray.Length;
            return promedio;
        }
        public double CalcularMenorNota()
        {
            double notamenor = this.notasArray[0];
            for (int i=1;i<notasArray.Length;i++)
            {
                if (notamenor >= this.notasArray[i])
                {
                    notamenor = this.notasArray[i];
                }
            }
            return notamenor;
        }
        public string CalcularCondicion()
        {
            string condicion = "Nulo";
            if (this.CalcularPromedio() >= 10.5)
            {
                condicion = "APROBADO";
            }else
            {
                condicion = "DESAPROBADO";
            }
            return condicion;
        }
    }
}
