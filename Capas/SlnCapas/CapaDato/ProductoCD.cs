using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Data;

namespace CapaDato
{
    public class ProductoCD
    {
        public void Actualizar(ProductoCE productoCE)
        {
            try
            {
                //crear el objeto de la conexion
                ConexionCD conexion = new ConexionCD();
                //crear el objeto sqlConnection
                SqlConnection sql = conexion.ConectarSQL();
                //aperturamos la conexion
                sql.Open();
                //crear un coomando
                SqlCommand cmd=sql.CreateCommand();
                //tipo de coomando
                cmd.CommandType=CommandType.Text;
                //Asigno la instruccion Sql
                cmd.CommandText = "update producto set" +
                    " descripcion=@descripcion," +
                    "categoria=@categoria," +
                    "precio=@precio WHERE id=@id";
                cmd.Parameters.AddWithValue("@descripcion",productoCE.descipcion);
                cmd.Parameters.AddWithValue("@categoria", productoCE.categoria);
                cmd.Parameters.AddWithValue("@precio",productoCE.precio);
                cmd.Parameters.AddWithValue("@id", productoCE.id);
                //Ejecutar el comando
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.Write(e.Message);
                throw;
            }
        }
    }
}
