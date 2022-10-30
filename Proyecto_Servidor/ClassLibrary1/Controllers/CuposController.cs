using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using Entities.Models;
using static DataAccess.Services.RegistroCuposSede;
using static DataAccess.Services.RegistroSedes;

namespace Business.Controllers
{
    public static class CuposController
    {

        public static void AgregarCuposController(Sede sede, DateTime fecha, int cupos)
        {
            AgregarCuposServicio(new CupoporSede
            {
                sede = sede,
                fechaCupos = fecha,
                cupos = cupos                
            });
        }
        /*public static void AgregarCuposSede(CupoporSede nuevo)
        {
            cuposSede.Add(nuevo);
        }*/

        public static List<CupoporSede> MostrarCuposSede()
        {
            ActualizarListaCupos();
            return cuposSede;
        }

        public static bool LlenoCupos()
        {
            return cuposSede.Count == 20; // Para averiguar si hay espacio
        }
            /*
            public static bool LlenoCupos()
            {
                return cuposSede.Any(x => x == null); // Para averiguar si hay espacio
            }

            public static int espacioLibreCupos()
            {
                return Array.IndexOf(cuposSede, null);
            }

            public static int obtenerPosCupos()
            {
                return Array.IndexOf(cuposSede, null);
            }
            public static void AgregarCuposSede(int pos, CupoporSede nuevo)
            {
                cuposSede[pos] = nuevo;
            }

            public static void MostrarCuposSede(DataGridView dgv)
            {
                dgv.Rows.Clear();
                foreach (var item in cuposSede.Where(x => x != null))
                {
                    dgv.Rows.Add(item.ListaCuposSedes());
                }
            }*/



            public static void MostrarCmbCuposSedes(ComboBox cb)
        {
            ActualizarListaCupos();
            cb.Items.Clear();
            foreach (var item in sedes.Where(x => x != null))
            {
                cb.Items.Add(item);
            }
            cb.ValueMember = "nombreSede";
        }
    }
}
