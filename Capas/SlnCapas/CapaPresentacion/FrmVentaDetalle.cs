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

        }
        private void CalcularTotal()
        {
            Double suma = 0;
            foreach(DataGridViewRow mifila in dgvDetalle.Rows)
            {
                suma = suma + Convert.ToDouble(mifila.Cells["total"].Value);
            }
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
            this.txtIdProducto.Text = frmProducto.Controls[""].Text;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtFechaVenta.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}
