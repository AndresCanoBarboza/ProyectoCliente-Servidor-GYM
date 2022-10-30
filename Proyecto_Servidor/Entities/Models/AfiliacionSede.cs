using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class AfiliacionSede
    {

        public int afilacionId { get; set; }
        public DateTime afiliacionFecha { get; set; }
        public Cliente cliente { get; set; }
        public Sede afiliacionClienteSede { get; set; }
        public string Datos { get => cliente.clienteId + cliente.nombreCliente + cliente.apellido1Cliente +
                cliente.apellido2Cliente + afiliacionClienteSede.sedeId + afiliacionClienteSede.nombreSede +
                afiliacionClienteSede.telefono; } // para consultar pero revisar

        public AfiliacionSede()
        {
            this.afilacionId = -1;
            this.afiliacionFecha = DateTime.MinValue;
            this.cliente = new Cliente();
            this.afiliacionClienteSede = new Sede();
        }

        public object[] ListaAfiliacion()
        {
            return new object[] { afilacionId, afiliacionFecha, cliente.clienteId, cliente.nombreCliente, cliente.apellido1Cliente, cliente.apellido2Cliente, 
                afiliacionClienteSede.sedeId, afiliacionClienteSede.nombreSede, afiliacionClienteSede.estado, afiliacionClienteSede.telefono };
        }

      
    }
}
