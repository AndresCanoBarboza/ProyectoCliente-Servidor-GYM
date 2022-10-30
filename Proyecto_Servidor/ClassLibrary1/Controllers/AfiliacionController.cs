using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Entities.Models;
using static DataAccess.Services.AfiliacionesSedes;

namespace Business.Controllers
{
    public static class AfiliacionController
    {

        public static void AgregarAfiController(int idAfi, DateTime fechaAfi, Cliente cliente, Sede sede)
        {
            AgregarAfiServicio(new AfiliacionSede
            {
                afilacionId = idAfi,
                afiliacionFecha = fechaAfi,
                cliente = cliente,
                afiliacionClienteSede = sede
            });
        }    
        
        public static bool BuscarAfiliacion(int id) 
        {
            ActualizarListaAfi();
            return afiSedes.Any(x => x.afilacionId.Equals(id));
        }

        /*public static void AgregarAfi(AfiliacionSede nueva) 
        {
            afiSedes.Add(nueva);
        }*/

        public static List<AfiliacionSede> MostrarAfiliacion() 
        {
            ActualizarListaAfi();
            return afiSedes;
        }

        public static bool LlenoAfi()
        {
            ActualizarListaAfi();
            return afiSedes.Count == 10; // Para averiguar si hay espacio
        }
        /*public static bool BuscarAfiliacion(int Id)
        {
            foreach (AfiliacionSede a in afiSedes)
            {
                if (a.afilacionId.Equals(Id))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool LlenoAfi()
        {
            return afiSedes.Any(x => x == null); // Para averiguar si hay espacio
        }

        public static int espacioLibreAF()
        {
            return Array.IndexOf(afiSedes, null);
        }

        public static int obtenerPosAfi()
        {
            return Array.IndexOf(afiSedes, null);
        }
        public static void AgregarAfi(int pos, AfiliacionSede nuevo)
        {
            afiSedes[pos] = nuevo;
        }

        public static void MostrarAfiliacion(DataGridView dgv)
        {
            dgv.Rows.Clear();
            foreach (var item in afiSedes.Where(x => x != null))
            {
                dgv.Rows.Add(item.ListaAfiliacion());
            }
        }*/




    }

}
