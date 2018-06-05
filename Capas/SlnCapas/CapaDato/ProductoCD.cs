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
                sql.Close();
            }
            catch (SqlException e)
            {
                Console.Write(e.Message);
                throw;
            }
        }

        public int Nuevo(ProductoCE productoCE)
        {
            try
            {
                ConexionCD conexion = new ConexionCD();
                SqlConnection sql = conexion.ConectarSQL();
                sql.Open();
                SqlCommand cmd = sql.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into producto(descripcion,categoria,precio) values(" +
                    "@descripcion,@categoria,@precio)";

                cmd.Parameters.AddWithValue("@descripcion", productoCE.descipcion);
                cmd.Parameters.AddWithValue("@categoria", productoCE.categoria);
                cmd.Parameters.AddWithValue("@precio", productoCE.precio);

                Console.WriteLine(cmd.CommandText.ToString());
                cmd.ExecuteNonQuery();

                cmd.CommandText = "SELECT max(id) as nuevoId from producto";
                //cmd.Parameters["@descripcion"].Value = productoCE.descipcion;
                SqlDataReader dr= cmd.ExecuteReader();
                //leer el datareader
                dr.Read();
                //leer el valor de la columna en el dataReader
                productoCE.id= Convert.ToInt32(dr["nuevoId"].ToString());     

                sql.Close();
                return productoCE.id;
            }
            catch (SqlException e)
            {
                Console.Write(e.Message);
                throw;
            }
        }
        public void Eliminar(ProductoCE productoCE)
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
                SqlCommand cmd = sql.CreateCommand();
                //tipo de coomando
                cmd.CommandType = CommandType.Text;
                //Asigno la instruccion Sql
                cmd.CommandText = "delete from producto WHERE id=@id";
                cmd.Parameters.AddWithValue("@id", productoCE.id);
                //Ejecutar el comando
                cmd.ExecuteNonQuery();
                sql.Close();
            }
            catch (SqlException e)
            {
                Console.Write(e.Message);
                throw;
            }
        }

    }
}
