using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Cliente
    {
        public string clienteId { get; set; }
        public string nombreCliente { get; set; }
        public string apellido1Cliente { get; set; }
        public string apellido2Cliente { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public char generoCliente { get; set; }
        public DateTime fechaIngreso { get; set; }


        public Cliente()
        {
            this.clienteId = string.Empty;
            this.nombreCliente = string.Empty;
            this.apellido1Cliente = string.Empty;
            this.apellido2Cliente = string.Empty;
            this.fechaNacimiento = DateTime.MinValue;
            this.generoCliente = char.MinValue;
            this.fechaIngreso = DateTime.MinValue;
        }

        public object[] ListaClientes()
        {
            return new object[] { clienteId, nombreCliente, apellido1Cliente, apellido2Cliente, fechaNacimiento, generoCliente, fechaIngreso };
        }

        public override string ToString()
        {
            return clienteId + ", " +nombreCliente + " " + apellido1Cliente + " " + apellido2Cliente;
        }

        

    }
}
