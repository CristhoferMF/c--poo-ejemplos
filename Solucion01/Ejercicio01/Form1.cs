using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Leer los valores de la caja de texto

            /* a = Convert.ToDouble(txtAncho.Text);
            l= Convert.ToDouble(txtLargo.Text); */
 
            double a, l;
            a = Double.Parse(txtAncho.Text);
            l = Double.Parse(txtLargo.Text);

            //Instaciar el Objeto

            Rectangulo objRectangulo = new Rectangulo();

            //asginar valores a las propiedades
            objRectangulo.ancho = a;
            objRectangulo.largo = l;

            //Ejecutar el metodo
            double pe,ar,di;
            pe = objRectangulo.CalcularPerimetro();
            ar = objRectangulo.CalcularArea();
            di = objRectangulo.CalcularDiagonal();

            //imprimiendo resultado
            txtArea.Text = ar.ToString();
            txtParametro.Text = pe.ToString();
            txtDiagonal.Text = di.ToString();
        }
    }
}
