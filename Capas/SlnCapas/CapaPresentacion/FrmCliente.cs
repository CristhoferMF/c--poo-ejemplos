using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            txtId.Focus();
            ClienteNE clienteNE = new ClienteNE();
            dgvBuscar.DataSource = clienteNE.BuscarProducto("");
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int id;
            if (txtId.Text.Length == 0) { id = 0; } else { id = Convert.ToInt32(txtId.Text); }
            
            string nombre = txtNombre.Text;
            string numruc = txtRuc.Text;
            string direccion = txtDireccion.Text;
            string telefono = txtTelefono.Text;

            ClienteCE clienteCE = new ClienteCE(id,nombre,numruc,direccion,telefono);
            ClienteNE clienteNE = new ClienteNE();
            if (id == 0)
            {
                txtId.Text = clienteNE.Nuevo(clienteCE).ToString();
                MessageBox.Show("Se ha añadido un nuevo Cliente", "Titulo");
                txtId.Enabled = false;
            }
            else
            {
                clienteNE.Actualizar(clienteCE);
                MessageBox.Show("Se ha actualizado un  Cliente", "Titulo");
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Length > 0)
            {
                if (MessageBox.Show("Deseas Borrar", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    //Instanciar un objeto CE
                    ClienteCE clienteCE = new ClienteCE();
                    ClienteNE clienteNE = new ClienteNE();
                    clienteCE.id = Convert.ToInt32(txtId.Text);
                    //Instanciar un objeto Cn
                    clienteNE.Eliminar(clienteCE);
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

        private void button1_Click(object sender, EventArgs e)
        {
            limpiarControles();
            txtId.Focus();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string condicion = txtBuscar.Text;
            ClienteNE clienteNE = new ClienteNE();
            dgvBuscar.DataSource = clienteNE.BuscarProducto(condicion);
            for (int i = 0; i < dgvBuscar.Columns.Count; i++)
            {
                dgvBuscar.AutoResizeColumn(i);
            }
        }

        private void dgvBuscar_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBuscar.SelectedRows.Count > 0)
            {
                DataGridViewRow miFila = dgvBuscar.SelectedRows[0];
                txtId.Text = miFila.Cells["id"].Value.ToString();
                txtNombre.Text = miFila.Cells["nombre"].Value.ToString();
                txtRuc.Text = miFila.Cells["numruc"].Value.ToString();
                txtDireccion.Text = miFila.Cells["direccion"].Value.ToString();
                txtTelefono.Text = miFila.Cells["telefono"].Value.ToString();
            }
        }
    }
}
