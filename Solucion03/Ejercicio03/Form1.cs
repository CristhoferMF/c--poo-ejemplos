using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double pr = Double.Parse(txtPrecio.Text);
            int can = Int32.Parse(txtCantidad.Text);
            Venta objVenta = new Venta(pr, can);

            double desc = objVenta.CalcularDescuento();
            double total = objVenta.CalcularTotal();

            txtDescuento.Text = desc.ToString("0.0 S/.");
            txtTotal.Text = total.ToString("0.0 S/.");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Venta objVenta = new Venta();
            string val = cmbProducto.SelectedItem.ToString();
            txtPrecio.Text= objVenta.AsignarPrecio(val).ToString();
            txtCantidad.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
