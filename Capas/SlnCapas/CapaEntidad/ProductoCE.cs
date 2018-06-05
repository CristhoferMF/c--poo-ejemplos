using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class ProductoCE
    {
        public int id { get; set; }
        public string descipcion { get; set; }
        public string categoria { get; set; }
        public double precio { get; set; }
        public ProductoCE()
        {

        }
        public ProductoCE(int _id,string _descripcion,string _categoria,double _precio)
        {
            this.id = _id;
            this.descipcion = _descripcion;
            this.categoria = _categoria;
            this.precio = _precio;
        }
    }
}
