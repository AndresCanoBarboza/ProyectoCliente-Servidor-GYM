using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using Entities.Models;
using static DataAccess.Services.RegistroClientes;

namespace Business.Controllers
{
    public static class ClienteController
    {
        public static void AgregarClienteController(string id, string nombre, string apellido1, string apellido2, DateTime fechaNac, char genero, DateTime fechaIngreso)
        {
            AgregarClienteServicio(new Cliente
            {
               clienteId = id,
               nombreCliente = nombre,
               apellido1Cliente = apellido1,
               apellido2Cliente = apellido2,
               fechaNacimiento = fechaNac,
               generoCliente = genero,
               fechaIngreso = fechaIngreso
            });
        }
        public static bool BuscarCliente(string id)
        {
            ActualizarListaClientes();
            return clientes.Any(x => x.clienteId.Equals(id));
        }
                
        public static List<Cliente> MostrarCliente()
        {
            ActualizarListaClientes();
            return clientes;
        }

        public static bool LlenoCliente()
        {
            ActualizarListaClientes();
            return clientes.Count == 20; // Para averiguar si hay espacio
        }
        
        public static void MostrarCmbClientes(ComboBox cb) 
        {
            cb.Items.Clear();
            foreach (var item in clientes.Where(x => x != null))
            {
                cb.Items.Add(item);
            }
            cb.DisplayMember = clientes.ToString();

           
        }

        

    }
}
