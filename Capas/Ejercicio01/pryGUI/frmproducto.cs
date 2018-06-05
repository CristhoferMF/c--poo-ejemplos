using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//Agregar mis namespace
using System.Data.SqlClient;
using MisClases;

namespace pryGUI
{
    public partial class frmproducto : Form
    {
        public frmproducto()
        {
            InitializeComponent();
        }

        private void btncargarproductos_Click(object sender, EventArgs e)
        {
            //Instanciando mi clase para la conexion
            ConexionBD MiConexion = new ConexionBD();
            //Crear una conexion 
            SqlConnection connBD = MiConexion.ConectarSQLSERVER(@"DESKTOP-QDCMGIV\MS_SQL", "BD_2018FE401", "sa", "181003");
            connBD.Open();



            //FORMA1 utilizando dataAdapter
            string consulta = "select * from producto";

            SqlDataAdapter daBD = new SqlDataAdapter(consulta,connBD);
            //crear la tabla 

            DataTable dtBD = new DataTable();

            //Llenar los registros al DataTable con el Dataadapter
            daBD.Fill(dtBD);

            //Llenar los registros en el datagridView
            dgvproductos.DataSource = dtBD;

            connBD.Close();
        }

        private void frmproducto_Load(object sender, EventArgs e)
        {

        }
    }
}
