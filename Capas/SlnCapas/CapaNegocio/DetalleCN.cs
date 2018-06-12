using CapaDato;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class DetalleCN
    {
        DetalleCD detalleCD = new DetalleCD();
        public void Nuevo(DetallleCE detalleCE)
        {
            detalleCD.NuevoVenta(detalleCE);
        }
    }
}
