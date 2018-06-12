using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class VentaCE
    {
        public int id { get; set; }
        public DateTime fecventa { get; set; }
        public int idCliente { get; set; }
        public VentaCE()
        {

        }
        public VentaCE(int miId,DateTime miFecventa,int miidCliente)
        {
            this.id = miidCliente;
            this.fecventa = miFecventa;
            this.idCliente = miidCliente;
        }
    }
}
