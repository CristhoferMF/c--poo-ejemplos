using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using CapaDato;
using CapaEntidad;
namespace CapaNegocio
{
    public class ClienteNE
    {
        public ClienteCD clienteCD = new ClienteCD();
        public void Actualizar(ClienteCE clienteCE)
        {
            clienteCD.Actualizar(clienteCE);
        }
    }
}
