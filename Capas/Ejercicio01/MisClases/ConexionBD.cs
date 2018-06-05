using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//Agregar los namespace para SQL SERVER
using System.Data.SqlClient;
namespace MisClases
{
    public class ConexionBD
    {
        public SqlConnection ConectarSQLSERVER(string servidor,string basedatos,string usuario,string password)
        {
            //Creando un objjeto tipo SqlConnectionStringBuilder
            SqlConnectionStringBuilder CadenaConexion = new SqlConnectionStringBuilder();
            //Pasando los valores de los parametros
            CadenaConexion.DataSource = servidor;
            CadenaConexion.InitialCatalog = basedatos;
            CadenaConexion.UserID = usuario;
            CadenaConexion.Password = password;
            //Generar la cadena conexion

            string cadenaCnx = CadenaConexion.ConnectionString;

            //Crear y generar un OBJETO TIPO sqlConnection

            SqlConnection connBD = new SqlConnection(cadenaCnx);

            //Devolvemos la conecion (sqlconnection);

            return connBD;
        }

    }
}
