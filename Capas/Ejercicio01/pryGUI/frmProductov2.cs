using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//agregar nos nameSpace 

using System.Data.SqlClient;
using MisClases;
namespace pryGUI
{
    public partial class frmProductov2 : Form
    {
        public frmProductov2()
        {
            InitializeComponent();
        }

        public void cargarGrid()
        {
            //instanciar la clase conexionbd
            ConexionBD miConexion = new ConexionBD();
            //crear la conexion a la bd
            SqlConnection connBD = miConexion.ConectarSQLSERVER(@"DESKTOP-QDCMGIV\MS_SQL", "BD_2018FE401", "sa", "181003");
            //Aperturamos la conexion
            connBD.Open();

            //declaramos la consulta sql en un string 
            string consulta = "SELECT * FROM producto where descripcion like '%' + @descripcion + '%'";

            //froma 2 usando sqlcommand
            SqlCommand cmd = connBD.CreateCommand();
            //definimos tipo de comando
            cmd.CommandType = CommandType.Text;
            //asignamos la consulta
            cmd.CommandText = consulta;


            //Declaro y asigno valor a parametro SQL

            cmd.Parameters.AddWithValue("@descripcion", txtcondicion.Text);
            //ejecutamos la consulta select 
            //se usa datareader y executereader para select
            SqlDataReader drBD = cmd.ExecuteReader();

            //limpiar el dgv
            dgvproductos.Columns.Clear();

            //agregar columnas 

            for (int i = 0; i < drBD.FieldCount; i++)
            {
                dgvproductos.Columns.Add(drBD.GetName(i).ToString(), drBD.GetName(i).ToString());

            }

            //agregar filas al datagridview

            int fila = 0;
            while (drBD.Read())
            {
                dgvproductos.Rows.Add();

                for (int col = 0; col < drBD.FieldCount; col++)
                {

                    dgvproductos.Rows[fila].Cells[col].Value = drBD[col].ToString();

                }
                fila = fila + 1;
            }
        }
        private void btncargarproductos_Click(object sender, EventArgs e)
        {

            cargarGrid();
        }

        private void dgvproductos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvproductos.SelectedRows.Count > 0)
            {
                //MessageBox.Show("Evento selectionChanged");
                DataGridViewRow fila = dgvproductos.SelectedRows[0];
                txtid.Text = fila.Cells[0].Value.ToString();
                txtdescripcion.Text = fila.Cells[1].Value.ToString();
                txtcategoria.Text = fila.Cells[2].Value.ToString();
                txtprecio.Text = fila.Cells[3].Value.ToString();
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (txtid.Text.Length > 0)
            {
                string miDescripcion = txtdescripcion.Text;
                string miCategoria = txtcategoria.Text;
                double miPrecio = Convert.ToDouble(txtprecio.Text);
                int miId = Convert.ToInt32(txtid.Text);
                Productos miproducto = new Productos(miDescripcion,miCategoria,miPrecio);
                miproducto.Guardar(miId);
                

                
            }
           else if(txtid.Text.Length == 0)
            {
                string miDescripcion = txtdescripcion.Text;
                string miCategoria = txtcategoria.Text;
                double miPrecio = Convert.ToDouble(txtprecio.Text);
                Productos miproducto = new Productos(miDescripcion, miCategoria, miPrecio);
                txtid.Text = miproducto.Nuevo().ToString();

            }
            cargarGrid();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            cargarGrid();

        }

        public void LimpiarControles()
        {
            foreach(TextBox T in Controls.OfType<TextBox>())
            {
                T.Clear();
            }
        }
    }
}

