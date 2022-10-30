using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Sede
    {
        public int sedeId { get; set; }
        public string nombreSede { get; set; }
        public string direccionSede { get; set; }
        public bool estado { get; set; }
        public string telefono { get; set; }

        public Sede()
        {
            this.sedeId = -1;
            this.nombreSede = string.Empty;
            this.direccionSede = string.Empty;
            this.estado = false;
            this.telefono = string.Empty;
        }

        public object[] ListaSedes()
        {
            return new object[] { sedeId, nombreSede, direccionSede, estado, telefono };
        }

        
    }



    
}
