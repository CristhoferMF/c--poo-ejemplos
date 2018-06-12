using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmVentaDetalle : Form
    {
        public FrmVentaDetalle()
        {
            InitializeComponent();
        }

        private void FrmVentaDetalle_Load(object sender, EventArgs e)
        {
            dgvDetalle.Columns.Add("idProducto","ID PRODUCTO");
            dgvDetalle.Columns.Add("descripcionProducto", "DESCRIPCION PRO.");
            dgvDetalle.Columns.Add("precioProducto", "PRECIO PRO.");
            dgvDetalle.Columns.Add("cantidadProducto", "CANTIDAD PRO.");
            dgvDetalle.Columns.Add("totalProducto", "IMPORTE TOTAL.");

            dgvDetalle.Columns["idProducto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDetalle.Columns["descripcionProducto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDetalle.Columns["precioProducto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDetalle.Columns["cantidadProducto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDetalle.Columns["totalProducto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private double CalcularTotal()
        {
            Double suma = 0;
            foreach(DataGridViewRow mifila in dgvDetalle.Rows)
            {
                suma = suma + Convert.ToDouble(mifila.Cells["totalProducto"].Value);
            }
            return suma;
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            FrmCliente frmCliente = new FrmCliente();
            frmCliente.ShowDialog(this);
            this.txtIdCliente.Text = frmCliente.Controls["txtId"].Text;
            this.txtNombreCliente.Text = frmCliente.Controls["txtNombre"].Text;
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            FrmProducto frmProducto = new FrmProducto();
            frmProducto.ShowDialog(this);
            this.txtIdProducto.Text = frmProducto.Controls["txtID"].Text;
            this.txtNombreProducto.Text = frmProducto.Controls["txtDescripcion"].Text;
            this.txtPrecioProducto.Text = frmProducto.Controls["txtPrecio"].Text;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtFechaVenta.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void btnGuardarVenta_Click(object sender, EventArgs e)
        {
            VentaCE ventaCE = new VentaCE();
            ventaCE.fecventa = Convert.ToDateTime(txtFechaVenta.Text);
            ventaCE.idCliente = Convert.ToInt32(txtIdCliente.Text);

            VentaCN ventaCN = new VentaCN();
            int miIdVenta = ventaCN.Nuevo(ventaCE);
            //Registrando Detalle
            DetallleCE detalleCE = new DetallleCE();
            DetalleCN detalleCN = new DetalleCN();
            foreach (DataGridViewRow row in dgvDetalle.Rows)
            {
                detalleCE.idVenta = miIdVenta;
                detalleCE.idProducto =Convert.ToInt32(row.Cells["idProducto"].Value);
                detalleCE.cantidad = Convert.ToInt32(row.Cells["cantidadProducto"].Value);
                detalleCN.Nuevo(detalleCE);
            }

            MessageBox.Show("La venta y su detalle ha sido almacenado");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtNombreProducto.Text.Length > 0)
            {
                dgvDetalle.Rows.Add(
                    txtIdProducto.Text,
                    txtNombreProducto.Text,
                    txtPrecioProducto.Text,
                    txtCantidadProducto.Text,
                    Convert.ToInt32(Convert.ToDouble(txtPrecioProducto.Text) * Convert.ToDouble(txtCantidadProducto.Text))
                    );
                txtTotal.Text = CalcularTotal().ToString();
            }
        }
    }
}
