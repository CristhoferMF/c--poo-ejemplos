using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDato
{
    public class ClienteCD
    {
        public void Actualizar(ClienteCE clienteCE)
        {
            try
            {
                ConexionCD conexion = new ConexionCD();
                SqlConnection sql = conexion.ConectarSQL();
                sql.Open();
                SqlCommand cmd = sql.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update cliente set " +
                    "nombre=@nombre, "+
                    "numruc=@numruc, "+
                    "direccion=@direccion, "+
                    "telefono=@telefono where id=@id";

                cmd.Parameters.AddWithValue("@nombre", clienteCE.nombre);
                cmd.Parameters.AddWithValue("@numruc", clienteCE.numruc);
                cmd.Parameters.AddWithValue("@direccion", clienteCE.direccion);
                cmd.Parameters.AddWithValue("@telefono", clienteCE.telefono);
                cmd.Parameters.AddWithValue("@id", clienteCE.id);
                cmd.ExecuteNonQuery();
                sql.Close();
            }
            catch (SqlException e)
            {
                Console.Write(e.Message);
                throw;
            }
        }
        public int Nuevo(ClienteCE clienteCE)
        {
            try
            {
                ConexionCD conexion = new ConexionCD();
                SqlConnection sql = conexion.ConectarSQL();
                sql.Open();
                SqlCommand cmd = sql.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into cliente(nombre,numruc,direccion,telefono) "+
                    "values(@nombre,@numruc,@direccion,@telefono)";
                
                cmd.Parameters.AddWithValue("@nombre", clienteCE.nombre);
                cmd.Parameters.AddWithValue("@numruc", clienteCE.numruc);
                cmd.Parameters.AddWithValue("@direccion", clienteCE.direccion);
                cmd.Parameters.AddWithValue("@telefono", clienteCE.telefono);
                Console.Write(cmd.CommandText.ToString());
                cmd.ExecuteNonQuery();

                cmd.CommandText = "select max(id) as maxid from cliente where nombre=@nombre";
                cmd.Parameters["@nombre"].Value = clienteCE.nombre;
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                clienteCE.id = Convert.ToInt32(dr["maxid"].ToString());
                
                sql.Close();
                return clienteCE.id;
            }
            catch (SqlException e)
            {
                Console.Write(e.Message);
                throw;
            }
        }
        public void Eliminar(ClienteCE clienteCE)
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
                cmd.CommandText = "delete from cliente WHERE id=@id";
                cmd.Parameters.AddWithValue("@id", clienteCE.id);
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
