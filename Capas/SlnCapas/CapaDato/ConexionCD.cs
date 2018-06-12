using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Agregar NameSpace
using System.Data.SqlClient;

namespace CapaDato
{
    public class ConexionCD
    {
        public SqlConnection ConectarSQL()
        {
            //Intanciar SqlConnectionStringBuilder
            SqlConnectionStringBuilder cadenaConexion = new SqlConnectionStringBuilder();
            cadenaConexion.DataSource = @"DESKTOP-QDCMGIV\MS_SQL";
            cadenaConexion.InitialCatalog = "BDFE401";
            cadenaConexion.UserID = "sa";
            cadenaConexion.Password = "181003";

            //crear objeto de conexion
            SqlConnection connBD = new SqlConnection(cadenaConexion.ConnectionString);
            return connBD;

        }
    }
}
