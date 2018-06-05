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
        
    }
}
