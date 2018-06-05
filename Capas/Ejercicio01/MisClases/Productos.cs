using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//desclarar namespace
using System.Data;
using System.Data.SqlClient;


namespace MisClases
{
    public class Productos
    {
        //definir estructura  y encapsular
        public int id { get; set; }
        public string descripcion { get; set; }
        public string categoria { get; set; }
        public double precio { get; set; }



        public Productos()
        {

        }

        public Productos(string descripcionx,string cateogirax,double preciox)
        {
            this.descripcion = descripcionx;
            this.categoria = cateogirax;
            this.precio = preciox;
        }

        //Metodos
        public void Guardar(int miId)
        {
            //INSTANCIAR MI CLASE
            ConexionBD miConexion = new ConexionBD();

            //CREAR LA CONEXION
            SqlConnection connBD = miConexion.ConectarSQLSERVER(@"DESKTOP-QDCMGIV\MS_SQL", "BD_2018FE401", "sa", "181003");

            //ABRIR CONEXION
            connBD.Open();

            //PREPARAR LA CONSULTA

            string consulta = "update producto "+ "set descripcion=@descripcion,categoria=@categoria,precio=@precio"+ " where id=@id";

            //PREPARAR EL SQLCOMMAND

            SqlCommand cmdBD = connBD.CreateCommand();
            cmdBD.CommandType = CommandType.Text;
            cmdBD.CommandText = consulta;

            //PREPARAR PARAMETROS

            cmdBD.Parameters.AddWithValue("@id",miId);
            cmdBD.Parameters.AddWithValue("@descripcion", this.descripcion);
            cmdBD.Parameters.AddWithValue("@categoria", this.categoria);
            cmdBD.Parameters.AddWithValue("@precio", this.precio);


            //EJECUTAR EL SQL COMMAND

            cmdBD.ExecuteNonQuery();

            connBD.Close();
        }

        public int Nuevo()
        {
            ConexionBD miConexion = new ConexionBD();

            SqlConnection connBD = miConexion.ConectarSQLSERVER(@"DESKTOP-QDCMGIV\MS_SQL", "BD_2018FE401", "sa", "181003");

            connBD.Open();

            string consulta = "insert into producto" + "(descripcion,categoria,precio)"+ " values (@descripcion,@categoria,@precio)";

            SqlCommand cmdBD = connBD.CreateCommand();
            cmdBD.CommandType = CommandType.Text;
            cmdBD.CommandText = consulta;

            cmdBD.Parameters.AddWithValue("@descripcion", this.descripcion);
            cmdBD.Parameters.AddWithValue("@categoria", this.categoria);
            cmdBD.Parameters.AddWithValue("@precio", this.precio);

            cmdBD.ExecuteNonQuery();

            //RECUPERAR ID

            cmdBD.CommandText = "select max(id) as nuevoId from producto where descripcion=@descripcion";
            //asignar valor al parametro

            cmdBD.Parameters["@descripcion"].Value = this.descripcion;

            //Ejecutar el sql command y asignar resultado datareader
            SqlDataReader drBD = cmdBD.ExecuteReader();

            //Leer el valor
            drBD.Read();


            int nuevoId = Convert.ToInt32(drBD["nuevoId"].ToString());
            return nuevoId;

        }
    }
}
