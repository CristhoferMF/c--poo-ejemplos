using CapaDato;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    
    public class VentaCN
    {
        VentaCD ventaCD = new VentaCD();
        public int Nuevo(VentaCE ventaCE)
        {
            return ventaCD.NuevoVenta(ventaCE);
        }
    }
}
