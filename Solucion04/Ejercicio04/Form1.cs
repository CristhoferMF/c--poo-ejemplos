using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConfigurarLista();
            AgregarProductos();
        }
        private void ConfigurarLista()
        {
            lvDetalleVenta.View = View.Details;
            lvDetalleVenta.Columns.Add("Producto",300,HorizontalAlignment.Center);
            lvDetalleVenta.Columns.Add("Cantidad",150);
            lvDetalleVenta.Columns.Add("Precio",150);
            lvDetalleVenta.Columns.Add("SubTotal",150);
            lvDetalleVenta.Columns.Add("Descuento",150);
            lvDetalleVenta.Columns.Add("Total",150);

        }
        private void AgregarProductos()
        {
            string[] producto = { "Teclado", "Impresora",
                "Monitor","Mouse","Parlantes" };
            foreach (string prod in producto)
            {
                cmbProducto.Items.Add(prod);
            }
            
        }
        private void ReinciarControles()
        {
            txtCantidad.Text = "0";
            cmbProducto.SelectedIndex = -1;
        }
        private void CalcularTotalPago()
        {
            double totalpago = 0;
            ListView.ListViewItemCollection items = lvDetalleVenta.Items;
            foreach (ListViewItem item in items)
            {
                totalpago+=Int32.Parse(item.SubItems[5].Text);
            }
            txtTotal.Text = totalpago.ToString("#,##0.0");
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Instanciar Clase
            Venta objVenta = new Venta();
            objVenta.cliente = txtCliente.Text;
            objVenta.producto = cmbProducto.Text;
            objVenta.cantidad = Int32.Parse(txtCantidad.Text);

            //preparar la fila para agregar
            string[] fila = new string[6];
            fila[0] = objVenta.producto;
            fila[1] = objVenta.cantidad.ToString();
            fila[2] = objVenta.asignaPrecio().ToString();
            fila[3] = objVenta.CalcularSubtotal().ToString();
            fila[4] = objVenta.CalcularDescuento().ToString();
            fila[5] = objVenta.CalcularTotal().ToString();

            //Transferir los valores a un ListViewItem
            ListViewItem item = new ListViewItem(fila);

            //Agregar fila al ListView
            lvDetalleVenta.Items.Add(item);
            ReinciarControles();
            CalcularTotalPago();
        }
    }
}
