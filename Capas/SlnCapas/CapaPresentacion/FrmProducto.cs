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

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            string descripcion = txtDescripcion.Text;
            string categoria = txtCategoria.Text;
            double precio =Convert.ToDouble(txtPrecio.Text);
            //Instanciar un objeto CE
            ProductoCE productoCE = new ProductoCE(id,descripcion,categoria,precio);
            //Instanciar un objeto Cn
            ProductoNE productoNE = new ProductoNE();
            //Ejecutar el metodo 
            productoNE.Actualizar(productoCE);
        }
    }
}
