using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
//agregar namespace para el control de transcacciones

namespace CapaDato
{
    public class VentaCD
    {
        public int NuevoVenta(VentaCE ventaCE)
        {
            //instanciar conexion
            ConexionCD con = new ConexionCD();
            //crear el objeto SQL CONNEction
            SqlConnection cn = con.ConectarSQL();
            //Abrir la conexion
            cn.Open();

            //Declaro nuevo ID
            int nuevoId = 0;

            //Inicia el control de transacciones
            using (SqlTransaction tr=cn.BeginTransaction(IsolationLevel.ReadCommitted))
            {
                //Crear un comando
                SqlCommand cmd = cn.CreateCommand();
                //Tipo de comando
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into venta(fecventa,idCliente) values (@fecventa,@idCliente)";
                //Vincular el controolde transacciones con el comando 
                cmd.Transaction = tr;
                //Asignar valores a lso sagrados
                cmd.Parameters.AddWithValue("@fecventa", ventaCE.fecventa);
                cmd.Parameters.AddWithValue("@idCliente", ventaCE.idCliente);
                try
                {
                    cmd.ExecuteNonQuery();
                    //Al confirmar la transaccion
                    tr.Commit();
                }
                catch 
                {
                    //Al existit error en la transaccion
                    tr.Rollback();
                }
                //Determinar el nuevoId
                //asignar nuevo instrucion SQL
                cmd.CommandText = "Select max(id) as nuevoId from venta "+
                    "where idCliente=@idCliente";
                //Asignar valor al parametro que ya existe
                cmd.Parameters["@idCliente"].Value = ventaCE.idCliente;
                //Ejecutar el comando 
                SqlDataReader dr=cmd.ExecuteReader();
                //Ejecuto el moviemiento del puntero de registros
                if(dr.Read())
                {
                    nuevoId = Convert.ToInt32(dr["nuevoId"]);
                }
                else
                {
                    nuevoId = 0;
                }
               
            }

            //Retornar nuevo
            return nuevoId;
        }
        
    }
}
