using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class CupoporSede
    {
        public int cupos { get; set; }
        public DateTime fechaCupos { get; set; }
        public Sede sede { get; set; }
                
        public object[] ListaCuposSedes()
        {
            return new object[] { fechaCupos, cupos, sede.nombreSede };
        }

        public override string ToString()
        {
            return fechaCupos + ", Cupos: " + cupos + ", Sede: " + sede;
        }


    }
}
