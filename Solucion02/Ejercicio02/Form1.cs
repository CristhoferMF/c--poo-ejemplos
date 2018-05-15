using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            double n1 = Convert.ToDouble(txtNota1.Text);
            double n2= Convert.ToDouble(txtNota2.Text);
            double n3 = Convert.ToDouble(txtNota3.Text);
            double n4 = Convert.ToDouble(txtNota4.Text);

            Registro objRegistro = new Registro(n1, n2, n3, n4);

            //ejecutar metodos
            double p = objRegistro.CalcularPromedio();
            double me = objRegistro.CalcularMenorNota();
            string cond = objRegistro.CalcularCondicion();
            //devolviendo metodos
            txtPromedio.Text = p.ToString("0.0");
            txtNotaMenor.Text= me.ToString();
            txtCondicion.Text = cond;
        }
    }
}
