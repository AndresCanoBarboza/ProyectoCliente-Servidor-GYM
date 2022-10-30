using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Reserva
    {
        public int idReserva { get; set; }
        public Sede idsede { get; set; }
        public Cliente idCliente { get; set; }
        public DateTime fecha { get; set; }

        public Reserva()
        {
            this.idReserva = -1;
            this.idsede = new Sede();
            this.idCliente = new Cliente();
            this.fecha = DateTime.MinValue;
        }

    }

    
    
}
