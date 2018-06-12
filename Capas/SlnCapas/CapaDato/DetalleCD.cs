using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaEntidad;

namespace CapaDato
{
    public class DetalleCD
    {
        public void NuevoVenta(DetallleCE detallleCE)
        {
            //instanciar conexion
            ConexionCD con = new ConexionCD();
            //crear el objeto SQL CONNEction
            SqlConnection cn = con.ConectarSQL();
            //Abrir la conexion
            cn.Open();
           
            //Inicia el control de transacciones
            using (SqlTransaction tr = cn.BeginTransaction(IsolationLevel.ReadCommitted))
            {
                //Crear un comando
                SqlCommand cmd = cn.CreateCommand();
                //Tipo de comando
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into detalle(idVenta,idProducto,cantidad) values (@idVenta,@idProducto,@cantidad)";
                //Vincular el controolde transacciones con el comando 

                  //****************//*******/**********//
                 cmd.Transaction = tr;
                //***************//*****************//

                //Asignar valores a lso sagrados
                cmd.Parameters.AddWithValue("@idVenta", detallleCE.idVenta);
                cmd.Parameters.AddWithValue("@idProducto", detallleCE.idProducto);
                cmd.Parameters.AddWithValue("@cantidad", detallleCE.cantidad);

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
               
            }

        }
    }
}
