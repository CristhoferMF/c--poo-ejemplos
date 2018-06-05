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
    }
}
