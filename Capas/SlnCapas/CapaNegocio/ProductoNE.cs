using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//agregar
using CapaEntidad;
using CapaDato;


namespace CapaNegocio
{
    public class ProductoNE
    {
        //Instanciar producto de la Capa Datos
        ProductoCD productoCD = new ProductoCD();
        //Declarar metodos que invoca a los metodos de la capa datos.
        public void Actualizar(ProductoCE productoCE)
        {
            productoCD.Actualizar(productoCE);
        }
        public int Nuevo(ProductoCE productoCE)
        {
            return productoCD.Nuevo(productoCE);
        }
        public void Eliminar(ProductoCE productoCE)
        {
            productoCD.Eliminar(productoCE);
        }
    }
}
