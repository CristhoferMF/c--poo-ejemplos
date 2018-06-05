using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class ClienteCE
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string numruc { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }

        public ClienteCE(int _id,string _nombre,string _numruc,string _direccion,string _telefono)
        {
            this.id = _id;
            this.nombre = _nombre;
            this.numruc = _numruc;
            this.direccion = _direccion;
            this.telefono = _telefono;
        }
    }
}
