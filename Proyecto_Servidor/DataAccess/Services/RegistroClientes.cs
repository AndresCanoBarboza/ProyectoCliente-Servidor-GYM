using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entities.Models;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DataAccess.Services
{
    public static class RegistroClientes
    {
        private const string cadenaConexion = "Data Source = CANOBARBOZA-OME\\SQLEXPRESS03; Initial Catalog = FITUNED; Integrated Security = True;";

        public static List<Cliente> clientes = new List<Cliente>(20);

        #region Querys

        const string queryAgregar = "Insert Into Cliente ([IdCliente], [Nombre], [PrimerApellido], [SegundoApellido], [FechaNacimiento], [Genero], [FechaIngreso])" +
                "Values (@pId, @pnombre, @pApellido1, @pApellido2, @pfechaNac, @pgenero, @pfechaIngreso)";

        const string queryAct = "select * from Cliente";

        #endregion
        public static void AgregarClienteServicio(Cliente nuevoCliente)
        {
            SqlConnection sql = new SqlConnection(cadenaConexion);
            try
            {
                sql.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error al conectarse con la base de datos");
                return;
            }
            
            SqlCommand commandC = new SqlCommand(queryAgregar, sql);
            
            commandC.CommandType = CommandType.Text;
            commandC.CommandText = queryAgregar;
            commandC.Connection = sql;
            commandC.Parameters.AddWithValue("@pId", nuevoCliente.clienteId);
            commandC.Parameters.AddWithValue("@pnombre", nuevoCliente.nombreCliente);
            commandC.Parameters.AddWithValue("@pApellido1", nuevoCliente.apellido1Cliente);
            commandC.Parameters.AddWithValue("@pApellido2", nuevoCliente.apellido2Cliente);
            commandC.Parameters.AddWithValue("@pfechaNac", nuevoCliente.fechaNacimiento);
            commandC.Parameters.AddWithValue("@pgenero", nuevoCliente.generoCliente);
            commandC.Parameters.AddWithValue("@pfechaIngreso", nuevoCliente.fechaIngreso);

            try
            {
                commandC.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error al insertar al Cliente en la base de datos");
                sql.Close();
                return;

            }

            sql.Close();
        }

        public static void ActualizarListaClientes()
        {
            SqlConnection sql = new SqlConnection(cadenaConexion);

            try
            {
                sql.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error al conectarse con la base de datos");
                return;
            }
                        
            SqlCommand command = new SqlCommand(queryAct, sql);
            SqlDataReader reader = command.ExecuteReader();

            clientes.Clear();
            while (reader.Read())
            {
                Cliente c = new Cliente()
                {
                    clienteId = reader["IdCliente"].ToString(),
                    nombreCliente = reader["Nombre"].ToString(),
                    apellido1Cliente = reader["PrimerApellido"].ToString(),
                    apellido2Cliente = reader["SegundoApellido"].ToString(),
                    fechaNacimiento = DateTime.Parse(reader["FechaNacimiento"].ToString()),
                    generoCliente = char.Parse(reader["Genero"].ToString()),
                    fechaIngreso = DateTime.Parse(reader["FechaIngreso"].ToString())                    
                };

                clientes.Add(c);
            }

            sql.Close();
        }

    }
}
