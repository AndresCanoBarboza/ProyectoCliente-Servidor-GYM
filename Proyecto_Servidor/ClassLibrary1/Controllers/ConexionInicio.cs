using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using Entities.Models;

namespace ClassLibrary1.Controllers
{
    public static class ConexionInicio
    {
        const string cadenaConexion = "Data Source = CANOBARBOZA-OME\\SQLEXPRESS03; Initial Catalog = FITUNED; Integrated Security = True;";

        private static SqlConnection conexion = new SqlConnection(cadenaConexion);

        #region Querys
        private const string selectCliente = "Select * From Cliente Where IdCliente = @pIdCliente";
        private const string reservar = "INSERT INTO Reserva(IdReserva, IdSede, IdCliente, Fecha)" +
            "VALUES(@pReserva, @pIdSede, @pIdCliente, @pFecha)";
        private const string selectReserva = "Select * From Reserva Where IdCliente = @pIdCliente";
        #endregion

        private static void Open()
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }
        }

        private static void Close()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
        }

        public static Cliente Iniciar(string usuario)
        {
            Open();
            SqlCommand cmd = new SqlCommand(selectCliente, conexion);
            cmd.Parameters.AddWithValue("@pUsuario_Id", usuario);


            Cliente login = new Cliente();

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                login.clienteId = reader["IdCliente"].ToString();
                login.nombreCliente = reader["nombre"].ToString();
            }
            Close();

            return login;
        }
            public static void Guardar(Reserva nueva)
            {
                Open();
                SqlCommand cmd = new SqlCommand(reservar, conexion);

                cmd.Parameters.AddWithValue("@pIdReserva", nueva.idReserva);
                cmd.Parameters.AddWithValue("@pIdSede", nueva.idsede);
                cmd.Parameters.AddWithValue("@pIdCliente", nueva.idCliente);
                cmd.Parameters.AddWithValue("@pFecha", nueva.fecha);
                cmd.ExecuteNonQuery();
                Close();
            }

        public static List<Reserva> ListaReservas(string usuario)
        {
            Open();
            SqlCommand cmd = new SqlCommand(selectReserva, conexion);
            cmd.Parameters.AddWithValue("@pUsuario_Id", usuario);

            List<Reserva> lista = new List<Reserva>();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lista.Add(new Reserva()
                {
                    fecha = DateTime.Parse(reader["Fecha"].ToString()),
                    idReserva = int.Parse(reader["IdReserva"].ToString()),
                    //idCliente = (reader["IdCliente"].ToString()   ERROR no convierte                                   
                });
            }
            Close();

            return lista;
        }

    }

    
}
