using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using Entities.Models;
using static DataAccess.Services.RegistroSedes;


namespace Business.Controllers
{
    public static class SedesController
    {
        public static void AgregarSedeController (int id, string nombre, string direccion, bool estado, string telefono) 
        {
            AgregarSedeServicio(new Sede
            {
                sedeId = id,
                nombreSede = nombre,
                direccionSede = direccion,
                estado = estado,
                telefono = telefono
            });
        }
        
        public static bool BuscarSede(int id)
        {
            ActualizarListaSedes();
            return sedes.Any(x => x.sedeId.Equals(id));
        }
                
        public static List<Sede> MostrarSede()
        {
            ActualizarListaSedes();
            return sedes;
        }

        public static bool LlenoSede()
        {
            return sedes.Count == 20; // Para averiguar si hay espacio
        }
        public static void MostrarCmbSedes(ComboBox cb)
        {
            cb.Items.Clear();
            foreach (var item in sedes.Where(x => x != null))
            {
                cb.Items.Add(item);
            }
            cb.ValueMember = "nombreSede";

        }
    }

}
