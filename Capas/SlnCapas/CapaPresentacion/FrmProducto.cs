using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmProducto : Form
    {
        public FrmProducto()
        {
            InitializeComponent();
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            txtId.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int id;

                if (txtId.Text.Length == 0) { id = 0; } else { id = Convert.ToInt32(txtId.Text); }

                string descripcion = txtDescripcion.Text;
                string categoria = txtCategoria.Text;
                double precio;
                if (txtPrecio.Text.Length == 0) { precio = 0; } else { precio = Convert.ToDouble(txtPrecio.Text); }

                //Instanciar un objeto CE
                ProductoCE productoCE = new ProductoCE(id, descripcion, categoria, precio);
                //Instanciar un objeto Cn
                ProductoNE productoNE = new ProductoNE();
                //Ejecutar el metodo 
                if (id == 0)
                {
                    txtId.Text= productoNE.Nuevo(productoCE).ToString();
                    MessageBox.Show("Se ha creado un nuevo producto", "Titulo");
                }
                else
                {
                    productoNE.Actualizar(productoCE);
                    MessageBox.Show("Se ha actualizado un nuevo producto", "Titulo");
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                throw;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Length > 0)
            {
                if(MessageBox.Show("Deseas Borrar", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    //Instanciar un objeto CE
                    ProductoCE productoCE = new ProductoCE();
                    productoCE.id = Convert.ToInt32(txtId.Text);
                    //Instanciar un objeto Cn
                    ProductoNE productoNE = new ProductoNE();
                    productoNE.Eliminar(productoCE);
                    limpiarControles();
                }
            }
            else
            {
                MessageBox.Show("Debera Ingresar un ID");
            }

        }
        private void limpiarControles()
        {
            foreach (TextBox caja in Controls.OfType<TextBox>())
            {
                caja.Clear();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarControles();
            txtId.Focus();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string condicion = txtBuscar.Text;
            ProductoNE productoNE = new ProductoNE();
            dgvBuscar.DataSource = productoNE.BuscarProducto(condicion);
        }

        private void dgvBuscar_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBuscar.SelectedRows.Count > 0)
            {
                DataGridViewRow miFila = dgvBuscar.SelectedRows[0];
                txtId.Text = miFila.Cells["id"].Value.ToString();
                txtDescripcion.Text = miFila.Cells["descripcion"].Value.ToString();
                txtCategoria.Text = miFila.Cells["categoria"].Value.ToString();
                txtPrecio.Text = miFila.Cells["precio"].Value.ToString();

            }
        }

        private void dgvBuscar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
